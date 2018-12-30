namespace RajEnterprise
{
    partial class AddStockForm
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
            this.cmbxProductName = new System.Windows.Forms.ComboBox();
            this.lblPName = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.txtMrp = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtSgst = new System.Windows.Forms.TextBox();
            this.lblMRP = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblSgst = new System.Windows.Forms.Label();
            this.lblCgst = new System.Windows.Forms.Label();
            this.txtCgst = new System.Windows.Forms.TextBox();
            this.IblIgst = new System.Windows.Forms.Label();
            this.txtIgst = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbxProductName
            // 
            this.cmbxProductName.FormattingEnabled = true;
            this.cmbxProductName.IntegralHeight = false;
            this.cmbxProductName.Location = new System.Drawing.Point(136, 25);
            this.cmbxProductName.Name = "cmbxProductName";
            this.cmbxProductName.Size = new System.Drawing.Size(185, 21);
            this.cmbxProductName.TabIndex = 0;
            // 
            // lblPName
            // 
            this.lblPName.AutoSize = true;
            this.lblPName.Location = new System.Drawing.Point(46, 28);
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(75, 13);
            this.lblPName.TabIndex = 1;
            this.lblPName.Text = "Product Name";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(46, 64);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(51, 13);
            this.lblCompany.TabIndex = 3;
            this.lblCompany.Text = "Company";
            // 
            // cmbCompany
            // 
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.IntegralHeight = false;
            this.cmbCompany.Location = new System.Drawing.Point(136, 61);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(185, 21);
            this.cmbCompany.TabIndex = 1;
            // 
            // txtMrp
            // 
            this.txtMrp.Location = new System.Drawing.Point(136, 99);
            this.txtMrp.Name = "txtMrp";
            this.txtMrp.Size = new System.Drawing.Size(185, 20);
            this.txtMrp.TabIndex = 2;
            this.txtMrp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSgst_KeyPress);
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(136, 175);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(185, 20);
            this.txtRate.TabIndex = 4;
            this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSgst_KeyPress);
            // 
            // txtSgst
            // 
            this.txtSgst.Location = new System.Drawing.Point(129, 21);
            this.txtSgst.Name = "txtSgst";
            this.txtSgst.Size = new System.Drawing.Size(74, 20);
            this.txtSgst.TabIndex = 0;
            this.txtSgst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSgst_KeyPress);
            // 
            // lblMRP
            // 
            this.lblMRP.AutoSize = true;
            this.lblMRP.Location = new System.Drawing.Point(46, 102);
            this.lblMRP.Name = "lblMRP";
            this.lblMRP.Size = new System.Drawing.Size(31, 13);
            this.lblMRP.TabIndex = 9;
            this.lblMRP.Text = "MRP";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(46, 178);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(30, 13);
            this.lblRate.TabIndex = 10;
            this.lblRate.Text = "Rate";
            // 
            // lblSgst
            // 
            this.lblSgst.AutoSize = true;
            this.lblSgst.Location = new System.Drawing.Point(63, 24);
            this.lblSgst.Name = "lblSgst";
            this.lblSgst.Size = new System.Drawing.Size(56, 13);
            this.lblSgst.TabIndex = 11;
            this.lblSgst.Text = "SGST  (%)";
            // 
            // lblCgst
            // 
            this.lblCgst.AutoSize = true;
            this.lblCgst.Location = new System.Drawing.Point(63, 56);
            this.lblCgst.Name = "lblCgst";
            this.lblCgst.Size = new System.Drawing.Size(56, 13);
            this.lblCgst.TabIndex = 13;
            this.lblCgst.Text = "CGST  (%)";
            // 
            // txtCgst
            // 
            this.txtCgst.Location = new System.Drawing.Point(129, 53);
            this.txtCgst.Name = "txtCgst";
            this.txtCgst.Size = new System.Drawing.Size(74, 20);
            this.txtCgst.TabIndex = 1;
            this.txtCgst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSgst_KeyPress);
            // 
            // IblIgst
            // 
            this.IblIgst.AutoSize = true;
            this.IblIgst.Location = new System.Drawing.Point(63, 90);
            this.IblIgst.Name = "IblIgst";
            this.IblIgst.Size = new System.Drawing.Size(52, 13);
            this.IblIgst.TabIndex = 15;
            this.IblIgst.Text = "IGST  (%)";
            // 
            // txtIgst
            // 
            this.txtIgst.Location = new System.Drawing.Point(129, 87);
            this.txtIgst.Name = "txtIgst";
            this.txtIgst.Size = new System.Drawing.Size(74, 20);
            this.txtIgst.TabIndex = 2;
            this.txtIgst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSgst_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Moccasin;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(226, 452);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 27);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSgst);
            this.groupBox1.Controls.Add(this.txtSgst);
            this.groupBox1.Controls.Add(this.IblIgst);
            this.groupBox1.Controls.Add(this.txtCgst);
            this.groupBox1.Controls.Add(this.txtIgst);
            this.groupBox1.Controls.Add(this.lblCgst);
            this.groupBox1.Location = new System.Drawing.Point(49, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 124);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TAX";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(46, 141);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(35, 13);
            this.lblStock.TabIndex = 19;
            this.lblStock.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(136, 138);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(185, 20);
            this.txtStock.TabIndex = 3;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // cmbUnit
            // 
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.IntegralHeight = false;
            this.cmbUnit.Items.AddRange(new object[] {
            "lt",
            "ml",
            "kg",
            "gm"});
            this.cmbUnit.Location = new System.Drawing.Point(257, 214);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(64, 21);
            this.cmbUnit.TabIndex = 28;
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(136, 252);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(185, 59);
            this.txtDetails.TabIndex = 26;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(46, 255);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(39, 13);
            this.lblDetails.TabIndex = 27;
            this.lblDetails.Text = "Details";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(136, 215);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(108, 20);
            this.txtWeight.TabIndex = 24;
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSgst_KeyPress);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(46, 217);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 13);
            this.lblWeight.TabIndex = 25;
            this.lblWeight.Text = "Weight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(33, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(33, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(33, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(33, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "*";
            // 
            // AddStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(374, 489);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblMRP);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtMrp);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.cmbCompany);
            this.Controls.Add(this.lblPName);
            this.Controls.Add(this.cmbxProductName);
            this.MaximizeBox = false;
            this.Name = "AddStockForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Stock";
            this.Load += new System.EventHandler(this.AddStockForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxProductName;
        private System.Windows.Forms.Label lblPName;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.TextBox txtMrp;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtSgst;
        private System.Windows.Forms.Label lblMRP;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblSgst;
        private System.Windows.Forms.Label lblCgst;
        private System.Windows.Forms.TextBox txtCgst;
        private System.Windows.Forms.Label IblIgst;
        private System.Windows.Forms.TextBox txtIgst;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}