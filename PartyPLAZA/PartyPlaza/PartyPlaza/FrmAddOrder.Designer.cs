namespace PartyPlaza
{
    partial class FrmAddOrder
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
            this.pnlAddOrder = new System.Windows.Forms.Panel();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.pnlSuppDetails = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.lblOrderNO = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lvwOrderDetails = new System.Windows.Forms.ListView();
            this.Supplier = new System.Windows.Forms.ColumnHeader();
            this.Product = new System.Windows.Forms.ColumnHeader();
            this.Qty = new System.Windows.Forms.ColumnHeader();
            this.lblSupplierNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblProductList = new System.Windows.Forms.Label();
            this.lblSupplierList = new System.Windows.Forms.Label();
            this.lstProduct = new System.Windows.Forms.ListBox();
            this.lstSupplier = new System.Windows.Forms.ListBox();
            this.btnAddNewOrder = new System.Windows.Forms.Button();
            this.btnAddExit = new System.Windows.Forms.Button();
            this.btnAddAddOrder = new System.Windows.Forms.Button();
            this.btnAddRemovePro = new System.Windows.Forms.Button();
            this.btnAddAddPro = new System.Windows.Forms.Button();
            this.pnlAddOrder.SuspendLayout();
            this.pnlSuppDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddOrder
            // 
            this.pnlAddOrder.Controls.Add(this.lblOrderDate);
            this.pnlAddOrder.Controls.Add(this.pnlSuppDetails);
            this.pnlAddOrder.Controls.Add(this.dtpOrderDate);
            this.pnlAddOrder.Controls.Add(this.label13);
            this.pnlAddOrder.Controls.Add(this.lblOrderNO);
            this.pnlAddOrder.Controls.Add(this.label11);
            this.pnlAddOrder.Controls.Add(this.lvwOrderDetails);
            this.pnlAddOrder.Controls.Add(this.lblSupplierNo);
            this.pnlAddOrder.Controls.Add(this.label3);
            this.pnlAddOrder.Enabled = false;
            this.pnlAddOrder.Location = new System.Drawing.Point(12, 217);
            this.pnlAddOrder.Name = "pnlAddOrder";
            this.pnlAddOrder.Size = new System.Drawing.Size(827, 429);
            this.pnlAddOrder.TabIndex = 1;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderDate.Location = new System.Drawing.Point(563, 59);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(20, 28);
            this.lblOrderDate.TabIndex = 22;
            this.lblOrderDate.Text = "-";
            // 
            // pnlSuppDetails
            // 
            this.pnlSuppDetails.Controls.Add(this.lblEmail);
            this.pnlSuppDetails.Controls.Add(this.lblTelNo);
            this.pnlSuppDetails.Controls.Add(this.lblCounty);
            this.pnlSuppDetails.Controls.Add(this.lblCity);
            this.pnlSuppDetails.Controls.Add(this.lblStreet);
            this.pnlSuppDetails.Controls.Add(this.lblSurname);
            this.pnlSuppDetails.Controls.Add(this.lblForename);
            this.pnlSuppDetails.Controls.Add(this.lblBusinessName);
            this.pnlSuppDetails.Location = new System.Drawing.Point(11, 53);
            this.pnlSuppDetails.Name = "pnlSuppDetails";
            this.pnlSuppDetails.Size = new System.Drawing.Size(399, 368);
            this.pnlSuppDetails.TabIndex = 17;
            this.pnlSuppDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(16, 329);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(19, 25);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "-";
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelNo.Location = new System.Drawing.Point(16, 282);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(19, 25);
            this.lblTelNo.TabIndex = 13;
            this.lblTelNo.Text = "-";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCounty.Location = new System.Drawing.Point(16, 235);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(19, 25);
            this.lblCounty.TabIndex = 12;
            this.lblCounty.Text = "-";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCity.Location = new System.Drawing.Point(16, 188);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(19, 25);
            this.lblCity.TabIndex = 11;
            this.lblCity.Text = "-";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStreet.Location = new System.Drawing.Point(16, 145);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(19, 25);
            this.lblStreet.TabIndex = 10;
            this.lblStreet.Text = "-";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSurname.Location = new System.Drawing.Point(16, 102);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(19, 25);
            this.lblSurname.TabIndex = 9;
            this.lblSurname.Text = "-";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblForename.Location = new System.Drawing.Point(16, 58);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(19, 25);
            this.lblForename.TabIndex = 8;
            this.lblForename.Text = "-";
            // 
            // lblBusinessName
            // 
            this.lblBusinessName.AutoSize = true;
            this.lblBusinessName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBusinessName.Location = new System.Drawing.Point(16, 9);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(19, 25);
            this.lblBusinessName.TabIndex = 7;
            this.lblBusinessName.Text = "-";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpOrderDate.Location = new System.Drawing.Point(449, 99);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(269, 34);
            this.dtpOrderDate.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(446, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "Order Date";
            // 
            // lblOrderNO
            // 
            this.lblOrderNO.AutoSize = true;
            this.lblOrderNO.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderNO.Location = new System.Drawing.Point(563, 10);
            this.lblOrderNO.Name = "lblOrderNO";
            this.lblOrderNO.Size = new System.Drawing.Size(20, 28);
            this.lblOrderNO.TabIndex = 13;
            this.lblOrderNO.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(443, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Order No";
            // 
            // lvwOrderDetails
            // 
            this.lvwOrderDetails.CheckBoxes = true;
            this.lvwOrderDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Supplier,
            this.Product,
            this.Qty});
            this.lvwOrderDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvwOrderDetails.FullRowSelect = true;
            this.lvwOrderDetails.GridLines = true;
            this.lvwOrderDetails.Location = new System.Drawing.Point(441, 151);
            this.lvwOrderDetails.Name = "lvwOrderDetails";
            this.lvwOrderDetails.Size = new System.Drawing.Size(381, 266);
            this.lvwOrderDetails.TabIndex = 11;
            this.lvwOrderDetails.UseCompatibleStateImageBehavior = false;
            this.lvwOrderDetails.View = System.Windows.Forms.View.Details;
            // 
            // Supplier
            // 
            this.Supplier.Text = "Supplier";
            this.Supplier.Width = 158;
            // 
            // Product
            // 
            this.Product.Text = "Product";
            this.Product.Width = 138;
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            this.Qty.Width = 88;
            // 
            // lblSupplierNo
            // 
            this.lblSupplierNo.AutoSize = true;
            this.lblSupplierNo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSupplierNo.Location = new System.Drawing.Point(155, 10);
            this.lblSupplierNo.Name = "lblSupplierNo";
            this.lblSupplierNo.Size = new System.Drawing.Size(20, 28);
            this.lblSupplierNo.TabIndex = 6;
            this.lblSupplierNo.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Supplier No";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQty.Location = new System.Drawing.Point(875, 57);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(205, 34);
            this.txtQty.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(875, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Quantity";
            // 
            // lblProductList
            // 
            this.lblProductList.AutoSize = true;
            this.lblProductList.Location = new System.Drawing.Point(453, 19);
            this.lblProductList.Name = "lblProductList";
            this.lblProductList.Size = new System.Drawing.Size(105, 25);
            this.lblProductList.TabIndex = 19;
            this.lblProductList.Text = "Product List";
            // 
            // lblSupplierList
            // 
            this.lblSupplierList.AutoSize = true;
            this.lblSupplierList.Location = new System.Drawing.Point(12, 19);
            this.lblSupplierList.Name = "lblSupplierList";
            this.lblSupplierList.Size = new System.Drawing.Size(108, 25);
            this.lblSupplierList.TabIndex = 16;
            this.lblSupplierList.Text = "Supplier List";
            // 
            // lstProduct
            // 
            this.lstProduct.FormattingEnabled = true;
            this.lstProduct.ItemHeight = 25;
            this.lstProduct.Location = new System.Drawing.Point(453, 57);
            this.lstProduct.Name = "lstProduct";
            this.lstProduct.Size = new System.Drawing.Size(386, 154);
            this.lstProduct.TabIndex = 18;
            this.lstProduct.Click += new System.EventHandler(this.lstProduct_Click);
            // 
            // lstSupplier
            // 
            this.lstSupplier.FormattingEnabled = true;
            this.lstSupplier.ItemHeight = 25;
            this.lstSupplier.Location = new System.Drawing.Point(12, 57);
            this.lstSupplier.Name = "lstSupplier";
            this.lstSupplier.Size = new System.Drawing.Size(410, 154);
            this.lstSupplier.TabIndex = 17;
            this.lstSupplier.Click += new System.EventHandler(this.lstSupplier_Click);
            // 
            // btnAddNewOrder
            // 
            this.btnAddNewOrder.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddNewOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddNewOrder.Location = new System.Drawing.Point(877, 305);
            this.btnAddNewOrder.Name = "btnAddNewOrder";
            this.btnAddNewOrder.Size = new System.Drawing.Size(203, 48);
            this.btnAddNewOrder.TabIndex = 26;
            this.btnAddNewOrder.Text = "Add New Order";
            this.btnAddNewOrder.UseVisualStyleBackColor = false;
            this.btnAddNewOrder.Click += new System.EventHandler(this.btnAddNewOrder_Click);
            // 
            // btnAddExit
            // 
            this.btnAddExit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddExit.Location = new System.Drawing.Point(877, 576);
            this.btnAddExit.Name = "btnAddExit";
            this.btnAddExit.Size = new System.Drawing.Size(203, 48);
            this.btnAddExit.TabIndex = 25;
            this.btnAddExit.Text = "Exit Order";
            this.btnAddExit.UseVisualStyleBackColor = false;
            this.btnAddExit.Click += new System.EventHandler(this.btnAddExit_Click);
            // 
            // btnAddAddOrder
            // 
            this.btnAddAddOrder.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddAddOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddAddOrder.Location = new System.Drawing.Point(877, 509);
            this.btnAddAddOrder.Name = "btnAddAddOrder";
            this.btnAddAddOrder.Size = new System.Drawing.Size(203, 48);
            this.btnAddAddOrder.TabIndex = 24;
            this.btnAddAddOrder.Text = "Add Order";
            this.btnAddAddOrder.UseVisualStyleBackColor = false;
            this.btnAddAddOrder.Click += new System.EventHandler(this.btnAddAddOrder_Click);
            // 
            // btnAddRemovePro
            // 
            this.btnAddRemovePro.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddRemovePro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddRemovePro.Location = new System.Drawing.Point(877, 439);
            this.btnAddRemovePro.Name = "btnAddRemovePro";
            this.btnAddRemovePro.Size = new System.Drawing.Size(203, 48);
            this.btnAddRemovePro.TabIndex = 23;
            this.btnAddRemovePro.Text = "Remove Product";
            this.btnAddRemovePro.UseVisualStyleBackColor = false;
            // 
            // btnAddAddPro
            // 
            this.btnAddAddPro.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddAddPro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddAddPro.Location = new System.Drawing.Point(877, 372);
            this.btnAddAddPro.Name = "btnAddAddPro";
            this.btnAddAddPro.Size = new System.Drawing.Size(203, 48);
            this.btnAddAddPro.TabIndex = 22;
            this.btnAddAddPro.Text = "Add Product";
            this.btnAddAddPro.UseVisualStyleBackColor = false;
            this.btnAddAddPro.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // FrmAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 646);
            this.Controls.Add(this.btnAddNewOrder);
            this.Controls.Add(this.btnAddExit);
            this.Controls.Add(this.btnAddAddOrder);
            this.Controls.Add(this.btnAddRemovePro);
            this.Controls.Add(this.btnAddAddPro);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblProductList);
            this.Controls.Add(this.lblSupplierList);
            this.Controls.Add(this.lstProduct);
            this.Controls.Add(this.lstSupplier);
            this.Controls.Add(this.pnlAddOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddOrder";
            this.Text = "FrmOrderProduct";
            this.Load += new System.EventHandler(this.FrmAddOrder_Load);
            this.pnlAddOrder.ResumeLayout(false);
            this.pnlAddOrder.PerformLayout();
            this.pnlSuppDetails.ResumeLayout(false);
            this.pnlSuppDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlAddOrder;
        private DateTimePicker dtpOrderDate;
        private Label label13;
        private Label lblOrderNO;
        private Label label11;
        private ListView lvwOrderDetails;
        private Panel pnlSuppDetails;
        private Label lblStreet;
        private Label lblSurname;
        private Label lblForename;
        private Label lblBusinessName;
        private Label lblSupplierNo;
        private Label label3;
        private Label lblEmail;
        private Label lblTelNo;
        private Label lblCounty;
        private Label lblCity;
        private TextBox txtQty;
        private Label label5;
        private Label lblProductList;
        private Label lblSupplierList;
        private ListBox lstProduct;
        private ListBox lstSupplier;
        private ColumnHeader Supplier;
        private ColumnHeader Product;
        private ColumnHeader Qty;
        private Label lblOrderDate;
        private Button btnAddNewOrder;
        private Button btnAddExit;
        private Button btnAddAddOrder;
        private Button btnAddRemovePro;
        private Button btnAddAddPro;
    }
}