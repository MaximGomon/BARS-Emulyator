using System.Runtime.Serialization;
using BARS_Emulyator.Entity;

namespace BARS_Emulyator.EntityForMethod
{
    [DataContract]
    public class ClientDataSed : BaseEntity
    {
        [DataMember]
        public string Rnk;
    }
}
