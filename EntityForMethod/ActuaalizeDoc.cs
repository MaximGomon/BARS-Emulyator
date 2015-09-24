using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace BARS_Emulyator.Entity
{
     [DataContract]
    public class ActuaalizeDoc : BaseEntity
    {
        [DataMember]
        public string BranchCode;

        [DataMember]
        public string Rnk;

        [DataMember]
        public string UserLogin;

        [DataMember]
        public string UserFio;

        [DataMember]
        public string ActDate;

        public ActuaalizeDoc()
        {
            
        }

        public ActuaalizeDoc(string branchCode, string userLogin, string userFio, DateTime actDate)
        {
            IFormatProvider theCultureInfo = CultureInfo.InvariantCulture;

            BranchCode = branchCode;
            UserFio = userFio;
            UserLogin = userLogin;
            ActDate = actDate.ToString(theCultureInfo);
        }
    }
}
