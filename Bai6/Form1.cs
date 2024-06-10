using Lab5;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab5
{
    public partial class LAB05_bai06 : Form
    {
        private ImapClient client;
        public LAB05_bai06()
        {
            InitializeComponent();
            client = new ImapClient();
            InitializeListView();
        }
        private void InitializeListView()
        {
            // Set the view to show details
            listView1.View = View.Details;

            // Allow the user to edit item text
            listView1.LabelEdit = true;

            // Allow the user to rearrange columns
            listView1.AllowColumnReorder = true;

            // Select the item and subitems when selection is made
            listView1.FullRowSelect = true;

            // Display grid lines
            listView1.GridLines = true;

            // Sort the items in the list in ascending order
            listView1.Sorting = SortOrder.Ascending;

            // Create columns for the items and subitems
            listView1.Columns.Add("Email", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("From", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Date", 150, HorizontalAlignment.Left);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Send sendMail = new Send(txtEmail.Text, txtPass.Text, txtSmtp.Text, txtSmtpport.Text);
            sendMail.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadEmails();
        }
        private void LoadEmails()
        {
            listView1.Clear();

            listView1.Columns.Add("Email", 398);
            listView1.Columns.Add("From", 200);
            listView1.Columns.Add("Date", 150);

            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);

            int numberOfEmailsToLoad = 20;

            for (int i = 0; i < numberOfEmailsToLoad; i++)
            {
                var message = inbox.GetMessage(i + 1);

                var item = new ListViewItem(new[] { message.Subject, message.From.ToString(), message.Date.ToString(), message.HtmlBody });

                listView1.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Đăng xuất")
            {
                DisconnectFromServer();
            }
            else
            {
                ConnectToServer();
            }
        }
        private void DisconnectFromServer()
        {

            try
            {

                if (client.IsConnected)
                {

                    client.Disconnect(true);
                    MessageBox.Show("Đã đăng xuất");
                }
                else
                {
                    MessageBox.Show("Không có kết nối đến server");

                }
                ResetLoginForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);

            }
        }
        private void ResetLoginForm()
        {
            txtEmail.ReadOnly = false;
            txtPass.ReadOnly = false;
            txtImap.ReadOnly = false;
            txtImapport.ReadOnly = false;
            txtSmtpport.ReadOnly = false;
            txtSmtp.ReadOnly = false;
            button2.Enabled = false;
            button1.Enabled = false;
            txtEmail.Clear();
            txtPass.Clear();
            txtImap.Clear();
            txtImapport.Clear();
            txtSmtpport.Clear();
            txtSmtp.Clear();
        }
        private void ConnectToServer()
        {
            // Kiểm tra xem trường IMAP đã được nhập hay chưa. Nếu chưa, đặt giá trị mặc định là "imap.gmail.com".
            if (string.IsNullOrEmpty(txtImap.Text))
            {
                txtImap.Text = "imap.gmail.com";
            }

            // Kiểm tra xem trường cổng IMAP đã được nhập hay chưa. Nếu chưa, đặt giá trị mặc định là "993".
            if (string.IsNullOrEmpty(txtImapport.Text))
            {
                txtImapport.Text = "993";
            }

            // Kiểm tra xem trường SMTP đã được nhập hay chưa. Nếu chưa, đặt giá trị mặc định là "smtp.gmail.com".
            if (string.IsNullOrEmpty(txtSmtp.Text))
            {
                txtSmtp.Text = "smtp.gmail.com";
            }

            // Kiểm tra xem trường cổng SMTP đã được nhập hay chưa. Nếu chưa, đặt giá trị mặc định là "465".
            if (string.IsNullOrEmpty(txtSmtpport.Text))
            {
                txtSmtpport.Text = "465";
            }

            try
            {
                client.Connect(txtImap.Text, int.Parse(txtImapport.Text), true);
                client.Authenticate(txtEmail.Text, txtPass.Text);
                LoadEmails();
                EnableControlsAfterLogin();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu không thể kết nối với máy chủ.
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EnableControlsAfterLogin()
        {
            txtEmail.ReadOnly = true;
            txtPass.ReadOnly = true;

            txtImap.ReadOnly = true;
            txtImapport.ReadOnly = true;

            txtSmtpport.ReadOnly = true;
            txtSmtp.ReadOnly = true;

            button2.Enabled = true;
            button1.Enabled = true;

            button3.Text = "Đăng xuất";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string subject = selectedItem.SubItems[0].Text;
                string from = selectedItem.SubItems[1].Text;
                string emailContent = selectedItem.SubItems[3].Text;

                Read readForm = new Read(from, txtEmail.Text, subject, emailContent);
                readForm.Show();
            }
        }
    }
}
