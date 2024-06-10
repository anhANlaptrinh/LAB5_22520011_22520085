using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;

namespace Lab5
{
    public partial class LAB05_bai01 : Form
    {
        public LAB05_bai01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 465, true);

            // Xác thực tài khoản
            try
            {
                smtpClient.Authenticate(textBox1.Text, textBox2.Text);
                MimeMessage message = new MimeMessage();
                message.From.Add(new MailboxAddress("", textBox1.Text));
                message.To.Add(new MailboxAddress("", textBox3.Text));
                message.Subject = textBox4.Text;
                message.Body = new TextPart("plain")
                {
                    Text = richTextBox1.Text,
                };
                smtpClient.Send(message);
                MessageBox.Show("Bã gửi email");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
        }
    }
}
