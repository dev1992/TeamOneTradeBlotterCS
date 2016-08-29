using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace TradeBlotterAppl
{
    [DataContract]
    public class TradeData
    {
        [DataMember]
        public int tradeID { get; set; }
        [DataMember]
        public string productType { get; set; }
        [DataMember]
        public string productName { get; set; }
        [DataMember]
        public int traderID { get; set; }
        [DataMember]
        public int quantity { get; set; }
        [DataMember]
        public double price { get; set; }
        [DataMember]
        public bool side { get; set; }
        [DataMember]
        public string submitTime { get; set; }
        [DataMember]
        public string status { get; set; }
        [DataMember]
        public string currency { get; set; }
        [DataMember]
        public bool media { get; set; }
        [DataMember]
        public string executionTime { get; set; }
        [DataMember]
        public string buyerFirm { get; set; }
        [DataMember]
        public string sellerFirm { get; set; }  

        public TradeData(int tradeID, string productType, string productName, int traderID, int quantity, double price, bool side, string submitTime, string status, string currency, bool media, string executionTime, string buyerFirm, string sellerFirm)
        {
            this.tradeID = tradeID;
            this.productType = productType;
            this.productName = productName;
            this.traderID = traderID;
            this.quantity = quantity;
            this.price = price;
            this.side = side;
            this.submitTime = submitTime;
            this.status = status;
            this.currency = currency;
            this.media = media;
            this.executionTime = executionTime;
            this.buyerFirm = buyerFirm;
            this.sellerFirm = sellerFirm;
        }
        public override string ToString()
        {
            return tradeID + " " + productType + " " + productName + " " + productName + " " + traderID + " " + quantity + " " + price + " " + side + " " + submitTime + " " + status + " " + currency + " " + media + " " + executionTime + " " + buyerFirm + " " + sellerFirm;
        }


    }
}
