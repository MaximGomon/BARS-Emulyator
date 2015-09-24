using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace BARS_Emulyator.Entity
{
     [DataContract]
    class Account: BaseEntity
    {
        [DataMember]
        public string Rnk;

        [DataMember]
        public string ChangeDate;

        [DataMember]
        public string CreateDate;

        [DataMember]
        public string UserLogin;

        [DataMember]
        public string UserFio;

        [DataMember]
        public string AccountNumber;

        [DataMember]
        public string CurrencyCode;

        [DataMember]
        public string Mfo;

        [DataMember]
        public string BranchCode;

        [DataMember]
        public string OpenDate;

        [DataMember]
        public string CloseDate;

        [DataMember]
        public string AgrNumber;

        [DataMember]
        public string AgrCode;

        [DataMember]
        public string AccountTypeCode;

        [DataMember]
        public string AccountStatusCode;


        public Account()
        {
            
        }

        public Account(DateTime changeDate, DateTime createDate, DateTime openDate, 
            string branchCode, string userLogin, 
            string userFio, string accountTypeCode, string currencyCode, string accountStatusCode)
        {
            
            IFormatProvider theCultureInfo = CultureInfo.InvariantCulture;

            ChangeDate = changeDate.ToString(theCultureInfo);
            CreateDate = createDate.ToString(theCultureInfo);
            BranchCode = branchCode;
            UserLogin = userLogin;
            UserFio = userFio;
            AccountTypeCode = accountTypeCode;
            CurrencyCode = currencyCode;
            AccountStatusCode = accountStatusCode;
            OpenDate = openDate.ToString(theCultureInfo);

            //CloseDate = closeDate != new DateTime() ? closeDate.ToString(theCultureInfo) : null;
        }
    }
}
