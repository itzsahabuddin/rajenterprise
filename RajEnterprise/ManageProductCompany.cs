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
    public partial class ManageProductCompany : Form
    {        
        private ManageStock mngStock = null;
        public string ConnectionString { get; set; }
        public ManageProductCompany(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
            InitializeComponent();
        }

        private void ManageProductCompany_Load(object sender, EventArgs e)
        {
            lblCmpInfo.Text = "";lblPidInfo.Text = "";
            GetProductAndCompany();
        }

        public void GetProductAndCompany()
        {
            try
            {
                mngStock = new ManageStock(ConnectionString);
                List<Product> lstProduct = mngStock.GetProduct();
                gridProduct.DataSource = lstProduct;
                gridProduct.ClearSelection();

                List<Company> lstCmp = mngStock.GetCompany();
                gridComp.DataSource = lstCmp;
                gridComp.ClearSelection();
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage(ex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                List<Company> lstComp = gridComp.DataSource as List<Company>;
                bool temp = lstComp.Exists(cmp => cmp.CompanyName.ToLower().Replace(" ", "") == txtComp.Text.ToLower().Replace(" ", ""));
                if (!temp && !string.IsNullOrEmpty(txtComp.Text))
                {
                    Company tempComp = new Company();
                    tempComp.ID = string.IsNullOrEmpty(lblCmpInfo.Text) ? 0 : Convert.ToInt32(lblCmpInfo.Text);
                    tempComp.CompanyName = txtComp.Text;
                    mngStock.CreateOrUpdateCompany(tempComp);
                    GetProductAndCompany();
                    HideCompanyLabels();
                    MessageBox.Show("This item successfully added/updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                Logger.WriteErrorMessage(ex);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                List<Product> lstProduct = gridProduct.DataSource as List<Product>;
                bool temp = lstProduct.Exists(p => p.ProductName.ToLower().Replace(" ", "") == txtProduct.Text.ToLower().Replace(" ", ""));
                if (!temp && !string.IsNullOrEmpty(txtProduct.Text))
                {
                    Product tempProduct = new Product();
                    tempProduct.ID = string.IsNullOrEmpty(lblPidInfo.Text) ? 0 : Convert.ToInt32(lblPidInfo.Text);
                    tempProduct.ProductName = txtProduct.Text;
                    mngStock.CreateOrUpdateProduct(tempProduct);
                    GetProductAndCompany();
                    HideProductLabels();
                    MessageBox.Show("This item successfully added/updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage(ex);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtProduct.Text))
                {
                    DialogResult dr = MessageBox.Show("Do you want to delete.", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        mngStock.DeleteProduct(Convert.ToInt32(lblPidInfo.Text));
                        GetProductAndCompany();
                        HideProductLabels();
                    }
                }
            }
            catch(Exception ex)
            {
                Logger.WriteErrorMessage(ex);
            }
        }

        private void btnDeleteComp_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtComp.Text))
                {
                    DialogResult dr = MessageBox.Show("Do you want to delete.", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        mngStock.DeleteCompany(Convert.ToInt32(lblCmpInfo.Text));
                        GetProductAndCompany();
                        HideCompanyLabels();
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage(ex);
            }
        }

        private void gridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Product UpOrDel_product = gridProduct.Rows[e.RowIndex].DataBoundItem as Product;
                lblPidInfo.Text = Convert.ToString(UpOrDel_product.ID);
                txtProduct.Text = UpOrDel_product.ProductName;
                lblPid.Visible = true;
                lblPidInfo.Visible = true;
            }
        }

        private void gridComp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Company UpOrDel_company = gridComp.Rows[e.RowIndex].DataBoundItem as Company;
                lblCmpInfo.Text = Convert.ToString(UpOrDel_company.ID);
                txtComp.Text = UpOrDel_company.CompanyName;
                lblCmp.Visible = true;
                lblCmpInfo.Visible = true;
            }
        }

        private void txtComp_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtComp.Text))
            {
                HideCompanyLabels();                
            }
        }

        private void txtProduct_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProduct.Text))
            {
                HideProductLabels();
            }
        }

        public void HideProductLabels()
        {
            txtProduct.Text = "";
            lblPidInfo.Text = "";
            lblPid.Visible = false;
            lblPidInfo.Visible = false;
            gridProduct.ClearSelection();
        }
        public void HideCompanyLabels()
        {
            txtComp.Text = "";
            lblCmpInfo.Text = "";
            lblCmp.Visible = false;
            lblCmpInfo.Visible = false;
            gridComp.ClearSelection();
        }
    }
}
