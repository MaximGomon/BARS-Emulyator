using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using BARS_Emulyator.Entity;
using BARS_Emulyator.EntityForMethod;

namespace BARS_Emulyator
{
    public partial class CoreForm : Form
    {

        private Setting _setParam = new Setting();//настройки для программы
        private History _userHistory = new History();

        private bool IsParamsTableFill { get; set; }

        public CoreForm()
        {
            try
            {
                InitializeComponent();

                IsParamsTableFill = false;
                toolStripTextBoxSessionId.Text = String.Empty;
                btAddLinkedPerson.Visible = false;
                btAddNoClient.Visible = false;
                btAddDocument.Visible = false;

                _setParam = Setting.LoadSetting();
                _userHistory.CurrentItem = new BaseEntity();

                ResizeParamsSplitContainer();
                ResizeScParams();
                ResizeListView();

                _setParam.MethodsName.Clear();
                _setParam.MethodsName.Add("SetAgreementData", "SetAgreementData");
                _setParam.MethodsName.Add("SetDocumentDataWithOutBinary", "SetDocumentData");
                _setParam.MethodsName.Add("SetDocumentDataWithBinary", "SetDocumentData");
                _setParam.MethodsName.Add("ActualizeIdDocs", "ActualizeIdDocs");
                _setParam.MethodsName.Add("SetClientData", "SetClientData");
                _setParam.MethodsName.Add("GetDocumentData", "GetDocumentData");
                _setParam.MethodsName.Add("SetDictionaryData", "SetDictionaryData");
                _setParam.MethodsName.Add("SetAccountDataU", "SetAccountDataU");
                _setParam.MethodsName.Add("SetClientDataU", "SetClientDataU");
                _setParam.MethodsName.Add("SetAgreementDataU", "SetAgreementDataU");

                _setParam.MethodsName.Add("GetClientDataSed", "GetClientData");
                _setParam.MethodsName.Add("GetDocumentMetaDataSed", "GetDocumentMetaData");
                _setParam.MethodsName.Add("GetDictionaryDataSed", "GetDictionaryData");
                _setParam.MethodsName.Add("SetDocumentAttributesSed", "SetDocumentAttributes");

                foreach (var item in _setParam.MethodsName.Keys)
                {
                    methodListView.Items.Add(item);
                }

                scParam.Panel2Collapsed = true;
                splitContainer2.Panel2Collapsed = true;

                FillBarsUrlList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void FillBarsUrlList()
        {
            toolStripComboBox.Items.Clear();
            foreach (var item in _setParam.AllBarsUrlList)
            {
                toolStripComboBox.Items.Add(item);
            }

            if (toolStripComboBox.Items.Count > 0)
                toolStripComboBox.SelectedIndex = 0;
        }

        #region GetFillItem

        private DocumentAttributeSed SetDocumentAttributesSedItem()
        {
            DocumentAttributeSed docAttribute = new DocumentAttributeSed
            {
                //BranchCode = paramsGridView.Rows[2].Cells[1].Value.ToString(),
                UserFullName = paramsGridView.Rows[1].Cells[1].Value.ToString(),
                UserLogin = paramsGridView.Rows[0].Cells[1].Value.ToString(),
                ModifyDateTime = paramsGridView.Rows[2].Cells[1].Value.ToString()
            };

            for(int i = 3; i < paramsGridView.Rows.Count; i++)
            {
                SedDocument document = new SedDocument
                {
                    Id = Guid.Parse(paramsGridView.Rows[i].Cells[1].Value.ToString()),
                    Version = paramsGridView.Rows[++i].Cells[1].Value.ToString()
                };
                i++;

                while (paramsGridView.Rows[i].Cells[2].Value.ToString() == "SedDocProperties")
                {
                    var prop = new SedDocument.SedDocumentProperties
                    {
                        Name = (DocumentProperties)Enum.Parse(typeof(DocumentProperties), paramsGridView.Rows[i].Cells[0].Value.ToString()),
                        Code = paramsGridView.Rows[i].Cells[1].Value.ToString()
                    };
                    document.PropertiesCollection.Add(prop);
                    i++;

                    if (i == paramsGridView.Rows.Count)
                    {
                        break;
                    }
                }
                
                docAttribute.Documents.Add(document);
            }

            return docAttribute;
        }

        private DocumentMetadataSed GetDocumentMetaDataSedItem()
        {
            var documentMetadata = new DocumentMetadataSed
            {
                Rnk = paramsGridView.Rows[0].Cells[1].Value.ToString(),
                IDs_Version = paramsGridView.Rows[1].Cells[1].Value.ToString(),
                StatusCode = paramsGridView.Rows[2].Cells[1].Value.ToString()
            };
            return documentMetadata;
        }

        private DictionaryDataSed GetDictionaryDataSedItem()
        {
            var dictionaryDataSed = new DictionaryDataSed
            {
                DictionaryId = paramsGridView.Rows[0].Cells[1].Value.ToString()
            };
            return dictionaryDataSed;
        }

        private ClientDataSed GetClientDataSedItem()
        {
            var clientSed = new ClientDataSed
            {
                Rnk = paramsGridView.Rows[0].Cells[1].Value.ToString()
            };
            return clientSed;
        }

        private CorpAgreement GetCorpAgreementItem()
        {
            CorpAgreement agreement = new CorpAgreement
            {
                AgrCode = paramsGridView.Rows[0].Cells[1].Value.ToString(),
                Rnk = paramsGridView.Rows[1].Cells[1].Value.ToString(),
                ChangeDate = paramsGridView.Rows[2].Cells[1].Value.ToString(),
                CreateDate = paramsGridView.Rows[3].Cells[1].Value.ToString(),
                ClientTypeCode = paramsGridView.Rows[4].Cells[1].Value.ToString(),
                BranchCode = paramsGridView.Rows[5].Cells[1].Value.ToString(),
                UserLogin = paramsGridView.Rows[6].Cells[1].Value.ToString(),
                UserFio = paramsGridView.Rows[7].Cells[1].Value.ToString(),
                AgrTypeCode = paramsGridView.Rows[8].Cells[1].Value.ToString(),
                AgrStatusCode = paramsGridView.Rows[9].Cells[1].Value.ToString(),
                AgrNumber = paramsGridView.Rows[10].Cells[1].Value.ToString(),
                AgrOpenDate = paramsGridView.Rows[11].Cells[1].Value.ToString(),
                AgrCloseDate = paramsGridView.Rows[12].Cells[1].Value.ToString()
            };

            _userHistory.CurrentItem = agreement;

            return agreement;
        }

        private CorpClient GetCorpClientItem()
        {
            try
            {
                CorpClient client = new CorpClient
                {
                    BranchCode = paramsGridView.Rows[0].Cells[1].Value.ToString(),
                    Rnk = paramsGridView.Rows[1].Cells[1].Value.ToString(),
                    ChangeDate = paramsGridView.Rows[2].Cells[1].Value.ToString(),
                    CreateDate = paramsGridView.Rows[3].Cells[1].Value.ToString(),
                    ClientTypeCode = paramsGridView.Rows[4].Cells[1].Value.ToString(),
                    ClientName = paramsGridView.Rows[5].Cells[1].Value.ToString(),
                    Inn_Edrpou = paramsGridView.Rows[6].Cells[1].Value.ToString(),
                    UserLogin = paramsGridView.Rows[7].Cells[1].Value.ToString(),
                    UserFio = paramsGridView.Rows[8].Cells[1].Value.ToString(),
                    ActualizeDate = paramsGridView.Rows[9].Cells[1].Value.ToString(),
                    ActualizeBy = paramsGridView.Rows[10].Cells[1].Value.ToString(),
                    //ThirdPerson = paramsGridView.Rows[11].Cells[1].Value.ToString()
                };

                //int i = 11;
                for (int i = 11; i < paramsGridView.Rows.Count; i++)
                {
                    if (paramsGridView.Rows[i].Cells[2].Value.ToString().StartsWith("LinkedPerson"))
                    {
                        LinkedPerson lk = new LinkedPerson();
                        lk.Rnk = paramsGridView.Rows[i].Cells[1].Value.ToString();

                        i++;

                        lk.PersonState = paramsGridView.Rows[i].Cells[1].Value.ToString();

                        client.LinkedPersons.Add(lk);

                        if (i == paramsGridView.Rows.Count)
                            break;
                    }


                    if (paramsGridView.Rows[i].Cells[2].Value.ToString().StartsWith("NoClient"))
                    {
                        var noClient = new NoClient();
                        noClient.PersonNumber = paramsGridView.Rows[i].Cells[1].Value.ToString();

                        i++;

                        noClient.StateId = paramsGridView.Rows[i].Cells[1].Value.ToString();

                        i++;

                        noClient.FullName = paramsGridView.Rows[i].Cells[1].Value.ToString();

                        i++;

                        noClient.ClientType = paramsGridView.Rows[i].Cells[1].Value.ToString();

                        i++;

                        noClient.Ipn = paramsGridView.Rows[i].Cells[1].Value.ToString();

                        client.NoClients.Add(noClient);

                        if (i == paramsGridView.Rows.Count)
                            break;
                    }
                }

                _userHistory.CurrentItem = client;

                return client;
            }
            catch (Exception ex)
            {
                //throw;
                return null;
            }
            
        }

        private Account GetAccountItem()
        {
            Account account = new Account
            {
                Rnk = paramsGridView.Rows[0].Cells[1].Value.ToString(),
                ChangeDate = paramsGridView.Rows[1].Cells[1].Value.ToString(),
                CreateDate = paramsGridView.Rows[2].Cells[1].Value.ToString(),
                UserLogin = paramsGridView.Rows[3].Cells[1].Value.ToString(),
                UserFio = paramsGridView.Rows[4].Cells[1].Value.ToString(),
                AccountNumber = paramsGridView.Rows[5].Cells[1].Value.ToString(),
                CurrencyCode = paramsGridView.Rows[6].Cells[1].Value.ToString(),
                Mfo = paramsGridView.Rows[7].Cells[1].Value.ToString(),
                BranchCode = paramsGridView.Rows[8].Cells[1].Value.ToString(),
                OpenDate = paramsGridView.Rows[9].Cells[1].Value.ToString(),
                CloseDate = paramsGridView.Rows[10].Cells[1].Value.ToString(),
                AgrNumber = paramsGridView.Rows[11].Cells[1].Value.ToString(),
                AgrCode = paramsGridView.Rows[12].Cells[1].Value.ToString(),
                AccountTypeCode = paramsGridView.Rows[13].Cells[1].Value.ToString(),
                AccountStatusCode = paramsGridView.Rows[14].Cells[1].Value.ToString()
            };

            _userHistory.CurrentItem = account;

            return account;
        }

        private DocumentBinary GetDocumentBinaryItem()
        {
            DocumentBinary documentBinary = new DocumentBinary();

            documentBinary.ExternalId = paramsGridView.Rows[0].Cells[1].Value.ToString() != string.Empty ? paramsGridView.Rows[0].Cells[1].Value.ToString() : "\"\"";
            documentBinary.Rnk = paramsGridView.Rows[1].Cells[1].Value.ToString();
            documentBinary.AgrCode = paramsGridView.Rows[2].Cells[1].Value.ToString() != string.Empty ? paramsGridView.Rows[2].Cells[1].Value.ToString() : "\"\"";
            documentBinary.TypeCode = paramsGridView.Rows[3].Cells[1].Value.ToString() != string.Empty ? paramsGridView.Rows[3].Cells[1].Value.ToString() : "\"\"";

            _userHistory.CurrentItem = documentBinary;

            return documentBinary;
        }

        private ActuaalizeDoc GetActualizeDocItem()
        {
            ActuaalizeDoc actualize = new ActuaalizeDoc();

            actualize.BranchCode = paramsGridView.Rows[0].Cells[1].Value.ToString();
            actualize.Rnk = paramsGridView.Rows[1].Cells[1].Value.ToString();
            actualize.UserLogin = paramsGridView.Rows[2].Cells[1].Value.ToString();
            actualize.UserFio = paramsGridView.Rows[3].Cells[1].Value.ToString();
            actualize.ActDate = paramsGridView.Rows[4].Cells[1].Value.ToString();

            _userHistory.CurrentItem = actualize;

            return actualize;
        }

        private Agreement GetAgreementItem()
        {
            Agreement agreement = new Agreement();
            
            agreement.AgrCode = paramsGridView.Rows[0].Cells[1].Value.ToString();
            agreement.Rnk = paramsGridView.Rows[1].Cells[1].Value.ToString();
            agreement.ChangeDate = paramsGridView.Rows[2].Cells[1].Value.ToString();
            agreement.CreateDate = paramsGridView.Rows[3].Cells[1].Value.ToString();
            agreement.BranchCode = paramsGridView.Rows[4].Cells[1].Value.ToString();
            agreement.UserLogin = paramsGridView.Rows[5].Cells[1].Value.ToString();
            agreement.UserFio = paramsGridView.Rows[6].Cells[1].Value.ToString();
            agreement.AgrTypeCode = paramsGridView.Rows[7].Cells[1].Value.ToString();
            agreement.AgrStatusCode = paramsGridView.Rows[8].Cells[1].Value.ToString();
            agreement.AgrNumber = paramsGridView.Rows[9].Cells[1].Value.ToString();
            agreement.AgrOpenDate = paramsGridView.Rows[10].Cells[1].Value.ToString();
            agreement.AccountNumber = paramsGridView.Rows[11].Cells[1].Value.ToString();
            agreement.AgrCloseDate = paramsGridView.Rows[12].Cells[1].Value.ToString();

            for (int i = 13; i < paramsGridView.Rows.Count; i++)
            {
                LinkedPerson lk = new LinkedPerson();
                lk.Rnk = paramsGridView.Rows[i].Cells[1].Value.ToString();

                i++;

                lk.PersonState = paramsGridView.Rows[i].Cells[1].Value.ToString();

                agreement.LinkedPersons.Add(lk);
            }

            _userHistory.CurrentItem = agreement;

            return agreement;
        }

        private Client GetClientItem()
        {
            Client client  = new Client();

            client.BranchCode = paramsGridView.Rows[0].Cells[1].Value.ToString();
            client.Rnk = paramsGridView.Rows[1].Cells[1].Value.ToString();
            client.ChangeDate = paramsGridView.Rows[2].Cells[1].Value.ToString();
            client.CreateDate = paramsGridView.Rows[3].Cells[1].Value.ToString();
            client.ClientFio = paramsGridView.Rows[4].Cells[1].Value.ToString();
            client.ClientTypeCode = paramsGridView.Rows[5].Cells[1].Value.ToString();
            client.Inn = paramsGridView.Rows[6].Cells[1].Value.ToString();
            client.BirthDate = paramsGridView.Rows[7].Cells[1].Value.ToString();
            client.DocSeries = paramsGridView.Rows[8].Cells[1].Value.ToString();
            client.DocNumber = paramsGridView.Rows[9].Cells[1].Value.ToString();
            client.UserLogin = paramsGridView.Rows[10].Cells[1].Value.ToString();
            client.UserFio = paramsGridView.Rows[11].Cells[1].Value.ToString();

            _userHistory.CurrentItem = client;

            return client;
        }

        private Document GetDocumentItem()
        {
            Document document = new Document();

            document.ExternalId = paramsGridView.Rows[0].Cells[1].Value.ToString();
            document.Rnk = paramsGridView.Rows[1].Cells[1].Value.ToString();
            document.AgrId = paramsGridView.Rows[2].Cells[1].Value.ToString();
            document.UserLogin = paramsGridView.Rows[3].Cells[1].Value.ToString();
            document.UserFio = paramsGridView.Rows[4].Cells[1].Value.ToString();
            document.BranchCode = paramsGridView.Rows[5].Cells[1].Value.ToString();
            document.DocTypeCode = paramsGridView.Rows[6].Cells[1].Value.ToString();
            document.ChangeDate = paramsGridView.Rows[7].Cells[1].Value.ToString();
            document.CreateDate = paramsGridView.Rows[8].Cells[1].Value.ToString();
            document.LinkedRnk = paramsGridView.Rows[9].Cells[1].Value.ToString();
            document.PagesCount = paramsGridView.Rows[10].Cells[1].Value.ToString();

            _userHistory.CurrentItem = document;

            return document;
        }

        private Branch GetBranchItem()
        {
            Branch branch = new Branch
            {
                Code = paramsGridView.Rows[0].Cells[1].Value.ToString(),
                Name = paramsGridView.Rows[1].Cells[1].Value.ToString(),
            };

            _userHistory.CurrentItem = branch;

            return branch;
        }

        #endregion
        
        #region Events
        
        private void requestRtb_Leave(object sender, EventArgs e)
        {
            requestRtb.Text = Util.ReplaceSessionId(requestRtb.Text, toolStripTextBoxSessionId.Text);
        }

        private void paramsGridView_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void toolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _setParam.CurrentBarsUrl = toolStripComboBox.SelectedItem.ToString();
        }

        private void setDateTimeNowButton_Click(object sender, EventArgs e)
        {
            foreach (var item in _setParam.GetType().GetProperties())
            {
                string dateTimeFullName = new DateTime().GetType().FullName;

                if (item.PropertyType.FullName == dateTimeFullName)
                {
                    item.SetValue(_setParam, DateTime.Now, null);
                }
            }
        }

        private void tsbSaveHistory_Click(object sender, EventArgs e)
        {
            SaveHistoryToFile();
        }

        private void tsbLoadHistory_Click(object sender, EventArgs e)
        {
            LoadHistoryFromFile();
        }

        private void tsbRunHistory_Click(object sender, EventArgs e)
        {
            RunAllHistoryItems();
        }

        private void CoreForm_Resize(object sender, EventArgs e)
        {
            ResizeListView();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "BARS Files (*.bars)|*.bars";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream st = new FileStream(openFileDialog.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(st);

                requestRtb.Text = sr.ReadToEnd();

                sr.Close();
                st.Close();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveBarsRequestFile();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            replyRtb.Text = BeginSendRequest(requestRtb.Text);
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            SettingForm sf = new SettingForm(_setParam);
            if (sf.ShowDialog() == DialogResult.OK)
            {
                _setParam = sf.GetSetting();
                FillBarsUrlList();
            }
        }
        
        private void CoreForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Setting.SaveSetting(_setParam);
        }

        private void methodListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //SetColorToSelectedItem();
            foreach (ListViewItem item in methodListView.Items)
            {
                item.BackColor = methodListView.BackColor;
                item.ForeColor = Color.Black;
            }
            Methods method = (Methods)Enum.Parse(typeof(Methods), e.Item.Text);

            InitializeEntityForMethod(method);
            e.Item.BackColor = Color.FromArgb(51, 153, 255);
            e.Item.ForeColor = Color.White;
            //BuildParamsTable(e.Item.Text);
        }

