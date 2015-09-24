using System;
using System.IO;
using System.Runtime.Serialization.Json;
using BARS_Emulyator.Entity;
using BARS_Emulyator.EntityForMethod;

namespace BARS_Emulyator
{
    class MethodHelper
    {

        public static string StartSession(string userLogin, string userFio, string userPassword, string methodName)
        {
            string result = String.Empty;


            result += "{";
            result += String.Format("\"user_login\":\"{0}\",\"user_fio\":\"{1}\",\"user_password\":\"{2}\",\"method\":\"{3}\"," +
                                     "\"params\":null,\"message_id\":\"BARS-MESS-379351\"", userLogin, userFio, userPassword, methodName);
            result += "}";
            return result;
        }

        public static string CloseSession(string sessionId, string methodName)
        {
            string result = String.Empty;
            result += "{";
            result += String.Format("\"sessionid\":\"{0}\",\"method\":\"{1}\",\"params\":null,\"message_id\":\"BARS-MESS-379350\"", sessionId, methodName);
            result += "}";
            return result;
        }

        public static string SetDictionaryData(string sessionId, string methodName, Branch branch)
        {
            string result = String.Empty;
            result += "{";
            result += String.Format("\"sessionid\":\"{0}\",\"method\":\"{1}\",\"params\":[{{\"code\":\"{2}\",\"name\":\"{3}\",\"is_closed\":false,\"close_date\":null}}]," +
                                    "\"message_id\":\"BARS-MESS-15003\"", sessionId, methodName, branch.Code, branch.Name);

            result += "}";
            return result;
        }

        #region PhisicPerson

        public static string GetDocumentData(string sessionId, string methodName, DocumentBinary document)
        {
            string result = String.Empty;
            result += "{";
            result += String.Format("\"sessionid\":\"{0}\",\"method\":\"{1}\",\"params\":{{\"ID\":{2},\"RNK\":\"{3}\",\"agreement_id\":{4},\"struct_code\":{5}}}," +
                                    "\"message_id\":\"BARS-MESS-15003\"", sessionId, methodName, document.ExternalId, document.Rnk, document.AgrCode, document.TypeCode);

            result += "}";
            return result;
        }

        public static string SetDocumentDataWithOutBinary(string sessionId, string methodName, Document document)
        {
            string result = String.Empty;

            result += "{";
            result += String.Format("\"sessionid\":\"{0}\",\"method\":\"{1}\",\"params\":" +
                                    "[{{\"ID\":{2},\"RNK\":{3},\"agreement_id\":{4},\"doc_type\":\"doc\",\"user_login\":\"{5}\"," +
                                    "\"user_fio\":\"{6}\",\"branch_id\":\"{7}\",\"struct_code\":{8},\"changed\":\"{9}\"," +
                                    "\"created\":\"{10}\",\"pages_count\":{12},\"binary_data\":\"\",\"linkedrnk\":[{11}]}}],\"message_id\":\"BARS-MESS-379071\"",
                                    sessionId, methodName, document.ExternalId, document.Rnk, document.AgrId, document.UserLogin, document.UserFio,
                                    document.BranchCode, document.DocTypeCode, document.ChangeDate, document.CreateDate, document.LinkedRnk, document.PagesCount);
            result += "}";
            return result;
        }

        public static string SetDocumentDataWithBinary(string sessionId, string methodName, Document document, string base64Data)
        {
            string result = String.Empty;
            result += "{";
            result += String.Format("\"sessionid\":\"{0}\",\"method\":\"{1}\",\"params\":" +
                                    "[{{\"ID\":{2},\"RNK\":{3},\"agreement_id\":{4},\"doc_type\":\"scan\",\"user_login\":\"{5}\"," +
                                    "\"user_fio\":\"{6}\",\"branch_id\":\"{7}\",\"struct_code\":{8},\"changed\":\"{9}\"," +
                                    "\"created\":\"{10}\",\"pages_count\":{13},\"binary_data\":\"{12}\",\"linkedrnk\":[{11}]" +
                                    "}}],\"message_id\":\"BARS-MESS-379071\"",
                                    sessionId, methodName, document.ExternalId, document.Rnk, document.AgrId, document.UserLogin, document.UserFio,
                                    document.BranchCode, document.DocTypeCode, document.ChangeDate, document.CreateDate, document.LinkedRnk, base64Data, document.PagesCount);
            result += "}";
            return result;
        }

