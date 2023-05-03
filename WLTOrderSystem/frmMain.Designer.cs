namespace WLTOrderSystem
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.listItemDisplay = new System.Windows.Forms.ListView();
            this.CodeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VendorHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QtyHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExitHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TaxHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtbCode = new System.Windows.Forms.TextBox();
            this.txtbVendor = new System.Windows.Forms.TextBox();
            this.txtbDescription = new System.Windows.Forms.TextBox();
            this.txtbPrice = new System.Windows.Forms.TextBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblVendor = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtbExitPrice = new System.Windows.Forms.TextBox();
            this.lblExitPrice = new System.Windows.Forms.Label();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtbTotalPrice = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.dataSalesBreakdown = new System.Windows.Forms.DataGridView();
            this.btnNewItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnPayOrder = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.txtbTax = new System.Windows.Forms.TextBox();
            this.txtbItemNotes = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbOrderNotes = new System.Windows.Forms.TextBox();
            this.chkTax = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSalesBreakdown)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // txtbDate
            // 
            this.txtbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbDate.Location = new System.Drawing.Point(19, 63);
            this.txtbDate.Name = "txtbDate";
            this.txtbDate.Size = new System.Drawing.Size(121, 24);
            this.txtbDate.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(15, 40);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(43, 18);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // listItemDisplay
            // 
            this.listItemDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CodeHeader,
            this.VendorHeader,
            this.DescriptionHeader,
            this.QtyHeader,
            this.PriceHeader,
            this.ExitHeader,
            this.TaxHeader,
            this.TotalHeader,
            this.OrderHeader,
            this.ItemHeader});
            this.listItemDisplay.FullRowSelect = true;
            this.listItemDisplay.GridLines = true;
            this.listItemDisplay.HideSelection = false;
            this.listItemDisplay.Location = new System.Drawing.Point(19, 180);
            this.listItemDisplay.MultiSelect = false;
            this.listItemDisplay.Name = "listItemDisplay";
            this.listItemDisplay.Size = new System.Drawing.Size(844, 435);
            this.listItemDisplay.TabIndex = 20;
            this.listItemDisplay.TabStop = false;
            this.listItemDisplay.UseCompatibleStateImageBehavior = false;
            this.listItemDisplay.View = System.Windows.Forms.View.Details;
            this.listItemDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listItemDisplay_MouseDoubleClick);
            // 
            // CodeHeader
            // 
            this.CodeHeader.Text = "Code";
            this.CodeHeader.Width = 64;
            // 
            // VendorHeader
            // 
            this.VendorHeader.Text = "Vendor Name";
            this.VendorHeader.Width = 128;
            // 
            // DescriptionHeader
            // 
            this.DescriptionHeader.Text = "Item Description";
            this.DescriptionHeader.Width = 254;
            // 
            // QtyHeader
            // 
            this.QtyHeader.Text = "Qty";
            this.QtyHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.QtyHeader.Width = 44;
            // 
            // PriceHeader
            // 
            this.PriceHeader.Text = "Price";
            this.PriceHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PriceHeader.Width = 64;
            // 
            // ExitHeader
            // 
            this.ExitHeader.Text = "Ext. Price";
            this.ExitHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ExitHeader.Width = 74;
            // 
            // TaxHeader
            // 
            this.TaxHeader.Text = "Tax";
            this.TaxHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TaxHeader.Width = 80;
            // 
            // TotalHeader
            // 
            this.TotalHeader.Text = "Total Price";
            this.TotalHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TotalHeader.Width = 84;
            // 
            // OrderHeader
            // 
            this.OrderHeader.Text = "Order #";
            this.OrderHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.OrderHeader.Width = 48;
            // 
            // ItemHeader
            // 
            this.ItemHeader.Text = "Item #";
            this.ItemHeader.Width = 0;
            // 
            // txtbCode
            // 
            this.txtbCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCode.Location = new System.Drawing.Point(19, 134);
            this.txtbCode.Name = "txtbCode";
            this.txtbCode.Size = new System.Drawing.Size(68, 26);
            this.txtbCode.TabIndex = 3;
            // 
            // txtbVendor
            // 
            this.txtbVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbVendor.Location = new System.Drawing.Point(84, 134);
            this.txtbVendor.Name = "txtbVendor";
            this.txtbVendor.Size = new System.Drawing.Size(131, 26);
            this.txtbVendor.TabIndex = 4;
            // 
            // txtbDescription
            // 
            this.txtbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbDescription.Location = new System.Drawing.Point(212, 134);
            this.txtbDescription.Name = "txtbDescription";
            this.txtbDescription.Size = new System.Drawing.Size(255, 26);
            this.txtbDescription.TabIndex = 5;
            this.txtbDescription.Leave += new System.EventHandler(this.txtbDescription_Leave);
            // 
            // txtbPrice
            // 
            this.txtbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPrice.Location = new System.Drawing.Point(507, 134);
            this.txtbPrice.Name = "txtbPrice";
            this.txtbPrice.Size = new System.Drawing.Size(67, 26);
            this.txtbPrice.TabIndex = 7;
            this.txtbPrice.Text = "$0.00";
            this.txtbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbPrice.Leave += new System.EventHandler(this.txtbPrice_Leave);
            // 
            // numQuantity
            // 
            this.numQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuantity.Location = new System.Drawing.Point(466, 134);
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(44, 26);
            this.numQuantity.TabIndex = 6;
            this.numQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Leave += new System.EventHandler(this.numQuantity_Leave);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(16, 113);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(48, 18);
            this.lblCode.TabIndex = 12;
            this.lblCode.Text = "Code";
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendor.Location = new System.Drawing.Point(81, 113);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(110, 18);
            this.lblVendor.TabIndex = 13;
            this.lblVendor.Text = "Vendor Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(209, 113);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(131, 18);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Item Description";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(463, 113);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(34, 18);
            this.lblQuantity.TabIndex = 15;
            this.lblQuantity.Text = "Qty";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(504, 113);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(47, 18);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "Price";
            // 
            // txtbExitPrice
            // 
            this.txtbExitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbExitPrice.Location = new System.Drawing.Point(573, 134);
            this.txtbExitPrice.Name = "txtbExitPrice";
            this.txtbExitPrice.Size = new System.Drawing.Size(78, 26);
            this.txtbExitPrice.TabIndex = 9;
            this.txtbExitPrice.Text = "$0.00";
            this.txtbExitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblExitPrice
            // 
            this.lblExitPrice.AutoSize = true;
            this.lblExitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExitPrice.Location = new System.Drawing.Point(570, 113);
            this.lblExitPrice.Name = "lblExitPrice";
            this.lblExitPrice.Size = new System.Drawing.Size(81, 18);
            this.lblExitPrice.TabIndex = 19;
            this.lblExitPrice.Text = "Ext. Price";
            // 
            // txtbName
            // 
            this.txtbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbName.Location = new System.Drawing.Point(147, 63);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(121, 24);
            this.txtbName.TabIndex = 2;
            this.txtbName.Leave += new System.EventHandler(this.txtbName_Leave);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(144, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(129, 18);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Sales Associate";
            // 
            // txtbTotalPrice
            // 
            this.txtbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTotalPrice.Location = new System.Drawing.Point(726, 134);
            this.txtbTotalPrice.Name = "txtbTotalPrice";
            this.txtbTotalPrice.Size = new System.Drawing.Size(88, 26);
            this.txtbTotalPrice.TabIndex = 12;
            this.txtbTotalPrice.Text = "$0.00";
            this.txtbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(726, 112);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(90, 18);
            this.lblTotalPrice.TabIndex = 23;
            this.lblTotalPrice.Text = "Total Price";
            // 
            // dataSalesBreakdown
            // 
            this.dataSalesBreakdown.AllowUserToAddRows = false;
            this.dataSalesBreakdown.AllowUserToDeleteRows = false;
            this.dataSalesBreakdown.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSalesBreakdown.Location = new System.Drawing.Point(986, 406);
            this.dataSalesBreakdown.Name = "dataSalesBreakdown";
            this.dataSalesBreakdown.ReadOnly = true;
            this.dataSalesBreakdown.Size = new System.Drawing.Size(240, 209);
            this.dataSalesBreakdown.TabIndex = 21;
            this.dataSalesBreakdown.TabStop = false;
            // 
            // btnNewItem
            // 
            this.btnNewItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewItem.Location = new System.Drawing.Point(1075, 63);
            this.btnNewItem.Name = "btnNewItem";
            this.btnNewItem.Size = new System.Drawing.Size(83, 45);
            this.btnNewItem.TabIndex = 13;
            this.btnNewItem.Text = "New Item";
            this.btnNewItem.UseVisualStyleBackColor = true;
            this.btnNewItem.Click += new System.EventHandler(this.btnNewItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.Location = new System.Drawing.Point(1075, 125);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(83, 45);
            this.btnDeleteItem.TabIndex = 15;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnPayOrder
            // 
            this.btnPayOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayOrder.Location = new System.Drawing.Point(1165, 124);
            this.btnPayOrder.Name = "btnPayOrder";
            this.btnPayOrder.Size = new System.Drawing.Size(83, 45);
            this.btnPayOrder.TabIndex = 17;
            this.btnPayOrder.Text = "Pay for Order";
            this.btnPayOrder.UseVisualStyleBackColor = true;
            this.btnPayOrder.Click += new System.EventHandler(this.btnPayOrder_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewOrder.Location = new System.Drawing.Point(977, 63);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(83, 45);
            this.btnNewOrder.TabIndex = 14;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOrder.Location = new System.Drawing.Point(977, 124);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(83, 45);
            this.btnDeleteOrder.TabIndex = 16;
            this.btnDeleteOrder.Text = "Delete Order";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // txtbTax
            // 
            this.txtbTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTax.Location = new System.Drawing.Point(648, 134);
            this.txtbTax.Name = "txtbTax";
            this.txtbTax.Size = new System.Drawing.Size(79, 26);
            this.txtbTax.TabIndex = 11;
            this.txtbTax.Text = "$0.00";
            this.txtbTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtbItemNotes
            // 
            this.txtbItemNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbItemNotes.Location = new System.Drawing.Point(976, 201);
            this.txtbItemNotes.Name = "txtbItemNotes";
            this.txtbItemNotes.Size = new System.Drawing.Size(272, 26);
            this.txtbItemNotes.TabIndex = 18;
            this.txtbItemNotes.Leave += new System.EventHandler(this.txtbItemNotes_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(974, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 18);
            this.label11.TabIndex = 32;
            this.label11.Text = "Item Notes";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(974, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 18);
            this.label12.TabIndex = 33;
            this.label12.Text = "Order Notes";
            // 
            // txtbOrderNotes
            // 
            this.txtbOrderNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbOrderNotes.Location = new System.Drawing.Point(976, 260);
            this.txtbOrderNotes.Name = "txtbOrderNotes";
            this.txtbOrderNotes.Size = new System.Drawing.Size(272, 26);
            this.txtbOrderNotes.TabIndex = 19;
            this.txtbOrderNotes.Leave += new System.EventHandler(this.txtbOrderNotes_Leave);
            // 
            // chkTax
            // 
            this.chkTax.AutoSize = true;
            this.chkTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTax.Location = new System.Drawing.Point(657, 112);
            this.chkTax.Name = "chkTax";
            this.chkTax.Size = new System.Drawing.Size(63, 22);
            this.chkTax.TabIndex = 34;
            this.chkTax.Text = "Tax?";
            this.chkTax.UseVisualStyleBackColor = true;
            this.chkTax.Leave += new System.EventHandler(this.chkTax_Leave);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.chkTax);
            this.Controls.Add(this.txtbOrderNotes);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtbItemNotes);
            this.Controls.Add(this.txtbTax);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.btnPayOrder);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnNewItem);
            this.Controls.Add(this.dataSalesBreakdown);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.txtbTotalPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.lblExitPrice);
            this.Controls.Add(this.txtbExitPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblVendor);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.txtbPrice);
            this.Controls.Add(this.txtbDescription);
            this.Controls.Add(this.txtbVendor);
            this.Controls.Add(this.txtbCode);
            this.Controls.Add(this.listItemDisplay);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtbDate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "WLT Sales Sheet";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSalesBreakdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox txtbDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ListView listItemDisplay;
        private System.Windows.Forms.TextBox txtbCode;
        private System.Windows.Forms.TextBox txtbVendor;
        private System.Windows.Forms.TextBox txtbDescription;
        private System.Windows.Forms.TextBox txtbPrice;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtbExitPrice;
        private System.Windows.Forms.Label lblExitPrice;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtbTotalPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.DataGridView dataSalesBreakdown;
        private System.Windows.Forms.Button btnNewItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnPayOrder;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.TextBox txtbTax;
        private System.Windows.Forms.TextBox txtbItemNotes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtbOrderNotes;
        private System.Windows.Forms.ColumnHeader CodeHeader;
        private System.Windows.Forms.ColumnHeader VendorHeader;
        private System.Windows.Forms.ColumnHeader DescriptionHeader;
        private System.Windows.Forms.ColumnHeader QtyHeader;
        private System.Windows.Forms.ColumnHeader PriceHeader;
        private System.Windows.Forms.ColumnHeader ExitHeader;
        private System.Windows.Forms.ColumnHeader TaxHeader;
        private System.Windows.Forms.ColumnHeader TotalHeader;
        private System.Windows.Forms.CheckBox chkTax;
        private System.Windows.Forms.ColumnHeader OrderHeader;
        private System.Windows.Forms.ColumnHeader ItemHeader;
    }
}

