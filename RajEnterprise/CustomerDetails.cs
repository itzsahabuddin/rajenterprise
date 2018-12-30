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
    public partial class CustomerDetails : Form
    {
        public string ConnectioString { get; set; }
        public Form Instance { get; set; }
        public CustomerModel Buyer
        {
            get
            {
                return _Buyer;
            }

           private set
            {
                _Buyer = value;
            }
        }
        private bool isBuyer = false;

        private ManageCustomer mngCustomer = null;
        private CustomerModel _Buyer;
        public CustomerDetails()
        {
            InitializeComponent();            
        }
        public CustomerDetails(string ConnectioString, Form Instance) :this()
        {
            this.ConnectioString = ConnectioString;
           this.Instance = Instance;
        }

        private void checkNewCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNewCustomer.Checked)
                grpBoxCust.Enabled = true;
            else
                grpBoxCust.Enabled = false;
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            try
            {
                if (Instance != null)
                    Instance.Hide();
                lblCustIdInfo.Text = "";
                ShowAllCustomer();
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage(ex);
            }
        }

        private void btnNewCust_Click(object sender, EventArgs e)
        {
            try
            {
                FillRequiredFiled();
                CustomerModel custModel = new CustomerModel()
                {
                    ID = string.IsNullOrEmpty(lblCustIdInfo.Text) ? 0 : Convert.ToInt32(lblCustIdInfo.Text),
                    CustomerName = txtCustName.Text,
                    Address = txtAddress.Text,
                    GstNo = txtGst.Text,
                    MobileNo = txtMobile.Text,
                    EmailId = txtEmail.Text,
                    Diactivate = chkIsActive.Checked
                };
                int flag = mngCustomer.CreateOrUpdateCustomer(custModel);
                if (flag == 1)
                {
                    ShowAllCustomer();
                    if (!string.IsNullOrEmpty(lblCustIdInfo.Text))
                        MessageBox.Show(string.Format("Customer \"{0}\" is added successfully", txtCustName.Text), "Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(string.Format("Customer \"{0}\" is updated successfully", txtCustName.Text), "Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAllInputBox();
                }
            }
            catch(Exception ex)
            {
                Logger.WriteErrorMessage(ex);
            }
        }

        private void FillRequiredFiled()
        {
            if(string.IsNullOrEmpty(txtCustName.Text.Trim()))
            {
                MessageBox.Show(string.Format("Please fill out \"{0}\"", "Customer Name"), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtMobile.Text.Trim()))
            {
                MessageBox.Show(string.Format("Please fill out \"{0}\"", "Mobile No"), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void ShowAllCustomer()
        {
            mngCustomer = new ManageCustomer(ConnectioString);
            List<CustomerModel> custList = mngCustomer.GetAllCustomer();
            if (radioName.Checked && !string.IsNullOrEmpty(txtSearch.Text))
            {
                custList = custList.FindAll(cust => cust.CustomerName.Contains(txtSearch.Text));
            }
            if (radioMobile.Checked && !string.IsNullOrEmpty(txtSearch.Text))
            {
                custList = custList.FindAll(cust => cust.MobileNo.Equals(txtSearch.Text));
            }
            if (chkSearchActiveUser.Checked)
            {
                custList = custList.FindAll(cust => cust.Diactivate);
            }
            else
            {
                custList = custList.FindAll(cust => !cust.Diactivate);
            }
            gridCust.DataSource = custList;
            gridCust.ClearSelection();
        }

        private void gridCust_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    lblCustIdInfo.Text = "";
                    lblCustIdInfo.Visible = true;
                    lblCustId.Visible = true;
                    CustomerModel cust = gridCust.Rows[e.RowIndex].DataBoundItem as CustomerModel;
                    lblCustIdInfo.Text = cust.ID.ToString();
                    txtAddress.Text = cust.Address;
                    txtCustName.Text = cust.CustomerName;
                    txtEmail.Text = cust.EmailId;
                    txtGst.Text = cust.GstNo;
                    txtMobile.Text = cust.MobileNo;
                    chkIsActive.Checked = cust.Diactivate;
                    if (!string.IsNullOrEmpty(lblCustIdInfo.Text))
                        btnOk.Enabled = true;
                    else
                        btnOk.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage(ex);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ShowAllCustomer();

            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage(ex);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                this.Buyer = new CustomerModel();
                Buyer.ID = !string.IsNullOrEmpty(lblCustIdInfo.Text) ? Convert.ToInt32(lblCustIdInfo.Text) : 0;
                Buyer.Address = txtAddress.Text;
                Buyer.CustomerName = txtCustName.Text;
                Buyer.Diactivate = chkIsActive.Checked;
                Buyer.EmailId = txtEmail.Text;
                Buyer.GstNo = txtGst.Text;
                Buyer.MobileNo = txtMobile.Text;
                this.DialogResult = DialogResult.OK;
                if (Instance != null)
                    this.Instance.Show();
                this.Close();
                isBuyer = true;
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage(ex);
            }
        }

        private void CustomerDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Instance != null)
                this.Instance.Show();
            if (!isBuyer)
            {
                this.Dispose();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllInputBox();
        }
        private void ClearAllInputBox()
        {
            lblCustIdInfo.Text = "";
            txtCustName.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtGst.Text = "";
            txtMobile.Text = "";
            chkIsActive.Checked = false;
        }        

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && radioMobile.Checked)
            {
                e.Handled = true;
            }
        }

        private void radioMobile_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMobile.Checked)
            {
                txtSearch.MaxLength = 10;
            }
        }

        private void radioName_CheckedChanged(object sender, EventArgs e)
        {
            if (radioName.Checked)
            {
                txtSearch.MaxLength = 40;
            }
        }
        

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        public bool ValidateNumeric(string value)
        {
            bool flag = true;
            Regex nonNumericRegex = new Regex(@"\D{10}");
            if (nonNumericRegex.IsMatch(value))
            {
                flag = false;
            }
            return flag;
        }

        public bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^[0-9]{10}$").Success;
        }
    }
}
