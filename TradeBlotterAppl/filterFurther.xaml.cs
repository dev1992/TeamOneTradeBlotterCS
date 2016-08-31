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
    /// Interaction logic for filterFurther.xaml
    /// </summary>
    public partial class filterFurther : Window
    {
        public filterFurther()
        {
            InitializeComponent();
        }

        private void returnTo(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
