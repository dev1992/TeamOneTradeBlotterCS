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

        private bool side { get; set; }
        private bool media { get; set; }
        [DataMember]
        public int tradeId { get; set; }
        [DataMember]
        public string productType { get; set; }
        [DataMember]
        public string productName { get; set; }
        [DataMember]
        public int traders_traderId { get; set; }
        [DataMember]
        public int quantity { get; set; }
        [DataMember]
        public double price { get; set; }

        public enum TradeSide { Buy, Sell }
        //[DataMember]
        public TradeSide GetTradeSide
        {
            get
            {
                if (side == true)
                    return TradeSide.Sell;
                else
                    return TradeSide.Buy;
            }
        }
        public enum TradeMedia { Voice, Electronic }

        [DataMember]
        public string submitTime { get; set; }
        [DataMember]
        public string status { get; set; }
        [DataMember]
        public string currency { get; set; }
        //[DataMember]
        public TradeMedia GetTradeMedia
        {
            get
            {
                if (media == true)
                    return TradeMedia.Electronic;
                else
                    return TradeMedia.Voice;
            }
        }
        [DataMember]
        public string executionTime { get; set; }
        [DataMember]
        public string buyerFirm { get; set; }
        [DataMember]
        public string sellerFirm { get; set; }  

        public TradeData(int tradeID, string productType, string productName, int traderID, int quantity, double price, string submitTime, string status, string currency, string executionTime, string buyerFirm, string sellerFirm)
        {
            this.tradeId = tradeID;
            this.productType = productType;
            this.productName = productName;
            this.traders_traderId = traderID;
            this.quantity = quantity;
            this.price = price;
           
            //if (side == false)
            //    this.side = "BUY";
            //else
            //    this.side = "SELL";
            this.submitTime = submitTime;
            this.status = status;
            this.currency = currency;
           
            //if (media == false)
            //    this.media = "VOICE";
            //else
            //    this.media = "ELECTRONIC";
            this.executionTime = executionTime;
            this.buyerFirm = buyerFirm;
            this.sellerFirm = sellerFirm;
            
        }
      
        public override string ToString()
        {
            return tradeId + " " + productType + " " + productName + " " + productName + " " + traders_traderId + " " + quantity + " " + price + " " + " " + submitTime + " " + status + " " + currency + " " + " " + executionTime + " " + buyerFirm + " " + sellerFirm;
        }


    }
}
