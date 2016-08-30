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
using System.Windows.Shapes;

namespace TradeBlotterAppl
{
    /// <summary>
    /// Interaction logic for FilterWindow.xaml
    /// </summary>
    public partial class FilterWindow : Window
    {
        String[] FilterType = new string[10];
        public FilterWindow()
        {
            InitializeComponent();
        }

        private void filterBlotter(object sender, RoutedEventArgs e)
        {
            //string itemToBeFiltered = comboFilterName.SelectedItem as string;
            MessageBox.Show(comboFilterName.SelectedItem.ToString());
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

        private void furtherClassification(object sender, RoutedEventArgs e)
        {
            switch (comboFilterName.SelectedIndex)
            {
                case 0:

                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    break;
            }
        }
    }
}
