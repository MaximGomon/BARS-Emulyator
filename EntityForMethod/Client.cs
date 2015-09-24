using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace BARS_Emulyator.Entity
{
    [DataContract]
    public class Client : BaseEntity
    {
        [DataMember]
        public string BranchCode;   
        [DataMember]
        public string Rnk;
        [DataMember]
        public string ChangeDate;
        [DataMember]
        public string CreateDate;
        [DataMember]
        public string ClientFio;
        [DataMember]
        public string ClientTypeCode;
        [DataMember]
        public string Inn;
        [DataMember]
        public string BirthDate;
        [DataMember]
        public string DocSeries;
        [DataMember]
        public string DocNumber;
        [DataMember]
        public string UserLogin;
        [DataMember]
        public string UserFio;

        public Client()
        {
            
        }

        public Client(string branchCode, DateTime changeDate, DateTime createDate,
                        string clientTypeCode, DateTime birthDate, 
                        string userLogin, string userFio)
        {
            IFormatProvider theCultureInfo = CultureInfo.InvariantCulture;
            
            BranchCode = branchCode;
            ChangeDate = changeDate.ToString(theCultureInfo);
            CreateDate = createDate.ToString(theCultureInfo);
            ClientTypeCode = clientTypeCode;
            BirthDate = birthDate.ToString(theCultureInfo);
            UserLogin = userLogin;
            UserFio = userFio;
        }
    }
}
