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
    /// Interaction logic for SignUpWindow.xaml
    /// </summary>
    public partial class SignUpWindow : Window
    {
        public SignUpWindow()
        {
            InitializeComponent();
        }

        private void confrimSignUp(object sender, RoutedEventArgs e)
        {
            string newUsername = txtNewUserName.Text;
            string newPassword = txtNewPassword.Password;
            var client = new WebClient();
            client.Proxy = null;
            using (client)
            {
                var values = new NameValueCollection();
                
                values["userName"] = newUsername;
                values["password"] = newPassword;
                values["firstName"] = newUsername;
                values["lastName"] = newUsername;
                var res = client.UploadValues("http://10.87.226.147:8080/TeamOneTradeBlotterFinalWeb/rest/traders/registersecure", values);
            }
            this.Close();
         }
    }
}
