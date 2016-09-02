using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
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
    /// Interaction logic for noteWindow.xaml
    /// </summary>
    public partial class noteWindow : Window
    {
        public noteWindow(string name)
        {
            InitializeComponent();
            this.username = name;
        }
        string newNote;
        string userName;
        public string username;
        private void postingNote(object sender, RoutedEventArgs e)
        {
            newNote = txtNotes.Text;
            
            var client = new WebClient();
            using (client)
            {
                var values = new NameValueCollection();
                values["noteText"] = newNote;
                values["userName"] = this.username;
                var res = client.UploadValues("http://10.87.226.147:8080/TeamOneTradeBlotterFinalWeb/rest/notes/create", values);
                var str = Encoding.Default.GetString(res);

            }
        }
    }
}
