using System;
using System.Linq;
using System.Windows.Forms;

namespace BARS_Emulyator
{
    public partial class SettingForm : Form
    {
        private Setting _setParams = null;
        public SettingForm(Setting pSetting)
        {
            InitializeComponent();
            _setParams = pSetting;
            BindForm();
        }

        private void BindForm()
        {
            //tbBarsIp.DataBindings.Add("Text", _setParams, Util.GetPropertyName(() => _setParams.CurrentBarsUrl));

            tbClientType.DataBindings.Add("Text", _setParams, Util.GetPropertyName(() => _setParams.ClientType));
            tbUserBranch.DataBindings.Add("Text", _setParams, Util.GetPropertyName(() => _setParams.UserBranchCodeOther));
            tbUserLogin.DataBindings.Add("Text", _setParams, Util.GetPropertyName(() => _setParams.UserLoginOther));

            tbUserLoginSS.DataBindings.Add("Text", _setParams, Util.GetPropertyName(() => _setParams.UserLoginSs));
            tbUserName.DataBindings.Add("Text", _setParams, Util.GetPropertyName(() => _setParams.UserNameOther));
            tbUserNameSS.DataBindings.Add("Text", _setParams, Util.GetPropertyName(() => _setParams.UserNameSs));
            tbUserPasswordSS.DataBindings.Add("Text", _setParams, Util.GetPropertyName(() => _setParams.UserPasswordSs));
            tbAgrStatus.DataBindings.Add("Text", _setParams, Util.GetPropertyName(() => _setParams.AgreementStatus));
            tbAgrType.DataBindings.Add("Text", _setParams, Util.GetPropertyName(() => _setParams.AgreementType));
            tbDefBranch.DataBindings.Add("Text", _setParams, Util.GetPropertyName(() => _setParams.BranchName));
            tbDefBranchCode.DataBindings.Add("Text", _setParams, Util.GetPropertyName(() => _setParams.BranchCode));

            tbAccountCurrency.DataBindings.Add("Text", _setParams, Util.GetPropertyName(() => _setParams.CurrencyCode));
            tbAccountStatus.DataBindings.Add("Text", _setParams, Util.GetPropertyName(() => _setParams.AccountStatusCode));
            tbAccountType.DataBindings.Add("Text", _setParams, Util.GetPropertyName(() => _setParams.AccountTypeCode));

            //_setParams.AccountOpenDate = DateTime.Now;
            if (_setParams.AgreementOpenDate > dtpAgrOpenDate.MinDate)
                dtpAgrOpenDate.DataBindings.Add("Value", _setParams, Util.GetPropertyName(() => _setParams.AgreementOpenDate));

            if (_setParams.AccountOpenDate > dtpOpenDate.MinDate)
                dtpOpenDate.DataBindings.Add("Value", _setParams, Util.GetPropertyName(() => _setParams.AccountOpenDate));

            if (_setParams.BirthDate > dtpBirthDate.MinDate)
                dtpBirthDate.DataBindings.Add("Value", _setParams, Util.GetPropertyName(() => _setParams.BirthDate));

            if (_setParams.ChangeDate > dtpChangeDate.MinDate)
                dtpChangeDate.DataBindings.Add("Value", _setParams, Util.GetPropertyName(() => _setParams.ChangeDate));

            if (_setParams.CreateDate > dtpCreateDate.MinDate)
                dtpCreateDate.DataBindings.Add("Value", _setParams, Util.GetPropertyName(() => _setParams.CreateDate));

            lvBarsUrls.Items.Clear();
            foreach (var item in _setParams.AllBarsUrlList)
            {
                lvBarsUrls.Items.Add(item);
            }
            //lvBarsUrls.Items.
        }

        public Setting GetSetting()
        {
            return _setParams;
        }

        private void SettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CheckBarsUrl())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string url = tbBarsIp.Text.Trim();

            if (url.Length > 5)
            {
                lvBarsUrls.Items.Add(url);
                tbBarsIp.Text = String.Empty;
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if(lvBarsUrls.SelectedIndices.Count > 0)
                lvBarsUrls.Items.RemoveAt(lvBarsUrls.SelectedIndices[0]);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (CheckBarsUrl())
            {
                _setParams.AllBarsUrlList.Clear();
                foreach (ListViewItem item in lvBarsUrls.Items)
                {
                    _setParams.AllBarsUrlList.Add(item.Text);
                }
                _setParams.CurrentBarsUrl = _setParams.AllBarsUrlList.First();
            }
        }

        private bool CheckBarsUrl()
        {
            if (lvBarsUrls.Items.Count > 0)
                return true;
            else
            {
                MessageBox.Show("Must be more that one BARS Url in list");
                return false;
            }
        }
    }
}
