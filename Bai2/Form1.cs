using MailKit.Net.Imap;
using MailKit;
using MailKit.Net.Smtp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MailKit.Net.Imap.ImapMailboxFilter;
using MimeKit;
using System.Net.Mail;

namespace Lab5
{
    public partial class LAB05_bai02 : Form
    {

        public LAB05_bai02()
        {
            InitializeComponent();
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
            listView1.Columns.Add("From", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Date", 100, HorizontalAlignment.Left);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Kết nối đến máy chủ IMAP của Gmail qua cổng 993 và sử dụng SSL (true)
            ImapClient imapClient = new ImapClient();
            imapClient.Connect("imap.gmail.com", 993, true);

            try
            {
                // Xác thực tài khoản Gmail
                imapClient.Authenticate(textBox1.Text, textBox2.Text);

                // Mở hộp thư đến
                var inbox = imapClient.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                // Lấy thông tin về 10 email mới nhất và hiển thị lên listView
                for (int i = 0; i < 10; i++)
                {
                    var message = inbox.GetMessage(i);

                    string[] row = { message.Subject, message.From.ToString(), message.Date.ToString() };
                    listView1.Items.Add(new ListViewItem(row));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
        }
    }
}
