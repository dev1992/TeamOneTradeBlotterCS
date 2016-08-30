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
using System.Net;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace TradeBlotterAppl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ReadAPI(object sender, RoutedEventArgs e)
        {
            WebClient webClient = new WebClient();
            Stream data = webClient.OpenRead("http://10.87.239.26:8080/TeamOneTradeBlotterWeb/rest/trades");
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(TradeData[]));
            TradeData[] other = (TradeData[])serializer.ReadObject(data);
            string msg = "";
            foreach (TradeData acc in other)
            {
                msg += acc.ToString() + System.Environment.NewLine;

            }
            dataTrade.ItemsSource = other;
           /* LoginWindow login = new LoginWindow();
            string username = login.txtUserName.Text;
            lstUserName.Items.Add(username) ;*/
        }
    }
}
