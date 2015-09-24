namespace BARS_Emulyator
{
    partial class CoreForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoreForm));
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.historyListView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.methodListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataSplitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBoxParams = new System.Windows.Forms.GroupBox();
            this.paramSplitContainer = new System.Windows.Forms.SplitContainer();
            this.scParam = new System.Windows.Forms.SplitContainer();
            this.paramsGridView = new System.Windows.Forms.DataGridView();
            this.btAddDocument = new System.Windows.Forms.Button();
            this.btAddLinkedPerson = new System.Windows.Forms.Button();
            this.btAddNoClient = new System.Windows.Forms.Button();
            this.sendRequestButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.requestGroupBox = new System.Windows.Forms.GroupBox();
            this.requestRtb = new System.Windows.Forms.RichTextBox();
            this.replyGroupBox = new System.Windows.Forms.GroupBox();
            this.replyRtb = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.openFileButton = new System.Windows.Forms.ToolStripButton();
            this.startSessionButton = new System.Windows.Forms.ToolStripButton();
            this.closeSessionButton = new System.Windows.Forms.ToolStripButton();
            this.generateReqStripButton = new System.Windows.Forms.ToolStripButton();
            this.sendButton = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveHistory = new System.Windows.Forms.ToolStripButton();
            this.tsbLoadHistory = new System.Windows.Forms.ToolStripButton();
            this.tsbRunHistory = new System.Windows.Forms.ToolStripButton();
            this.settingButton = new System.Windows.Forms.ToolStripButton();
            this.closeToolButton = new System.Windows.Forms.ToolStripButton();
            this.setDateTimeNowButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBoxSessionId = new System.Windows.Forms.ToolStripTextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSplitContainer)).BeginInit();
            this.dataSplitContainer.Panel1.SuspendLayout();
            this.dataSplitContainer.Panel2.SuspendLayout();
            this.dataSplitContainer.SuspendLayout();
            this.groupBoxParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paramSplitContainer)).BeginInit();
            this.paramSplitContainer.Panel1.SuspendLayout();
            this.paramSplitContainer.Panel2.SuspendLayout();
            this.paramSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scParam)).BeginInit();
            this.scParam.Panel1.SuspendLayout();
            this.scParam.Panel2.SuspendLayout();
            this.scParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paramsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.requestGroupBox.SuspendLayout();
            this.replyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.historyListView);
            this.mainSplitContainer.Panel1.Controls.Add(this.methodListView);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.dataSplitContainer);
            this.mainSplitContainer.Size = new System.Drawing.Size(886, 518);
            this.mainSplitContainer.SplitterDistance = 184;
            this.mainSplitContainer.TabIndex = 1;
            // 
            // historyListView
            // 
            this.historyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.historyListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.historyListView.FullRowSelect = true;
            this.historyListView.GridLines = true;
            this.historyListView.Location = new System.Drawing.Point(0, 228);
            this.historyListView.Name = "historyListView";
            this.historyListView.Size = new System.Drawing.Size(184, 290);
            this.historyListView.TabIndex = 1;
            this.historyListView.UseCompatibleStateImageBehavior = false;
            this.historyListView.View = System.Windows.Forms.View.Details;
            this.historyListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.historyListView_ItemSelectionChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "History";
            this.columnHeader2.Width = 175;
            // 
            // methodListView
            // 
            this.methodListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.methodListView.Dock = System.Windows.Forms.DockStyle.Top;
            this.methodListView.FullRowSelect = true;
            this.methodListView.GridLines = true;
            this.methodListView.Location = new System.Drawing.Point(0, 0);
            this.methodListView.Name = "methodListView";
            this.methodListView.Size = new System.Drawing.Size(184, 210);
            this.methodListView.TabIndex = 0;
            this.methodListView.UseCompatibleStateImageBehavior = false;
            this.methodListView.View = System.Windows.Forms.View.Details;
            this.methodListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.methodListView_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Method";
            this.columnHeader1.Width = 175;
            // 
            // dataSplitContainer
            // 
            this.dataSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.dataSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.dataSplitContainer.Name = "dataSplitContainer";
            // 
            // dataSplitContainer.Panel1
            // 
            this.dataSplitContainer.Panel1.Controls.Add(this.groupBoxParams);
            // 
            // dataSplitContainer.Panel2
            // 
            this.dataSplitContainer.Panel2.Controls.Add(this.splitContainer3);
            this.dataSplitContainer.Size = new System.Drawing.Size(698, 518);
            this.dataSplitContainer.SplitterDistance = 251;
            this.dataSplitContainer.TabIndex = 0;
            // 
            // groupBoxParams
            // 
            this.groupBoxParams.Controls.Add(this.paramSplitContainer);
            this.groupBoxParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxParams.Location = new System.Drawing.Point(0, 0);
            this.groupBoxParams.Name = "groupBoxParams";
            this.groupBoxParams.Size = new System.Drawing.Size(251, 518);
            this.groupBoxParams.TabIndex = 0;
            this.groupBoxParams.TabStop = false;
            this.groupBoxParams.Text = "Params";
            // 
            // paramSplitContainer
            // 
            this.paramSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paramSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.paramSplitContainer.IsSplitterFixed = true;
            this.paramSplitContainer.Location = new System.Drawing.Point(3, 16);
            this.paramSplitContainer.Name = "paramSplitContainer";
            this.paramSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // paramSplitContainer.Panel1
            // 
            this.paramSplitContainer.Panel1.Controls.Add(this.scParam);
            // 
            // paramSplitContainer.Panel2
            // 
            this.paramSplitContainer.Panel2.Controls.Add(this.sendRequestButton);
            this.paramSplitContainer.Panel2.Controls.Add(this.generateButton);
            this.paramSplitContainer.Size = new System.Drawing.Size(245, 499);
            this.paramSplitContainer.SplitterDistance = 461;
            this.paramSplitContainer.TabIndex = 1;
            this.paramSplitContainer.Resize += new System.EventHandler(this.paramSplitContainer_Resize);
            // 
            // scParam
            // 
            this.scParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scParam.IsSplitterFixed = true;
            this.scParam.Location = new System.Drawing.Point(0, 0);
            this.scParam.Name = "scParam";
            this.scParam.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scParam.Panel1
            // 
            this.scParam.Panel1.Controls.Add(this.paramsGridView);
            // 
            // scParam.Panel2
            // 
            this.scParam.Panel2.Controls.Add(this.btAddDocument);
            this.scParam.Panel2.Controls.Add(this.btAddLinkedPerson);
            this.scParam.Panel2.Controls.Add(this.btAddNoClient);
            this.scParam.Size = new System.Drawing.Size(245, 461);
            this.scParam.SplitterDistance = 391;
            this.scParam.TabIndex = 3;
            // 
            // paramsGridView
            // 
            this.paramsGridView.AllowUserToAddRows = false;
            this.paramsGridView.AllowUserToDeleteRows = false;
            this.paramsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paramsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paramsGridView.Location = new System.Drawing.Point(0, 0);
            this.paramsGridView.Name = "paramsGridView";
            this.paramsGridView.RowHeadersVisible = false;
            this.paramsGridView.Size = new System.Drawing.Size(245, 391);
            this.paramsGridView.TabIndex = 0;
            this.paramsGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.paramsGridView_CellBeginEdit);
            this.paramsGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.paramsGridView_CellDoubleClick);
            this.paramsGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.paramsGridView_CellEnter);
            this.paramsGridView.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.paramsGridView_ColumnAdded);
            // 
            // btAddDocument
            // 
            this.btAddDocument.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAddDocument.BackgroundImage")));
            this.btAddDocument.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAddDocument.Dock = System.Windows.Forms.DockStyle.Right;
            this.btAddDocument.Location = new System.Drawing.Point(121, 0);
            this.btAddDocument.Name = "btAddDocument";
            this.btAddDocument.Size = new System.Drawing.Size(62, 66);
            this.btAddDocument.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btAddDocument, "Add Document");
            this.btAddDocument.UseVisualStyleBackColor = true;
            this.btAddDocument.Click += new System.EventHandler(this.btAddDocument_Click);
            // 
            // btAddLinkedPerson
            // 
            this.btAddLinkedPerson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAddLinkedPerson.BackgroundImage")));
            this.btAddLinkedPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAddLinkedPerson.Dock = System.Windows.Forms.DockStyle.Right;
            this.btAddLinkedPerson.Location = new System.Drawing.Point(183, 0);
            this.btAddLinkedPerson.Name = "btAddLinkedPerson";
            this.btAddLinkedPerson.Size = new System.Drawing.Size(62, 66);
            this.btAddLinkedPerson.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btAddLinkedPerson, "Add Linked Person");
            this.btAddLinkedPerson.UseVisualStyleBackColor = true;
            this.btAddLinkedPerson.Click += new System.EventHandler(this.btAddLinkedPerson_Click);
            // 
            // btAddNoClient
            // 
            this.btAddNoClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAddNoClient.BackgroundImage")));
            this.btAddNoClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAddNoClient.Dock = System.Windows.Forms.DockStyle.Left;
            this.btAddNoClient.Location = new System.Drawing.Point(0, 0);
            this.btAddNoClient.Name = "btAddNoClient";
            this.btAddNoClient.Size = new System.Drawing.Size(82, 66);
            this.btAddNoClient.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btAddNoClient, "Add No Client");
            this.btAddNoClient.UseVisualStyleBackColor = true;
            this.btAddNoClient.Click += new System.EventHandler(this.btAddNoClient_Click);
            // 
            // sendRequestButton
            // 
            this.sendRequestButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.sendRequestButton.Location = new System.Drawing.Point(156, 0);
            this.sendRequestButton.Name = "sendRequestButton";
            this.sendRequestButton.Size = new System.Drawing.Size(89, 34);
            this.sendRequestButton.TabIndex = 1;
            this.sendRequestButton.Text = "Send Request";
            this.sendRequestButton.UseVisualStyleBackColor = true;
            this.sendRequestButton.Click += new System.EventHandler(this.sendRequestButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.generateButton.Location = new System.Drawing.Point(0, 0);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(115, 34);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Generate Request";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.requestGroupBox);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.replyGroupBox);
            this.splitContainer3.Size = new System.Drawing.Size(443, 518);
            this.splitContainer3.SplitterDistance = 247;
            this.splitContainer3.TabIndex = 0;
            // 
            // requestGroupBox
            // 
            this.requestGroupBox.Controls.Add(this.requestRtb);
            this.requestGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestGroupBox.Location = new System.Drawing.Point(0, 0);
            this.requestGroupBox.Name = "requestGroupBox";
            this.requestGroupBox.Size = new System.Drawing.Size(443, 247);
            this.requestGroupBox.TabIndex = 0;
            this.requestGroupBox.TabStop = false;
            this.requestGroupBox.Text = "Request";
            // 
            // requestRtb
            // 
            this.requestRtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestRtb.Location = new System.Drawing.Point(3, 16);
            this.requestRtb.Name = "requestRtb";
            this.requestRtb.Size = new System.Drawing.Size(437, 228);
            this.requestRtb.TabIndex = 0;
            this.requestRtb.Text = "";
            this.requestRtb.Leave += new System.EventHandler(this.requestRtb_Leave);
            // 
            // replyGroupBox
            // 
            this.replyGroupBox.Controls.Add(this.replyRtb);
            this.replyGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.replyGroupBox.Location = new System.Drawing.Point(0, 0);
            this.replyGroupBox.Name = "replyGroupBox";
            this.replyGroupBox.Size = new System.Drawing.Size(443, 267);
            this.replyGroupBox.TabIndex = 1;
            this.replyGroupBox.TabStop = false;
            this.replyGroupBox.Text = "Reply";
            // 
            // replyRtb
            // 
            this.replyRtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.replyRtb.Location = new System.Drawing.Point(3, 16);
            this.replyRtb.Name = "replyRtb";
            this.replyRtb.Size = new System.Drawing.Size(437, 248);
            this.replyRtb.TabIndex = 0;
            this.replyRtb.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStripMenu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mainSplitContainer);
            this.splitContainer1.Size = new System.Drawing.Size(886, 557);
            this.splitContainer1.SplitterDistance = 35;
            this.splitContainer1.TabIndex = 3;
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveButton,
            this.openFileButton,
            this.startSessionButton,
            this.closeSessionButton,
            this.generateReqStripButton,
            this.sendButton,
            this.tsbSaveHistory,
            this.tsbLoadHistory,
            this.tsbRunHistory,
            this.settingButton,
            this.closeToolButton,
            this.setDateTimeNowButton,
            this.toolStripComboBox,
            this.toolStripTextBoxSessionId});
            this.toolStripMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(886, 37);
            this.toolStripMenu.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(34, 34);
            this.saveButton.ToolTipText = "Save request to file";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openFileButton.Image = ((System.Drawing.Image)(resources.GetObject("openFileButton.Image")));
            this.openFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(34, 34);
            this.openFileButton.ToolTipText = "Open file";
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // startSessionButton
            // 
            this.startSessionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.startSessionButton.Image = ((System.Drawing.Image)(resources.GetObject("startSessionButton.Image")));
            this.startSessionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startSessionButton.Name = "startSessionButton";
            this.startSessionButton.Size = new System.Drawing.Size(34, 34);
            this.startSessionButton.ToolTipText = "Start session";
            this.startSessionButton.Click += new System.EventHandler(this.startSessionButton_Click);
            // 
            // closeSessionButton
            // 
            this.closeSessionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeSessionButton.Image = ((System.Drawing.Image)(resources.GetObject("closeSessionButton.Image")));
            this.closeSessionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeSessionButton.Name = "closeSessionButton";
            this.closeSessionButton.Size = new System.Drawing.Size(34, 34);
            this.closeSessionButton.ToolTipText = "Close session";
            this.closeSessionButton.Click += new System.EventHandler(this.closeSessionButton_Click);
            // 
            // generateReqStripButton
            // 
            this.generateReqStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.generateReqStripButton.Image = ((System.Drawing.Image)(resources.GetObject("generateReqStripButton.Image")));
            this.generateReqStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.generateReqStripButton.Name = "generateReqStripButton";
            this.generateReqStripButton.Size = new System.Drawing.Size(34, 34);
            this.generateReqStripButton.Text = "Generate Request";
            this.generateReqStripButton.Click += new System.EventHandler(this.generateReqStripButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sendButton.Image = ((System.Drawing.Image)(resources.GetObject("sendButton.Image")));
            this.sendButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(34, 34);
            this.sendButton.ToolTipText = "Send Request";
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // tsbSaveHistory
            // 
            this.tsbSaveHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSaveHistory.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveHistory.Image")));
            this.tsbSaveHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveHistory.Name = "tsbSaveHistory";
            this.tsbSaveHistory.Size = new System.Drawing.Size(34, 34);
            this.tsbSaveHistory.Text = "Save User History";
            this.tsbSaveHistory.Click += new System.EventHandler(this.tsbSaveHistory_Click);
            // 
            // tsbLoadHistory
            // 
            this.tsbLoadHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLoadHistory.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoadHistory.Image")));
            this.tsbLoadHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoadHistory.Name = "tsbLoadHistory";
            this.tsbLoadHistory.Size = new System.Drawing.Size(34, 34);
            this.tsbLoadHistory.Text = "Load User History";
            this.tsbLoadHistory.Click += new System.EventHandler(this.tsbLoadHistory_Click);
            // 
            // tsbRunHistory
            // 
            this.tsbRunHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRunHistory.Image = ((System.Drawing.Image)(resources.GetObject("tsbRunHistory.Image")));
            this.tsbRunHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRunHistory.Name = "tsbRunHistory";
            this.tsbRunHistory.Size = new System.Drawing.Size(34, 34);
            this.tsbRunHistory.Text = "Run all history";
            this.tsbRunHistory.Click += new System.EventHandler(this.tsbRunHistory_Click);
            // 
            // settingButton
            // 
            this.settingButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.settingButton.Image = ((System.Drawing.Image)(resources.GetObject("settingButton.Image")));
            this.settingButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(34, 34);
            this.settingButton.ToolTipText = "Setting";
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // closeToolButton
            // 
            this.closeToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeToolButton.Image = ((System.Drawing.Image)(resources.GetObject("closeToolButton.Image")));
            this.closeToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeToolButton.Name = "closeToolButton";
            this.closeToolButton.Size = new System.Drawing.Size(34, 34);
            this.closeToolButton.ToolTipText = "Close tool";
            this.closeToolButton.Click += new System.EventHandler(this.closeToolButton_Click);
            // 
            // setDateTimeNowButton
            // 
            this.setDateTimeNowButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.setDateTimeNowButton.Image = ((System.Drawing.Image)(resources.GetObject("setDateTimeNowButton.Image")));
            this.setDateTimeNowButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.setDateTimeNowButton.Name = "setDateTimeNowButton";
            this.setDateTimeNowButton.Size = new System.Drawing.Size(34, 34);
            this.setDateTimeNowButton.Text = "toolStripButton1";
            this.setDateTimeNowButton.ToolTipText = "Set DateTime Now";
            this.setDateTimeNowButton.Click += new System.EventHandler(this.setDateTimeNowButton_Click);
            // 
            // toolStripComboBox
            // 
            this.toolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox.DropDownWidth = 200;
            this.toolStripComboBox.Name = "toolStripComboBox";
            this.toolStripComboBox.Size = new System.Drawing.Size(200, 37);
            this.toolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_SelectedIndexChanged);
            // 
            // toolStripTextBoxSessionId
            // 
            this.toolStripTextBoxSessionId.AutoToolTip = true;
            this.toolStripTextBoxSessionId.Name = "toolStripTextBoxSessionId";
            this.toolStripTextBoxSessionId.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripTextBoxSessionId.ReadOnly = true;
            this.toolStripTextBoxSessionId.Size = new System.Drawing.Size(200, 37);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.statusStrip);
            this.splitContainer2.Size = new System.Drawing.Size(886, 586);
            this.splitContainer2.SplitterDistance = 557;
            this.splitContainer2.TabIndex = 4;
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 3);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(886, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // CoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 586);
            this.Controls.Add(this.splitContainer2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CoreForm";
            this.Text = "BARS Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CoreForm_FormClosing);
            this.Resize += new System.EventHandler(this.CoreForm_Resize);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.dataSplitContainer.Panel1.ResumeLayout(false);
            this.dataSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSplitContainer)).EndInit();
            this.dataSplitContainer.ResumeLayout(false);
            this.groupBoxParams.ResumeLayout(false);
            this.paramSplitContainer.Panel1.ResumeLayout(false);
            this.paramSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paramSplitContainer)).EndInit();
            this.paramSplitContainer.ResumeLayout(false);
            this.scParam.Panel1.ResumeLayout(false);
            this.scParam.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scParam)).EndInit();
            this.scParam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paramsGridView)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.requestGroupBox.ResumeLayout(false);
            this.replyGroupBox.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.ListView methodListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.SplitContainer dataSplitContainer;
        private System.Windows.Forms.GroupBox groupBoxParams;
        private System.Windows.Forms.SplitContainer paramSplitContainer;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox requestGroupBox;
        private System.Windows.Forms.RichTextBox requestRtb;
        private System.Windows.Forms.GroupBox replyGroupBox;
        private System.Windows.Forms.RichTextBox replyRtb;
        private System.Windows.Forms.DataGridView paramsGridView;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton startSessionButton;
        private System.Windows.Forms.ToolStripButton closeSessionButton;
        private System.Windows.Forms.ToolStripButton sendButton;
        private System.Windows.Forms.ToolStripButton openFileButton;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton closeToolButton;
        private System.Windows.Forms.ToolStripButton settingButton;
        private System.Windows.Forms.ToolStripButton generateReqStripButton;
        private System.Windows.Forms.Button sendRequestButton;
        private System.Windows.Forms.ListView historyListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStripButton tsbSaveHistory;
        private System.Windows.Forms.ToolStripButton tsbLoadHistory;
        private System.Windows.Forms.ToolStripButton tsbRunHistory;
        private System.Windows.Forms.Button btAddLinkedPerson;
        private System.Windows.Forms.ToolStripButton setDateTimeNowButton;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox;
        private System.Windows.Forms.Button btAddNoClient;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSessionId;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SplitContainer scParam;
        private System.Windows.Forms.Button btAddDocument;
    }
}

