namespace PartyPlaza
{
    partial class FrmDisplayBooking
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.butEditBook = new System.Windows.Forms.Button();
            this.butExitBook = new System.Windows.Forms.Button();
            this.butAddBook = new System.Windows.Forms.Button();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(674, 201);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(209, 59);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // butEditBook
            // 
            this.butEditBook.Location = new System.Drawing.Point(674, 107);
            this.butEditBook.Name = "butEditBook";
            this.butEditBook.Size = new System.Drawing.Size(209, 59);
            this.butEditBook.TabIndex = 14;
            this.butEditBook.Text = "Edit";
            this.butEditBook.UseVisualStyleBackColor = true;
            this.butEditBook.Click += new System.EventHandler(this.butEditBook_Click);
            // 
            // butExitBook
            // 
            this.butExitBook.Location = new System.Drawing.Point(674, 291);
            this.butExitBook.Name = "butExitBook";
            this.butExitBook.Size = new System.Drawing.Size(209, 59);
            this.butExitBook.TabIndex = 13;
            this.butExitBook.Text = "Exit";
            this.butExitBook.UseVisualStyleBackColor = true;
            this.butExitBook.Click += new System.EventHandler(this.butExitBook_Click);
            // 
            // butAddBook
            // 
            this.butAddBook.Location = new System.Drawing.Point(674, 18);
            this.butAddBook.Name = "butAddBook";
            this.butAddBook.Size = new System.Drawing.Size(209, 59);
            this.butAddBook.TabIndex = 12;
            this.butAddBook.Text = "Add";
            this.butAddBook.UseVisualStyleBackColor = true;
            this.butAddBook.Click += new System.EventHandler(this.butAddBook_Click);
            // 
            // dgvBooking
            // 
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Location = new System.Drawing.Point(14, 18);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.RowHeadersWidth = 51;
            this.dgvBooking.RowTemplate.Height = 29;
            this.dgvBooking.Size = new System.Drawing.Size(640, 481);
            this.dgvBooking.TabIndex = 11;
            // 
            // FrmDisplayBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 517);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.butEditBook);
            this.Controls.Add(this.butExitBook);
            this.Controls.Add(this.butAddBook);
            this.Controls.Add(this.dgvBooking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDisplayBooking";
            this.Text = "FrmDisplayBooking";
            this.Load += new System.EventHandler(this.FrmDisplayBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnDelete;
        private Button butEditBook;
        private Button butExitBook;
        private Button butAddBook;
        private DataGridView dgvBooking;
    }
}