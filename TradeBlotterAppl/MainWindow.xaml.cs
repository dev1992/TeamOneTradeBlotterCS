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
        string urlFilter;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ReadAPI(object sender, RoutedEventArgs e)
        {
            WebClient webClient = new WebClient();
            Stream data = webClient.OpenRead("http://10.87.239.26:8080/TeamOneTradeBlotterFinalWeb/rest/trades");
            //Stream data = webClient.OpenRead("http://10.87.239.26:8080/TeamOneTradeBlotterFinalWeb/rest/trades/filterbytype?productType=FX");
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(TradeData[]));
            TradeData[] other = (TradeData[])serializer.ReadObject(data);
            string msg = "";
            foreach (TradeData acc in other)
            {
                msg += acc.ToString() +System.Environment.NewLine;

            }
            dataTrade.ItemsSource = other;
        }

        private void filterTradeBlotter(object sender, RoutedEventArgs e)
        {
            FilterWindow filterWindow = new FilterWindow();
            //naam = txtUserName.Text;
            //userLog.lstUserName.Items.Add(naam);
            bool? result1 = filterWindow.ShowDialog();
            if (result1==true)
            {
                MessageBox.Show(filterWindow.urlReturn().ToString());
                WebClient webClient = new WebClient();
                Stream data = webClient.OpenRead(filterWindow.urlReturn().ToString());
                //Stream data = webClient.OpenRead("http://10.87.239.26:8080/TeamOneTradeBlotterFinalWeb/rest/trades/filterbytype?productType=fx");
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(TradeData[]));
                TradeData[] other = (TradeData[])serializer.ReadObject(data);
                string msg = "";
                foreach (TradeData acc in other)
                {
                    msg += acc.ToString() +  System.Environment.NewLine;

                }
                dataTrade.Items.Refresh();
                dataTrade.ItemsSource = other;
            }
            else
            {

            }
            
        }
    }
}
