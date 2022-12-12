namespace PartyPlaza
{
    partial class FrmBooking
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
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.btnEditBooking = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.pnlAddEdit = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listBoxProdType = new System.Windows.Forms.ListBox();
            this.listViewProduct = new System.Windows.Forms.ListView();
            this.pnlDate = new System.Windows.Forms.Panel();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.labBookingDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cust = new System.Windows.Forms.Label();
            this.listBoxCust = new System.Windows.Forms.ListBox();
            this.pnlAddEdit.SuspendLayout();
            this.pnlDate.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.Location = new System.Drawing.Point(749, 436);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(117, 58);
            this.btnDeleteBooking.TabIndex = 21;
            this.btnDeleteBooking.Text = "Delete Booking";
            this.btnDeleteBooking.UseVisualStyleBackColor = true;
            this.btnDeleteBooking.Click += new System.EventHandler(this.butDeleteBooking_Click);
            // 
            // btnEditBooking
            // 
            this.btnEditBooking.Location = new System.Drawing.Point(749, 389);
            this.btnEditBooking.Name = "btnEditBooking";
            this.btnEditBooking.Size = new System.Drawing.Size(117, 41);
            this.btnEditBooking.TabIndex = 20;
            this.btnEditBooking.Text = "Edit Booking";
            this.btnEditBooking.UseVisualStyleBackColor = true;
            this.btnEditBooking.Click += new System.EventHandler(this.butEditBooking_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(749, 342);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(117, 41);
            this.btnDeleteItem.TabIndex = 19;
            this.btnDeleteItem.Text = "Delete item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.butDeleteItem_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.Location = new System.Drawing.Point(749, 295);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(117, 41);
            this.btnEditItem.TabIndex = 18;
            this.btnEditItem.Text = "Edit item";
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.butEditItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(749, 248);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(117, 41);
            this.btnAddItem.TabIndex = 17;
            this.btnAddItem.Text = "Add item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.butAddItem_Click);
            // 
            // pnlAddEdit
            // 
            this.pnlAddEdit.BackColor = System.Drawing.SystemColors.Control;
            this.pnlAddEdit.Controls.Add(this.textBox1);
            this.pnlAddEdit.Controls.Add(this.label10);
            this.pnlAddEdit.Location = new System.Drawing.Point(317, 219);
            this.pnlAddEdit.Name = "pnlAddEdit";
            this.pnlAddEdit.Size = new System.Drawing.Size(341, 84);
            this.pnlAddEdit.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 27);
            this.textBox1.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Qty";
            // 
            // listBoxProdType
            // 
            this.listBoxProdType.FormattingEnabled = true;
            this.listBoxProdType.ItemHeight = 20;
            this.listBoxProdType.Items.AddRange(new object[] {
            "Drinks",
            "Entertainer",
            "Equipment",
            "Food"});
            this.listBoxProdType.Location = new System.Drawing.Point(317, 89);
            this.listBoxProdType.Name = "listBoxProdType";
            this.listBoxProdType.Size = new System.Drawing.Size(276, 124);
            this.listBoxProdType.TabIndex = 1;
            this.listBoxProdType.Click += new System.EventHandler(this.listBoxProdType_Click);
            // 
            // listViewProduct
            // 
            this.listViewProduct.Location = new System.Drawing.Point(317, 309);
            this.listViewProduct.Name = "listViewProduct";
            this.listViewProduct.Size = new System.Drawing.Size(406, 200);
            this.listViewProduct.TabIndex = 15;
            this.listViewProduct.UseCompatibleStateImageBehavior = false;
            this.listViewProduct.Click += new System.EventHandler(this.listBoxBooking_Click);
            // 
            // pnlDate
            // 
            this.pnlDate.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDate.Controls.Add(this.dtpStartDate);
            this.pnlDate.Controls.Add(this.label2);
            this.pnlDate.Controls.Add(this.labBookingDate);
            this.pnlDate.Controls.Add(this.label1);
            this.pnlDate.Location = new System.Drawing.Point(317, 9);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(568, 74);
            this.pnlDate.TabIndex = 14;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(300, 34);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(249, 27);
            this.dtpStartDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date Booked";
            // 
            // labBookingDate
            // 
            this.labBookingDate.AutoSize = true;
            this.labBookingDate.Location = new System.Drawing.Point(109, 9);
            this.labBookingDate.Name = "labBookingDate";
            this.labBookingDate.Size = new System.Drawing.Size(15, 20);
            this.labBookingDate.TabIndex = 1;
            this.labBookingDate.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking Date";
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 20;
            this.listBoxProducts.Location = new System.Drawing.Point(599, 89);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(286, 124);
            this.listBoxProducts.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Cust);
            this.panel2.Location = new System.Drawing.Point(12, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 181);
            this.panel2.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Postcode";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "County";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Town";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Street";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Name";
            // 
            // Cust
            // 
            this.Cust.AutoSize = true;
            this.Cust.Location = new System.Drawing.Point(7, 4);
            this.Cust.Name = "Cust";
            this.Cust.Size = new System.Drawing.Size(92, 20);
            this.Cust.TabIndex = 0;
            this.Cust.Text = "CustomerNo";
            // 
            // listBoxCust
            // 
            this.listBoxCust.FormattingEnabled = true;
            this.listBoxCust.ItemHeight = 20;
            this.listBoxCust.Location = new System.Drawing.Point(12, 9);
            this.listBoxCust.Name = "listBoxCust";
            this.listBoxCust.Size = new System.Drawing.Size(273, 184);
            this.listBoxCust.TabIndex = 11;
            this.listBoxCust.Click += new System.EventHandler(this.listBoxCust_Click);
            // 
            // FrmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 517);
            this.Controls.Add(this.btnDeleteBooking);
            this.Controls.Add(this.btnEditBooking);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.listBoxProdType);
            this.Controls.Add(this.btnEditItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.pnlAddEdit);
            this.Controls.Add(this.listViewProduct);
            this.Controls.Add(this.pnlDate);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listBoxCust);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBooking";
            this.Text = "FrmBooking";
            this.Load += new System.EventHandler(this.FrmBooking_Load);
            this.pnlAddEdit.ResumeLayout(false);
            this.pnlAddEdit.PerformLayout();
            this.pnlDate.ResumeLayout(false);
            this.pnlDate.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnDeleteBooking;
        private Button btnEditBooking;
        private Button btnDeleteItem;
        private Button btnEditItem;
        private Button btnAddItem;
        private Panel pnlAddEdit;
        private ListBox listBoxProdType;
        private ListView listViewProduct;
        private Panel pnlDate;
        private DateTimePicker dtpStartDate;
        private Label label2;
        private Label labBookingDate;
        private Label label1;
        private ListBox listBoxProducts;
        private Panel panel2;
        private Label label8;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label Cust;
        private ListBox listBoxCust;
        private Label label9;
        private Label label10;
        private TextBox textBox1;
    }
}