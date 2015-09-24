using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BARS_Emulyator
{
    [DataContract]
    public class Setting
    {

        public Setting()
        {
            MethodsName = new Dictionary<string, string>();
           // MethodsParams = new Dictionary<string, string>();
            CreateDate = DateTime.Now;
            ChangeDate = DateTime.Now;
            BirthDate = DateTime.Now;
            AccountOpenDate = DateTime.Now;
            AllBarsUrlList = new List<string>();
        }

        [DataMember]
        public string CurrentBarsUrl { get; set; }

        [DataMember]
        public List<string> AllBarsUrlList { get; set; }

        [DataMember]
        public string SessionId { get; set; }

        [DataMember]
        public Dictionary<string, string> MethodsName { get; set; }

        //[DataMember]
        //public Dictionary<string, string> MethodsParams { get; set; }

        [DataMember]
        public string UserLoginSs { get; set; }

        [DataMember]
        public string UserNameSs { get; set; }

        [DataMember]
        public string UserPasswordSs { get; set; }

        [DataMember]
        public string UserLoginOther { get; set; }

        [DataMember]
        public string UserNameOther { get; set; }

        [DataMember]
        public string UserBranchCodeOther { get; set; }

        [DataMember]
        public string BranchCode { get; set; }

        [DataMember]
        public string BranchName { get; set; }

        [DataMember]
        public string AgreementType { get; set; }

        [DataMember]
        public string AgreementStatus { get; set; }

        [DataMember]
        public DateTime CreateDate { get; set; }

        [DataMember]
        public DateTime ChangeDate { get; set; }

        [DataMember]
        public DateTime BirthDate { get; set; }

        [DataMember]
        public string ClientType { get; set; }

        [DataMember]
        public DateTime AccountOpenDate { get; set; }

        [DataMember]
        public string AccountTypeCode { get; set; }

        [DataMember]
        public string CurrencyCode { get; set; }

        [DataMember]
        public string AccountStatusCode { get; set; }

        [DataMember]
        public DateTime AgreementOpenDate { get; set; }

        #region Setting

        public static bool SaveSetting(Setting setParam)
        {
            string filepath = Directory.GetCurrentDirectory() + @"\setting.xml";
            Stream stream = null;
            XmlTextWriter xmlTextWriter = null;
            bool successfull = false;
            try
            {
                stream = new FileStream(filepath, FileMode.Create, FileAccess.Write);
                DataContractSerializer serializer = new DataContractSerializer(typeof(Setting), new Type[] { typeof (List<string>)});

                xmlTextWriter = new XmlTextWriter(stream, Encoding.UTF8) { Formatting = Formatting.Indented, Indentation = 4 };
                serializer.WriteObject(xmlTextWriter, setParam);
                xmlTextWriter.Close();
                stream.Close();
                successfull = true;
            }
            catch (Exception ex)
            {
                successfull = false;
            }
            finally
            {
                if (xmlTextWriter != null)
                {
                    xmlTextWriter.Close();
                }
                if (stream != null)
                {
                    stream.Close();
                }
            }
            return successfull;
        }

        public static Setting LoadSetting()
        {
            string path = Directory.GetCurrentDirectory() + @"\setting.xml";

            Setting setParam = new Setting();

            Stream stream = null;
            XmlDictionaryReader xmlTextReader = null;

            try
            {
                if (File.Exists(path))
                {
                    stream = new FileStream(path, FileMode.Open, FileAccess.Read);
                    DataContractSerializer serializer = new DataContractSerializer(typeof(Setting), new Type[] { typeof(List<string>) });
                    xmlTextReader = XmlDictionaryReader.CreateTextReader(stream, new XmlDictionaryReaderQuotas());
                    
                    setParam = (Setting)serializer.ReadObject(xmlTextReader, true);
                    
                    xmlTextReader.Close();
                    stream.Close();

                    //if (setParam.AccountOpenDate == DateTime.MinValue)
                    //{
                    //    setParam.AccountOpenDate = DateTime.Now;
                    //}

                    foreach (var item in setParam.GetType().GetProperties())
                    {
                        string dateTimeFullName = new DateTime().GetType().FullName;
                        
                        if (item.PropertyType.FullName == dateTimeFullName)
                        {
                            setParam.GetType().GetProperty(item.Name).SetValue(setParam, DateTime.Now, null);// = DateTime.Now;
                        }
                        
                    }
                    if (setParam.AllBarsUrlList == null)
                    {
                        setParam.AllBarsUrlList = new List<string>();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (xmlTextReader != null)
                {
                    xmlTextReader.Close();
                }
                if (stream != null)
                {
                    stream.Close();
                }
            }
            return setParam;
        }

        #endregion

    }
}
