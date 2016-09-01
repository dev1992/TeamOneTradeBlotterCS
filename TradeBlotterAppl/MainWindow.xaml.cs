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

using System.Collections;
using System.ComponentModel;

namespace TradeBlotterAppl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string urlFilter;
        private readonly PagingCollectionView _cview;

        public MainWindow()
        {
            InitializeComponent();

            // -------------------------

            WebClient webClient = new WebClient();
            webClient.Proxy = null;
            Stream data = webClient.OpenRead("http://10.87.231.72:8080/TeamOneTradeBlotterFinalWeb/rest/trades");
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(TradeData[]));
            TradeData[] other = (TradeData[])serializer.ReadObject(data);


            // ---------------------------


            this._cview = new PagingCollectionView(
                other,
                15
            );
            this.DataContext = this._cview;
        }

        private void OnNextClicked(object sender, RoutedEventArgs e)
        {
            this._cview.MoveToNextPage();
        }

        private void OnPreviousClicked(object sender, RoutedEventArgs e)
        {
            this._cview.MoveToPreviousPage();
        }

        private void filterEvent(object sender, RoutedEventArgs e)
        {
            FilterWindow filterWindow = new FilterWindow();
            
            bool? result1 = filterWindow.ShowDialog();
            if (result1 == true)
            {
                //MessageBox.Show(filterWindow.urlReturn().ToString());
                WebClient webClient = new WebClient();
                Stream data = webClient.OpenRead(filterWindow.urlReturn().ToString());
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(TradeData[]));
                TradeData[] other = (TradeData[])serializer.ReadObject(data);

                FilteredResult filteredWindowResult = new FilteredResult(other);
                bool? result2 = filteredWindowResult.ShowDialog();
            }
            else
            {

            }

        }

        private void ToUserWindow(object sender, RoutedEventArgs e)
        {

                WebClient webClient = new WebClient();
                webClient.Proxy = null;

                Stream data = webClient.OpenRead("http://10.87.231.72:8080/TeamOneTradeBlotterFinalWeb/rest/trades/filterbyuser?userName=user2");

                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(TradeData[]));

                TradeData[] other = (TradeData[])serializer.ReadObject(data);
                UserSpecificWindow userwindow = new UserSpecificWindow(other);
                bool? result2 = userwindow.ShowDialog();

        }

        private void toMessageWindow(object sender, RoutedEventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.Proxy = null;

            Stream data = webClient.OpenRead("http://10.87.231.72:8080/TeamOneTradeBlotterFinalWeb/rest/messages/bytopic?productType=fx");

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(MessageData[]));

            MessageData[] other = (MessageData[])serializer.ReadObject(data);
            
            MessageWindow userwindow = new MessageWindow(other);
            bool? result = userwindow.ShowDialog();
        }

        private void toEmailWindow(object sender, RoutedEventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.Proxy = null;

            Stream data = webClient.OpenRead("http://10.87.231.72:8080/TeamOneTradeBlotterFinalWeb/rest/mails/ofuser?userName=user1");

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(EmailData[]));

            EmailData[] other = (EmailData[])serializer.ReadObject(data);
            EmailWindow userwindow = new EmailWindow(other);
            bool? result = userwindow.ShowDialog();
        }

        private void getResultsByDateFilter(object sender, RoutedEventArgs e)
        {
            DateTime? sDate = startDate.SelectedDate;
            DateTime? eDate = endDate.SelectedDate;
            string dateStr1 = sDate.ToString();
            string[] words1 = dateStr1.Split(' ');
            string[] splits1 = words1[0].Split('/');

            string dateStr2 = eDate.ToString();
            string[] words2 = dateStr2.Split(' ');
            string[] splits2 = words2[0].Split('/');

            string query = "startDate=" +splits1[2] + "-" + splits1[1] + "-" + splits1[0] + "&endDate=" + splits2[2] + "-" + splits2[1] + "-" + splits2[0];
            MessageBox.Show(query);

            WebClient webClient = new WebClient();
            webClient.Proxy = null;

            Stream data = webClient.OpenRead("http://10.87.231.72:8080/TeamOneTradeBlotterFinalWeb/rest/trades/filterbydate?"+query);

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(TradeData[]));

            TradeData[] other = (TradeData[])serializer.ReadObject(data);
            DateWindow userwindow = new DateWindow(other);
            bool? result = userwindow.ShowDialog();
        }
    }

    // =============== Page Class

    public class PagingCollectionView : CollectionView
    {
        private readonly IList _innerList;
        private readonly int _itemsPerPage;

        private int _currentPage = 1;

        public PagingCollectionView(IList innerList, int itemsPerPage)
            : base(innerList)
        {
            this._innerList = innerList;
            this._itemsPerPage = itemsPerPage;
        }

        public override int Count
        {
            get
            {
                if (this._innerList.Count == 0) return 0;
                if (this._currentPage < this.PageCount) // page 1..n-1
                {
                    return this._itemsPerPage;
                }
                else // page n
                {
                    var itemsLeft = this._innerList.Count % this._itemsPerPage;
                    if (0 == itemsLeft)
                    {
                        return this._itemsPerPage; // exactly itemsPerPage left
                    }
                    else
                    {
                        // return the remaining items
                        return itemsLeft;
                    }
                }
            }
        }

        public int CurrentPage
        {
            get { return this._currentPage; }
            set
            {
                this._currentPage = value;
                this.OnPropertyChanged(new PropertyChangedEventArgs("CurrentPage"));
            }
        }

        public int ItemsPerPage { get { return this._itemsPerPage; } }

        public int PageCount
        {
            get
            {
                return (this._innerList.Count + this._itemsPerPage - 1)
                    / this._itemsPerPage;
            }
        }

        private int EndIndex
        {
            get
            {
                var end = this._currentPage * this._itemsPerPage - 1;
                return (end > this._innerList.Count) ? this._innerList.Count : end;
            }
        }

        private int StartIndex
        {
            get { return (this._currentPage - 1) * this._itemsPerPage; }
        }

        public override object GetItemAt(int index)
        {
            var offset = index % (this._itemsPerPage);
            return this._innerList[this.StartIndex + offset];
        }

        public void MoveToNextPage()
        {
            if (this._currentPage < this.PageCount)
            {
                this.CurrentPage += 1;
            }
            this.Refresh();
        }

        public void MoveToPreviousPage()
        {
            if (this._currentPage > 1)
            {
                this.CurrentPage -= 1;
            }
            this.Refresh();
        }
    }
}