        private void paramsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenFileloadDialog(e.RowIndex);
        }

        private void closeToolButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void generateButton_Click(object sender, EventArgs e)
        {
            if (IsParamsTableFill)
                GenerateRequest();
            //generateButton.Visible = false;
            //sendRequestButton.Visible = true;
        }

        private void closeSessionButton_Click(object sender, EventArgs e)
        {
            string postData = CreatePostString(Methods.CloseSession);

           // requestRtb.Text = postData;

            var responseString = BeginSendRequest(postData);

            replyRtb.Text = responseString;
        }

        private void startSessionButton_Click(object sender, EventArgs e)
        {
            string postData = CreatePostString(Methods.StartSession);

            requestRtb.Text = postData;

            var responseString = BeginSendRequest(postData);

            replyRtb.Text = responseString;

            TryGetSessionIdFromResponce(responseString);
        }

        private void paramsGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            OpenFileloadDialog(e.RowIndex);
        }

        private void paramsGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            OpenFileloadDialog(e.RowIndex);
        }

        private void generateReqStripButton_Click(object sender, EventArgs e)
        {
            GenerateRequest();
        }

        private void sendRequestButton_Click(object sender, EventArgs e)
        {
            replyRtb.Text = BeginSendRequest(requestRtb.Text);
            //generateButton.Visible = true;
            //sendRequestButton.Visible = false;
        }

        private void historyListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var entity = _userHistory.HistoryList[e.Item.Index];

            replyRtb.Text = entity.Reply;
            BuildParamsTable(entity);

            if (entity.MethodName == "SetDocumentDataWithOutBinary")
                paramsGridView.Rows.RemoveAt(11);

            requestRtb.Text = CreatePostString((Methods)Enum.Parse(typeof(Methods), entity.MethodName));
        }
        
        private void paramSplitContainer_Resize(object sender, EventArgs e)
        {
            ResizeParamsSplitContainer();
        }

        private void btAddLinkedPerson_Click(object sender, EventArgs e)
        {
            AddNewLinkedPersonParams(string.Empty, string.Empty);
        }

        private void btAddNoClient_Click(object sender, EventArgs e)
        {
            AddNewNoClientParams(string.Empty, string.Empty);
        }
        
        private void btAddDocument_Click(object sender, EventArgs e)
        {
            AddNewSedDocumentParams();
        }

        #endregion

        #region Helpers

        private void SaveHistoryToFile()
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "BARS History files (*.history)|*.history";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                History.SaveHistoryToFile(sf.FileName, _userHistory);
            }
        }

        private void LoadHistoryFromFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "BARS History Files (*.history)|*.history";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _userHistory = History.LoadHistoryFromFile(openFileDialog.FileName);
                WriteHistoryToListView();
            }
        }

        private void SaveBarsRequestFile()
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "BARS files (*.bars)|*.bars";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                Stream st = new FileStream(sf.FileName, FileMode.CreateNew);
                StreamWriter sw = new StreamWriter(st);

                sw.Write(requestRtb.Text);

                sw.Close();
                st.Close();
            }
        }

        private void RunAllHistoryItems()
        {
            History h = (History)_userHistory.Clone();
            
            _userHistory = new History();
            historyListView.Items.Clear();

            foreach (var item in h.HistoryList)
            {
                BuildParamsTable(item);
                string postData = CreatePostString((Methods)Enum.Parse(typeof(Methods), item.MethodName));
                string responce = BeginSendRequest(postData);
                if (item.MethodName == "StartSession")
                {
                    TryGetSessionIdFromResponce(responce);
                }
            }
        }

        private void TryGetSessionIdFromResponce(string responseString)
        {
            string sessionId = Util.GetSessionId(responseString);

            if (sessionId != String.Empty)
            {
                _setParam.SessionId = sessionId;
                toolStripTextBoxSessionId.Text = sessionId;
            }
            else
            {
                MessageBox.Show("Не удалось определить параметр \"sessionId\" из ответа.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private string BeginSendRequest(string postData)
        {
            try
            {
                string responce = String.Empty;

                responce = Util.SendRequest(postData, _setParam.CurrentBarsUrl);

                _userHistory.CurrentItem.Reply = responce;

                if (responce.ToLower().IndexOf("\"status\":\"ok\"") > 0)
                    _userHistory.CurrentItem.Status = true;
                else
                    _userHistory.CurrentItem.Status = false;

                WriteHistory();

                return responce;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
           
        }

        private string CreatePostString(Methods methodName)
        {
            string result = String.Empty;

            switch (methodName)
            {
                case Methods.StartSession:
                    result = MethodHelper.StartSession(_setParam.UserLoginSs, _setParam.UserNameSs, _setParam.UserPasswordSs, "StartSession");
                    break;
                case Methods.CloseSession:
                    result = MethodHelper.CloseSession(_setParam.SessionId, "CloseSession");
                    break;
                case Methods.SetAgreementData:
                    result = MethodHelper.SetAgreementData(_setParam.SessionId, _setParam.MethodsName["SetAgreementData"], GetAgreementItem());
                    break;
                case Methods.SetDocumentDataWithOutBinary:
                    result = MethodHelper.SetDocumentDataWithOutBinary(_setParam.SessionId, _setParam.MethodsName["SetDocumentDataWithOutBinary"], GetDocumentItem());
                    break;
                case Methods.SetDocumentDataWithBinary:
                    string base64String = Util.ConvertImageToBase64Strimg(paramsGridView.Rows[11].Cells[1].Value.ToString());
                    result = MethodHelper.SetDocumentDataWithBinary(_setParam.SessionId, _setParam.MethodsName["SetDocumentDataWithBinary"], GetDocumentItem(),
                            base64String);
                    break;
                case Methods.ActualizeIdDocs:
                    result = MethodHelper.ActualizeIdDocs(_setParam.SessionId, _setParam.MethodsName["ActualizeIdDocs"], GetActualizeDocItem());
                    break;
                case Methods.SetClientData:
                    result = MethodHelper.SetClientData(_setParam.SessionId, _setParam.MethodsName["SetClientData"], GetClientItem());
                    break;
                case Methods.GetDocumentData:
                    result = MethodHelper.GetDocumentData(_setParam.SessionId, _setParam.MethodsName["GetDocumentData"], GetDocumentBinaryItem());
                    break;
                case Methods.SetAccountDataU:
                    result = MethodHelper.SetAccountData(_setParam.SessionId, _setParam.MethodsName["SetAccountDataU"], GetAccountItem());
                    break;
                case Methods.SetClientDataU:
                    result = MethodHelper.SetCorpClientData(_setParam.SessionId, _setParam.MethodsName["SetClientDataU"], GetCorpClientItem());
                    break;
                case Methods.SetAgreementDataU:
                    result = MethodHelper.SetCorpAgreementData(_setParam.SessionId, _setParam.MethodsName["SetAgreementDataU"], GetCorpAgreementItem());
                    break;
                case Methods.SetDictionaryData:
                    result = MethodHelper.SetDictionaryData(_setParam.SessionId, _setParam.MethodsName["SetDictionaryData"], GetBranchItem());
                    break;
                case Methods.GetClientDataSed:
                    result = MethodHelper.GetClientDataSed(_setParam.SessionId, _setParam.MethodsName["GetClientDataSed"], GetClientDataSedItem());
                    break;
                case Methods.GetDocumentMetaDataSed:
                    result = MethodHelper.GetDocumentMetaDataSed(_setParam.SessionId, _setParam.MethodsName["GetDocumentMetaDataSed"], GetDocumentMetaDataSedItem());
                    break;
                case Methods.GetDictionaryDataSed:
                    result = MethodHelper.GetDictionaryDataSed(_setParam.SessionId, _setParam.MethodsName["GetDictionaryDataSed"], GetDictionaryDataSedItem());
                    break;
                case Methods.SetDocumentAttributesSed:
                    result = MethodHelper.SetDocumentAttributesSed(_setParam.SessionId, _setParam.MethodsName["SetDocumentAttributesSed"], SetDocumentAttributesSedItem());
                    break;
            }

            _userHistory.CurrentItem.MethodName = methodName.ToString();
            //_userHistory.CurrentItem.Key = 5;

            return result;
        }

        
        private void WriteHistoryToListView()
        {
            foreach (var item in _userHistory.HistoryList)
            {
                var lv = new ListViewItem();
                lv.BackColor = item.Status ? Color.GreenYellow : Color.Tomato;
                lv.Text = item.MethodName;

                AddItemToHistoryListView(lv);
            }
        }

        private void WriteHistory()
        {
            var item = new ListViewItem();
            item.BackColor = _userHistory.CurrentItem.Status ? Color.GreenYellow : Color.Tomato;
            item.Text = _userHistory.CurrentItem.MethodName;

            AddItemToHistoryListView(item);

            _userHistory.HistoryList.Add(_userHistory.CurrentItem);
            _userHistory.CurrentItem = new BaseEntity();

        }

        private void AddItemToHistoryListView(ListViewItem item)
        {
            historyListView.Items.Add(item);
        }

        private void InitializeEntityForMethod(Methods methodName)
        {
            switch (methodName)
            {
                case Methods.SetDocumentDataWithOutBinary:
                    Document doc = new Document(_setParam.UserLoginOther, _setParam.UserNameOther, _setParam.BranchCode, _setParam.ChangeDate, _setParam.CreateDate);
                    BuildParamsTable(doc);
                    paramsGridView.Rows.RemoveAt(11);
                    break;
                case Methods.SetDocumentDataWithBinary:
                    Document document = new Document(_setParam.UserLoginOther, _setParam.UserNameOther, _setParam.BranchCode, _setParam.ChangeDate, _setParam.CreateDate);
                    BuildParamsTable(document);
                    break;
                case Methods.SetClientData:
                    Client client = new Client(_setParam.BranchCode, _setParam.ChangeDate, _setParam.CreateDate, _setParam.ClientType, _setParam.BirthDate,
                        _setParam.UserLoginOther, _setParam.UserNameOther);
                    BuildParamsTable(client);
                    break;
                case Methods.ActualizeIdDocs:
                    ActuaalizeDoc actualizeDoc = new ActuaalizeDoc(_setParam.BranchCode, _setParam.UserLoginOther, _setParam.UserNameOther, _setParam.CreateDate);
                    BuildParamsTable(actualizeDoc);
                    break;
                case Methods.SetAgreementData:
                    Agreement agreement = new Agreement(_setParam.ChangeDate, _setParam.CreateDate, _setParam.BranchCode,
                        _setParam.UserLoginOther, _setParam.UserNameOther, _setParam.AgreementType, _setParam.AgreementStatus, _setParam.AgreementOpenDate, new List<LinkedPerson>());
                    BuildParamsTable(agreement);
                    break;
                case Methods.GetDocumentData:
                    DocumentBinary documentBinary = new DocumentBinary();
                    BuildParamsTable(documentBinary);
                    break;
                case Methods.SetAccountDataU:
                    Account account = new Account(_setParam.ChangeDate, _setParam.CreateDate, _setParam.AccountOpenDate, _setParam.UserBranchCodeOther,
                        _setParam.UserLoginOther, _setParam.UserNameOther, _setParam.AccountTypeCode, _setParam.CurrencyCode, _setParam.AccountStatusCode);
                    BuildParamsTable(account);
                    break;
                case Methods.SetClientDataU:
                    CorpClient corpClient = new CorpClient(_setParam.UserBranchCodeOther, _setParam.ChangeDate, _setParam.CreateDate, _setParam.ClientType,
                        _setParam.UserLoginOther, _setParam.UserNameOther, new List<LinkedPerson>() , new List<NoClient>());
                    BuildParamsTable(corpClient);
                    break;
                case Methods.SetAgreementDataU:
                    CorpAgreement corpAgreement = new CorpAgreement(_setParam.ChangeDate, _setParam.CreateDate, _setParam.BranchCode, _setParam.UserLoginOther,
                        _setParam.UserNameOther, _setParam.AgreementType, _setParam.AgreementStatus, _setParam.ClientType, _setParam.AgreementOpenDate);
                    BuildParamsTable(corpAgreement);
                    break;
                case Methods.SetDictionaryData:
                    Branch branch = new Branch();
                    BuildParamsTable(branch);
                    break;
                case Methods.GetClientDataSed:
                    BuildParamsTable(new ClientDataSed());
                    break;
                case Methods.GetDocumentMetaDataSed:
                    BuildParamsTable(new DocumentMetadataSed());
                    break;
                case Methods.GetDictionaryDataSed:
                    BuildParamsTable(new DictionaryDataSed());
                    break;
                case Methods.SetDocumentAttributesSed:
                    var documentAttributeSed = new DocumentAttributeSed();//{ModifyDateTime = _setParam.ChangeDate};
                    IFormatProvider theCultureInfo = CultureInfo.InvariantCulture;
                    documentAttributeSed.ModifyDateTime = _setParam.ChangeDate.ToString(theCultureInfo);
                    BuildParamsTable(documentAttributeSed);
                    break;
            }
        }

        private void GenerateRequest()
        {

            string postData = CreatePostString((Methods)Enum.Parse(typeof(Methods), methodListView.SelectedItems[0].Text));

            requestRtb.Text = postData;
        }

        #region Interface

        private void AddNewLinkedPersonParams(string rnk, string state)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Param"));
            dt.Columns.Add(new DataColumn("Value"));
            dt.Columns.Add(new DataColumn("Type"));
            dt = (DataTable)paramsGridView.DataSource;
            // paramsGridView.DataSource = dt;

            var row = dt.NewRow();
            row[0] = "LinkedPerson Rnk";
            row[1] = rnk;
            row[2] = "LinkedPerson";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row[0] = "LinkedPerson StateId";
            row[1] = state;
            row[2] = "LinkedPerson";
            dt.Rows.Add(row);
            btAddLinkedPerson.Visible = true;
        }

        private void AddNewNoClientParams(string rnk, string state)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Param"));
            dt.Columns.Add(new DataColumn("Value"));
            dt.Columns.Add(new DataColumn("Type"));
            dt = (DataTable)paramsGridView.DataSource;
            // paramsGridView.DataSource = dt;

            var row = dt.NewRow();
            row[0] = "NoClient Number";
            row[1] = rnk;
            row[2] = "NoClient";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row[0] = "NoClient StateId";
            row[1] = state;
            row[2] = "NoClient";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row[0] = "NoClient FullName";
            row[1] = state;
            row[2] = "NoClient";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row[0] = "NoClient ClientType";
            row[1] = state;
            row[2] = "NoClient";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row[0] = "NoClient Ipn";
            row[1] = state;
            row[2] = "NoClient";
            dt.Rows.Add(row);

            btAddNoClient.Visible = true;
        }

        private void AddNewSedDocumentParams()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Param"));
            dt.Columns.Add(new DataColumn("Value"));
            dt.Columns.Add(new DataColumn("Type"));
            dt = (DataTable)paramsGridView.DataSource;
            // paramsGridView.DataSource = dt;

            var row = dt.NewRow();
            row[0] = "SedDoc Id";
            row[1] = string.Empty;
            row[2] = "SedDoc";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row[0] = "SedDoc Version";
            row[1] = string.Empty;
            row[2] = "SedDoc";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row[0] = DocumentProperties.Status;
            row[1] = string.Empty; 
            row[2] = "SedDocProperties";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row[0] = DocumentProperties.Location;
            row[1] = string.Empty; 
            row[2] = "SedDocProperties";
            dt.Rows.Add(row);
        }

        private void ResizeListView()
        {
            int height = mainSplitContainer.Panel1.Height / 3;
            methodListView.Height = height * 2;
            historyListView.Height = height;
        }

        private void ResizeParamsSplitContainer()
        {
            int i = paramSplitContainer.Panel2.Width / 2;
            generateButton.Width = i;
            sendRequestButton.Width = i;
        }

        private void ResizeScParams()
        {
            int i = paramSplitContainer.Panel2.Width / 2;
            btAddLinkedPerson.Width = btAddNoClient.Visible == true ? i : i * 2;
            btAddNoClient.Width = i;
            scParam.SplitterDistance = paramSplitContainer.Panel1.Height - 66;
        }

        private void OpenFileloadDialog(int rowIndex)
        {
            if (methodListView.SelectedItems.Count > 0)
            {
                if (methodListView.SelectedItems[0].Text == "SetDocumentDataWithBinary")
                {
                    if (rowIndex == 11)
                    {
                        OpenFileDialog openFileDialog = new OpenFileDialog();
                        openFileDialog.Filter = "JPEG and Tiff Files (*.jpeg, *.jpg, *.tiff, *.tif)|*.jpeg;*.jpg;*.tiff;*.tif|PDF files (*.pdf)| *.pdf";
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string localPath = Util.CopyImageToProgramFolder(openFileDialog.FileName);

                            paramsGridView.Rows[11].Cells[1].Value = localPath;// base64String.Substring(0, 50);
                        }
                    }
                }
            }
        }

        private void BuildParamsTable(BaseEntity data)
        {
            IsParamsTableFill = true;

            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Param"));
            dt.Columns.Add(new DataColumn("Value"));
            dt.Columns.Add(new DataColumn("Type"));

            foreach (var par in data.GetType().GetFields())
            {
                if (par.FieldType.FullName == "System.String")
                {
                    paramsGridView.DataSource = dt;

                    var row = dt.NewRow();

                    row[0] = par.Name;
                    row[1] = data.GetType().GetField(par.Name).GetValue(data);// GetValue(data, null);

                    dt.Rows.Add(row);

                    paramsGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    paramsGridView.Columns[0].ReadOnly = true;
                    paramsGridView.Columns[0].Width = 100;
                    paramsGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    paramsGridView.RowHeadersVisible = false;
                    scParam.Panel2Collapsed = true;
                    btAddLinkedPerson.Visible = false;
                    btAddNoClient.Visible = false;
                    btAddDocument.Visible = false;
                }

                if (par.Name == "LinkedPersons")
                {
                    if (data is Agreement)
                    {
                        var d = (Agreement) data;
                        foreach (var item in d.LinkedPersons)
                        {
                            AddNewLinkedPersonParams(item.Rnk, item.PersonState);
                        }
                    }
                    scParam.Panel2Collapsed = false;
                    btAddLinkedPerson.Visible = true;
                }

                if (par.Name == "NoClients")
                {
                    scParam.Panel2Collapsed = false;
                    btAddNoClient.Visible = true;
                }

                if (par.Name == "Documents")
                {
                    scParam.Panel2Collapsed = false;
                    btAddDocument.Visible = true;
                    btAddDocument.Dock = DockStyle.Fill;
                }
            }
            paramsGridView.Columns[2].Visible = false;
            ResizeScParams();
        }
        
        #endregion

       

        #endregion
    }

    public enum Methods
    {
        StartSession,
        CloseSession,
        SetAgreementData,
        SetDocumentDataWithOutBinary,
        SetDocumentDataWithBinary,
        ActualizeIdDocs,
        SetClientData,
        GetDocumentData,
        SetAccountDataU,
        SetClientDataU,
        SetAgreementDataU,
        SetDictionaryData,
        GetClientDataSed,
        GetDocumentMetaDataSed,
        GetDictionaryDataSed,
        SetDocumentAttributesSed
    }
}
