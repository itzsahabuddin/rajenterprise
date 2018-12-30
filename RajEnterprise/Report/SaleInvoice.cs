using RajEnterpriseBusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RajEnterprise.Report
{
    public partial class SaleInvoice : Form
    {
        List<SalesReportModel> _lstSale;
        CustomerModel _cust;
        Dictionary<string, object> _additional;
        public SaleInvoice(List<SalesReportModel> lstSale, CustomerModel cust,Dictionary<string,object> additional)
        {
            InitializeComponent();
            _lstSale = lstSale;
            _cust = cust;
            _additional = additional;
        }

        private void SaleInvoice_Load(object sender, EventArgs e)
        {
            invoice1.SetDataSource(_lstSale);
            invoice1.SetParameterValue("pCustName", _cust.CustomerName);
            invoice1.SetParameterValue("pAddress", _cust.Address);
            invoice1.SetParameterValue("pCustConactNo",_cust.MobileNo);
            invoice1.SetParameterValue("pBillNo", _additional["BillNo"]);
            invoice1.SetParameterValue("pDiscount", _additional["Discount"]);
            invoice1.SetParameterValue("pIGST", _additional["IGST"]);
            invoice1.SetParameterValue("pCGST", _additional["CGST"]);
            invoice1.SetParameterValue("pSGST", _additional["SGST"]);
            invoice1.SetParameterValue("pGrandTotal", _additional["GrandTotal"]);

            reportForSale.ReportSource = invoice1;

            reportForSale.Refresh();
        }
    }
}
