using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassBoard
{
    public partial class AboutPage : Form
    {
        public AboutPage()
        {
            InitializeComponent();
            webBrowser1.Navigate(String.Format("{0}README.html", AppDomain.CurrentDomain.BaseDirectory));
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