        public static string SetClientData(string sessionId, string methodName, Client client)
        {
            string result = String.Empty;
            result += "{";
            result += String.Format("\"sessionid\":\"{0}\",\"method\":\"{1}\",\"params\":" +
                                    "[{{\"branch_id\":\"{2}\",\"RNK\":{3},\"changed\":\"{4}\"," +
                                    "\"created\":\"{5}\",\"fio\":\"{6}\",\"client_type\":\"{7}\",\"inn\":\"{8}\",\"birth_date\":\"{9}\"," +
                                    "\"document_series\":\"{10}\",\"document_number\":\"{11}\",\"client_data\":\"\",\"mergedRNK\":[],\"user_login\":\"{12}\"" +
                                    ",\"user_fio\":\"{13}\"" +
                                    "}}],\"message_id\":\"BARS-MESS-379518\"", sessionId, methodName, client.BranchCode, client.Rnk, client.ChangeDate,
                                    client.CreateDate, client.ClientFio, client.ClientTypeCode, client.Inn, client.BirthDate, client.DocSeries,
                                    client.DocNumber, client.UserLogin, client.UserFio);
            result += "}";
            return result;
        }

        public static string SetAgreementData(string sessionId, string methodName, Agreement agr)
        {
            string result = String.Empty;

            string linkedRnk = String.Empty;

            if (agr.LinkedPersons.Count > 0)
            {


                foreach (var person in agr.LinkedPersons)
                {
                    linkedRnk += "{";

                    linkedRnk += String.Format("\"RNK\": {0}, \"LinkPersonStateID\": {1}", person.Rnk,
                        person.PersonState);

                    linkedRnk += "},";
                }

            }

            result += "{";
            result += String.Format("\"sessionid\":\"{0}\",\"method\":\"{1}\",\"params\":" +
                                    "[{{\"agr_code\":\"{2}\",\"RNK\":{3},\"changed\":\"{4}\",\"created\":\"{5}\",\"branch_id\":\"{6}\"," +
                                    "\"user_login\":\"{7}\",\"user_fio\":\"{8}\",\"agr_type\":\"{9}\",\"agr_status\":\"{10}\",\"agr_number\":\"{11}\"," +
                                    "\"agr_date_open\":\"{12}\",\"account_number\":\"{13}\",\"agr_date_close\":\"{14}\",\"linkedRNK\":[{15}]" +
                                    "}}],\"message_id\":\"BARS-MESS-379518\"", sessionId, methodName, agr.AgrCode, agr.Rnk, agr.ChangeDate, agr.CreateDate,
                                    agr.BranchCode, agr.UserLogin, agr.UserFio, agr.AgrTypeCode, agr.AgrStatusCode, agr.AgrNumber, agr.AgrOpenDate,
                                    agr.AccountNumber, agr.AgrCloseDate, linkedRnk);
            //"linkedRNK":[{"RNK":1234307,"LinkPersonStateID":4}]}],"
            result += "}";
            return result;
        }

        public static string ActualizeIdDocs(string sessionId, string methodName, ActuaalizeDoc act)
        {
            string result = String.Empty;
            result += "{";
            result += String.Format("\"sessionid\":\"{0}\",\"method\":\"{1}\",\"params\":" +
                                    "[{{\"RNK\":{2},\"branch_id\":\"{3}\",\"user_login\":\"{4}\",\"user_fio\":\"{5}\",\"actual_date\":\"{6}\"" +
                                    "}}],\"message_id\":\"BARS-MESS-15106256\"", sessionId, methodName, act.Rnk, act.BranchCode, act.UserLogin, act.UserFio,
                                    act.ActDate);
            result += "}";
            return result;
        }

