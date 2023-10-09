using Microsoft.Web.WebView2.Core;
using System.Windows.Controls;

namespace WPFNavigationTemplate.Views.Home
{
    /// <summary>
    /// Interaction logic for Report.xaml
    /// </summary>
    public partial class ReportView : UserControl
    {
        public ReportView()
        {
            InitializeComponent();
        }

        private void webView_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            webView.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = false;
            webView.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;

            webView.CoreWebView2.Settings.HiddenPdfToolbarItems =

                CoreWebView2PdfToolbarItems.Save |
                CoreWebView2PdfToolbarItems.SaveAs |
                CoreWebView2PdfToolbarItems.Print;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            webView.Dispose();
        }
    }
}
