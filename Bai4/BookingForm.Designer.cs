using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab5
{
    partial class BookingForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblCustomerName = new Label();
            txtCustomerName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblSeatNumber = new Label();
            txtSeatNumber = new TextBox();
            btnBook = new Button();
            lblMovieTitle = new Label();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(13, 13);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(97, 15);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "Customer Name:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(104, 10);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(200, 23);
            txtCustomerName.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(13, 40);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(104, 37);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 3;
            // 
            // lblSeatNumber
            // 
            lblSeatNumber.AutoSize = true;
            lblSeatNumber.Location = new Point(13, 67);
            lblSeatNumber.Name = "lblSeatNumber";
            lblSeatNumber.Size = new Size(79, 15);
            lblSeatNumber.TabIndex = 4;
            lblSeatNumber.Text = "Seat Number:";
            // 
            // txtSeatNumber
            // 
            txtSeatNumber.Location = new Point(104, 64);
            txtSeatNumber.Name = "txtSeatNumber";
            txtSeatNumber.Size = new Size(200, 23);
            txtSeatNumber.TabIndex = 5;
            // 
            // btnBook
            // 
            btnBook.Location = new Point(10, 525);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(75, 23);
            btnBook.TabIndex = 6;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // lblMovieTitle
            // 
            lblMovieTitle.AutoSize = true;
            lblMovieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieTitle.Location = new Point(10, 100);
            lblMovieTitle.Name = "lblMovieTitle";
            lblMovieTitle.Size = new Size(0, 20);
            lblMovieTitle.TabIndex = 7;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(10, 136);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(291, 377);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 8;
            pictureBox.TabStop = false;
            // 
            // BookingForm
            // 
            ClientSize = new Size(313, 560);
            Controls.Add(lblMovieTitle);
            Controls.Add(btnBook);
            Controls.Add(txtSeatNumber);
            Controls.Add(lblSeatNumber);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtCustomerName);
            Controls.Add(lblCustomerName);
            Controls.Add(pictureBox);
            Name = "BookingForm";
            Text = "Booking Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSeatNumber;
        private System.Windows.Forms.TextBox txtSeatNumber;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label lblMovieTitle;
    }
}