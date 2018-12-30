using RajEnterprise.Report;
using RajEnterpriseBusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace RajEnterprise
{
    public partial class SalesForm : Form
    {
        public Form Instance { get; set; }
        public string ConnectioString { get; set; }
        private ManageStock mngStock = null;
        private ManageSale mngSale = null;
        private List<StockModels> stockList = null;
        private BindingList<SalesModel> saleItemList = null;
        private string[] gridColumn = null;

        public SalesForm()
        {
            InitializeComponent();
        }
        public SalesForm(Form Instance) : this()
        {
            this.Instance = Instance;
            saleItemList =new BindingList<SalesModel>();
            gridColumn = new string[] { "3", "8", "9", "10", "11" };
        }

        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerDetails custDetail = new CustomerDetails(ConnectioString, null);
                custDetail.Controls.Find("checkNewCustomer", true)[0].Enabled = false; ;
                DialogResult dialoagResult = custDetail.ShowDialog();
                if (dialoagResult == DialogResult.OK)
                {
                    string xml_Invoice = PrepareInvoiceXML(custDetail.Buyer).Replace("\r\n", "").Replace(" ", "");
                    List<StockModels> saleItems = GetStockItemBasedOnPrdNCmp((gridSale.DataSource as IList<SalesModel>).ToList());
                    mngSale.BulkUpdate(GetSaleItems());
                    string invoiceId = mngSale.GenerateInvoive(custDetail.Buyer.ID, xml_Invoice);
                    MakeInvoiceGenerationEnable();
                    PrintInvoice(invoiceId, custDetail);
                    #region clear all controls
                    gridSale.DataSource = null;
                    cmbCompany.Text = "";
                    cmbProduct.Text = "";
                    cmbUnit.Text = "";
                    cmbUnit.Enabled = false;
                    lblStock.Text = "";
                    txtGrandTotal.Text = "";
                    txtCgst.Text = "";
                    txtDiscount.Text = "";
                    txtIgst.Text = "";
                    txtSgst.Text = "";
                    txtUnit.Text = "";
                    btnCart.Enabled = false;
                    btnGenerateBill.Enabled = false;
                    cmbProduct.Focus();
                    custDetail.Dispose();
                    #endregion

                }
            }
            catch(Exception ex)
            {
                Logger.WriteErrorMessage(ex);
            }
        }

        private void PrintInvoice(string invoiceId,CustomerDetails custDetail)
        {
            CustomerModel custM = new CustomerModel()
            {
                CustomerName = custDetail.Controls.Find("txtCustName", true)[0].Text,
                Address = custDetail.Controls.Find("txtAddress", true)[0].Text,
                MobileNo = custDetail.Controls.Find("txtMobile", true)[0].Text,
                EmailId = custDetail.Controls.Find("txtEmail", true)[0].Text,
                GstNo = custDetail.Controls.Find("txtGst", true)[0].Text
            };
             

            List<SalesReportModel> lstSaleReport = new List<SalesReportModel>();
            foreach (SalesModel item in gridSale.DataSource as IList<SalesModel>)
            {
                SalesReportModel sRModel = new SalesReportModel()
                {
                    ProductName = string.Format("{0} {1} {2}", item.ProductName, item.Weight, item.Company),
                    Quantity = item.Quantity,
                    MRP = item.MRP,
                    Amount = item.Total,
                    Discount = string.IsNullOrEmpty(item.Discount) ? "0" : item.Discount,
                    CGST = string.IsNullOrEmpty(item.CGST) ? "0" : item.CGST,
                    IGST = string.IsNullOrEmpty(item.IGST) ? "0" : item.IGST,
                    SGST = string.IsNullOrEmpty(item.SGST) ? "0" : item.SGST,
                    Rate = item.Rate
                };
                lstSaleReport.Add(sRModel);
            }
            Dictionary<string, object> htParam = new Dictionary<string, object>();
            htParam.Add("BillNo", invoiceId);
            htParam.Add("Discount", string.IsNullOrEmpty(txtDiscount.Text) ? "0" : txtDiscount.Text);
            htParam.Add("IGST", string.IsNullOrEmpty(txtIgst.Text) ? "0" : txtIgst.Text);
            htParam.Add("CGST", string.IsNullOrEmpty(txtCgst.Text) ? "0" : txtCgst.Text);
            htParam.Add("SGST", string.IsNullOrEmpty(txtSgst.Text) ? "0" : txtSgst.Text);
            htParam.Add("GrandTotal", txtGrandTotal.Text);
            SaleInvoice slInv = new Report.SaleInvoice(lstSaleReport, custM, htParam);
            slInv.ShowDialog();
        }

        public DataTable GetSaleItems()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[2] {new DataColumn("sid", typeof(int)),
                new DataColumn("stock",typeof(int)) });
            foreach (DataGridViewRow row in gridSale.Rows)
            {
                stockList.ForEach(st =>
                {
                    if (st.ID == Convert.ToInt32(row.Cells[0].Value))
                    {
                        dt.Rows.Add(st.ID, st.Stock);                       
                    }
                });

            }
            return dt;
        }

        private List<StockModels> GetStockItemBasedOnPrdNCmp(List<SalesModel> items)
        {
            List<StockModels> lstSaleItems = new List<StockModels>();
            try
            {
                List<StockModels> lstStock = mngStock.GetAllStock();


                foreach (SalesModel item in items)
                {
                    StockModels stockItem = null;
                    lstStock.ForEach(st =>
                    {
                        if (st.ProductName.Replace(" ", "").ToLower().Equals(item.ProductName.Replace(" ", "").ToLower()) &&
                        st.Company.Replace(" ", "").ToLower().Equals(item.Company.Replace(" ", "").ToLower()))
                        {
                            stockItem = st;
                            stockItem.Stock = (Convert.ToInt32(stockItem.Stock) - Convert.ToInt32(item.Quantity)).ToString();
                            lstSaleItems.Add(stockItem);
                        }
                    });

                }
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage(ex);
            }
            return lstSaleItems;
        }

        private string PrepareInvoiceXML(CustomerModel buyer)
        {
            string xmlData = null;
            InvoiceModel im = new InvoiceModel();
            im.Items = (gridSale.DataSource as IList<SalesModel>).ToList();
            im.Customer = buyer;
            XmlSerializer xmlSrz = new XmlSerializer(typeof(InvoiceModel));
            using (TextWriter tw = new StringWriter())
            {
                xmlSrz.Serialize(tw, im);
                xmlData = tw.ToString();
            }
            return xmlData;
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            this.Instance.Show();
            this.Dispose();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            try
            {
                ConnectioString = ConfigurationManager.ConnectionStrings["cns"].ConnectionString;
                mngStock = new ManageStock(ConnectioString);
                mngSale = new ManageSale(ConnectioString);
                //List<StockModels> lstStock = mngStock.GetAllStock();
                stockList = mngStock.GetAllStock();
                bindCombobox();
                lblStock.Text = "";

                ChangeBackColor(lblHome);
                picHomeArrow.Visible = true;
                picInvoiceArrow.Visible = false;
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage(ex);
            }
        }

        public void bindCombobox()
        {
            List<Product> lstProduct = null;
            List<Company> lstCmp = null;           
            getCompanyAndProduct(out lstProduct, out lstCmp);
            //lstCmp.Add(new Company() { ID = 0, CompanyName = "" });
            lstProduct.Add(new Product() { ID = 0, ProductName = "" });
            //cmbCompany.DataSource = lstCmp; cmbCompany.DisplayMember = "CompanyName";
            cmbProduct.DataSource = lstProduct; cmbProduct.DisplayMember = "ProductName";
            //cmbCompany.Text = "";
            cmbProduct.Text = "";
        }

        public void getCompanyAndProduct(out List<Product> lstProduct, out List<Company> lstCmp)
        {
            List<Product> tempLstProduct = null; List<Company> tempLstCmp = null;
            try
            {
                tempLstProduct = mngStock.GetProduct();
                tempLstCmp = mngStock.GetCompany();
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage(ex);
            }
            lstProduct = tempLstProduct;
            lstCmp = tempLstCmp;
        }

    private List<StockModels> getSelectedItemFromStock()
        {
            List<StockModels> stList = null;
            string pdt = (cmbProduct.SelectedItem as Product) != null ? (cmbProduct.SelectedItem as Product).ProductName.Replace(" ", "") : "";
            string cmp = (cmbCompany.SelectedItem as Company) != null ? (cmbCompany.SelectedItem as Company).CompanyName.Replace(" ", "") : "";
            if (!string.IsNullOrEmpty(pdt) && !string.IsNullOrEmpty(cmp))
            {
                stList = stockList.Where(st => st.ProductName.Replace(" ", "") == pdt
                && st.Company.Replace(" ", "") == cmp
                ).ToList();
            }
            if (cmbUnit.DataSource != null)
            {
                stList = stList.Where(st => st.Weight == cmbUnit.Text
                ).ToList();
            }
            return stList;
        }

        private void GetItemFromStock()
        {                
            List<StockModels> stList = getSelectedItemFromStock();            
            if (stList != null && stList.Count != 0)
            {
                GetItemInStockOnUnit(stList[0]);
            }
            else
            {
                txtUnit.Enabled = false;
                lblStock.Text = "";
            }
        }

        private void BindUnitCmb()
        {
            List<StockModels> stList = getSelectedItemFromStock();
            cmbUnit.DataSource = stList;
            cmbUnit.DisplayMember = "weight";
            if (stList != null && stList.Count > 1)
            {                
                cmbUnit.Enabled = true;
                //GetItemInStockOnUnit(stList[0]);
            }
            else
                cmbUnit.Enabled = false;
        }

        private void GetItemInStockOnUnit(StockModels stModel)
        {
            int temp = !string.IsNullOrEmpty(txtUnit.Text) ? Convert.ToInt32(txtUnit.Text) : 0;
            lblStock.Text = Convert.ToString(Convert.ToInt32(stModel.Stock) - temp);
            txtUnit.Enabled = true;
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            try
            {
                List<StockModels> stList = getSelectedItemFromStock();
                StockModels itemForSale = null;
                if (cmbUnit.DataSource != null)
                    itemForSale = stList.Where(st => st.Weight == cmbUnit.Text).ToList()[0];
                else
                    itemForSale = stList[0];
                //master stock list manage
                stockList.ForEach(st => { if (st.ID == itemForSale.ID) { st.Stock = (Convert.ToInt32(st.Stock) - Convert.ToInt32(txtUnit.Text)).ToString(); } });

                SalesModel slModel = new SalesModel();

                slModel.ID = stList[0].ID;
                slModel.ProductName = stList[0].ProductName;
                slModel.Company = stList[0].Company;
                slModel.Quantity = txtUnit.Text;
                slModel.Weight = cmbUnit.Text;
                slModel.Details = stList[0].Details;
                slModel.MRP = stList[0].MRP;
                slModel.Rate = stList[0].Rate;
                slModel.CGST = stList[0].CGST;
                slModel.SGST = stList[0].SGST;
                slModel.IGST = stList[0].IGST;
                slModel.Total = (decimal)calculateTotal(Convert.ToInt32(txtUnit.Text), !string.IsNullOrEmpty(slModel.SGST) ? Convert.ToDouble(slModel.SGST) : 0,
                    !string.IsNullOrEmpty(slModel.SGST) ? Convert.ToDouble(slModel.SGST) : 0,
                    !string.IsNullOrEmpty(slModel.SGST) ? Convert.ToDouble(slModel.SGST) : 0,
                    Convert.ToDouble(slModel.Rate), 0);
                if (saleItemList.ToList().Exists(slm => slm.ID == stList[0].ID))
                {
                    saleItemList.ToList().ForEach(slm =>
                    {
                        if (slm.ID == stList[0].ID)
                        {
                            slm.Quantity = Convert.ToString(Convert.ToInt32(slm.Quantity) + Convert.ToInt32(slModel.Quantity));
                            slm.Total = slm.Total + slModel.Total;
                        }
                    });
                }
                else
                {
                    saleItemList.Add(slModel);
                }
                gridSale.DataSource = null;
                gridSale.DataSource = saleItemList;
                gridSale.ClearSelection();

                txtUnit.Text = "";
                lblStock.Text = "";
                cmbCompany.Text = "";
                cmbProduct.Text = "";
                txtUnit.Enabled = false; btnCart.Enabled = false;
                cmbUnit.DataSource = null;
                cmbUnit.Enabled = false;

                getSaleItemGrandTotalAmt();
                MakeInvoiceGenerationEnable();
            }
            catch(Exception ex)
            {
                Logger.WriteErrorMessage(ex);
            }
        }

        private double calculateTotal(int qty, double sgst, double cgst, double igst, double rate, double disc)
        {
            double total = qty * rate;
            if (sgst != 0)
            {
                total = total + (total * (sgst / 100));
            }
            if (igst != 0)
            {
                total = total + (total * (igst / 100));
            }
            if (cgst != 0)
            {
                total = total + (total * (cgst / 100));
            }
            if (disc != 0)
            {
                total = total - (total * (disc / 100));
            }
            return total;
        }

        private void cmbProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                cmbUnit.DataSource = null;
                cmbUnit.Enabled = false;
                lblStock.Text = "";
                //GetItemFromStock();
                BindCompanyCmb((cmbProduct.SelectedItem as Product));
                BindUnitCmb();
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage(ex);
            }
        }
        private void BindCompanyCmb(Product pdt)
        {
            List<Company> lstCmp = mngSale.GetCompanyOnPdtSelect(pdt);
            lstCmp.Add(new Company() { ID = 0, CompanyName = "" });
            cmbCompany.DataSource = lstCmp;
            cmbCompany.DisplayMember = "CompanyName";
            cmbCompany.Text = "";
        }

        private void cmbCompany_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                cmbUnit.DataSource = null;
                cmbUnit.Enabled = false;
                GetItemFromStock();
                BindUnitCmb();
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage(ex);
            }
        }

        private void txtUnit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ValidateNumeric(txtUnit.Text))
                {
                    GetItemFromStock();
                    if (!string.IsNullOrEmpty(txtUnit.Text) && Convert.ToInt32(lblStock.Text) >= 0)
                        btnCart.Enabled = true;
                    else
                        btnCart.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage(ex);
            }
        }

        private void gridSale_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1 && gridColumn.Contains(e.ColumnIndex.ToString()))
                {
                    List<SalesModel> tempModel = (gridSale.DataSource as IList<SalesModel>).ToList();
                    SalesModel saleModel = gridSale.Rows[e.RowIndex].DataBoundItem as SalesModel;
                    decimal tempTotal = (decimal)calculateTotal(Convert.ToInt32(saleModel.Quantity),
                        !string.IsNullOrEmpty(saleModel.SGST) ? Convert.ToDouble(saleModel.SGST) : 0,
                        !string.IsNullOrEmpty(saleModel.CGST) ? Convert.ToDouble(saleModel.CGST) : 0,
                        !string.IsNullOrEmpty(saleModel.IGST) ? Convert.ToDouble(saleModel.IGST) : 0,
                        Convert.ToDouble(saleModel.Rate), Convert.ToDouble(saleModel.Discount));

                    ((gridSale.Rows[e.RowIndex]).Cells[12]).Value = tempTotal;

                    getSaleItemGrandTotalAmt();
                }
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage(ex);
            }
        }

        private void getSaleItemGrandTotalAmt()
        {
            List<SalesModel> tempModel = (gridSale.DataSource as IList<SalesModel>) != null ? (gridSale.DataSource as IList<SalesModel>).ToList() : null;

            if (tempModel == null)            
                return;
            
            double grandTotal = 0;
            foreach (SalesModel item in tempModel)
            {
                grandTotal = grandTotal + (double)item.Total;
            }
            if (!string.IsNullOrEmpty(txtDiscount.Text))
            {
                grandTotal = grandTotal - (grandTotal * (Convert.ToDouble(txtDiscount.Text) / 100));
            }
            if (!string.IsNullOrEmpty(txtCgst.Text))
            {
                grandTotal = grandTotal + (grandTotal * (Convert.ToDouble(txtCgst.Text) / 100));
            }
            if (!string.IsNullOrEmpty(txtIgst.Text))
            {
                grandTotal = grandTotal + (grandTotal * (Convert.ToDouble(txtIgst.Text) / 100));
            }
            if (!string.IsNullOrEmpty(txtSgst.Text))
            {
                grandTotal = grandTotal + (grandTotal * (Convert.ToDouble(txtSgst.Text) / 100));
            }
            txtGrandTotal.Text = Convert.ToString(grandTotal);
        }

        private void txtSgst_TextChanged(object sender, EventArgs e)
        {
            try
            {
                getSaleItemGrandTotalAmt();
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage(ex);
            }
        }

        private void gridSale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex == gridSale.Columns["Del"].Index)
                {
                    UpdateStockForRowDelete(gridSale.Rows[e.RowIndex].DataBoundItem as SalesModel);
                    gridSale.Rows.RemoveAt(e.RowIndex);
                    getSaleItemGrandTotalAmt();
                    MakeInvoiceGenerationEnable();
                }
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage(ex);
            }
        }

        private void UpdateStockForRowDelete(SalesModel slModel)
        {
            List<StockModels> tempStock = stockList.Where(ss => ss.ID == (slModel).ID).ToList();
            stockList.ForEach(st =>
            {
                if (st.ID == (slModel).ID)
                {
                    st.Stock = (Convert.ToInt32(tempStock[0].Stock) + Convert.ToInt32(slModel.Quantity)).ToString();
                }
            });
        }

        private void gridSale_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                DataGridViewRow grdRow = gridSale.Rows[e.RowIndex];
                DataGridViewCell grdCell = grdRow.Cells[3];
                if (e.FormattedValue as string == null) return;
                if (e.ColumnIndex == 3 && ValidateNumeric(e.FormattedValue as string) && !string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    List<StockModels> stList = mngStock.GetAllStock();
                    bool flag = true;
                    int qty = !string.IsNullOrEmpty(grdCell.EditedFormattedValue as string) ? Convert.ToInt32(grdCell.EditedFormattedValue) : 1;
                    stList.ForEach(st =>
                    {
                        if (st.ID == (grdRow.DataBoundItem as SalesModel).ID && qty > Convert.ToInt32(st.Stock))
                        {
                            MessageBox.Show(string.Format("Entered quantity must be less than stock. Item in stock \"{0}\"", st.Stock), "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            flag = false;
                            e.Cancel = true;
                        }
                    });
                    if (flag)
                    {
                        List<StockModels> tempStock = stList.Where(ss => ss.ID == (grdRow.DataBoundItem as SalesModel).ID).ToList();
                        stockList.ForEach(st =>
                        {
                            if (st.ID == (grdRow.DataBoundItem as SalesModel).ID && e.ColumnIndex == 3)
                            {
                                st.Stock = (Convert.ToInt32(tempStock[0].Stock) - Convert.ToInt32(e.FormattedValue)).ToString();
                            }
                        });
                    }
                }
                else if (e.ColumnIndex == 3)
                {
                    MessageBox.Show(string.Format("Provided input is Invalid. "), "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    e.Cancel = true;
                }

            }catch(Exception ex)
            {
                Logger.WriteErrorMessage(ex);
            }
        }
        
        public bool ValidateNumeric(string value)
        {
            bool flag = true;
            Regex nonNumericRegex = new Regex(@"\D");
            if (nonNumericRegex.IsMatch(value))
            {
                flag = false;
            }
            return flag;
        }

        public bool ValidateParcentage(string value)
        {
            bool flag = false;
            Regex ParcentageRegex = new Regex(@"^(\d+|\d+[.]\d+)%?$");
            if (ParcentageRegex.IsMatch(value))
            {
                flag = true;
            }
            return flag;
        }

        public void MakeInvoiceGenerationEnable()
        {
            if ((gridSale.DataSource as IList<SalesModel>).Count != 0)
                btnGenerateBill.Enabled = true;
            else
                btnGenerateBill.Enabled = false;
        }

        private void cmbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbUnit.DataSource == null) return;

                List<StockModels> stList = (cmbUnit.DataSource as List<StockModels>).Where(st => st.Weight == cmbUnit.Text).ToList();
                if (stList.Count > 0)
                    GetItemInStockOnUnit(stList[0]);
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage(ex);
            }
        }

        private void txtSgst_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
                //only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage(ex);
            }
        }

        private void txtUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #region Events for Left menu
        private void lblHome_MouseHover(object sender, EventArgs e)
        {
            Common.CustomMouseHoverForMenuBar(sender as Control);
        }

        private void lblHome_MouseLeave(object sender, EventArgs e)
        {
            Common.CustomMouseLeaveForMenuBar(sender as Control);
        }

        private void lblInvoice_MouseHover(object sender, EventArgs e)
        {
            Common.CustomMouseHoverForMenuBar(sender as Control);
        }

        private void lblInvoice_MouseLeave(object sender, EventArgs e)
        {
            Common.CustomMouseLeaveForMenuBar(sender as Control);
        }

        private void ChangeBackColor(Control _control)
        {
            _control.BackColor= Color.FromArgb(51, 153, 255);
            _control.ForeColor = Color.White;
        }
        #endregion

        private void lblInvoice_Click(object sender, EventArgs e)
        {

        }
    }
}
