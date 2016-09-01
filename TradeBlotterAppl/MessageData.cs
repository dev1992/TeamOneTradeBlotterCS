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
    public class MessageData
    {

        [DataMember]
        public int messageId { get; set; }
        [DataMember]
        public int traders_traderId { get; set; }
        [DataMember]
        public int subjects_subjectId { get; set; }
        [DataMember]
        public string messageBody { get; set; }


        public MessageData(int messagesId, int traders_traderId, int subjects_subjectId, string messageBody)
        {
            this.messageId = messagesId;
            this.traders_traderId = traders_traderId;
            this.subjects_subjectId = subjects_subjectId;
            this.messageBody = this.messageBody;
        }

        public override string ToString()
        {
            return messageId + " " + traders_traderId + " " + subjects_subjectId + messageBody;
        }


    }
}
