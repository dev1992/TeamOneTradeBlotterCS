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
    public class TradePK
    {
        [DataMember]
        public int tradeId { get; set; }
        [DataMember]
        public int traderId{ get; set; }

        public TradePK(int tradeId,int traderId)
        {
            this.tradeId = tradeId;
            this.traderId = traderId;
        }

        public override string ToString()
        {
            return tradeId + " " + traderId;
        }


    }
}
