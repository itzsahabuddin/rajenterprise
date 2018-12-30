using RajEnterpriseBusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RajEnterprise
{
    public partial class RegistrationForm : Form
    {
        public string ConnectionString { get; set; }
        public Form Instance { get; set; }
        public ManageRegistration mngReg = null;
        public List<QuestionModel> questionList = null;
        public RegistrationForm()
        {
            InitializeComponent();
        }
        public RegistrationForm(string ConnectionString, Form Instance) : this()
        {
            this.Instance = Instance;
            this.ConnectionString = ConnectionString;

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            try
            {
                mngReg = new ManageRegistration(ConnectionString);
                questionList = mngReg.GetAllQuestion();
                cmbQuestion.DataSource = questionList;
                cmbQuestion.DisplayMember = "Question";
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage(ex.Message);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                if (mngReg.CheckAvailability(txtContactNo.Text.Trim()))
                {
                    grbBusinessDetails.Enabled = true;
                    grbCredential.Enabled = true;
                    grbUserDetails.Enabled = true;
                    btnClear.Enabled = true;
                    btnSubmit.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage(ex.Message);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text.Trim()) || string.IsNullOrEmpty(txtBname.Text.Trim()) || 
                    string.IsNullOrEmpty(txtPassword.Text.Trim()) || string.IsNullOrEmpty(txtAnswer.Text.Trim()))
                {
                    MessageBox.Show("Please provide Mandatory fields value.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                UserModel uModel = new UserModel()
                {
                    Name = txtName.Text,
                    Address = txtAddress.Text,
                    Email = txtEmail.Text,
                    Answer = txtAnswer.Text,
                    BusinessAddress = txtBaddress.Text,
                    BusinessName = txtBname.Text,
                    ContactNo = txtContactNo.Text,
                    GST = txtGst.Text,
                    PAN = txtPAN.Text,
                    Password = txtPassword.Text,
                    Role = "0"
                };
                uModel.Qid = Convert.ToString((cmbQuestion.SelectedItem as QuestionModel).Qid);
                int flag = mngReg.DoRegistration(uModel);
                ResetAllControls();
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                ResetAllControls();
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage(ex.Message);
            }
        }

        private void ResetAllControls()
        {
            txtContactNo.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";

            txtBname.Text = "";
            txtBaddress.Text = "";
            txtGst.Text = "";
            txtPAN.Text = "";

            txtPassword.Text = "";
            txtAnswer.Text = "";
        }

        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtContactNo.Text.Trim()) && IsPhoneNumber(txtContactNo.Text))
            {
                btnCheck.Enabled = true;
            }
            else
            {
                btnCheck.Enabled = false;

                grbBusinessDetails.Enabled = false;
                grbCredential.Enabled = false;
                grbUserDetails.Enabled = false;
                btnClear.Enabled = false;
                btnSubmit.Enabled = false;
            }
        }

        public bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^[0-9]{10}$").Success;
        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Instance.Show();
        }
    }
}
