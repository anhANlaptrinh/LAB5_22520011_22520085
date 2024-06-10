using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MimeKit;
using System.Xml.Linq;
using MailKit.Net.Smtp;
using System.Net.Mail;
namespace Lab5
{
    public partial class Send : Form
    {
        private string userEmail;
        private string userPassword;
        private string smtpServer;
        private string smtpPort;
        public Send(string email, string password, string smtpServer, string smtpPort)
        {
            InitializeComponent();
            this.userEmail = email;
            this.userPassword = password;
            this.smtpServer = smtpServer;
            this.smtpPort = smtpPort;
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;

            // Lọc file (Filter = "All Files (*.*)|*.*")
            openFileDialog.Filter = "All Files (*.*)|*.*";

            // Hiển thị hộp thoại chọn file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn file được chọn
                string filePath = openFileDialog.FileName;

                // Hiển thị đường dẫn file trong textbox
                txtFile.Text = filePath;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new MailKit.Net.Smtp.SmtpClient();
                client.Connect(smtpServer, int.Parse(smtpPort), true);
                client.Authenticate(userEmail, userPassword);
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(txtName.Text, txtFrom.Text));
                message.To.Add(new MailboxAddress("", txtTo.Text));
                message.Subject = txtSubject.Text.Trim();
                message.Body = new TextPart();

                var bodyBuilder = new BodyBuilder();

                if (checkBoxHtml.Checked == true)
                {
                    bodyBuilder.HtmlBody = richTextBox1.Text;
                }
                else
                {
                    bodyBuilder.TextBody = richTextBox1.Text;
                }

                string filePath = txtFile.Text;

                if (!string.IsNullOrEmpty(filePath))
                {
                    bodyBuilder.Attachments.Add(filePath);
                }

                message.Body = bodyBuilder.ToMessageBody();
                client.Send(message);
                MessageBox.Show("Email sent successfully.", "Success", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message);
            }
        }
    }
}
