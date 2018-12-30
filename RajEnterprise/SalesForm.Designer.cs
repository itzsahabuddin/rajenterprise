using RajEnterpriseBusinessLogic;

namespace RajEnterprise
{
    partial class SalesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblFormName = new System.Windows.Forms.Label();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.picInvoiceArrow = new System.Windows.Forms.PictureBox();
            this.picHomeArrow = new System.Windows.Forms.PictureBox();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.gridSale = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mRPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Del = new System.Windows.Forms.DataGridViewImageColumn();
            this.salesModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnGenerateBill = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.grbTax = new System.Windows.Forms.GroupBox();
            this.txtIgst = new System.Windows.Forms.TextBox();
            this.lblIgst = new System.Windows.Forms.Label();
            this.txtCgst = new System.Windows.Forms.TextBox();
            this.lblCgst = new System.Windows.Forms.Label();
            this.txtSgst = new System.Windows.Forms.TextBox();
            this.lblSgst = new System.Windows.Forms.Label();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInvoiceArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHomeArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesModelBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbTax.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblFormName);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1223, 28);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormName.Location = new System.Drawing.Point(610, 4);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(54, 20);
            this.lblFormName.TabIndex = 0;
            this.lblFormName.Text = "Sales";
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlNavigation.Controls.Add(this.picInvoiceArrow);
            this.pnlNavigation.Controls.Add(this.picHomeArrow);
            this.pnlNavigation.Controls.Add(this.lblInvoice);
            this.pnlNavigation.Controls.Add(this.lblHome);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 28);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(205, 553);
            this.pnlNavigation.TabIndex = 1;
            // 
            // picInvoiceArrow
            // 
            this.picInvoiceArrow.Image = global::RajEnterprise.Properties.Resources.Arrow;
            this.picInvoiceArrow.Location = new System.Drawing.Point(173, 59);
            this.picInvoiceArrow.Name = "picInvoiceArrow";
            this.picInvoiceArrow.Size = new System.Drawing.Size(29, 28);
            this.picInvoiceArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInvoiceArrow.TabIndex = 5;
            this.picInvoiceArrow.TabStop = false;
            this.picInvoiceArrow.Visible = false;
            // 
            // picHomeArrow
            // 
            this.picHomeArrow.Image = global::RajEnterprise.Properties.Resources.Arrow;
            this.picHomeArrow.Location = new System.Drawing.Point(174, 29);
            this.picHomeArrow.Name = "picHomeArrow";
            this.picHomeArrow.Size = new System.Drawing.Size(29, 28);
            this.picHomeArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHomeArrow.TabIndex = 4;
            this.picHomeArrow.TabStop = false;
            this.picHomeArrow.Visible = false;
            // 
            // lblInvoice
            // 
            this.lblInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInvoice.Location = new System.Drawing.Point(3, 60);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(188, 28);
            this.lblInvoice.TabIndex = 3;
            this.lblInvoice.Text = "        Invoice";
            this.lblInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInvoice.Click += new System.EventHandler(this.lblInvoice_Click);
            this.lblInvoice.MouseLeave += new System.EventHandler(this.lblInvoice_MouseLeave);
            this.lblInvoice.MouseHover += new System.EventHandler(this.lblInvoice_MouseHover);
            // 
            // lblHome
            // 
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHome.Location = new System.Drawing.Point(3, 29);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(188, 28);
            this.lblHome.TabIndex = 2;
            this.lblHome.Text = "        Home";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            this.lblHome.MouseLeave += new System.EventHandler(this.lblHome_MouseLeave);
            this.lblHome.MouseHover += new System.EventHandler(this.lblHome_MouseHover);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(205, 555);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1018, 26);
            this.pnlFooter.TabIndex = 2;
            // 
            // gridSale
            // 
            this.gridSale.AllowUserToAddRows = false;
            this.gridSale.AllowUserToResizeColumns = false;
            this.gridSale.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PeachPuff;
            this.gridSale.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridSale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSale.AutoGenerateColumns = false;
            this.gridSale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.mRPDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.sGSTDataGridViewTextBoxColumn,
            this.cGSTDataGridViewTextBoxColumn,
            this.iGSTDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.Del});
            this.gridSale.DataSource = this.salesModelBindingSource;
            this.gridSale.Location = new System.Drawing.Point(222, 181);
            this.gridSale.MultiSelect = false;
            this.gridSale.Name = "gridSale";
            this.gridSale.RowHeadersVisible = false;
            this.gridSale.Size = new System.Drawing.Size(976, 257);
            this.gridSale.TabIndex = 3;
            this.gridSale.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSale_CellClick);
            this.gridSale.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSale_CellEndEdit);
            this.gridSale.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.gridSale_CellValidating);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.FillWeight = 93.54061F;
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.FillWeight = 93.54061F;
            this.companyDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            this.companyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.FillWeight = 93.54061F;
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.FillWeight = 93.54061F;
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mRPDataGridViewTextBoxColumn
            // 
            this.mRPDataGridViewTextBoxColumn.DataPropertyName = "MRP";
            this.mRPDataGridViewTextBoxColumn.FillWeight = 93.54061F;
            this.mRPDataGridViewTextBoxColumn.HeaderText = "MRP";
            this.mRPDataGridViewTextBoxColumn.Name = "mRPDataGridViewTextBoxColumn";
            this.mRPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn.FillWeight = 75F;
            this.rateDataGridViewTextBoxColumn.HeaderText = "Rate (@)";
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            this.rateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.FillWeight = 70F;
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // sGSTDataGridViewTextBoxColumn
            // 
            this.sGSTDataGridViewTextBoxColumn.DataPropertyName = "SGST";
            this.sGSTDataGridViewTextBoxColumn.FillWeight = 70F;
            this.sGSTDataGridViewTextBoxColumn.HeaderText = "SGST (%)";
            this.sGSTDataGridViewTextBoxColumn.Name = "sGSTDataGridViewTextBoxColumn";
            // 
            // cGSTDataGridViewTextBoxColumn
            // 
            this.cGSTDataGridViewTextBoxColumn.DataPropertyName = "CGST";
            this.cGSTDataGridViewTextBoxColumn.FillWeight = 70F;
            this.cGSTDataGridViewTextBoxColumn.HeaderText = "CGST (%)";
            this.cGSTDataGridViewTextBoxColumn.Name = "cGSTDataGridViewTextBoxColumn";
            // 
            // iGSTDataGridViewTextBoxColumn
            // 
            this.iGSTDataGridViewTextBoxColumn.DataPropertyName = "IGST";
            this.iGSTDataGridViewTextBoxColumn.FillWeight = 70F;
            this.iGSTDataGridViewTextBoxColumn.HeaderText = "IGST (%)";
            this.iGSTDataGridViewTextBoxColumn.Name = "iGSTDataGridViewTextBoxColumn";
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "Details";
            this.detailsDataGridViewTextBoxColumn.FillWeight = 93.54061F;
            this.detailsDataGridViewTextBoxColumn.HeaderText = "Details";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            this.detailsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.FillWeight = 93.54061F;
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Del
            // 
            this.Del.FillWeight = 25F;
            this.Del.HeaderText = "";
            this.Del.Image = ((System.Drawing.Image)(resources.GetObject("Del.Image")));
            this.Del.Name = "Del";
            this.Del.ReadOnly = true;
            // 
            // salesModelBindingSource
            // 
            this.salesModelBindingSource.DataSource = typeof(RajEnterpriseBusinessLogic.SalesModel);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbUnit);
            this.groupBox1.Controls.Add(this.lblUnit);
            this.groupBox1.Controls.Add(this.txtUnit);
            this.groupBox1.Controls.Add(this.lblQty);
            this.groupBox1.Controls.Add(this.cmbCompany);
            this.groupBox1.Controls.Add(this.lblCompany);
            this.groupBox1.Controls.Add(this.cmbProduct);
            this.groupBox1.Controls.Add(this.lblProduct);
            this.groupBox1.Controls.Add(this.lblStock);
            this.groupBox1.Location = new System.Drawing.Point(266, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 92);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sales Details";
            // 
            // cmbUnit
            // 
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.Enabled = false;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.IntegralHeight = false;
            this.cmbUnit.Location = new System.Drawing.Point(511, 44);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(137, 21);
            this.cmbUnit.TabIndex = 9;
            this.cmbUnit.SelectedIndexChanged += new System.EventHandler(this.cmbUnit_SelectedIndexChanged);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(508, 27);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(26, 13);
            this.lblUnit.TabIndex = 8;
            this.lblUnit.Text = "Unit";
            // 
            // txtUnit
            // 
            this.txtUnit.Enabled = false;
            this.txtUnit.Location = new System.Drawing.Point(678, 45);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(89, 20);
            this.txtUnit.TabIndex = 7;
            this.txtUnit.TextChanged += new System.EventHandler(this.txtUnit_TextChanged);
            this.txtUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnit_KeyPress);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(679, 26);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(46, 13);
            this.lblQty.TabIndex = 6;
            this.lblQty.Text = "Quantity";
            // 
            // cmbCompany
            // 
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.IntegralHeight = false;
            this.cmbCompany.Location = new System.Drawing.Point(287, 43);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(191, 21);
            this.cmbCompany.TabIndex = 5;
            this.cmbCompany.SelectionChangeCommitted += new System.EventHandler(this.cmbCompany_SelectionChangeCommitted);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(284, 26);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(51, 13);
            this.lblCompany.TabIndex = 4;
            this.lblCompany.Text = "Company";
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.IntegralHeight = false;
            this.cmbProduct.Location = new System.Drawing.Point(69, 44);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(187, 21);
            this.cmbProduct.TabIndex = 3;
            this.cmbProduct.SelectionChangeCommitted += new System.EventHandler(this.cmbProduct_SelectionChangeCommitted);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(66, 27);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(44, 13);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = "Product";
            // 
            // lblStock
            // 
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(734, 68);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(33, 16);
            this.lblStock.TabIndex = 0;
            this.lblStock.Text = "0";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.Moccasin;
            this.btnCart.Enabled = false;
            this.btnCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.Location = new System.Drawing.Point(998, 142);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(95, 27);
            this.btnCart.TabIndex = 5;
            this.btnCart.Text = "Add to Cart";
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateBill.BackColor = System.Drawing.Color.Moccasin;
            this.btnGenerateBill.Enabled = false;
            this.btnGenerateBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateBill.Location = new System.Drawing.Point(1107, 522);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(95, 27);
            this.btnGenerateBill.TabIndex = 6;
            this.btnGenerateBill.Text = "Generate Bill";
            this.btnGenerateBill.UseVisualStyleBackColor = false;
            this.btnGenerateBill.Click += new System.EventHandler(this.btnGenerateBill_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.txtDiscount);
            this.groupBox2.Controls.Add(this.lblDiscount);
            this.groupBox2.Location = new System.Drawing.Point(484, 446);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 71);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(20, 33);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(162, 20);
            this.txtDiscount.TabIndex = 9;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtSgst_TextChanged);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSgst_KeyPress);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(21, 17);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(66, 13);
            this.lblDiscount.TabIndex = 8;
            this.lblDiscount.Text = "Discount (%)";
            // 
            // grbTax
            // 
            this.grbTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grbTax.Controls.Add(this.txtIgst);
            this.grbTax.Controls.Add(this.lblIgst);
            this.grbTax.Controls.Add(this.txtCgst);
            this.grbTax.Controls.Add(this.lblCgst);
            this.grbTax.Controls.Add(this.txtSgst);
            this.grbTax.Controls.Add(this.lblSgst);
            this.grbTax.Location = new System.Drawing.Point(222, 446);
            this.grbTax.Name = "grbTax";
            this.grbTax.Size = new System.Drawing.Size(189, 103);
            this.grbTax.TabIndex = 8;
            this.grbTax.TabStop = false;
            this.grbTax.Text = "Tax";
            // 
            // txtIgst
            // 
            this.txtIgst.Location = new System.Drawing.Point(85, 71);
            this.txtIgst.Name = "txtIgst";
            this.txtIgst.Size = new System.Drawing.Size(76, 20);
            this.txtIgst.TabIndex = 16;
            this.txtIgst.TextChanged += new System.EventHandler(this.txtSgst_TextChanged);
            this.txtIgst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSgst_KeyPress);
            // 
            // lblIgst
            // 
            this.lblIgst.AutoSize = true;
            this.lblIgst.Location = new System.Drawing.Point(22, 74);
            this.lblIgst.Name = "lblIgst";
            this.lblIgst.Size = new System.Drawing.Size(52, 13);
            this.lblIgst.TabIndex = 15;
            this.lblIgst.Text = "IGST  (%)";
            // 
            // txtCgst
            // 
            this.txtCgst.Location = new System.Drawing.Point(85, 42);
            this.txtCgst.Name = "txtCgst";
            this.txtCgst.Size = new System.Drawing.Size(76, 20);
            this.txtCgst.TabIndex = 14;
            this.txtCgst.TextChanged += new System.EventHandler(this.txtSgst_TextChanged);
            this.txtCgst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSgst_KeyPress);
            // 
            // lblCgst
            // 
            this.lblCgst.AutoSize = true;
            this.lblCgst.Location = new System.Drawing.Point(22, 45);
            this.lblCgst.Name = "lblCgst";
            this.lblCgst.Size = new System.Drawing.Size(56, 13);
            this.lblCgst.TabIndex = 13;
            this.lblCgst.Text = "CGST  (%)";
            // 
            // txtSgst
            // 
            this.txtSgst.Location = new System.Drawing.Point(85, 13);
            this.txtSgst.Name = "txtSgst";
            this.txtSgst.Size = new System.Drawing.Size(76, 20);
            this.txtSgst.TabIndex = 12;
            this.txtSgst.TextChanged += new System.EventHandler(this.txtSgst_TextChanged);
            this.txtSgst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSgst_KeyPress);
            // 
            // lblSgst
            // 
            this.lblSgst.AutoSize = true;
            this.lblSgst.Location = new System.Drawing.Point(22, 16);
            this.lblSgst.Name = "lblSgst";
            this.lblSgst.Size = new System.Drawing.Size(56, 13);
            this.lblSgst.TabIndex = 11;
            this.lblSgst.Text = "SGST  (%)";
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrandTotal.ForeColor = System.Drawing.Color.Blue;
            this.txtGrandTotal.Location = new System.Drawing.Point(1098, 445);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(100, 29);
            this.txtGrandTotal.TabIndex = 10;
            this.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(1027, 448);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(69, 13);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Grand Total :";
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1223, 581);
            this.Controls.Add(this.txtGrandTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.grbTax);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGenerateBill);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridSale);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.pnlHeader);
            this.Name = "SalesForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.lblHome_Click);
            this.Load += new System.EventHandler(this.SalesForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picInvoiceArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHomeArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesModelBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbTax.ResumeLayout(false);
            this.grbTax.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.DataGridView gridSale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnGenerateBill;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.GroupBox grbTax;
        private System.Windows.Forms.TextBox txtIgst;
        private System.Windows.Forms.Label lblIgst;
        private System.Windows.Forms.TextBox txtCgst;
        private System.Windows.Forms.Label lblCgst;
        private System.Windows.Forms.TextBox txtSgst;
        private System.Windows.Forms.Label lblSgst;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.BindingSource salesModelBindingSource;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mRPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Del;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.PictureBox picHomeArrow;
        private System.Windows.Forms.PictureBox picInvoiceArrow;
    }
}