using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Net;

namespace TradeBlotterAppl
{
    [DataContract]
    public class EmailData
    {
        [DataMember]
        public int mailId { get; set; }
        
        public string CreatorName {
            get { return GetTraderByID(traders_traderId); } }
        [DataMember]
        public int traders_traderId { get; set; }
        [DataMember]
        public int receiverId { get; set; }
        [DataMember]
        public string mailBody { get; set; }


        public EmailData(int mailId, int traders_traderId, int receiverId, string mailBody)
        {
            this.mailId = mailId;
            this.traders_traderId = traders_traderId;
            this.receiverId = receiverId;
            this.mailBody = this.mailBody;
        }



        public override string ToString()
        {
            return mailId + " " + traders_traderId + " " + receiverId + mailBody;
        }

        public string GetTraderByID(int creatorId)
        {
            WebClient webClient = new WebClient();
            webClient.Proxy = null;
            Stream data = webClient.OpenRead("http://10.87.231.72:8080/TeamOneTradeBlotterFinalWeb/rest/traders/getTrader?userId="+creatorId.ToString());
            
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(TraderData[]));
            TraderData[] other = (TraderData[])serializer.ReadObject(data);
            
            string userName = other[0].userName.ToString();
            
            return userName;
        }


    }

    public class foo
    {
        string a { get; set; }
    }
}
