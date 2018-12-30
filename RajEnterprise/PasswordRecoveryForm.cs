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
    public partial class PasswordRecoveryForm : Form
    {
        public string ConnectionString { get; set; }
        public Form Instance { get; set; }
        public ManageRegistration mngReg = null;
        public List<QuestionModel> questionList = null;
        public PasswordRecoveryForm()
        {
            InitializeComponent();
        }
        public PasswordRecoveryForm(string ConnectionString, Form Instance) : this()
        {
            this.Instance = Instance;
            this.ConnectionString = ConnectionString;

        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        public bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^[0-9]{10}$").Success;
        }

        private void PasswordRecoveryForm_Load(object sender, EventArgs e)
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

        private void PasswordRecoveryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Instance.Show();
        }

        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtContactNo.Text.Trim()) && IsPhoneNumber(txtContactNo.Text))
            {
                btnRecover.Enabled = true;
            }
            else
            {
                txtAnswer.Text = "";
                txtPassword.Text = "";
                btnRecover.Enabled = false;
            }
        }        

        private void btnRecover_Click(object sender, EventArgs e)
        {
            try
            {
                mngReg = new ManageRegistration(ConnectionString);
                string password = mngReg.GetPassword(txtContactNo.Text, (cmbQuestion.SelectedItem as QuestionModel).Qid, txtAnswer.Text);
                if (!string.IsNullOrEmpty(password))
                {
                    txtPassword.Text = password;
                }
                else
                {
                    MessageBox.Show("Please provide correct information to get Password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage(ex.Message);
            }
        }
    }
}
