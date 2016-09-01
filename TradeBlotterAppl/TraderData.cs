using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TradeBlotterAppl
{

    [DataContract]
    public class TraderData
    {
        [DataMember]
        public int traderId { get; set; }
        [DataMember]
        public string scratchPad { get; set; }
        [DataMember]
        public string userName { get; set; }
        [DataMember]
        public string firstName { get; set; }
        [DataMember]
        public string lastName { get; set; }

        public TraderData(int traderId, string scratchPad, string userName, string firstName, string lastName)
        {
            this.traderId = traderId;
            this.scratchPad = scratchPad;
            this.userName = userName;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public override string ToString()
        {
            return traderId + " " + scratchPad + " " + userName + " " + firstName + " " + lastName;
        }


    }
}

