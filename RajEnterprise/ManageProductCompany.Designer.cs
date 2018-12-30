namespace RajEnterprise
{
    partial class ManageProductCompany
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
            this.grpBoxCompany = new System.Windows.Forms.GroupBox();
            this.lblCmpInfo = new System.Windows.Forms.Label();
            this.lblCmp = new System.Windows.Forms.Label();
            this.btnDeleteComp = new System.Windows.Forms.Button();
            this.gridComp = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblComp = new System.Windows.Forms.Label();
            this.txtComp = new System.Windows.Forms.TextBox();
            this.grpBoxProduct = new System.Windows.Forms.GroupBox();
            this.lblPidInfo = new System.Windows.Forms.Label();
            this.lblPid = new System.Windows.Forms.Label();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.gridProduct = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lblProduct = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.grpBoxCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.grpBoxProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxCompany
            // 
            this.grpBoxCompany.Controls.Add(this.lblCmpInfo);
            this.grpBoxCompany.Controls.Add(this.lblCmp);
            this.grpBoxCompany.Controls.Add(this.btnDeleteComp);
            this.grpBoxCompany.Controls.Add(this.gridComp);
            this.grpBoxCompany.Controls.Add(this.btnAdd);
            this.grpBoxCompany.Controls.Add(this.lblComp);
            this.grpBoxCompany.Controls.Add(this.txtComp);
            this.grpBoxCompany.Location = new System.Drawing.Point(22, 47);
            this.grpBoxCompany.Name = "grpBoxCompany";
            this.grpBoxCompany.Size = new System.Drawing.Size(413, 329);
            this.grpBoxCompany.TabIndex = 0;
            this.grpBoxCompany.TabStop = false;
            this.grpBoxCompany.Text = "Company";
            // 
            // lblCmpInfo
            // 
            this.lblCmpInfo.AutoSize = true;
            this.lblCmpInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmpInfo.Location = new System.Drawing.Point(375, 11);
            this.lblCmpInfo.Name = "lblCmpInfo";
            this.lblCmpInfo.Size = new System.Drawing.Size(26, 13);
            this.lblCmpInfo.TabIndex = 9;
            this.lblCmpInfo.Text = "CId";
            this.lblCmpInfo.Visible = false;
            // 
            // lblCmp
            // 
            this.lblCmp.AutoSize = true;
            this.lblCmp.Location = new System.Drawing.Point(351, 11);
            this.lblCmp.Name = "lblCmp";
            this.lblCmp.Size = new System.Drawing.Size(24, 13);
            this.lblCmp.TabIndex = 8;
            this.lblCmp.Text = "ID :";
            this.lblCmp.Visible = false;
            // 
            // btnDeleteComp
            // 
            this.btnDeleteComp.Location = new System.Drawing.Point(303, 294);
            this.btnDeleteComp.Name = "btnDeleteComp";
            this.btnDeleteComp.Size = new System.Drawing.Size(80, 23);
            this.btnDeleteComp.TabIndex = 4;
            this.btnDeleteComp.Text = "Delete";
            this.btnDeleteComp.UseVisualStyleBackColor = true;
            this.btnDeleteComp.Click += new System.EventHandler(this.btnDeleteComp_Click);
            // 
            // gridComp
            // 
            this.gridComp.AllowUserToAddRows = false;
            this.gridComp.AllowUserToDeleteRows = false;
            this.gridComp.AllowUserToResizeColumns = false;
            this.gridComp.AllowUserToResizeRows = false;
            this.gridComp.AutoGenerateColumns = false;
            this.gridComp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridComp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.companyNameDataGridViewTextBoxColumn});
            this.gridComp.DataSource = this.companyBindingSource;
            this.gridComp.Location = new System.Drawing.Point(28, 92);
            this.gridComp.MultiSelect = false;
            this.gridComp.Name = "gridComp";
            this.gridComp.ReadOnly = true;
            this.gridComp.RowHeadersVisible = false;
            this.gridComp.Size = new System.Drawing.Size(355, 189);
            this.gridComp.TabIndex = 3;
            this.gridComp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridComp_CellClick);
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.FillWeight = 50.76142F;
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.FillWeight = 149.2386F;
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "Company Name";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(RajEnterpriseBusinessLogic.Company);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(303, 56);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add/Update";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.Location = new System.Drawing.Point(29, 41);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(82, 13);
            this.lblComp.TabIndex = 1;
            this.lblComp.Text = "Company Name";
            // 
            // txtComp
            // 
            this.txtComp.Location = new System.Drawing.Point(32, 57);
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(191, 20);
            this.txtComp.TabIndex = 0;
            this.txtComp.TextChanged += new System.EventHandler(this.txtComp_TextChanged);
            // 
            // grpBoxProduct
            // 
            this.grpBoxProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxProduct.Controls.Add(this.lblPidInfo);
            this.grpBoxProduct.Controls.Add(this.lblPid);
            this.grpBoxProduct.Controls.Add(this.btnDeleteProduct);
            this.grpBoxProduct.Controls.Add(this.gridProduct);
            this.grpBoxProduct.Controls.Add(this.btnAddProduct);
            this.grpBoxProduct.Controls.Add(this.lblProduct);
            this.grpBoxProduct.Controls.Add(this.txtProduct);
            this.grpBoxProduct.Location = new System.Drawing.Point(464, 47);
            this.grpBoxProduct.Name = "grpBoxProduct";
            this.grpBoxProduct.Size = new System.Drawing.Size(413, 329);
            this.grpBoxProduct.TabIndex = 4;
            this.grpBoxProduct.TabStop = false;
            this.grpBoxProduct.Text = "Product";
            // 
            // lblPidInfo
            // 
            this.lblPidInfo.AutoSize = true;
            this.lblPidInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPidInfo.Location = new System.Drawing.Point(369, 11);
            this.lblPidInfo.Name = "lblPidInfo";
            this.lblPidInfo.Size = new System.Drawing.Size(26, 13);
            this.lblPidInfo.TabIndex = 7;
            this.lblPidInfo.Text = "PId";
            this.lblPidInfo.Visible = false;
            // 
            // lblPid
            // 
            this.lblPid.AutoSize = true;
            this.lblPid.Location = new System.Drawing.Point(345, 11);
            this.lblPid.Name = "lblPid";
            this.lblPid.Size = new System.Drawing.Size(24, 13);
            this.lblPid.TabIndex = 6;
            this.lblPid.Text = "ID :";
            this.lblPid.Visible = false;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(304, 294);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(80, 23);
            this.btnDeleteProduct.TabIndex = 5;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // gridProduct
            // 
            this.gridProduct.AllowUserToAddRows = false;
            this.gridProduct.AllowUserToDeleteRows = false;
            this.gridProduct.AllowUserToResizeColumns = false;
            this.gridProduct.AllowUserToResizeRows = false;
            this.gridProduct.AutoGenerateColumns = false;
            this.gridProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn});
            this.gridProduct.DataSource = this.productBindingSource;
            this.gridProduct.Location = new System.Drawing.Point(29, 93);
            this.gridProduct.MultiSelect = false;
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.ReadOnly = true;
            this.gridProduct.RowHeadersVisible = false;
            this.gridProduct.Size = new System.Drawing.Size(355, 189);
            this.gridProduct.TabIndex = 3;
            this.gridProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProduct_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 50.76142F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.FillWeight = 149.2386F;
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(RajEnterpriseBusinessLogic.Product);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(304, 55);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(80, 23);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Text = "Add/Update";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(32, 44);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(75, 13);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Product Name";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(35, 59);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(191, 20);
            this.txtProduct.TabIndex = 0;
            this.txtProduct.TextChanged += new System.EventHandler(this.txtProduct_TextChanged);
            // 
            // ManageProductCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(902, 403);
            this.Controls.Add(this.grpBoxProduct);
            this.Controls.Add(this.grpBoxCompany);
            this.MaximizeBox = false;
            this.Name = "ManageProductCompany";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Product Company";
            this.Load += new System.EventHandler(this.ManageProductCompany_Load);
            this.grpBoxCompany.ResumeLayout(false);
            this.grpBoxCompany.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.grpBoxProduct.ResumeLayout(false);
            this.grpBoxProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxCompany;
        private System.Windows.Forms.DataGridView gridComp;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblComp;
        private System.Windows.Forms.TextBox txtComp;
        private System.Windows.Forms.GroupBox grpBoxProduct;
        private System.Windows.Forms.DataGridView gridProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Button btnDeleteComp;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Label lblPidInfo;
        private System.Windows.Forms.Label lblPid;
        private System.Windows.Forms.Label lblCmpInfo;
        private System.Windows.Forms.Label lblCmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
    }
}