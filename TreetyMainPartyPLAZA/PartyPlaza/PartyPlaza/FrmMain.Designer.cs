namespace PartyPlaza
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMainExit = new System.Windows.Forms.PictureBox();
            this.ButBooking = new System.Windows.Forms.PictureBox();
            this.btnSupplier = new System.Windows.Forms.PictureBox();
            this.btnOrder = new System.Windows.Forms.PictureBox();
            this.ButCustomer = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMainExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.BackgroundImage = global::PartyPlaza.Properties.Resources.MicrosoftTeams_image__10_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnMainExit);
            this.panel1.Controls.Add(this.ButBooking);
            this.panel1.Controls.Add(this.btnSupplier);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.ButCustomer);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 650);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.lblMenu_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnMainExit
            // 
            this.btnMainExit.BackColor = System.Drawing.Color.Transparent;
            this.btnMainExit.Location = new System.Drawing.Point(39, 498);
            this.btnMainExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnMainExit.Name = "btnMainExit";
            this.btnMainExit.Size = new System.Drawing.Size(130, 111);
            this.btnMainExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMainExit.TabIndex = 9;
            this.btnMainExit.TabStop = false;
            this.btnMainExit.Click += new System.EventHandler(this.btnMainExit_Click);
            // 
            // ButBooking
            // 
            this.ButBooking.BackColor = System.Drawing.Color.Transparent;
            this.ButBooking.Image = global::PartyPlaza.Properties.Resources.MicrosoftTeams_image__8_;
            this.ButBooking.Location = new System.Drawing.Point(39, 11);
            this.ButBooking.Margin = new System.Windows.Forms.Padding(4);
            this.ButBooking.Name = "ButBooking";
            this.ButBooking.Size = new System.Drawing.Size(130, 111);
            this.ButBooking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButBooking.TabIndex = 8;
            this.ButBooking.TabStop = false;
            this.ButBooking.Click += new System.EventHandler(this.pictureBox7_Click);
            this.ButBooking.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox7_MouseDown);
            this.ButBooking.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox7_MouseUp);
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.Color.Transparent;
            this.btnSupplier.Image = global::PartyPlaza.Properties.Resources.MicrosoftTeams_image__9_;
            this.btnSupplier.Location = new System.Drawing.Point(39, 366);
            this.btnSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(130, 111);
            this.btnSupplier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSupplier.TabIndex = 6;
            this.btnSupplier.TabStop = false;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            this.btnSupplier.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox5_MouseDown);
            this.btnSupplier.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox5_MouseUp);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnOrder.Image = global::PartyPlaza.Properties.Resources.MicrosoftTeams_image__1_;
            this.btnOrder.Location = new System.Drawing.Point(39, 249);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(130, 111);
            this.btnOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOrder.TabIndex = 5;
            this.btnOrder.TabStop = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            this.btnOrder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseDown);
            this.btnOrder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseUp);
            // 
            // ButCustomer
            // 
            this.ButCustomer.BackColor = System.Drawing.Color.Transparent;
            this.ButCustomer.Image = global::PartyPlaza.Properties.Resources.MicrosoftTeams_image__7_;
            this.ButCustomer.Location = new System.Drawing.Point(39, 130);
            this.ButCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.ButCustomer.Name = "ButCustomer";
            this.ButCustomer.Size = new System.Drawing.Size(130, 111);
            this.ButCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButCustomer.TabIndex = 4;
            this.ButCustomer.TabStop = false;
            this.ButCustomer.Click += new System.EventHandler(this.ButCustomer_Click);
            this.ButCustomer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.ButCustomer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseUp);
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(201, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1121, 646);
            this.pnlMain.TabIndex = 2;
            this.pnlMain.Click += new System.EventHandler(this.btnMianExit_Click);
            this.pnlMain.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.pnlMain_ControlRemoved);
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            this.pnlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PartyPlaza.Properties.Resources.MicrosoftTeams_image__13_;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 641);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1344, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 804);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMainExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox ButBooking;
        private PictureBox btnSupplier;
        private PictureBox btnOrder;
        private PictureBox ButCustomer;
        private Panel pnlMain;
        private PictureBox pictureBox1;
        private PictureBox btnMainExit;
    }
}