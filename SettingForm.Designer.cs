namespace BARS_Emulyator
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageDefault = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtpOpenDate = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.tbAccountCurrency = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbAccountType = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbAccountStatus = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpAgrOpenDate = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.tbAgrStatus = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbAgrType = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbClientType = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.dtpChangeDate = new System.Windows.Forms.DateTimePicker();
            this.dtpCreateDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbDefBranchCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDefBranch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbUserBranch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUserLogin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxStartSession = new System.Windows.Forms.GroupBox();
            this.tbUserPasswordSS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUserNameSS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUserLoginSS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.tbBarsIp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lvBarsUrls = new System.Windows.Forms.ListView();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl.SuspendLayout();
            this.tabPageDefault.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxStartSession.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageDefault);
            this.tabControl.Controls.Add(this.tabPageGeneral);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(593, 384);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageDefault
            // 
            this.tabPageDefault.Controls.Add(this.groupBox5);
            this.tabPageDefault.Controls.Add(this.groupBox4);
            this.tabPageDefault.Controls.Add(this.groupBox3);
            this.tabPageDefault.Controls.Add(this.groupBox2);
            this.tabPageDefault.Controls.Add(this.groupBox1);
            this.tabPageDefault.Controls.Add(this.groupBoxStartSession);
            this.tabPageDefault.Location = new System.Drawing.Point(4, 22);
            this.tabPageDefault.Name = "tabPageDefault";
            this.tabPageDefault.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDefault.Size = new System.Drawing.Size(585, 358);
            this.tabPageDefault.TabIndex = 1;
            this.tabPageDefault.Text = "Default Values";
            this.tabPageDefault.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtpOpenDate);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.tbAccountCurrency);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.tbAccountType);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.tbAccountStatus);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Location = new System.Drawing.Point(303, 225);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(273, 124);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Account params";
            // 
            // dtpOpenDate
            // 
            this.dtpOpenDate.Location = new System.Drawing.Point(82, 95);
            this.dtpOpenDate.Name = "dtpOpenDate";
            this.dtpOpenDate.Size = new System.Drawing.Size(185, 20);
            this.dtpOpenDate.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 98);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 13);
            this.label19.TabIndex = 9;
            this.label19.Text = "Open date";
            // 
            // tbAccountCurrency
            // 
            this.tbAccountCurrency.Location = new System.Drawing.Point(82, 69);
            this.tbAccountCurrency.Name = "tbAccountCurrency";
            this.tbAccountCurrency.Size = new System.Drawing.Size(185, 20);
            this.tbAccountCurrency.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 72);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Currency Code";
            // 
            // tbAccountType
            // 
            this.tbAccountType.Location = new System.Drawing.Point(82, 43);
            this.tbAccountType.Name = "tbAccountType";
            this.tbAccountType.Size = new System.Drawing.Size(185, 20);
            this.tbAccountType.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 46);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Account Type";
            // 
            // tbAccountStatus
            // 
            this.tbAccountStatus.Location = new System.Drawing.Point(82, 17);
            this.tbAccountStatus.Name = "tbAccountStatus";
            this.tbAccountStatus.Size = new System.Drawing.Size(185, 20);
            this.tbAccountStatus.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Status Code";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpAgrOpenDate);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.tbAgrStatus);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.tbAgrType);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.tbClientType);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(9, 225);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(273, 124);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Other params";
            // 
            // dtpAgrOpenDate
            // 
            this.dtpAgrOpenDate.Location = new System.Drawing.Point(82, 95);
            this.dtpAgrOpenDate.Name = "dtpAgrOpenDate";
            this.dtpAgrOpenDate.Size = new System.Drawing.Size(185, 20);
            this.dtpAgrOpenDate.TabIndex = 12;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 98);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 13);
            this.label20.TabIndex = 11;
            this.label20.Text = "Agr open date";
            // 
            // tbAgrStatus
            // 
            this.tbAgrStatus.Location = new System.Drawing.Point(66, 69);
            this.tbAgrStatus.Name = "tbAgrStatus";
            this.tbAgrStatus.Size = new System.Drawing.Size(201, 20);
            this.tbAgrStatus.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Agr Status";
            // 
            // tbAgrType
            // 
            this.tbAgrType.Location = new System.Drawing.Point(66, 43);
            this.tbAgrType.Name = "tbAgrType";
            this.tbAgrType.Size = new System.Drawing.Size(201, 20);
            this.tbAgrType.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Agr Type";
            // 
            // tbClientType
            // 
            this.tbClientType.Location = new System.Drawing.Point(66, 17);
            this.tbClientType.Name = "tbClientType";
            this.tbClientType.Size = new System.Drawing.Size(201, 20);
            this.tbClientType.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "ClientType";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpBirthDate);
            this.groupBox3.Controls.Add(this.dtpChangeDate);
            this.groupBox3.Controls.Add(this.dtpCreateDate);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(303, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 104);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Date Setting";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(82, 67);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(185, 20);
            this.dtpBirthDate.TabIndex = 8;
            // 
            // dtpChangeDate
            // 
            this.dtpChangeDate.Location = new System.Drawing.Point(82, 43);
            this.dtpChangeDate.Name = "dtpChangeDate";
            this.dtpChangeDate.Size = new System.Drawing.Size(185, 20);
            this.dtpChangeDate.TabIndex = 7;
            // 
            // dtpCreateDate
            // 
            this.dtpCreateDate.Location = new System.Drawing.Point(82, 17);
            this.dtpCreateDate.Name = "dtpCreateDate";
            this.dtpCreateDate.Size = new System.Drawing.Size(185, 20);
            this.dtpCreateDate.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Birth date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Change date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Create date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbDefBranchCode);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbDefBranch);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(9, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 104);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Default Branch";
            // 
            // tbDefBranchCode
            // 
            this.tbDefBranchCode.Location = new System.Drawing.Point(82, 67);
            this.tbDefBranchCode.Name = "tbDefBranchCode";
            this.tbDefBranchCode.Size = new System.Drawing.Size(185, 20);
            this.tbDefBranchCode.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Branch Code";
            // 
            // tbDefBranch
            // 
            this.tbDefBranch.Location = new System.Drawing.Point(66, 17);
            this.tbDefBranch.Multiline = true;
            this.tbDefBranch.Name = "tbDefBranch";
            this.tbDefBranch.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbDefBranch.Size = new System.Drawing.Size(201, 42);
            this.tbDefBranch.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Branch";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbUserBranch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbUserName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbUserLogin);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(303, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 102);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Users Data";
            // 
            // tbUserBranch
            // 
            this.tbUserBranch.Location = new System.Drawing.Point(82, 69);
            this.tbUserBranch.Name = "tbUserBranch";
            this.tbUserBranch.Size = new System.Drawing.Size(185, 20);
            this.tbUserBranch.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Branch Code";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(66, 43);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(201, 20);
            this.tbUserName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Name";
            // 
            // tbUserLogin
            // 
            this.tbUserLogin.Location = new System.Drawing.Point(66, 17);
            this.tbUserLogin.Name = "tbUserLogin";
            this.tbUserLogin.Size = new System.Drawing.Size(201, 20);
            this.tbUserLogin.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Login";
            // 
            // groupBoxStartSession
            // 
            this.groupBoxStartSession.Controls.Add(this.tbUserPasswordSS);
            this.groupBoxStartSession.Controls.Add(this.label3);
            this.groupBoxStartSession.Controls.Add(this.tbUserNameSS);
            this.groupBoxStartSession.Controls.Add(this.label2);
            this.groupBoxStartSession.Controls.Add(this.tbUserLoginSS);
            this.groupBoxStartSession.Controls.Add(this.label1);
            this.groupBoxStartSession.Location = new System.Drawing.Point(9, 7);
            this.groupBoxStartSession.Name = "groupBoxStartSession";
            this.groupBoxStartSession.Size = new System.Drawing.Size(273, 102);
            this.groupBoxStartSession.TabIndex = 0;
            this.groupBoxStartSession.TabStop = false;
            this.groupBoxStartSession.Text = "Start Session Credentials";
            // 
            // tbUserPasswordSS
            // 
            this.tbUserPasswordSS.Location = new System.Drawing.Point(66, 69);
            this.tbUserPasswordSS.Name = "tbUserPasswordSS";
            this.tbUserPasswordSS.Size = new System.Drawing.Size(201, 20);
            this.tbUserPasswordSS.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // tbUserNameSS
            // 
            this.tbUserNameSS.Location = new System.Drawing.Point(66, 43);
            this.tbUserNameSS.Name = "tbUserNameSS";
            this.tbUserNameSS.Size = new System.Drawing.Size(201, 20);
            this.tbUserNameSS.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // tbUserLoginSS
            // 
            this.tbUserLoginSS.Location = new System.Drawing.Point(66, 17);
            this.tbUserLoginSS.Name = "tbUserLoginSS";
            this.tbUserLoginSS.Size = new System.Drawing.Size(201, 20);
            this.tbUserLoginSS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.btSave);
            this.tabPageGeneral.Controls.Add(this.btRemove);
            this.tabPageGeneral.Controls.Add(this.btAdd);
            this.tabPageGeneral.Controls.Add(this.lvBarsUrls);
            this.tabPageGeneral.Controls.Add(this.tbBarsIp);
            this.tabPageGeneral.Controls.Add(this.label8);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(585, 358);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "General";
            this.tabPageGeneral.ToolTipText = "General";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // tbBarsIp
            // 
            this.tbBarsIp.Location = new System.Drawing.Point(76, 21);
            this.tbBarsIp.Name = "tbBarsIp";
            this.tbBarsIp.Size = new System.Drawing.Size(201, 20);
            this.tbBarsIp.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "BARS URL";
            // 
            // lvBarsUrls
            // 
            this.lvBarsUrls.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvBarsUrls.FullRowSelect = true;
            this.lvBarsUrls.GridLines = true;
            this.lvBarsUrls.Location = new System.Drawing.Point(76, 48);
            this.lvBarsUrls.Name = "lvBarsUrls";
            this.lvBarsUrls.Size = new System.Drawing.Size(201, 116);
            this.lvBarsUrls.TabIndex = 4;
            this.lvBarsUrls.UseCompatibleStateImageBehavior = false;
            this.lvBarsUrls.View = System.Windows.Forms.View.Details;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(283, 19);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 5;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(283, 48);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(75, 23);
            this.btRemove.TabIndex = 6;
            this.btRemove.Text = "Delete";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(283, 141);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(74, 23);
            this.btSave.TabIndex = 7;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Bars urls";
            this.columnHeader1.Width = 196;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 384);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingForm";
            this.ShowInTaskbar = false;
            this.Text = "SettingForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingForm_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tabPageDefault.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxStartSession.ResumeLayout(false);
            this.groupBoxStartSession.PerformLayout();
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.TabPage tabPageDefault;
        private System.Windows.Forms.TextBox tbBarsIp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbAgrType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbClientType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.DateTimePicker dtpChangeDate;
        private System.Windows.Forms.DateTimePicker dtpCreateDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbDefBranchCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDefBranch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbUserBranch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbUserLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxStartSession;
        private System.Windows.Forms.TextBox tbUserPasswordSS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUserNameSS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUserLoginSS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAgrStatus;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dtpOpenDate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbAccountCurrency;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbAccountType;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbAccountStatus;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtpAgrOpenDate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.ListView lvBarsUrls;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}