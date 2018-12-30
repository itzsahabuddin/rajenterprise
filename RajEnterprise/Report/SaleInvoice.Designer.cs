namespace RajEnterprise.Report
{
    partial class SaleInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportForSale = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.invoice1 = new RajEnterprise.Report.Invoice();
            this.SuspendLayout();
            // 
            // reportForSale
            // 
            this.reportForSale.ActiveViewIndex = -1;
            this.reportForSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportForSale.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportForSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportForSale.Location = new System.Drawing.Point(0, 0);
            this.reportForSale.Name = "reportForSale";
            this.reportForSale.ShowRefreshButton = false;
            this.reportForSale.Size = new System.Drawing.Size(1145, 446);
            this.reportForSale.TabIndex = 0;
            // 
            // SaleInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 446);
            this.Controls.Add(this.reportForSale);
            this.Name = "SaleInvoice";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SaleInvoice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SaleInvoice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportForSale;
        private Invoice invoice1;
    }
}