using Microsoft.Web.WebView2.WinForms;
using System;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Hienthi : Form
    {
        public Hienthi()
        {
            InitializeComponent();
        }

        public void Hienthiweb(string s)
        {
            string url = s;
            webView21.Source = new Uri(url);
        }
    }
}
