using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TradeBlotterAppl
{
    [DataContract]
    class Notes
    {
        [DataMember]
        public int noteId {
            get; set; }
        [DataMember]
        public string noteText { get; set; }
        public Notes(int noteId,string noteText)
        {
            this.noteId = noteId;
            this.noteText = noteText;
        }
        public override string ToString()
        {
            return noteId+" "+noteText;
        }
    }
}
