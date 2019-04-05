using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace appWeb
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            webBrowser.Navigate("https://login.microsoftonline.com");


        }
        mshtml.HTMLDocument htmldoc;

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            htmldoc = webBrowser.Document as mshtml.HTMLDocument;
            htmldoc.getElementById("i0116").innerText = "mariem.kraiem@supinfo.com";
            htmldoc.getElementById("idSIButton9").click();



        }
    }
}
