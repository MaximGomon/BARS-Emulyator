using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace BARS_Emulyator.Entity
{
     [DataContract]
    public class CorpAgreement: BaseEntity
    {
        [DataMember]
        public string AgrCode;
       
        [DataMember]
        public string Rnk;
        
        [DataMember]
        public string ChangeDate;
        
        [DataMember]
        public string CreateDate;
        
        [DataMember]
        public string ClientTypeCode;
        
        [DataMember]
        public string BranchCode;
        
        [DataMember]
        public string UserLogin;
        
        [DataMember]
        public string UserFio;
        
        [DataMember]
        public string AgrTypeCode;

        [DataMember]
        public string AgrStatusCode;
        
        [DataMember]
        public string AgrNumber;
        
        [DataMember]
        public string AgrOpenDate;
        
        [DataMember]
        public string AgrCloseDate;

         
        public CorpAgreement()
        {
            
        }

        public CorpAgreement(DateTime changeDate, DateTime createDate, string branchCode, string userLogin,
            string userFio, string agrTypeCode, string agrStatusCode, string clientTypeCode, DateTime openDate)
        {
            IFormatProvider theCultureInfo = CultureInfo.InvariantCulture;

            ChangeDate = changeDate.ToString(theCultureInfo);
            CreateDate = createDate.ToString(theCultureInfo);
            BranchCode = branchCode;
            UserLogin = userLogin;
            UserFio = userFio;
            AgrTypeCode = agrTypeCode;
            AgrStatusCode = agrStatusCode;
            ClientTypeCode = clientTypeCode;
            AgrOpenDate = openDate.ToString(theCultureInfo);
        }
    }
}
