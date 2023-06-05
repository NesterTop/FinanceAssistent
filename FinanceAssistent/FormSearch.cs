using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceAssistent
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            //this.ChangeDisigne();
        }

        private void webView21_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            webView.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
        }
        private void CoreWebView2_NewWindowRequested(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs e)
        {
            e.NewWindow = webView.CoreWebView2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webView.Source = new Uri($"https://market.yandex.ru/search?text={textBox1.Text}&cvredirect=0&track=redirbarup");
        }

        private void FormSearch_SizeChanged(object sender, EventArgs e)
        {
            
        }
    }
}
