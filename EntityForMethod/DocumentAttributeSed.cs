using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using BARS_Emulyator.Entity;

namespace BARS_Emulyator.EntityForMethod
{
    [DataContract]
    public class DocumentAttributeSed : BaseEntity
    {
        [DataMember] 
        public string UserLogin;

        [DataMember] 
        public string UserFullName;

        //[DataMember] 
        //public string BranchCode;

        [DataMember] 
        public string ModifyDateTime;

        [DataMember]
        public List<SedDocument> Documents = new List<SedDocument>();
    }

    [DataContract]
    public class SedDocument
    {
        [DataMember]
        public Guid Id;

        [DataMember]
        public string Version;

        [DataMember]
        public List<SedDocumentProperties> PropertiesCollection = new List<SedDocumentProperties>();

        [DataContract]
        public class SedDocumentProperties
        {
            [DataMember]
            public DocumentProperties Name;

            [DataMember]
            public string Code;
        }
    }

    [DataContract]
    public enum DocumentProperties
    {
        Status,
        Location
    }
}
