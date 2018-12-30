using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RajEnterpriseBusinessLogic;
using System.Configuration;

namespace RajEnterprise
{
    public partial class LoginForm : Form
    {
        public string ConnectioString { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            InitializeLogger();
        }
        public LoginForm(string ConnectioString) : this()
        {
            this.ConnectioString = ConnectioString;
        }
        private void InitializeLogger()
        {
            string executablePath = Assembly.GetAssembly(typeof(LoginForm)).Location;
            string loggerFilePath = Directory.GetParent(executablePath).ToString();
            Logger.InitializeLogger(loggerFilePath);
        }
        
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtuserName.Text))
            {
                txtuserName.Text = "username";
                txtuserName.TextAlign = HorizontalAlignment.Center;
                txtuserName.ForeColor = Color.LightGray;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtuserName.Text = "username";
            txtPassword.Text = "password";
            ConnectioString = ConfigurationManager.ConnectionStrings["cns"].ConnectionString;
        }
        private void txtuserName_Enter(object sender, EventArgs e)
        {
            if (txtuserName.Text.Equals("username"))
            {
                txtuserName.Text = "";
                txtuserName.TextAlign = HorizontalAlignment.Left;
                txtuserName.ForeColor = Color.Black;
                //txtuserName.Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
            }
        }
        private void txtuserName_Leave(object sender, EventArgs e)
        {
            ManageTextBox();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("password"))
            {
                txtPassword.Text = "";
                txtPassword.TextAlign = HorizontalAlignment.Left;
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        public void ManageTextBox()
        {
            if (string.IsNullOrEmpty(txtuserName.Text))
            {
                txtuserName.Text = "username";
                txtuserName.TextAlign = HorizontalAlignment.Center;
                txtuserName.ForeColor = Color.LightGray;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "password";
                txtPassword.TextAlign = HorizontalAlignment.Center;
                txtPassword.ForeColor = Color.LightGray;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            ManageTextBox();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                btnLogin.Enabled = false;
                Logger.WriteInfoMessage("Application started ");
                Logger.WriteInfoMessage("***** Session started *****");
                ManageLogIn mngLogin = new ManageLogIn(ConnectioString);
                bool isRegUser = mngLogin.DoLogIn(txtuserName.Text, txtPassword.Text);
                if (txtuserName.Text.Equals("username"))
                {
                    btnLogin.Enabled = true;
                    lblErrorMsg.Text = "Please provide username.";
                    lblErrorMsg.Visible = true;
                    return;
                }
                if (txtPassword.Text.Equals("password"))
                {
                    btnLogin.Enabled = true;
                    lblErrorMsg.Text = "Please provide password.";
                    lblErrorMsg.Visible = true;
                    return;
                }
                if (isRegUser)
                {
                    btnLogin.Enabled = true;
                    lblErrorMsg.Visible = false;
                    (new HomeForm(this)).Show();
                    this.Hide();
                    txtuserName.Text = "";
                    btnLogin.Select();
                }
                else
                {
                    btnLogin.Enabled = true;
                    lblErrorMsg.Text = "Provided username or password is incorrect.";
                    lblErrorMsg.Visible = true;
                }
                txtPassword.Text = "";
                ManageTextBox();
            }
            catch(Exception ex)
            {
                btnLogin.Enabled = true;
                lblErrorMsg.Text = ex.Message;
                lblErrorMsg.Visible = true;
                Logger.WriteErrorMessage(ex);
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logger.WriteInfoMessage("***** Session closed *****");
            Logger.WriteInfoMessage("Application closed " + Environment.NewLine);
        }

        private void lblReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm regForm = new RajEnterprise.RegistrationForm(ConnectioString, this);
            this.Hide();
            regForm.ShowDialog();
        }

        private void lblForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordRecoveryForm passRecoveryForm = new RajEnterprise.PasswordRecoveryForm(ConnectioString, this);
            this.Hide();
            passRecoveryForm.ShowDialog();
        }
    }
}
