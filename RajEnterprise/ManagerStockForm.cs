using RajEnterpriseBusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RajEnterprise
{
    public partial class ManagerStockForm : Form
    {
        public Form Instanse { get; set; }
        public string ConnectioString { get; set; }
        private ManageStock mngStock = null;
        public ManagerStockForm()
        {
            InitializeComponent();
        }
        public ManagerStockForm(Form instance) : this()
        {           
            this.Instanse = instance;
        }

        private void CustomMouseHover(Control _control)
        {
            if (_control.BackColor != Color.FromArgb(51, 153, 255))
            {
                _control.BackColor = Color.White;
                _control.ForeColor = Color.Black;
                _control.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f);
            }
        }
        private void CustomMouseLeave(Control _control)
        {
            if (_control.BackColor != Color.FromArgb(51, 153, 255))
            {
                _control.BackColor = Color.FromKnownColor(KnownColor.Control);
                _control.ForeColor = Color.Black;
                _control.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f);
            }
        }

        private void gridStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gridStock.ClearSelection();
            if (e.ColumnIndex == 1 && e.RowIndex != -1)
            {
                StockModels sm = gridStock.Rows[e.RowIndex].DataBoundItem as StockModels;

                List<Product> lstProduct = null;
                List<Company> lstCmp = null;
                getCompanyAndProduct(out lstProduct, out lstCmp);

                UpdateStockForm upStockForm = new RajEnterprise.UpdateStockForm(lstProduct, lstCmp, ConnectioString, sm, gridStock, e.RowIndex);
                upStockForm.ShowDialog();
                gridStock.ClearSelection();
            }
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            try
            {
                ConnectioString = ConfigurationManager.ConnectionStrings["cns"].ConnectionString;
                mngStock = new ManageStock(ConnectioString);
                List<StockModels> lstStock = mngStock.GetAllStock();
                gridStock.DataSource = lstStock;
                gridStock.ClearSelection();
                bindCombobox();
            }
            catch(Exception ex)
            {
                Logger.WriteErrorMessage(ex);
            }
        }

        public void bindCombobox()
        {
            List<Product> lstProduct = null;
            List<Company> lstCmp = null;
            getCompanyAndProduct(out lstProduct, out lstCmp);

            cmbCompany.DataSource = lstCmp; cmbCompany.DisplayMember = "CompanyName";
            cmbProduct.DataSource = lstProduct; cmbProduct.DisplayMember = "ProductName";
            cmbCompany.Text = "";
            cmbProduct.Text = "";
        }

        public void getCompanyAndProduct(out List<Product> lstProduct, out List<Company> lstCmp)
        {
            List<Product> tempLstProduct = null;
            List<Company> tempLstCmp = null;
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

        private void lblAddProduct_Click(object sender, EventArgs e)
        {
            List<Product> lstProduct = null;
            List<Company> lstCmp = null;
            getCompanyAndProduct(out lstProduct, out lstCmp);

            AddStockForm addStock = new RajEnterprise.AddStockForm(lstProduct, lstCmp, ConnectioString, gridStock);
            addStock.ShowDialog();
            
        }

        private void lblMngProduct_Click(object sender, EventArgs e)
        {
            ManageProductCompany mngPrdCmp = new ManageProductCompany(ConnectioString);
            mngPrdCmp.ShowDialog();
            bindCombobox();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbProduct.Text) || !string.IsNullOrEmpty(cmbCompany.Text))
            {
                SearchItems();
            }
        }

        private void SearchItems()
        {
            try
            {
                List<StockModels> tempList = null;
                if (!string.IsNullOrEmpty(cmbProduct.Text) || !string.IsNullOrEmpty(cmbCompany.Text))
                {
                    List<StockModels> lstStock = mngStock.GetAllStock();

                    if (!string.IsNullOrEmpty(cmbProduct.Text) && !string.IsNullOrEmpty(cmbCompany.Text))
                        tempList = lstStock.Where(i => i.ProductName == cmbProduct.Text && i.Company == cmbCompany.Text).ToList();
                    else
                    {
                        if (!string.IsNullOrEmpty(cmbProduct.Text))
                            tempList = lstStock.Where(i => i.ProductName == cmbProduct.Text).ToList();
                        else
                            tempList = lstStock.Where(i => i.Company == cmbCompany.Text).ToList();
                    }
                }
                gridStock.DataSource = tempList;
                gridStock.ClearSelection();
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage(ex);
            }
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            this.Instanse.Show();
            this.Dispose();
        }
                
    }
}