        #endregion

        #region CorpRegion

        public static string SetCorpAgreementData(string sessionId, string methodName, CorpAgreement agr)
        {
            string result = String.Empty;
            result += "{";
            result += String.Format("\"sessionid\":\"{0}\",\"method\":\"{1}\",\"params\":" +
                                   "[{{\"agr_code\":\"{2}\",\"RNK\":{3},\"changed\":\"{4}\",\"created\":\"{5}\",\"client_type\":{6},\"branch_id\":\"{7}\"," +
                                    "\"user_login\":\"{8}\",\"user_fio\":\"{9}\",\"agr_type\":\"{10}\",\"agr_status\":\"{11}\",\"agr_number\":\"{12}\"," +
                                    "\"agr_date_open\":\"{13}\",\"agr_date_close\":\"{14}\"" +
                                    "}}],\"message_id\":\"BARS-MESS-379518\"", sessionId, methodName, agr.AgrCode, agr.Rnk, agr.ChangeDate, agr.CreateDate,
                                    agr.ClientTypeCode, agr.BranchCode, agr.UserLogin, agr.UserFio, agr.AgrTypeCode, agr.AgrStatusCode, agr.AgrNumber, agr.AgrOpenDate,
                                    agr.AgrCloseDate);
            result += "}";
            return result;
        }

        public static string SetCorpClientData(string sessionId, string methodName, CorpClient client)
        {
            string result = String.Empty;
            string noClients = String.Empty;
            string linkedPersons = String.Empty;

            if (client.LinkedPersons.Count > 0)
            {
                foreach (var person in client.LinkedPersons)
                {
                    linkedPersons += "{";
                    linkedPersons += String.Format("\"rnk\": {0}, \"personStateID\": {1}", person.Rnk,
                        person.PersonState);
                    linkedPersons += "},";
                }
                linkedPersons = linkedPersons.Remove(linkedPersons.Length - 1);
            }

            if (client.NoClients.Count > 0)
            {
                foreach (var person in client.NoClients)
                {
                    noClients += "{";
                    noClients += String.Format("\"id\": {0}, \"personStateID\": {1}, \"name\": \"{2}\", \"client_type\": {3}, \"inn_edrpou\":\"{4}\"",
                        person.PersonNumber, person.StateId, person.FullName.Replace("\"", "\\\""), person.ClientType, person.Ipn);
                    noClients += "},";
                }
                noClients = noClients.Remove(noClients.Length - 1);
            }

            // {"rnk":1063592,"personStateID":22},{"rnk":1063592,"personStateID":26}
            result += "{";
            result += String.Format("\"sessionid\":\"{0}\",\"method\":\"{1}\",\"params\":" +
                                    "[{{\"branch_id\":\"{2}\",\"rnk\":{3},\"changed\":\"{4}\"," +
                                    "\"created\":\"{5}\",\"client_type\":\"{6}\",\"client_name\":\"{7}\",\"inn_edrpou\":\"{8}\",\"user_login\":\"{9}\"," +
                                    "\"user_fio\":\"{10}\",\"actualized_date\":\"{11}\",\"actualized_by\":\"{12}\",\"third_persons_clients\":[{13}], \"third_persons_non_clients\":[{14}]}}]," +
                                    "\"message_id\":\"BARS-MESS-379518\"", sessionId, methodName, client.BranchCode, client.Rnk, client.ChangeDate,
                                    client.CreateDate, client.ClientTypeCode, client.ClientName.Replace("\"", "\\\""), client.Inn_Edrpou,
                                    client.UserLogin, client.UserFio, client.ActualizeDate, client.ActualizeBy, linkedPersons, noClients);
            result += "}";
            return result;
        }

