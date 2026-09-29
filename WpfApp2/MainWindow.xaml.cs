using System;
using System.Windows;
using Microsoft.Web.WebView2.Core;

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Browser.Source =
                new Uri("https://www.google.com");
        }

        private void GoButton_Click(
            object sender,
            RoutedEventArgs e)
        {
            string address = AddressBox.Text;

            if (!address.StartsWith("http"))
            {
                address = "https://" + address;
            }

            Browser.Source = new Uri(address);
        }

        private void BackButton_Click(
            object sender,
            RoutedEventArgs e)
        {
            if (Browser.CanGoBack)
            {
                Browser.GoBack();
            }
        }

        private void ForwardButton_Click(
            object sender,
            RoutedEventArgs e)
        {
            if (Browser.CanGoForward)
            {
                Browser.GoForward();
            }
        }

        private void RefreshButton_Click(
            object sender,
            RoutedEventArgs e)
        {
            Browser.Reload();
        }

        private void HomeButton_Click(
            object sender,
            RoutedEventArgs e)
        {
            Browser.Source =
                new Uri("https://www.google.com");
        }

        private void Browser_SourceChanged(
            object sender,
            CoreWebView2SourceChangedEventArgs e)
        {
            AddressBox.Text = Browser.Source.ToString();
        }
    }
}