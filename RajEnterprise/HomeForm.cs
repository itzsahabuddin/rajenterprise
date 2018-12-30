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
    public partial class HomeForm : Form
    {
        public string ConnectioString { get; set; }
        public Form Instance { get; set; }
        public HomeForm(Form Instance)
        {
            this.Instance = Instance;
            InitializeComponent();
        }

        private void pnlSales_Click(object sender, EventArgs e)
        {
            Logger.WriteInfoMessage("***** Manage Sale *****");
            SalesForm sf = new RajEnterprise.SalesForm(this);
            sf.Show();
            this.Hide();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            ConnectioString = ConfigurationManager.ConnectionStrings["cns"].ConnectionString;
        }

        private void pnlSales_MouseHover(object sender, EventArgs e)
        {
            Common.CustomMouseHover(pnlSales);
        }

        private void pnlSales_MouseLeave(object sender, EventArgs e)
        {
            Common.CustomMouseLeave(pnlSales);
        }

        private void pnlStock_MouseHover(object sender, EventArgs e)
        {
            Common.CustomMouseHover(pnlStock);
        }

        private void pnlStock_MouseLeave(object sender, EventArgs e)
        {
            Common.CustomMouseLeave(pnlStock);
        }

        private void pnlManageCust_MouseHover(object sender, EventArgs e)
        {
            Common.CustomMouseHover(pnlManageCust);
        }

        private void pnlManageCust_MouseLeave(object sender, EventArgs e)
        {
            Common.CustomMouseLeave(pnlManageCust);
        }


        private void pnlStock_Click(object sender, EventArgs e)
        {
            Logger.WriteInfoMessage("***** Mahage Stock *****");
            ManagerStockForm msf = new ManagerStockForm(this);
            msf.Show();
            this.Hide();
        }

        private void picReport_Click(object sender, EventArgs e)
        {

        }

        private void pnlLogout_MouseHover(object sender, EventArgs e)
        {
            Common.CustomMouseHover(pnlLogout);
        }

        private void pnlLogout_MouseLeave(object sender, EventArgs e)
        {
            Common.CustomMouseLeave(pnlLogout);
        }
        private void picLogout_Click(object sender, EventArgs e)
        {
            this.Instance.Show();
            this.Dispose();
            Logger.WriteInfoMessage("***** Session closed *****");
        }

        private void picManageCust_Click(object sender, EventArgs e)
        {
            Logger.WriteInfoMessage("***** Manage Customer *****");
            CustomerDetails custDetail = new CustomerDetails(ConnectioString, this);
            custDetail.Controls.Find("checkNewCustomer", true)[0].Enabled = true;
            custDetail.Controls.Find("chkSearchActiveUser", true)[0].Enabled = true;
            custDetail.Controls.Find("btnOk", true)[0].Visible = false;
            custDetail.Show();
            this.Hide();
        }
    }
}
