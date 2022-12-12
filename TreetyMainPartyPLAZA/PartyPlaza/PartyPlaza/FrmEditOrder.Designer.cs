namespace PartyPlaza
{
    partial class FrmEditOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.lblOrderNO = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblProductList = new System.Windows.Forms.Label();
            this.lblSupplierList = new System.Windows.Forms.Label();
            this.lstProduct = new System.Windows.Forms.ListBox();
            this.lstSupplier = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnDeleteOP = new System.Windows.Forms.Button();
            this.btnEditOP = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lvwOrderDetails = new System.Windows.Forms.ListView();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProductNo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpOrderDate);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.lblOrderNO);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lblProductList);
            this.panel1.Controls.Add(this.lblSupplierList);
            this.panel1.Controls.Add(this.lstProduct);
            this.panel1.Controls.Add(this.lstSupplier);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 288);
            this.panel1.TabIndex = 0;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpOrderDate.Location = new System.Drawing.Point(750, 214);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(269, 34);
            this.dtpOrderDate.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(750, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 28);
            this.label13.TabIndex = 23;
            this.label13.Text = "Order Date";
            // 
            // lblOrderNO
            // 
            this.lblOrderNO.AutoSize = true;
            this.lblOrderNO.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderNO.Location = new System.Drawing.Point(750, 106);
            this.lblOrderNO.Name = "lblOrderNO";
            this.lblOrderNO.Size = new System.Drawing.Size(20, 28);
            this.lblOrderNO.TabIndex = 22;
            this.lblOrderNO.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(750, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 28);
            this.label11.TabIndex = 21;
            this.label11.Text = "Order No";
            // 
            // lblProductList
            // 
            this.lblProductList.AutoSize = true;
            this.lblProductList.Location = new System.Drawing.Point(360, 2);
            this.lblProductList.Name = "lblProductList";
            this.lblProductList.Size = new System.Drawing.Size(105, 25);
            this.lblProductList.TabIndex = 20;
            this.lblProductList.Text = "Product List";
            // 
            // lblSupplierList
            // 
            this.lblSupplierList.AutoSize = true;
            this.lblSupplierList.Location = new System.Drawing.Point(3, 2);
            this.lblSupplierList.Name = "lblSupplierList";
            this.lblSupplierList.Size = new System.Drawing.Size(108, 25);
            this.lblSupplierList.TabIndex = 17;
            this.lblSupplierList.Text = "Supplier List";
            // 
            // lstProduct
            // 
            this.lstProduct.FormattingEnabled = true;
            this.lstProduct.ItemHeight = 25;
            this.lstProduct.Location = new System.Drawing.Point(360, 40);
            this.lstProduct.Name = "lstProduct";
            this.lstProduct.Size = new System.Drawing.Size(337, 229);
            this.lstProduct.TabIndex = 19;
            // 
            // lstSupplier
            // 
            this.lstSupplier.FormattingEnabled = true;
            this.lstSupplier.ItemHeight = 25;
            this.lstSupplier.Location = new System.Drawing.Point(3, 40);
            this.lstSupplier.Name = "lstSupplier";
            this.lstSupplier.Size = new System.Drawing.Size(337, 229);
            this.lstSupplier.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 329);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 293);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDeleteOrder);
            this.panel3.Controls.Add(this.btnEditOrder);
            this.panel3.Controls.Add(this.txtQty);
            this.panel3.Controls.Add(this.btnDeleteOP);
            this.panel3.Controls.Add(this.btnEditOP);
            this.panel3.Controls.Add(this.btnAddProduct);
            this.panel3.Controls.Add(this.lvwOrderDetails);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lblPrice);
            this.panel3.Controls.Add(this.lblProductNo);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 306);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1097, 328);
            this.panel3.TabIndex = 2;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteOrder.Location = new System.Drawing.Point(768, 274);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(293, 48);
            this.btnDeleteOrder.TabIndex = 23;
            this.btnDeleteOrder.Text = "Delete Order";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEditOrder.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditOrder.Location = new System.Drawing.Point(768, 207);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(293, 48);
            this.btnEditOrder.TabIndex = 21;
            this.btnEditOrder.Text = "Edit Order";
            this.btnEditOrder.UseVisualStyleBackColor = false;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQty.Location = new System.Drawing.Point(425, 81);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(205, 34);
            this.txtQty.TabIndex = 30;
            // 
            // btnDeleteOP
            // 
            this.btnDeleteOP.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDeleteOP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteOP.Location = new System.Drawing.Point(768, 143);
            this.btnDeleteOP.Name = "btnDeleteOP";
            this.btnDeleteOP.Size = new System.Drawing.Size(293, 48);
            this.btnDeleteOP.TabIndex = 19;
            this.btnDeleteOP.Text = "Delete Item";
            this.btnDeleteOP.UseVisualStyleBackColor = false;
            this.btnDeleteOP.Click += new System.EventHandler(this.btnDeleteOP_Click);
            // 
            // btnEditOP
            // 
            this.btnEditOP.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEditOP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditOP.Location = new System.Drawing.Point(768, 79);
            this.btnEditOP.Name = "btnEditOP";
            this.btnEditOP.Size = new System.Drawing.Size(293, 48);
            this.btnEditOP.TabIndex = 17;
            this.btnEditOP.Text = "Edit Item";
            this.btnEditOP.UseVisualStyleBackColor = false;
            this.btnEditOP.Click += new System.EventHandler(this.btnEditOP_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddProduct.Location = new System.Drawing.Point(768, 13);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(293, 48);
            this.btnAddProduct.TabIndex = 16;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lvwOrderDetails
            // 
            this.lvwOrderDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvwOrderDetails.Location = new System.Drawing.Point(21, 163);
            this.lvwOrderDetails.Name = "lvwOrderDetails";
            this.lvwOrderDetails.Size = new System.Drawing.Size(694, 167);
            this.lvwOrderDetails.TabIndex = 29;
            this.lvwOrderDetails.UseCompatibleStateImageBehavior = false;
            // 
            // label10
            // 
            this.label10.AutoEllipsis = true;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(425, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 25);
            this.label10.TabIndex = 28;
            this.label10.Text = "Qty";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Product No";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.Location = new System.Drawing.Point(216, 76);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(20, 28);
            this.lblPrice.TabIndex = 25;
            this.lblPrice.Text = "-";
            // 
            // lblProductNo
            // 
            this.lblProductNo.AutoSize = true;
            this.lblProductNo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductNo.Location = new System.Drawing.Point(21, 76);
            this.lblProductNo.Name = "lblProductNo";
            this.lblProductNo.Size = new System.Drawing.Size(20, 28);
            this.lblProductNo.TabIndex = 24;
            this.lblProductNo.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Product No";
            // 
            // FrmEditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 646);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditOrder";
            this.Text = "FrmEditOrderProduct";
            this.Load += new System.EventHandler(this.FrmEditOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DateTimePicker dtpOrderDate;
        private Label label13;
        private Label lblOrderNO;
        private Label label11;
        private Label lblProductList;
        private Label lblSupplierList;
        private ListBox lstProduct;
        private ListBox lstSupplier;
        private Button btnDeleteOrder;
        private Button btnEditOrder;
        private TextBox txtQty;
        private Button btnDeleteOP;
        private Button btnEditOP;
        private Button btnAddProduct;
        private ListView lvwOrderDetails;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label lblPrice;
        private Label lblProductNo;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}