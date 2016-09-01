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
    public class EmailData
    {

        [DataMember]
        public int mailId { get; set; }
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


    }
}
