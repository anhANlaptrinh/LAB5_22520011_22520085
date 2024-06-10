using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Read : Form
    {
        private string EmailContent;
        public Read(string From, string to, string title, string EmailContent)
        {
            InitializeComponent();
            Mail.Text = From;
            Mailto.Text = to;
            Title.Text = title;
            this.EmailContent = EmailContent;
        }
        private void Read_Load(object sender, EventArgs e)
        {
            webBrowser1.DocumentText = EmailContent;
        }
    }
}
