using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using BARS_Emulyator.EntityForMethod;

namespace BARS_Emulyator.Entity
{
     [DataContract]
    public class Agreement : BaseEntity
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
        public string AccountNumber;

        [DataMember]
        public string AgrCloseDate;

        [DataMember]
        public List<LinkedPerson> LinkedPersons = new List<LinkedPerson>(); 

        public Agreement()
        {
            
        }

        public Agreement(DateTime changeDate, DateTime createDate, string branchCode, string userLogin,
            string userFio, string agrTypeCode, string agrStatusCode, DateTime openDate, List<LinkedPerson> linkedPersons)
        {
            IFormatProvider theCultureInfo = CultureInfo.InvariantCulture;

            ChangeDate = changeDate.ToString(theCultureInfo);
            CreateDate = createDate.ToString(theCultureInfo);
            BranchCode = branchCode;
            UserLogin = userLogin;
            UserFio = userFio;
            AgrTypeCode = agrTypeCode;
            AgrStatusCode = agrStatusCode;
            AgrOpenDate = openDate.ToString(theCultureInfo);
            LinkedPersons = linkedPersons;
        }
    }
}
