using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab5
{
    partial class ProgressBarWithLabel
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
            progressBar = new ProgressBar();
            label = new Label();
            pictureBox = new PictureBox();
            label1 = new Label();
            btnShowDetails = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Location = new Point(3, 3);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(294, 23);
            progressBar.TabIndex = 0;
            progressBar.Click += ProgressBar_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(3, 29);
            label.Name = "label";
            label.Size = new Size(38, 15);
            label.TabIndex = 1;
            label.Text = "label1";
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(3, 89);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(375, 479);
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 57);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // btnShowDetails
            // 
            btnShowDetails.Location = new Point(303, 3);
            btnShowDetails.Name = "btnShowDetails";
            btnShowDetails.Size = new Size(75, 23);
            btnShowDetails.TabIndex = 4;
            btnShowDetails.Text = "Show Details";
            btnShowDetails.UseVisualStyleBackColor = true;
            btnShowDetails.Click += BtnShowDetails_Click;
            // 
            // ProgressBarWithLabel
            // 
            Controls.Add(btnShowDetails);
            Controls.Add(label1);
            Controls.Add(pictureBox);
            Controls.Add(label);
            Controls.Add(progressBar);
            Name = "ProgressBarWithLabel";
            Size = new Size(384, 582);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowDetails;
    }
}
