namespace RajEnterprise
{
    partial class HomeForm
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
            this.pnlSales = new System.Windows.Forms.Panel();
            this.picSales = new System.Windows.Forms.PictureBox();
            this.pnlStock = new System.Windows.Forms.Panel();
            this.picStock = new System.Windows.Forms.PictureBox();
            this.pnlManageCust = new System.Windows.Forms.Panel();
            this.picManageCust = new System.Windows.Forms.PictureBox();
            this.pnlReport = new System.Windows.Forms.Panel();
            this.picReport = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlLogout = new System.Windows.Forms.Panel();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.pnlSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSales)).BeginInit();
            this.pnlStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStock)).BeginInit();
            this.pnlManageCust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picManageCust)).BeginInit();
            this.pnlReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReport)).BeginInit();
            this.pnlLogout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSales
            // 
            this.pnlSales.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSales.Controls.Add(this.picSales);
            this.pnlSales.Location = new System.Drawing.Point(29, 40);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(119, 111);
            this.pnlSales.TabIndex = 0;
            this.pnlSales.Click += new System.EventHandler(this.pnlSales_Click);
            this.pnlSales.MouseLeave += new System.EventHandler(this.pnlSales_MouseLeave);
            this.pnlSales.MouseHover += new System.EventHandler(this.pnlSales_MouseHover);
            // 
            // picSales
            // 
            this.picSales.Image = global::RajEnterprise.Properties.Resources.sale;
            this.picSales.Location = new System.Drawing.Point(33, 30);
            this.picSales.Name = "picSales";
            this.picSales.Size = new System.Drawing.Size(52, 47);
            this.picSales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSales.TabIndex = 0;
            this.picSales.TabStop = false;
            this.picSales.Click += new System.EventHandler(this.pnlSales_Click);
            this.picSales.MouseLeave += new System.EventHandler(this.pnlSales_MouseLeave);
            this.picSales.MouseHover += new System.EventHandler(this.pnlSales_MouseHover);
            // 
            // pnlStock
            // 
            this.pnlStock.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStock.Controls.Add(this.picStock);
            this.pnlStock.Location = new System.Drawing.Point(166, 40);
            this.pnlStock.Name = "pnlStock";
            this.pnlStock.Size = new System.Drawing.Size(119, 111);
            this.pnlStock.TabIndex = 1;
            this.pnlStock.Click += new System.EventHandler(this.pnlStock_Click);
            this.pnlStock.MouseLeave += new System.EventHandler(this.pnlStock_MouseLeave);
            this.pnlStock.MouseHover += new System.EventHandler(this.pnlStock_MouseHover);
            // 
            // picStock
            // 
            this.picStock.Image = global::RajEnterprise.Properties.Resources.stock;
            this.picStock.Location = new System.Drawing.Point(34, 30);
            this.picStock.Name = "picStock";
            this.picStock.Size = new System.Drawing.Size(52, 47);
            this.picStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStock.TabIndex = 1;
            this.picStock.TabStop = false;
            this.picStock.Click += new System.EventHandler(this.pnlStock_Click);
            this.picStock.MouseLeave += new System.EventHandler(this.pnlStock_MouseLeave);
            this.picStock.MouseHover += new System.EventHandler(this.pnlStock_MouseHover);
            // 
            // pnlManageCust
            // 
            this.pnlManageCust.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlManageCust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlManageCust.Controls.Add(this.picManageCust);
            this.pnlManageCust.Location = new System.Drawing.Point(305, 40);
            this.pnlManageCust.Name = "pnlManageCust";
            this.pnlManageCust.Size = new System.Drawing.Size(119, 111);
            this.pnlManageCust.TabIndex = 2;
            this.pnlManageCust.Click += new System.EventHandler(this.picManageCust_Click);
            this.pnlManageCust.MouseLeave += new System.EventHandler(this.pnlManageCust_MouseLeave);
            this.pnlManageCust.MouseHover += new System.EventHandler(this.pnlManageCust_MouseHover);
            // 
            // picManageCust
            // 
            this.picManageCust.Image = global::RajEnterprise.Properties.Resources.customer;
            this.picManageCust.Location = new System.Drawing.Point(35, 30);
            this.picManageCust.Name = "picManageCust";
            this.picManageCust.Size = new System.Drawing.Size(52, 47);
            this.picManageCust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picManageCust.TabIndex = 2;
            this.picManageCust.TabStop = false;
            this.picManageCust.Click += new System.EventHandler(this.picManageCust_Click);
            this.picManageCust.MouseLeave += new System.EventHandler(this.pnlManageCust_MouseLeave);
            this.picManageCust.MouseHover += new System.EventHandler(this.pnlManageCust_MouseHover);
            // 
            // pnlReport
            // 
            this.pnlReport.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReport.Controls.Add(this.picReport);
            this.pnlReport.Location = new System.Drawing.Point(29, 175);
            this.pnlReport.Name = "pnlReport";
            this.pnlReport.Size = new System.Drawing.Size(119, 111);
            this.pnlReport.TabIndex = 2;
            // 
            // picReport
            // 
            this.picReport.Location = new System.Drawing.Point(33, 33);
            this.picReport.Name = "picReport";
            this.picReport.Size = new System.Drawing.Size(52, 47);
            this.picReport.TabIndex = 3;
            this.picReport.TabStop = false;
            this.picReport.Click += new System.EventHandler(this.picReport_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(456, 19);
            this.pnlHeader.TabIndex = 3;
            // 
            // pnlLogout
            // 
            this.pnlLogout.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlLogout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogout.Controls.Add(this.picLogout);
            this.pnlLogout.Location = new System.Drawing.Point(166, 175);
            this.pnlLogout.Name = "pnlLogout";
            this.pnlLogout.Size = new System.Drawing.Size(119, 111);
            this.pnlLogout.TabIndex = 4;
            this.pnlLogout.Click += new System.EventHandler(this.picLogout_Click);
            this.pnlLogout.MouseLeave += new System.EventHandler(this.pnlLogout_MouseLeave);
            this.pnlLogout.MouseHover += new System.EventHandler(this.pnlLogout_MouseHover);
            // 
            // picLogout
            // 
            this.picLogout.Image = global::RajEnterprise.Properties.Resources.logout;
            this.picLogout.Location = new System.Drawing.Point(33, 33);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(52, 47);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogout.TabIndex = 3;
            this.picLogout.TabStop = false;
            this.picLogout.Click += new System.EventHandler(this.picLogout_Click);
            this.picLogout.MouseLeave += new System.EventHandler(this.pnlLogout_MouseLeave);
            this.picLogout.MouseHover += new System.EventHandler(this.pnlLogout_MouseHover);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 308);
            this.Controls.Add(this.pnlLogout);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlReport);
            this.Controls.Add(this.pnlManageCust);
            this.Controls.Add(this.pnlStock);
            this.Controls.Add(this.pnlSales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.pnlSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSales)).EndInit();
            this.pnlStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStock)).EndInit();
            this.pnlManageCust.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picManageCust)).EndInit();
            this.pnlReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picReport)).EndInit();
            this.pnlLogout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSales;
        private System.Windows.Forms.Panel pnlStock;
        private System.Windows.Forms.Panel pnlManageCust;
        private System.Windows.Forms.Panel pnlReport;
        private System.Windows.Forms.PictureBox picSales;
        private System.Windows.Forms.PictureBox picStock;
        private System.Windows.Forms.PictureBox picManageCust;
        private System.Windows.Forms.PictureBox picReport;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picLogout;
        private System.Windows.Forms.Panel pnlLogout;
    }
}