        public static string SetAccountData(string sessionId, string methodName, Account account)
        {
            string result = String.Empty;
            result += "{";
            result += String.Format("\"sessionid\":\"{0}\",\"method\":\"{1}\",\"params\":" +
                                    "[{{\"RNK\":{2},\"changed\":\"{3}\",\"created\":\"{4}\",\"user_login\":\"{5}\",\"user_fio\":\"{6}\"," +
                                    "\"account_number\":\"{7}\",\"currency_code\":\"{8}\",\"mfo\":{9},\"branch_id\":\"{10}\",\"open_date\":\"{11}\"," +
                                    "\"close_date\":\"{12}\",\"agr_number\":\"{13}\",\"agr_code\":\"{14}\",\"account_type\":\"{15}\",\"account_status\":{16}}}]," +
                                    "\"message_id\":\"BARS-MESS-379518\"", sessionId, methodName, account.Rnk, account.ChangeDate,
                                    account.CreateDate, account.UserLogin, account.UserFio, account.AccountNumber, account.CurrencyCode,
                                    account.Mfo, account.BranchCode, account.OpenDate, account.CloseDate, account.AgrNumber, account.AgrCode,
                                    account.AccountTypeCode, account.AccountStatusCode);
            result += "}";
            return result;
        }

        #endregion

        #region SED

        public static string GetClientDataSed(string sessionId, string methodName, ClientDataSed client)
        {
            string result = String.Empty;
            result += "{";
            result += String.Format("\"sessionid\":\"{0}\",\"method\":\"{1}\",\"params\":[{{\"RNK\":\"{2}\"}}]," +
                                    "\"message_id\":\"BARS-MESS-15003\"", sessionId, methodName, client.Rnk);

            result += "}";
            return result;
        }

        public static string GetDictionaryDataSed(string sessionId, string methodName, DictionaryDataSed dictionary)
        {
            string result = String.Empty;
            result += "{";
            result += String.Format("\"sessionid\":\"{0}\",\"method\":\"{1}\",\"params\":[{{\"dictionary_id\":\"{2}\"}}]," +
                                    "\"message_id\":\"BARS-MESS-15003\"", sessionId, methodName, dictionary.DictionaryId);

            result += "}";
            return result;
        }

        public static string GetDocumentMetaDataSed(string sessionId, string methodName, DocumentMetadataSed document)
        {
            string result = String.Empty;
            result += "{";
            result += String.Format("\"sessionid\":\"{0}\",\"method\":\"{1}\",\"params\":[{{\"RNK\":\"{2}\",\"IDs_Version\":\"{3}\",\"status_code\":\"{4}\"}}]," +
                                    "\"message_id\":\"BARS-MESS-15003\"", sessionId, methodName, document.Rnk, document.IDs_Version, document.StatusCode);

            result += "}";
            return result;
        }

        public static string SetDocumentAttributesSed(string sessionId, string methodName, DocumentAttributeSed document)
        {
            string result = String.Empty;

            var docInFolder = String.Empty;
            foreach (var doc in document.Documents)
            {
                var properties = String.Empty;

                foreach (var propert in doc.PropertiesCollection)
                {
                    properties += "{";

                    properties += String.Format("\"property_name\":\"{0}\",\"property_value\":\"{1}\"", propert.Name, propert.Code);

                    properties += "},";
                }

                properties = properties.Remove(properties.Length - 1, 1);

                docInFolder += "{";

                docInFolder += String.Format("\"ID\": \"{0}\",\"Version\": \"{1}\", \"values\":[{2}]", doc.Id, doc.Version, properties);

                docInFolder += "},";

                docInFolder = docInFolder.Remove(docInFolder.Length - 1, 1);
                
            }

            result += "{";
            result +=
                String.Format(
                    "\"sessionid\":\"{0}\",\"method\":\"{1}\",\"params\":[{{\"user_login\":\"{2}\",\"user_fio\":\"{3}\",\"changed\":\"{4}\",\"documents\":[{5}]}}],\"message_id\":\"BARS-MESS-15003\"",
                    sessionId, methodName, document.UserLogin, document.UserFullName, document.ModifyDateTime, docInFolder);
                                    

            result += "}";
            return result;
        }

        #endregion
    }
}
