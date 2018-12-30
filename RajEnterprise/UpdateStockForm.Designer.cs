namespace RajEnterprise
{
    partial class UpdateStockForm
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
            this.lblRate = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtMrp = new System.Windows.Forms.TextBox();
            this.lblMrp = new System.Windows.Forms.Label();
            this.txtSgst = new System.Windows.Forms.TextBox();
            this.lblSGST = new System.Windows.Forms.Label();
            this.txtCgst = new System.Windows.Forms.TextBox();
            this.lblCgst = new System.Windows.Forms.Label();
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.txtIgst = new System.Windows.Forms.TextBox();
            this.lblIgst = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(42, 142);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(30, 13);
            this.lblRate.TabIndex = 0;
            this.lblRate.Text = "Rate";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(136, 139);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(185, 20);
            this.txtRate.TabIndex = 3;
            this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSgst_KeyPress);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(42, 36);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Product Name";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(42, 71);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(51, 13);
            this.lblCompany.TabIndex = 4;
            this.lblCompany.Text = "Company";
            // 
            // txtMrp
            // 
            this.txtMrp.Location = new System.Drawing.Point(136, 104);
            this.txtMrp.Name = "txtMrp";
            this.txtMrp.Size = new System.Drawing.Size(185, 20);
            this.txtMrp.TabIndex = 2;
            this.txtMrp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSgst_KeyPress);
            // 
            // lblMrp
            // 
            this.lblMrp.AutoSize = true;
            this.lblMrp.Location = new System.Drawing.Point(41, 107);
            this.lblMrp.Name = "lblMrp";
            this.lblMrp.Size = new System.Drawing.Size(31, 13);
            this.lblMrp.TabIndex = 6;
            this.lblMrp.Text = "MRP";
            // 
            // txtSgst
            // 
            this.txtSgst.Location = new System.Drawing.Point(133, 22);
            this.txtSgst.Name = "txtSgst";
            this.txtSgst.Size = new System.Drawing.Size(74, 20);
            this.txtSgst.TabIndex = 0;
            this.txtSgst.TextChanged += new System.EventHandler(this.txtSgst_TextChanged);
            this.txtSgst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSgst_KeyPress);
            // 
            // lblSGST
            // 
            this.lblSGST.AutoSize = true;
            this.lblSGST.Location = new System.Drawing.Point(71, 25);
            this.lblSGST.Name = "lblSGST";
            this.lblSGST.Size = new System.Drawing.Size(56, 13);
            this.lblSGST.TabIndex = 8;
            this.lblSGST.Text = "SGST  (%)";
            // 
            // txtCgst
            // 
            this.txtCgst.Location = new System.Drawing.Point(133, 53);
            this.txtCgst.Name = "txtCgst";
            this.txtCgst.Size = new System.Drawing.Size(74, 20);
            this.txtCgst.TabIndex = 1;
            this.txtCgst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSgst_KeyPress);
            // 
            // lblCgst
            // 
            this.lblCgst.AutoSize = true;
            this.lblCgst.Location = new System.Drawing.Point(71, 56);
            this.lblCgst.Name = "lblCgst";
            this.lblCgst.Size = new System.Drawing.Size(56, 13);
            this.lblCgst.TabIndex = 10;
            this.lblCgst.Text = "CGST  (%)";
            // 
            // cmbProductName
            // 
            this.cmbProductName.Enabled = false;
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.IntegralHeight = false;
            this.cmbProductName.Location = new System.Drawing.Point(136, 33);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(185, 21);
            this.cmbProductName.TabIndex = 0;
            // 
            // cmbCompany
            // 
            this.cmbCompany.Enabled = false;
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.IntegralHeight = false;
            this.cmbCompany.Location = new System.Drawing.Point(136, 68);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(185, 21);
            this.cmbCompany.TabIndex = 1;
            // 
            // txtIgst
            // 
            this.txtIgst.Location = new System.Drawing.Point(133, 86);
            this.txtIgst.Name = "txtIgst";
            this.txtIgst.Size = new System.Drawing.Size(74, 20);
            this.txtIgst.TabIndex = 2;
            this.txtIgst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSgst_KeyPress);
            // 
            // lblIgst
            // 
            this.lblIgst.AutoSize = true;
            this.lblIgst.Location = new System.Drawing.Point(71, 89);
            this.lblIgst.Name = "lblIgst";
            this.lblIgst.Size = new System.Drawing.Size(52, 13);
            this.lblIgst.TabIndex = 14;
            this.lblIgst.Text = "IGST  (%)";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(136, 175);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(185, 20);
            this.txtStock.TabIndex = 4;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(42, 178);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(35, 13);
            this.lblStock.TabIndex = 18;
            this.lblStock.Text = "Stock";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSGST);
            this.groupBox1.Controls.Add(this.txtSgst);
            this.groupBox1.Controls.Add(this.lblCgst);
            this.groupBox1.Controls.Add(this.txtIgst);
            this.groupBox1.Controls.Add(this.txtCgst);
            this.groupBox1.Controls.Add(this.lblIgst);
            this.groupBox1.Location = new System.Drawing.Point(45, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 118);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tax";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Moccasin;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(258, 450);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(63, 25);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Moccasin;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(177, 450);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(63, 25);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.Enabled = false;
            this.txtWeight.Location = new System.Drawing.Point(136, 210);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(108, 20);
            this.txtWeight.TabIndex = 19;
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSgst_KeyPress);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(42, 212);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 13);
            this.lblWeight.TabIndex = 20;
            this.lblWeight.Text = "Weight";
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(136, 247);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(185, 59);
            this.txtDetails.TabIndex = 21;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(42, 250);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(39, 13);
            this.lblDetails.TabIndex = 22;
            this.lblDetails.Text = "Details";
            // 
            // cmbUnit
            // 
            this.cmbUnit.Enabled = false;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.IntegralHeight = false;
            this.cmbUnit.Items.AddRange(new object[] {
            "lt",
            "ml",
            "kg",
            "gm"});
            this.cmbUnit.Location = new System.Drawing.Point(257, 209);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(64, 21);
            this.cmbUnit.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(29, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(29, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(29, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "*";
            // 
            // UpdateStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(374, 489);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.cmbCompany);
            this.Controls.Add(this.cmbProductName);
            this.Controls.Add(this.txtMrp);
            this.Controls.Add(this.lblMrp);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.lblRate);
            this.MaximizeBox = false;
            this.Name = "UpdateStockForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Stock";
            this.Load += new System.EventHandler(this.UpdateStockForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox txtMrp;
        private System.Windows.Forms.Label lblMrp;
        private System.Windows.Forms.TextBox txtSgst;
        private System.Windows.Forms.Label lblSGST;
        private System.Windows.Forms.TextBox txtCgst;
        private System.Windows.Forms.Label lblCgst;
        private System.Windows.Forms.ComboBox cmbProductName;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.TextBox txtIgst;
        private System.Windows.Forms.Label lblIgst;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}