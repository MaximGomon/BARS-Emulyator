using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using BARS_Emulyator.Entity;
using BARS_Emulyator.EntityForMethod;

namespace BARS_Emulyator
{
    [DataContract]
    public class History : ICloneable
    {

        //[DataMember]
        //public string SessionId {get; set;}

        [DataMember]
        public List<BaseEntity> HistoryList { get; set; }

        [DataMember]
        public BaseEntity CurrentItem { get; set; }

        public History()
        {
            HistoryList = new List<BaseEntity>();
            CurrentItem = new BaseEntity();
        }

        public static History LoadHistoryFromFile(string filePath)
        {
            History his = new History();

            Stream stream = null;
            XmlDictionaryReader xmlTextReader = null;

            try
            {
                if (File.Exists(filePath))
                {
                    stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    DataContractSerializer serializer = new DataContractSerializer(typeof(History), new[]
                    {
                        typeof (BaseEntity),
                        typeof (Document),
                        typeof (Account),
                        typeof (ActuaalizeDoc),
                        typeof (Agreement),
                        typeof (Client),
                        typeof (CorpAgreement),
                        typeof (CorpClient),
                        typeof (DocumentBinary),
                        typeof(LinkedPerson)
                    });
                    xmlTextReader = XmlDictionaryReader.CreateTextReader(stream, new XmlDictionaryReaderQuotas());

                    his = (History)serializer.ReadObject(xmlTextReader, true);

                    xmlTextReader.Close();
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
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
            
            return his;
        }

        public static bool SaveHistoryToFile(string filePath, History userHistory)
        {
            Stream stream = null;
            XmlTextWriter xmlTextWriter = null;
            bool successfull = false;
            try
            {
                stream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                DataContractSerializer serializer = new DataContractSerializer(typeof(History), new[]
                    {
                        typeof (BaseEntity),
                        typeof (Document),
                        typeof (Account),
                        typeof (ActuaalizeDoc),
                        typeof (Agreement),
                        typeof (Client),
                        typeof (CorpAgreement),
                        typeof (CorpClient),
                        typeof (DocumentBinary),
                        typeof(LinkedPerson)
                    });
                xmlTextWriter = new XmlTextWriter(stream, null) { Formatting = Formatting.Indented, Indentation = 4 };

                serializer.WriteObject(xmlTextWriter, userHistory);

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

        public object Clone()
        {
            History h = new History();

            if (h.CurrentItem != null)
            {
                h.CurrentItem.MethodName = this.CurrentItem.MethodName;
                h.CurrentItem.Reply = this.CurrentItem.Reply;
                h.CurrentItem.Status = this.CurrentItem.Status;
            }

            foreach (var entity in HistoryList)
            {
                h.HistoryList.Add(entity);
            }

            return h;
        }
    }
}
