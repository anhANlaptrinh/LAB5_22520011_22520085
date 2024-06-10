namespace Lab5
{
    partial class Read
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
            this.From = new System.Windows.Forms.Label();
            this.Mail = new System.Windows.Forms.Label();
            this.To = new System.Windows.Forms.Label();
            this.Mailto = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Location = new System.Drawing.Point(21, 17);
            this.From.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(30, 13);
            this.From.TabIndex = 0;
            this.From.Text = "From";
            // 
            // Mail
            // 
            this.Mail.AutoSize = true;
            this.Mail.Location = new System.Drawing.Point(77, 17);
            this.Mail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(26, 13);
            this.Mail.TabIndex = 1;
            this.Mail.Text = "Mail";
            // 
            // To
            // 
            this.To.AutoSize = true;
            this.To.Location = new System.Drawing.Point(21, 41);
            this.To.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(20, 13);
            this.To.TabIndex = 2;
            this.To.Text = "To";
            // 
            // Mailto
            // 
            this.Mailto.AutoSize = true;
            this.Mailto.Location = new System.Drawing.Point(77, 41);
            this.Mailto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Mailto.Name = "Mailto";
            this.Mailto.Size = new System.Drawing.Size(42, 13);
            this.Mailto.TabIndex = 3;
            this.Mailto.Text = "Mail To";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(21, 66);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(27, 13);
            this.Title.TabIndex = 4;
            this.Title.Text = "Title";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(24, 92);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(13, 13);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(345, 239);
            this.webBrowser1.TabIndex = 5;
            // 
            // Read
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 342);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Mailto);
            this.Controls.Add(this.To);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.From);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Read";
            this.Text = "Read";
            this.Load += new System.EventHandler(this.Read_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label From;
        private System.Windows.Forms.Label Mail;
        private System.Windows.Forms.Label To;
        private System.Windows.Forms.Label Mailto;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}