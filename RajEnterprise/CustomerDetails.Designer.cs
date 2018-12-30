using RajEnterpriseBusinessLogic;

namespace RajEnterprise
{
    partial class CustomerDetails
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCustName = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtGst = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.gridCust = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gstNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diactivateDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.customerModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnOk = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.radioName = new System.Windows.Forms.RadioButton();
            this.radioMobile = new System.Windows.Forms.RadioButton();
            this.lblGst = new System.Windows.Forms.Label();
            this.btnNewCust = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSearchActiveUser = new System.Windows.Forms.CheckBox();
            this.grpBoxCust = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.checkNewCustomer = new System.Windows.Forms.CheckBox();
            this.lblCustId = new System.Windows.Forms.Label();
            this.lblCustIdInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerModelBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpBoxCust.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 39);
            this.panel1.TabIndex = 0;
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(26, 18);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(88, 13);
            this.lblCustName.TabIndex = 1;
            this.lblCustName.Text = "Customer Name :";
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(29, 34);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(198, 20);
            this.txtCustName.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(29, 81);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(198, 78);
            this.txtAddress.TabIndex = 4;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(26, 65);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 13);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address :";
            // 
            // txtGst
            // 
            this.txtGst.Location = new System.Drawing.Point(29, 184);
            this.txtGst.Name = "txtGst";
            this.txtGst.Size = new System.Drawing.Size(198, 20);
            this.txtGst.TabIndex = 6;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(29, 230);
            this.txtMobile.MaxLength = 10;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(198, 20);
            this.txtMobile.TabIndex = 8;
            this.txtMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobile_KeyPress);
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(26, 214);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(61, 13);
            this.lblMobile.TabIndex = 7;
            this.lblMobile.Text = "Mobile No :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(29, 275);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(198, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(26, 259);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 13);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email ID :";
            // 
            // gridCust
            // 
            this.gridCust.AllowUserToAddRows = false;
            this.gridCust.AllowUserToDeleteRows = false;
            this.gridCust.AllowUserToResizeColumns = false;
            this.gridCust.AllowUserToResizeRows = false;
            this.gridCust.AutoGenerateColumns = false;
            this.gridCust.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridCust.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.gstNoDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.emailIdDataGridViewTextBoxColumn,
            this.diactivateDataGridViewCheckBoxColumn});
            this.gridCust.DataSource = this.customerModelBindingSource;
            this.gridCust.Location = new System.Drawing.Point(20, 93);
            this.gridCust.MultiSelect = false;
            this.gridCust.Name = "gridCust";
            this.gridCust.ReadOnly = true;
            this.gridCust.RowHeadersVisible = false;
            this.gridCust.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridCust.Size = new System.Drawing.Size(468, 217);
            this.gridCust.TabIndex = 11;
            this.gridCust.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCust_CellDoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Visible = false;
            // 
            // gstNoDataGridViewTextBoxColumn
            // 
            this.gstNoDataGridViewTextBoxColumn.DataPropertyName = "GstNo";
            this.gstNoDataGridViewTextBoxColumn.HeaderText = "PAN/GST";
            this.gstNoDataGridViewTextBoxColumn.Name = "gstNoDataGridViewTextBoxColumn";
            this.gstNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "MobileNo";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "MobileNo";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailIdDataGridViewTextBoxColumn
            // 
            this.emailIdDataGridViewTextBoxColumn.DataPropertyName = "EmailId";
            this.emailIdDataGridViewTextBoxColumn.HeaderText = "EmailId";
            this.emailIdDataGridViewTextBoxColumn.Name = "emailIdDataGridViewTextBoxColumn";
            this.emailIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // diactivateDataGridViewCheckBoxColumn
            // 
            this.diactivateDataGridViewCheckBoxColumn.DataPropertyName = "Diactivate";
            this.diactivateDataGridViewCheckBoxColumn.HeaderText = "Diactivate";
            this.diactivateDataGridViewCheckBoxColumn.Name = "diactivateDataGridViewCheckBoxColumn";
            this.diactivateDataGridViewCheckBoxColumn.ReadOnly = true;
            this.diactivateDataGridViewCheckBoxColumn.Visible = false;
            // 
            // customerModelBindingSource
            // 
            this.customerModelBindingSource.DataSource = typeof(RajEnterpriseBusinessLogic.CustomerModel);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Moccasin;
            this.btnOk.Enabled = false;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(710, 412);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(95, 27);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(20, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(198, 20);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Moccasin;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(392, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 27);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // radioName
            // 
            this.radioName.AutoSize = true;
            this.radioName.Location = new System.Drawing.Point(20, 22);
            this.radioName.Name = "radioName";
            this.radioName.Size = new System.Drawing.Size(53, 17);
            this.radioName.TabIndex = 16;
            this.radioName.TabStop = true;
            this.radioName.Text = "Name";
            this.radioName.UseVisualStyleBackColor = true;
            this.radioName.CheckedChanged += new System.EventHandler(this.radioName_CheckedChanged);
            // 
            // radioMobile
            // 
            this.radioMobile.AutoSize = true;
            this.radioMobile.Location = new System.Drawing.Point(111, 22);
            this.radioMobile.Name = "radioMobile";
            this.radioMobile.Size = new System.Drawing.Size(73, 17);
            this.radioMobile.TabIndex = 17;
            this.radioMobile.TabStop = true;
            this.radioMobile.Text = "Mobile No";
            this.radioMobile.UseVisualStyleBackColor = true;
            this.radioMobile.CheckedChanged += new System.EventHandler(this.radioMobile_CheckedChanged);
            // 
            // lblGst
            // 
            this.lblGst.AutoSize = true;
            this.lblGst.Location = new System.Drawing.Point(26, 168);
            this.lblGst.Name = "lblGst";
            this.lblGst.Size = new System.Drawing.Size(68, 13);
            this.lblGst.TabIndex = 5;
            this.lblGst.Text = "PAN / GST :";
            // 
            // btnNewCust
            // 
            this.btnNewCust.BackColor = System.Drawing.Color.Moccasin;
            this.btnNewCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCust.Location = new System.Drawing.Point(142, 346);
            this.btnNewCust.Name = "btnNewCust";
            this.btnNewCust.Size = new System.Drawing.Size(95, 27);
            this.btnNewCust.TabIndex = 18;
            this.btnNewCust.Text = "New / Update";
            this.btnNewCust.UseVisualStyleBackColor = false;
            this.btnNewCust.Click += new System.EventHandler(this.btnNewCust_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSearchActiveUser);
            this.groupBox1.Controls.Add(this.radioName);
            this.groupBox1.Controls.Add(this.gridCust);
            this.groupBox1.Controls.Add(this.radioMobile);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(296, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 341);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Customer";
            // 
            // chkSearchActiveUser
            // 
            this.chkSearchActiveUser.AutoSize = true;
            this.chkSearchActiveUser.Checked = true;
            this.chkSearchActiveUser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSearchActiveUser.Enabled = false;
            this.chkSearchActiveUser.Location = new System.Drawing.Point(20, 65);
            this.chkSearchActiveUser.Name = "chkSearchActiveUser";
            this.chkSearchActiveUser.Size = new System.Drawing.Size(92, 17);
            this.chkSearchActiveUser.TabIndex = 18;
            this.chkSearchActiveUser.Text = "Active User(s)";
            this.chkSearchActiveUser.UseVisualStyleBackColor = true;
            // 
            // grpBoxCust
            // 
            this.grpBoxCust.Controls.Add(this.label2);
            this.grpBoxCust.Controls.Add(this.label1);
            this.grpBoxCust.Controls.Add(this.btnClear);
            this.grpBoxCust.Controls.Add(this.chkIsActive);
            this.grpBoxCust.Controls.Add(this.lblCustName);
            this.grpBoxCust.Controls.Add(this.btnNewCust);
            this.grpBoxCust.Controls.Add(this.txtCustName);
            this.grpBoxCust.Controls.Add(this.lblAddress);
            this.grpBoxCust.Controls.Add(this.txtAddress);
            this.grpBoxCust.Controls.Add(this.txtEmail);
            this.grpBoxCust.Controls.Add(this.lblGst);
            this.grpBoxCust.Controls.Add(this.lblEmail);
            this.grpBoxCust.Controls.Add(this.txtGst);
            this.grpBoxCust.Controls.Add(this.txtMobile);
            this.grpBoxCust.Controls.Add(this.lblMobile);
            this.grpBoxCust.Enabled = false;
            this.grpBoxCust.Location = new System.Drawing.Point(21, 60);
            this.grpBoxCust.Name = "grpBoxCust";
            this.grpBoxCust.Size = new System.Drawing.Size(252, 382);
            this.grpBoxCust.TabIndex = 20;
            this.grpBoxCust.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(15, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "*";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Moccasin;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(43, 346);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 27);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Location = new System.Drawing.Point(29, 308);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(67, 17);
            this.chkIsActive.TabIndex = 11;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // checkNewCustomer
            // 
            this.checkNewCustomer.AutoSize = true;
            this.checkNewCustomer.Location = new System.Drawing.Point(24, 44);
            this.checkNewCustomer.Name = "checkNewCustomer";
            this.checkNewCustomer.Size = new System.Drawing.Size(189, 17);
            this.checkNewCustomer.TabIndex = 21;
            this.checkNewCustomer.Text = "Do you want to add new Customer";
            this.checkNewCustomer.UseVisualStyleBackColor = true;
            this.checkNewCustomer.CheckedChanged += new System.EventHandler(this.checkNewCustomer_CheckedChanged);
            // 
            // lblCustId
            // 
            this.lblCustId.AutoSize = true;
            this.lblCustId.Location = new System.Drawing.Point(741, 42);
            this.lblCustId.Name = "lblCustId";
            this.lblCustId.Size = new System.Drawing.Size(24, 13);
            this.lblCustId.TabIndex = 22;
            this.lblCustId.Text = "ID :";
            // 
            // lblCustIdInfo
            // 
            this.lblCustIdInfo.AutoSize = true;
            this.lblCustIdInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustIdInfo.Location = new System.Drawing.Point(771, 42);
            this.lblCustIdInfo.Name = "lblCustIdInfo";
            this.lblCustIdInfo.Size = new System.Drawing.Size(14, 13);
            this.lblCustIdInfo.TabIndex = 23;
            this.lblCustIdInfo.Text = "0";
            // 
            // CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(825, 454);
            this.Controls.Add(this.lblCustIdInfo);
            this.Controls.Add(this.lblCustId);
            this.Controls.Add(this.checkNewCustomer);
            this.Controls.Add(this.grpBoxCust);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "CustomerDetails";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Details";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerDetails_FormClosed);
            this.Load += new System.EventHandler(this.CustomerDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerModelBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBoxCust.ResumeLayout(false);
            this.grpBoxCust.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtGst;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DataGridView gridCust;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton radioName;
        private System.Windows.Forms.RadioButton radioMobile;
        private System.Windows.Forms.Label lblGst;
        private System.Windows.Forms.Button btnNewCust;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpBoxCust;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.BindingSource customerModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gstNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn diactivateDataGridViewCheckBoxColumn;
        private System.Windows.Forms.CheckBox checkNewCustomer;
        private System.Windows.Forms.Label lblCustId;
        private System.Windows.Forms.Label lblCustIdInfo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkSearchActiveUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}