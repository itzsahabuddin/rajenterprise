using RajEnterpriseBusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RajEnterprise
{
    public partial class UpdateStockForm : Form
    {
        private ManageStock mngStock = null;
        public List<Product> Products { get; set; }
        public List<Company> Companies { get; set; }
        public string Connection { get; set; }
        public StockModels Stock { get; set; }
        private DataGridView _gridStock;
        private int rowIndex;
        public UpdateStockForm()
        {
            InitializeComponent();
        }
        public UpdateStockForm(List<Product> Products, List<Company> Companies, string Connection, StockModels sm, DataGridView _gridStock,int rowIndex) : this()
        {
            this.Connection = Connection;
            this.Products = Products;
            this.Companies = Companies;
            this.Stock = sm;
            this._gridStock = _gridStock;
            this.rowIndex = rowIndex;
        }

        private void UpdateStockForm_Load(object sender, EventArgs e)
        {
            mngStock = new ManageStock(Connection);
            cmbProductName.DataSource = this.Products;
            cmbProductName.DisplayMember = "ProductName";
            cmbCompany.DataSource = this.Companies;
            cmbCompany.DisplayMember = "CompanyName";

            cmbProductName.Text = Stock.ProductName;
            cmbCompany.Text = Stock.Company;
            txtWeight.Text = !string.IsNullOrEmpty(Stock.Weight) ? Stock.Weight.Substring(0, (Stock.Weight.Length - 2)) : "";
            cmbUnit.Text = !string.IsNullOrEmpty(Stock.Weight) ? Stock.Weight.Substring(Stock.Weight.Length - 2) : "";
            txtStock.Text = Stock.Stock;
            txtCgst.Text = Stock.CGST;
            txtIgst.Text = Stock.IGST;
            txtMrp.Text = Stock.MRP;
            txtRate.Text = Stock.Rate;
            txtSgst.Text = Stock.SGST;
            txtDetails.Text = Stock.Details;        
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckMandatoryFileds())
                {
                    return;
                }

                List<ProductModel> prdNcmpList = mngStock.GetProductDetails();
                //bool flag = prdNcmpList.Exists(pc => pc.ProductName.ToLower().Replace(" ", "") == cmbProductName.Text.ToLower().Replace(" ", "") && pc.CompanyName.ToLower().Replace(" ", "") == cmbCompany.Text.ToLower().Replace(" ", ""));
                //if (!flag)
                //{
                string weight = (txtWeight.Text.Replace(" ", "") + cmbUnit.Text).ToLower();
                mngStock.UpdateStock(Stock.ID, (cmbProductName.SelectedItem as Product).ID, (cmbCompany.SelectedItem as Company).ID, weight, txtDetails.Text, txtMrp.Text.Trim(), txtRate.Text.Trim(), Convert.ToInt32(txtStock.Text), txtSgst.Text.Trim(), txtCgst.Text.Trim(), txtIgst.Text.Trim());
                RefreshStockGrid();
                // _gridStock.Rows[rowIndex].Selected = true;
                //}
                MessageBox.Show("This Item is successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage(ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to delete this Item permanently.", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                mngStock.DeleteStock(Stock.ID);
                RefreshStockGrid();
                this.Dispose();
            }
        }

        private void RefreshStockGrid()
        {
            try
            {
                List<StockModels> lstStock = mngStock.GetAllStock();
                List<StockModels> tempStockList = new List<StockModels>();
                (_gridStock.DataSource as List<StockModels>).ForEach(st =>
                {
                    lstStock.ForEach(upSt =>
                    {
                        if (st.ID == upSt.ID)
                        {
                            tempStockList.Add(upSt);
                        }
                    });
                });

                _gridStock.DataSource = tempStockList;
                _gridStock.ClearSelection();
            }
            catch (Exception ex)
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

        private void txtSgst_TextChanged(object sender, EventArgs e)
        {
            if (ValidateParcentage(txtSgst.Text))            
                btnUpdate.Enabled = true;            
            else
                btnUpdate.Enabled = false;
        }

        private bool CheckMandatoryFileds()
        {
            bool flag = true;
            if (string.IsNullOrEmpty(cmbProductName.Text))
            {
                flag = false;
            }
            if (string.IsNullOrEmpty(cmbCompany.Text))
            {
                flag = false;
            }
            if (string.IsNullOrEmpty(txtStock.Text))
            {
                flag = false;
            }
            if (string.IsNullOrEmpty(txtRate.Text))
            {
                flag = false;
            }
            if (string.IsNullOrEmpty(txtMrp.Text))
            {
                flag = false;
            }
            return flag;
        }
        private void txtSgst_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
