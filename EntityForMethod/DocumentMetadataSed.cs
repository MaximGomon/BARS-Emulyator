using System.Runtime.Serialization;
using BARS_Emulyator.Entity;

namespace BARS_Emulyator.EntityForMethod
{
    [DataContract]
    public class DocumentMetadataSed : BaseEntity
    {
        [DataMember]
        public string Rnk;

        [DataMember]
        public string IDs_Version;

        [DataMember]
        public string StatusCode;

    }
}
