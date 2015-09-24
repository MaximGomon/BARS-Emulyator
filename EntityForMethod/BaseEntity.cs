using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace BARS_Emulyator.Entity
{
     [DataContract]
    public class BaseEntity
    {

        [DataMember]
        public string Reply { get; set; }

        [DataMember]
        public bool Status { get; set; }

        [DataMember]
        public string MethodName { get; set; }

        //public int Key { get; set; }
    }
}
