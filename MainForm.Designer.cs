namespace BitMonk
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.myMnsCountLabel = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.inputsCountLabel = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.stakeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.logMessageLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.currentAddressLabel = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sendCommentInput = new System.Windows.Forms.TextBox();
            this.txIdLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sendAmountInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.sendAddressInput = new System.Windows.Forms.TextBox();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.transactionsGridView = new System.Windows.Forms.DataGridView();
            this.Conf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.mnAddButton = new System.Windows.Forms.Button();
            this.mnUpdateButton = new System.Windows.Forms.Button();
            this.masternodesGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.consoleTextBox = new System.Windows.Forms.RichTextBox();
            this.commandBox = new System.Windows.Forms.TextBox();
            this.peersCountLabel = new System.Windows.Forms.Label();
            this.mnCounLabel = new System.Windows.Forms.Label();
            this.syncLabel = new System.Windows.Forms.Label();
            this.pVerLabel = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.protocolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masternodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masternodesGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masternodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(397, 374);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.logMessageLabel);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.balanceLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(389, 348);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Wallet";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.myMnsCountLabel);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.inputsCountLabel);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.stakeLinkLabel);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(10, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(372, 77);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "POS info";
            // 
            // myMnsCountLabel
            // 
            this.myMnsCountLabel.AutoSize = true;
            this.myMnsCountLabel.Location = new System.Drawing.Point(253, 26);
            this.myMnsCountLabel.Name = "myMnsCountLabel";
            this.myMnsCountLabel.Size = new System.Drawing.Size(38, 13);
            this.myMnsCountLabel.TabIndex = 15;
            this.myMnsCountLabel.TabStop = true;
            this.myMnsCountLabel.Text = "sync...";
            this.myMnsCountLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.myMnsCountLabel_LinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(205, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "My MN:";
            // 
            // inputsCountLabel
            // 
            this.inputsCountLabel.AutoSize = true;
            this.inputsCountLabel.Location = new System.Drawing.Point(43, 49);
            this.inputsCountLabel.Name = "inputsCountLabel";
            this.inputsCountLabel.Size = new System.Drawing.Size(38, 13);
            this.inputsCountLabel.TabIndex = 13;
            this.inputsCountLabel.TabStop = true;
            this.inputsCountLabel.Text = "sync...";
            this.inputsCountLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.inputsCountLabel_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Inputs:";
            // 
            // stakeLinkLabel
            // 
            this.stakeLinkLabel.AutoSize = true;
            this.stakeLinkLabel.Location = new System.Drawing.Point(42, 26);
            this.stakeLinkLabel.Name = "stakeLinkLabel";
            this.stakeLinkLabel.Size = new System.Drawing.Size(65, 13);
            this.stakeLinkLabel.TabIndex = 11;
            this.stakeLinkLabel.TabStop = true;
            this.stakeLinkLabel.Text = "sync... BMO";
            this.stakeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.stakeLinkLabel_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Stake:";
            // 
            // logMessageLabel
            // 
            this.logMessageLabel.AutoSize = true;
            this.logMessageLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.logMessageLabel.Location = new System.Drawing.Point(6, 318);
            this.logMessageLabel.Name = "logMessageLabel";
            this.logMessageLabel.Size = new System.Drawing.Size(16, 13);
            this.logMessageLabel.TabIndex = 10;
            this.logMessageLabel.Text = "...";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.currentAddressLabel);
            this.groupBox2.Location = new System.Drawing.Point(10, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 80);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Your current address for receive coins";
            // 
            // currentAddressLabel
            // 
            this.currentAddressLabel.Location = new System.Drawing.Point(6, 32);
            this.currentAddressLabel.Name = "currentAddressLabel";
            this.currentAddressLabel.Size = new System.Drawing.Size(361, 20);
            this.currentAddressLabel.TabIndex = 6;
            this.currentAddressLabel.Click += new System.EventHandler(this.currentAddressLabel_Click);
            this.currentAddressLabel.TextChanged += new System.EventHandler(this.currentAddressLabel_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.sendCommentInput);
            this.groupBox1.Controls.Add(this.txIdLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.sendAmountInput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sendButton);
            this.groupBox1.Controls.Add(this.sendAddressInput);
            this.groupBox1.Location = new System.Drawing.Point(9, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 109);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send coins to address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Comment";
            // 
            // sendCommentInput
            // 
            this.sendCommentInput.Location = new System.Drawing.Point(64, 45);
            this.sendCommentInput.Name = "sendCommentInput";
            this.sendCommentInput.Size = new System.Drawing.Size(303, 20);
            this.sendCommentInput.TabIndex = 12;
            // 
            // txIdLabel
            // 
            this.txIdLabel.AutoSize = true;
            this.txIdLabel.Location = new System.Drawing.Point(7, 81);
            this.txIdLabel.Name = "txIdLabel";
            this.txIdLabel.Size = new System.Drawing.Size(0, 13);
            this.txIdLabel.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Amount";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // sendAmountInput
            // 
            this.sendAmountInput.Location = new System.Drawing.Point(64, 73);
            this.sendAmountInput.Name = "sendAmountInput";
            this.sendAmountInput.Size = new System.Drawing.Size(186, 20);
            this.sendAmountInput.TabIndex = 9;
            this.sendAmountInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sendAmountInput_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Address";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(256, 71);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(111, 23);
            this.sendButton.TabIndex = 7;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // sendAddressInput
            // 
            this.sendAddressInput.Location = new System.Drawing.Point(64, 19);
            this.sendAddressInput.Name = "sendAddressInput";
            this.sendAddressInput.Size = new System.Drawing.Size(303, 20);
            this.sendAddressInput.TabIndex = 6;
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balanceLabel.Location = new System.Drawing.Point(12, 14);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(104, 20);
            this.balanceLabel.TabIndex = 2;
            this.balanceLabel.Text = "sync... BMO";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.transactionsGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(389, 348);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Transactions";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // transactionsGridView
            // 
            this.transactionsGridView.AllowUserToDeleteRows = false;
            this.transactionsGridView.AllowUserToOrderColumns = true;
            this.transactionsGridView.AutoGenerateColumns = false;
            this.transactionsGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.transactionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.amountDataGridViewTextBoxColumn,
            this.Conf,
            this.dateDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.Address,
            this.idDataGridViewTextBoxColumn});
            this.transactionsGridView.DataSource = this.transactionBindingSource;
            this.transactionsGridView.Location = new System.Drawing.Point(4, 4);
            this.transactionsGridView.Name = "transactionsGridView";
            this.transactionsGridView.ReadOnly = true;
            this.transactionsGridView.Size = new System.Drawing.Size(382, 341);
            this.transactionsGridView.TabIndex = 0;
            // 
            // Conf
            // 
            this.Conf.DataPropertyName = "Conf";
            this.Conf.HeaderText = "Conf";
            this.Conf.Name = "Conf";
            this.Conf.ReadOnly = true;
            this.Conf.Width = 45;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.mnAddButton);
            this.tabPage3.Controls.Add(this.mnUpdateButton);
            this.tabPage3.Controls.Add(this.masternodesGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(389, 348);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MN list";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // mnAddButton
            // 
            this.mnAddButton.Location = new System.Drawing.Point(310, 316);
            this.mnAddButton.Name = "mnAddButton";
            this.mnAddButton.Size = new System.Drawing.Size(75, 23);
            this.mnAddButton.TabIndex = 3;
            this.mnAddButton.Text = "My MN";
            this.mnAddButton.UseMnemonic = false;
            this.mnAddButton.UseVisualStyleBackColor = true;
            this.mnAddButton.Click += new System.EventHandler(this.mnAddButton_Click);
            // 
            // mnUpdateButton
            // 
            this.mnUpdateButton.Location = new System.Drawing.Point(3, 316);
            this.mnUpdateButton.Name = "mnUpdateButton";
            this.mnUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.mnUpdateButton.TabIndex = 2;
            this.mnUpdateButton.Text = "Update";
            this.mnUpdateButton.UseMnemonic = false;
            this.mnUpdateButton.UseVisualStyleBackColor = true;
            this.mnUpdateButton.Click += new System.EventHandler(this.mnUpdateButton_Click);
            // 
            // masternodesGridView
            // 
            this.masternodesGridView.AllowUserToDeleteRows = false;
            this.masternodesGridView.AllowUserToOrderColumns = true;
            this.masternodesGridView.AutoGenerateColumns = false;
            this.masternodesGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.masternodesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.masternodesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statusDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.protocolDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn});
            this.masternodesGridView.DataSource = this.masternodeBindingSource;
            this.masternodesGridView.Location = new System.Drawing.Point(3, 3);
            this.masternodesGridView.Name = "masternodesGridView";
            this.masternodesGridView.ReadOnly = true;
            this.masternodesGridView.Size = new System.Drawing.Size(382, 306);
            this.masternodesGridView.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(389, 348);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Exchange";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Decentralized exchange is coming...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Black;
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.consoleTextBox);
            this.tabPage5.Controls.Add(this.commandBox);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(389, 348);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Console";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(6, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Command";
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.consoleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.consoleTextBox.Location = new System.Drawing.Point(7, 57);
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.Size = new System.Drawing.Size(376, 285);
            this.consoleTextBox.TabIndex = 1;
            this.consoleTextBox.Text = "";
            // 
            // commandBox
            // 
            this.commandBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.commandBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.commandBox.Location = new System.Drawing.Point(7, 31);
            this.commandBox.Name = "commandBox";
            this.commandBox.Size = new System.Drawing.Size(376, 20);
            this.commandBox.TabIndex = 0;
            this.commandBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.commandBox_KeyDown);
            this.commandBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.commandBox_KeyPress);
            // 
            // peersCountLabel
            // 
            this.peersCountLabel.AutoSize = true;
            this.peersCountLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.peersCountLabel.Location = new System.Drawing.Point(252, 389);
            this.peersCountLabel.Name = "peersCountLabel";
            this.peersCountLabel.Size = new System.Drawing.Size(46, 13);
            this.peersCountLabel.TabIndex = 1;
            this.peersCountLabel.Text = "Peers: 0";
            // 
            // mnCounLabel
            // 
            this.mnCounLabel.AutoSize = true;
            this.mnCounLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.mnCounLabel.Location = new System.Drawing.Point(171, 389);
            this.mnCounLabel.Name = "mnCounLabel";
            this.mnCounLabel.Size = new System.Drawing.Size(66, 13);
            this.mnCounLabel.TabIndex = 2;
            this.mnCounLabel.Text = "MN count: 0";
            // 
            // syncLabel
            // 
            this.syncLabel.AutoSize = true;
            this.syncLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.syncLabel.Location = new System.Drawing.Point(13, 389);
            this.syncLabel.Name = "syncLabel";
            this.syncLabel.Size = new System.Drawing.Size(40, 13);
            this.syncLabel.TabIndex = 4;
            this.syncLabel.Text = "Sync: -";
            // 
            // pVerLabel
            // 
            this.pVerLabel.AutoSize = true;
            this.pVerLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.pVerLabel.Location = new System.Drawing.Point(332, 389);
            this.pVerLabel.Name = "pVerLabel";
            this.pVerLabel.Size = new System.Drawing.Size(39, 13);
            this.pVerLabel.TabIndex = 5;
            this.pVerLabel.Text = "PVer: -";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Bitmonk";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 50;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(BitMonk.Entities.Transaction);
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 75;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // protocolDataGridViewTextBoxColumn
            // 
            this.protocolDataGridViewTextBoxColumn.DataPropertyName = "Protocol";
            this.protocolDataGridViewTextBoxColumn.HeaderText = "Protocol";
            this.protocolDataGridViewTextBoxColumn.Name = "protocolDataGridViewTextBoxColumn";
            this.protocolDataGridViewTextBoxColumn.ReadOnly = true;
            this.protocolDataGridViewTextBoxColumn.Width = 51;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // masternodeBindingSource
            // 
            this.masternodeBindingSource.DataSource = typeof(BitMonk.Entities.Masternode);
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataSource = typeof(BitMonk.Collections.Transactions);
            // 
            // transactionBindingSource1
            // 
            this.transactionBindingSource1.DataSource = typeof(BitMonk.Entities.Transaction);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(421, 410);
            this.Controls.Add(this.pVerLabel);
            this.Controls.Add(this.syncLabel);
            this.Controls.Add(this.mnCounLabel);
            this.Controls.Add(this.peersCountLabel);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Bitmonk Wallet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.masternodesGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masternodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox currentAddressLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox sendAddressInput;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sendAmountInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txIdLabel;
        private System.Windows.Forms.Label peersCountLabel;
        private System.Windows.Forms.Label mnCounLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sendCommentInput;
        private System.Windows.Forms.Label syncLabel;
        private System.Windows.Forms.Label logMessageLabel;
        private System.Windows.Forms.DataGridView transactionsGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox consoleTextBox;
        private System.Windows.Forms.TextBox commandBox;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label pVerLabel;
        private System.Windows.Forms.LinkLabel stakeLinkLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel myMnsCountLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel inputsCountLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView masternodesGridView;
        private System.Windows.Forms.BindingSource transactionBindingSource1;
        private System.Windows.Forms.BindingSource masternodeBindingSource;
        private System.Windows.Forms.Button mnUpdateButton;
        private System.Windows.Forms.Button mnAddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn protocolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conf;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

