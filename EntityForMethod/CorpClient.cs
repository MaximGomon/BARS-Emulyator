using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using BARS_Emulyator.EntityForMethod;

namespace BARS_Emulyator.Entity
{
     [DataContract]
    public class CorpClient: BaseEntity
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
        public string ClientTypeCode;
        
        [DataMember]
        public string ClientName;
        
        [DataMember]
        public string Inn_Edrpou;
        
        [DataMember]
        public string UserLogin;
        
        [DataMember]
        public string UserFio;
        
        [DataMember]
        public string ActualizeDate;
        
        [DataMember]
        public string ActualizeBy;
        
        //[DataMember]
        //public string ThirdPerson;
         
        [DataMember]
        public List<LinkedPerson> LinkedPersons = new List<LinkedPerson>();

        [DataMember]
        public List<NoClient> NoClients = new List<NoClient>(); 

        public CorpClient()
        {
            
        }

        public CorpClient(string branchCode, DateTime changeDate, DateTime createDate,
                        string clientTypeCode, /*DateTime actualizeDate,*/
                        string userLogin, string userFio, List<LinkedPerson> linkedPersons, List<NoClient> noClients )
        {
            IFormatProvider theCultureInfo = CultureInfo.InvariantCulture;
            
            BranchCode = branchCode;
            ChangeDate = changeDate.ToString(theCultureInfo);
            CreateDate = createDate.ToString(theCultureInfo);
            //ActualizeDate = actualizeDate.ToString(theCultureInfo);
            ClientTypeCode = clientTypeCode;
            UserLogin = userLogin;
            UserFio = userFio;
            LinkedPersons = linkedPersons;
            NoClients = noClients;
        }
    }
}
