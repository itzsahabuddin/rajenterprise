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
    public partial class AddStockForm : Form
    {
        private ManageStock mngStock = null;
        public List<Product> Products { get; set; }
        public List<Company> Companies { get; set; }
        public string ConnectionString { get; set; }
        private DataGridView _gridStock;
        public AddStockForm()
        {
            InitializeComponent();
        }
        public AddStockForm(List<Product> Products, List<Company> Companies,string ConnectionString, DataGridView _gridStock) : this()
        {
            this.ConnectionString = ConnectionString;
            this.Products = Products;
            this.Companies = Companies;
            this._gridStock = _gridStock;
        }

        private void AddStockForm_Load(object sender, EventArgs e)
        {
            try
            {
                mngStock = new ManageStock(ConnectionString);

                cmbxProductName.DataSource = this.Products;
                cmbxProductName.DisplayMember = "ProductName";

                cmbCompany.DataSource = this.Companies;
                cmbCompany.DisplayMember = "CompanyName";
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage(ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckMandatoryFileds())
                {
                    return;
                }

                List<ProductModel> prdNcmpList = mngStock.GetProductDetails();
                string weight = (txtWeight.Text.Replace(" ", "") + cmbUnit.Text).ToLower();
                bool flag = prdNcmpList.Exists(pc =>
                            pc.ProductName.ToLower().Replace(" ", "") == cmbxProductName.Text.ToLower().Replace(" ", "")
                            && pc.CompanyName.ToLower().Replace(" ", "") == cmbCompany.Text.ToLower().Replace(" ", "")
                            && pc.Weight == weight
                            );
                //if (!flag)
                //{
                mngStock.IncreaseStock((cmbxProductName.SelectedItem as Product).ID, (cmbCompany.SelectedItem as Company).ID, weight, txtDetails.Text, txtMrp.Text.Trim(), txtRate.Text.Trim(), Convert.ToInt32(txtStock.Text), txtSgst.Text.Trim(), txtCgst.Text.Trim(), txtIgst.Text.Trim());
                List<StockModels> lstStock = mngStock.GetAllStock();
                _gridStock.DataSource = lstStock;
                _gridStock.ClearSelection();
                //}
                MessageBox.Show("New Item has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage(ex);
            }
        }

        private bool CheckMandatoryFileds()
        {
            bool flag = true;
            if(string.IsNullOrEmpty(cmbxProductName.Text))
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
