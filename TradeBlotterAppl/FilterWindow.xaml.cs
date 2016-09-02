using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TradeBlotterAppl
{
    /// <summary>
    /// Interaction logic for FilterWindow.xaml
    /// </summary>
    public partial class FilterWindow : Window
    {
        String[] FilterType = new string[10];
        public string username;

        public FilterWindow()
        {
            InitializeComponent();
        }
        public string urlReturn()
        {
            return urlFilter;
        }
        public  string urlFilter;

        private void filterBlotter(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            string filterValue;
            switch (comboFilterName.SelectedIndex)
            { 
                case 0:
                    filterValue = txtFurtherFilter.Text;
                    //var client = new WebClient();
                    urlFilter = "http://10.87.226.147:8080/TeamOneTradeBlotterFinalWeb/rest/trades/filterbytype?" + "productType=" + filterValue;
                    //var response = client.DownloadString(urlFilter);
                    break;
                case 1:
                    filterValue = txtFurtherFilter.Text;
                    //var client = new WebClient();
                    urlFilter = "http://10.87.226.147:8080/TeamOneTradeBlotterFinalWeb/rest/trades/filterbyname?" + "productName=" + filterValue;
                    //var response = client.DownloadString(urlFilter);
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    break;
            }

            
    }

        private void whenLoaded(object sender, RoutedEventArgs e)
        {
            FilterType[0] = "Product Type";
            FilterType[1] = "Product Name";
            FilterType[2] = "Price";
            FilterType[3] = "Trader ID";
            FilterType[4] = "Quantity";
            FilterType[5] = "Currency";
            FilterType[6] = "Date";
            comboFilterName.ItemsSource = FilterType;
            comboFilterName.SelectedIndex = 0;
        }

        private void cancelEvent(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
