using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using BARS_Emulyator.Entity;

namespace BARS_Emulyator.EntityForMethod
{
    [DataContract]
    public class DictionaryDataSed : BaseEntity
    {
        [DataMember] 
        public string DictionaryId;
    }
}
