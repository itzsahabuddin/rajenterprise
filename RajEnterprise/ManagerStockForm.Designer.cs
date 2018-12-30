using RajEnterpriseBusinessLogic;

namespace RajEnterprise
{
    partial class ManagerStockForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelNav = new System.Windows.Forms.Panel();
            this.lblMngProduct = new System.Windows.Forms.Label();
            this.lblAddProduct = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlStock = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gridStock = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mRPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpBoxFilter = new System.Windows.Forms.GroupBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.panelHeader.SuspendLayout();
            this.panelNav.SuspendLayout();
            this.pnlStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockModelsBindingSource)).BeginInit();
            this.grpBoxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1205, 21);
            this.panelHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(566, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Stock";
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelNav.Controls.Add(this.lblMngProduct);
            this.panelNav.Controls.Add(this.lblAddProduct);
            this.panelNav.Controls.Add(this.lblHome);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.Location = new System.Drawing.Point(0, 21);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(194, 527);
            this.panelNav.TabIndex = 1;
            // 
            // lblMngProduct
            // 
            this.lblMngProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMngProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMngProduct.Location = new System.Drawing.Point(5, 82);
            this.lblMngProduct.Name = "lblMngProduct";
            this.lblMngProduct.Size = new System.Drawing.Size(164, 28);
            this.lblMngProduct.TabIndex = 3;
            this.lblMngProduct.Text = "        Manage Product";
            this.lblMngProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMngProduct.Click += new System.EventHandler(this.lblMngProduct_Click);
            // 
            // lblAddProduct
            // 
            this.lblAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAddProduct.Location = new System.Drawing.Point(3, 51);
            this.lblAddProduct.Name = "lblAddProduct";
            this.lblAddProduct.Size = new System.Drawing.Size(164, 28);
            this.lblAddProduct.TabIndex = 2;
            this.lblAddProduct.Text = "        Add Product";
            this.lblAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAddProduct.Click += new System.EventHandler(this.lblAddProduct_Click);
            // 
            // lblHome
            // 
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHome.Location = new System.Drawing.Point(3, 20);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(164, 28);
            this.lblHome.TabIndex = 1;
            this.lblHome.Text = "        Home";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(194, 520);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1011, 28);
            this.pnlFooter.TabIndex = 2;
            // 
            // pnlStock
            // 
            this.pnlStock.Controls.Add(this.btnSearch);
            this.pnlStock.Controls.Add(this.gridStock);
            this.pnlStock.Controls.Add(this.grpBoxFilter);
            this.pnlStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStock.Location = new System.Drawing.Point(194, 21);
            this.pnlStock.Name = "pnlStock";
            this.pnlStock.Size = new System.Drawing.Size(1011, 499);
            this.pnlStock.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Moccasin;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(695, 104);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gridStock
            // 
            this.gridStock.AllowUserToAddRows = false;
            this.gridStock.AllowUserToDeleteRows = false;
            this.gridStock.AllowUserToResizeColumns = false;
            this.gridStock.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PeachPuff;
            this.gridStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridStock.AutoGenerateColumns = false;
            this.gridStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.mRPDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn,
            this.sGSTDataGridViewTextBoxColumn,
            this.cGSTDataGridViewTextBoxColumn,
            this.iGSTDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn});
            this.gridStock.DataSource = this.stockModelsBindingSource;
            this.gridStock.Location = new System.Drawing.Point(23, 142);
            this.gridStock.MultiSelect = false;
            this.gridStock.Name = "gridStock";
            this.gridStock.ReadOnly = true;
            this.gridStock.RowHeadersVisible = false;
            this.gridStock.Size = new System.Drawing.Size(965, 339);
            this.gridStock.TabIndex = 1;
            this.gridStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridStock_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            this.companyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mRPDataGridViewTextBoxColumn
            // 
            this.mRPDataGridViewTextBoxColumn.DataPropertyName = "MRP";
            this.mRPDataGridViewTextBoxColumn.HeaderText = "MRP";
            this.mRPDataGridViewTextBoxColumn.Name = "mRPDataGridViewTextBoxColumn";
            this.mRPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "Rate";
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            this.rateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sGSTDataGridViewTextBoxColumn
            // 
            this.sGSTDataGridViewTextBoxColumn.DataPropertyName = "SGST";
            this.sGSTDataGridViewTextBoxColumn.HeaderText = "SGST";
            this.sGSTDataGridViewTextBoxColumn.Name = "sGSTDataGridViewTextBoxColumn";
            this.sGSTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cGSTDataGridViewTextBoxColumn
            // 
            this.cGSTDataGridViewTextBoxColumn.DataPropertyName = "CGST";
            this.cGSTDataGridViewTextBoxColumn.HeaderText = "CGST";
            this.cGSTDataGridViewTextBoxColumn.Name = "cGSTDataGridViewTextBoxColumn";
            this.cGSTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iGSTDataGridViewTextBoxColumn
            // 
            this.iGSTDataGridViewTextBoxColumn.DataPropertyName = "IGST";
            this.iGSTDataGridViewTextBoxColumn.HeaderText = "IGST";
            this.iGSTDataGridViewTextBoxColumn.Name = "iGSTDataGridViewTextBoxColumn";
            this.iGSTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "Details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "Details";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            this.detailsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockModelsBindingSource
            // 
            this.stockModelsBindingSource.DataSource = typeof(RajEnterpriseBusinessLogic.StockModels);
            // 
            // grpBoxFilter
            // 
            this.grpBoxFilter.Controls.Add(this.lblCompany);
            this.grpBoxFilter.Controls.Add(this.cmbCompany);
            this.grpBoxFilter.Controls.Add(this.lblProduct);
            this.grpBoxFilter.Controls.Add(this.cmbProduct);
            this.grpBoxFilter.Location = new System.Drawing.Point(165, 20);
            this.grpBoxFilter.Name = "grpBoxFilter";
            this.grpBoxFilter.Size = new System.Drawing.Size(605, 78);
            this.grpBoxFilter.TabIndex = 0;
            this.grpBoxFilter.TabStop = false;
            this.grpBoxFilter.Text = "Filter By";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(374, 17);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(57, 13);
            this.lblCompany.TabIndex = 4;
            this.lblCompany.Text = "Company :";
            // 
            // cmbCompany
            // 
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.IntegralHeight = false;
            this.cmbCompany.Items.AddRange(new object[] {
            "Kolkata",
            "Bangalore",
            "Chennai"});
            this.cmbCompany.Location = new System.Drawing.Point(377, 33);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(209, 21);
            this.cmbCompany.TabIndex = 3;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(19, 20);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(50, 13);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = "Product :";
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.IntegralHeight = false;
            this.cmbProduct.Items.AddRange(new object[] {
            "Kolkata",
            "Bangalore",
            "Chennai"});
            this.cmbProduct.Location = new System.Drawing.Point(22, 36);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(209, 21);
            this.cmbProduct.TabIndex = 0;
            // 
            // ManagerStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 548);
            this.Controls.Add(this.pnlStock);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.panelNav);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ManagerStockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.lblHome_Click);
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelNav.ResumeLayout(false);
            this.pnlStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockModelsBindingSource)).EndInit();
            this.grpBoxFilter.ResumeLayout(false);
            this.grpBoxFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlStock;
        private System.Windows.Forms.GroupBox grpBoxFilter;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView gridStock;
        private System.Windows.Forms.Label lblAddProduct;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblMngProduct;
        private System.Windows.Forms.BindingSource stockModelsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mRPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
    }
}