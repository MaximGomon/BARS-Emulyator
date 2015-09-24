using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace BARS_Emulyator.Entity
{
     [DataContract]
    public class DocumentBinary: BaseEntity
    {

        [DataMember]
        public string ExternalId;

        [DataMember]
        public string Rnk;

        [DataMember]
        public string AgrCode;

        [DataMember]
        public string TypeCode; 

        public DocumentBinary()
        {
            
        }
    }
}
