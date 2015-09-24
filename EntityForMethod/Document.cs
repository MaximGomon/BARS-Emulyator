using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace BARS_Emulyator.Entity
{
     [DataContract]
    class Document : BaseEntity
    {
        [DataMember]
        public string ExternalId;

        [DataMember]
        public string Rnk;

        [DataMember]
        public string AgrId;

        [DataMember]
        public string UserLogin;

        [DataMember]
        public string UserFio;

        [DataMember]
        public string BranchCode;

        [DataMember]
        public string DocTypeCode;

        [DataMember]
        public string ChangeDate;

        [DataMember]
        public string CreateDate;

        [DataMember]
        public string LinkedRnk;

        [DataMember]
        public string PagesCount;

        [DataMember]
        public string FilePath;

        
        public Document()
        {
            
        }

        public Document(string userLogin, string userFio, string branchCode, DateTime changeDate, DateTime createDate)
        {
            IFormatProvider theCultureInfo = CultureInfo.InvariantCulture;

            UserLogin = userLogin;
            UserFio = userFio;
            BranchCode = branchCode;

            ChangeDate = changeDate.ToString(theCultureInfo);
            CreateDate = createDate.ToString(theCultureInfo);
        }
    }
}
