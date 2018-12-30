using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RajEnterprise
{
    public static class Common
    {
        public static void CustomMouseHover(Control _control)
        {
            if (_control.BackColor != Color.FromArgb(51, 153, 255))
            {
                _control.BackColor = Color.FromArgb(51, 153, 255);
                _control.ForeColor = Color.Black;
                _control.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            }
        }
        public static void CustomMouseLeave(Control _control)
        {
            if (_control.BackColor == Color.FromArgb(51, 153, 255))
            {
                _control.BackColor = Color.FromName("ControlDark");
                _control.ForeColor = Color.Black;
                _control.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            }
        }

        public static void CustomMouseHoverForMenuBar(Control _control)
        {
            if (_control.BackColor != Color.FromArgb(51, 153, 255))
            {
                _control.BackColor = Color.WhiteSmoke;
            }
        }
        public static void CustomMouseLeaveForMenuBar(Control _control)
        {
            if (_control.BackColor == Color.WhiteSmoke)
            {
                _control.BackColor = Color.FromName("ControlDark");
            }
        }
    }

    public class SalesReportModel
    {
        public string ProductName { get; set; }
        public string Quantity { get; set; }
        public string MRP { get; set; }
        public string Rate { get; set; }
        public string Discount { get; set; }
        public string SGST { get; set; }
        public string CGST { get; set; }
        public string IGST { get; set; }
        public decimal Amount { get; set; }
    }
}
