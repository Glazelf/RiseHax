
namespace RiseHax.WinForms
{
    partial class SysBotUI
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
            this.TextBoxIP = new System.Windows.Forms.TextBox();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.GroupSysBotConnection = new System.Windows.Forms.GroupBox();
            this.LabelPort = new System.Windows.Forms.Label();
            this.LabelIP = new System.Windows.Forms.Label();
            this.TextBoxPort = new System.Windows.Forms.TextBox();
            this.GroupSysBotStatus = new System.Windows.Forms.GroupBox();
            this.ButtonSysbotQuestRead = new System.Windows.Forms.Button();
            this.TabControlSysBot = new System.Windows.Forms.TabControl();
            this.TabSysBot1Player = new System.Windows.Forms.TabPage();
            this.GroupSysBotHunterCoords = new System.Windows.Forms.GroupBox();
            this.SysBotHunterCoordZCount = new System.Windows.Forms.NumericUpDown();
            this.SysBotHunterCoordZLabel = new System.Windows.Forms.Label();
            this.SysBotHunterCoordYCount = new System.Windows.Forms.NumericUpDown();
            this.SysBotHunterCoordYLabel = new System.Windows.Forms.Label();
            this.SysBotHunterCoordXCount = new System.Windows.Forms.NumericUpDown();
            this.SysBotHunterCoordXLabel = new System.Windows.Forms.Label();
            this.TabSysBot2Items = new System.Windows.Forms.TabPage();
            this.TabSysBot3Quest = new System.Windows.Forms.TabPage();
            this.GroupQuestSysBotPouch = new System.Windows.Forms.GroupBox();
            this.QuestSysBotTriesRemaining = new System.Windows.Forms.NumericUpDown();
            this.QuestSysBotPouchTriesLabel = new System.Windows.Forms.Label();
            this.QuestSysBotPouchMegaPotionLabel = new System.Windows.Forms.Label();
            this.QuestSysBotPouchMegaPotionCount = new System.Windows.Forms.NumericUpDown();
            this.GroupQuestSysBotHunter = new System.Windows.Forms.GroupBox();
            this.QuestSysBotHunterHPCount = new System.Windows.Forms.NumericUpDown();
            this.QuestSysBotHunterHP = new System.Windows.Forms.Label();
            this.GroupQuestSysBotMonster = new System.Windows.Forms.GroupBox();
            this.QuestSysBotMonsterHPCount = new System.Windows.Forms.NumericUpDown();
            this.QuestSysBotMonsterHPLabel = new System.Windows.Forms.Label();
            this.TabSysBot4Log = new System.Windows.Forms.TabPage();
            this.SysBotLog = new System.Windows.Forms.RichTextBox();
            this.GroupSysBotConnection.SuspendLayout();
            this.GroupSysBotStatus.SuspendLayout();
            this.TabControlSysBot.SuspendLayout();
            this.TabSysBot1Player.SuspendLayout();
            this.GroupSysBotHunterCoords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SysBotHunterCoordZCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SysBotHunterCoordYCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SysBotHunterCoordXCount)).BeginInit();
            this.TabSysBot3Quest.SuspendLayout();
            this.GroupQuestSysBotPouch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestSysBotTriesRemaining)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestSysBotPouchMegaPotionCount)).BeginInit();
            this.GroupQuestSysBotHunter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestSysBotHunterHPCount)).BeginInit();
            this.GroupQuestSysBotMonster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestSysBotMonsterHPCount)).BeginInit();
            this.TabSysBot4Log.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxIP
            // 
            this.TextBoxIP.AccessibleName = "TextBoxIP";
            this.TextBoxIP.Location = new System.Drawing.Point(44, 28);
            this.TextBoxIP.Name = "TextBoxIP";
            this.TextBoxIP.Size = new System.Drawing.Size(96, 20);
            this.TextBoxIP.TabIndex = 0;
            this.TextBoxIP.Text = "192.168.0.1";
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.AccessibleName = "ButtonConnect";
            this.ButtonConnect.Location = new System.Drawing.Point(44, 81);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(84, 24);
            this.ButtonConnect.TabIndex = 2;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // GroupSysBotConnection
            // 
            this.GroupSysBotConnection.AccessibleName = "GroupSysBotConnection";
            this.GroupSysBotConnection.Controls.Add(this.LabelPort);
            this.GroupSysBotConnection.Controls.Add(this.LabelIP);
            this.GroupSysBotConnection.Controls.Add(this.TextBoxPort);
            this.GroupSysBotConnection.Controls.Add(this.ButtonConnect);
            this.GroupSysBotConnection.Controls.Add(this.TextBoxIP);
            this.GroupSysBotConnection.Location = new System.Drawing.Point(614, 440);
            this.GroupSysBotConnection.Name = "GroupSysBotConnection";
            this.GroupSysBotConnection.Size = new System.Drawing.Size(163, 119);
            this.GroupSysBotConnection.TabIndex = 3;
            this.GroupSysBotConnection.TabStop = false;
            this.GroupSysBotConnection.Text = "Connection";
            // 
            // LabelPort
            // 
            this.LabelPort.AccessibleName = "LabelPort";
            this.LabelPort.AutoSize = true;
            this.LabelPort.Location = new System.Drawing.Point(9, 57);
            this.LabelPort.Name = "LabelPort";
            this.LabelPort.Size = new System.Drawing.Size(29, 13);
            this.LabelPort.TabIndex = 5;
            this.LabelPort.Text = "Port:";
            // 
            // LabelIP
            // 
            this.LabelIP.AccessibleName = "LabelIP";
            this.LabelIP.AutoSize = true;
            this.LabelIP.Location = new System.Drawing.Point(18, 31);
            this.LabelIP.Name = "LabelIP";
            this.LabelIP.Size = new System.Drawing.Size(20, 13);
            this.LabelIP.TabIndex = 4;
            this.LabelIP.Text = "IP:";
            // 
            // TextBoxPort
            // 
            this.TextBoxPort.AccessibleName = "TextBoxPort";
            this.TextBoxPort.Location = new System.Drawing.Point(44, 54);
            this.TextBoxPort.Name = "TextBoxPort";
            this.TextBoxPort.Size = new System.Drawing.Size(96, 20);
            this.TextBoxPort.TabIndex = 3;
            this.TextBoxPort.Text = "6000";
            // 
            // GroupSysBotStatus
            // 
            this.GroupSysBotStatus.AccessibleName = "GroupSysBotStatus";
            this.GroupSysBotStatus.Controls.Add(this.ButtonSysbotQuestRead);
            this.GroupSysBotStatus.Location = new System.Drawing.Point(12, 436);
            this.GroupSysBotStatus.Name = "GroupSysBotStatus";
            this.GroupSysBotStatus.Size = new System.Drawing.Size(596, 119);
            this.GroupSysBotStatus.TabIndex = 4;
            this.GroupSysBotStatus.TabStop = false;
            this.GroupSysBotStatus.Text = "Status";
            // 
            // ButtonSysbotQuestRead
            // 
            this.ButtonSysbotQuestRead.AccessibleName = "ButtonSysbotQuestRead";
            this.ButtonSysbotQuestRead.Enabled = false;
            this.ButtonSysbotQuestRead.Location = new System.Drawing.Point(521, 85);
            this.ButtonSysbotQuestRead.Name = "ButtonSysbotQuestRead";
            this.ButtonSysbotQuestRead.Size = new System.Drawing.Size(75, 23);
            this.ButtonSysbotQuestRead.TabIndex = 14;
            this.ButtonSysbotQuestRead.Text = "Refresh All";
            this.ButtonSysbotQuestRead.UseVisualStyleBackColor = true;
            this.ButtonSysbotQuestRead.Click += new System.EventHandler(this.ButtonSysbotQuestRead_Click);
            // 
            // TabControlSysBot
            // 
            this.TabControlSysBot.AccessibleName = "TabControlSysBot";
            this.TabControlSysBot.Controls.Add(this.TabSysBot1Player);
            this.TabControlSysBot.Controls.Add(this.TabSysBot2Items);
            this.TabControlSysBot.Controls.Add(this.TabSysBot3Quest);
            this.TabControlSysBot.Controls.Add(this.TabSysBot4Log);
            this.TabControlSysBot.Location = new System.Drawing.Point(2, 3);
            this.TabControlSysBot.Name = "TabControlSysBot";
            this.TabControlSysBot.SelectedIndex = 0;
            this.TabControlSysBot.Size = new System.Drawing.Size(775, 431);
            this.TabControlSysBot.TabIndex = 0;
            // 
            // TabSysBot1Player
            // 
            this.TabSysBot1Player.AccessibleName = "TabSysBot1Player";
            this.TabSysBot1Player.Controls.Add(this.GroupSysBotHunterCoords);
            this.TabSysBot1Player.Location = new System.Drawing.Point(4, 22);
            this.TabSysBot1Player.Name = "TabSysBot1Player";
            this.TabSysBot1Player.Padding = new System.Windows.Forms.Padding(3);
            this.TabSysBot1Player.Size = new System.Drawing.Size(767, 405);
            this.TabSysBot1Player.TabIndex = 0;
            this.TabSysBot1Player.Text = "Player";
            this.TabSysBot1Player.UseVisualStyleBackColor = true;
            // 
            // GroupSysBotHunterCoords
            // 
            this.GroupSysBotHunterCoords.AccessibleName = "GroupSysBotHunterCoords";
            this.GroupSysBotHunterCoords.Controls.Add(this.SysBotHunterCoordZCount);
            this.GroupSysBotHunterCoords.Controls.Add(this.SysBotHunterCoordZLabel);
            this.GroupSysBotHunterCoords.Controls.Add(this.SysBotHunterCoordYCount);
            this.GroupSysBotHunterCoords.Controls.Add(this.SysBotHunterCoordYLabel);
            this.GroupSysBotHunterCoords.Controls.Add(this.SysBotHunterCoordXCount);
            this.GroupSysBotHunterCoords.Controls.Add(this.SysBotHunterCoordXLabel);
            this.GroupSysBotHunterCoords.Location = new System.Drawing.Point(473, 365);
            this.GroupSysBotHunterCoords.Name = "GroupSysBotHunterCoords";
            this.GroupSysBotHunterCoords.Size = new System.Drawing.Size(291, 40);
            this.GroupSysBotHunterCoords.TabIndex = 8;
            this.GroupSysBotHunterCoords.TabStop = false;
            this.GroupSysBotHunterCoords.Text = "Coordinates:";
            // 
            // SysBotHunterCoordZCount
            // 
            this.SysBotHunterCoordZCount.AccessibleName = "SysBotHunterCoordZCount";
            this.SysBotHunterCoordZCount.Enabled = false;
            this.SysBotHunterCoordZCount.Location = new System.Drawing.Point(211, 16);
            this.SysBotHunterCoordZCount.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.SysBotHunterCoordZCount.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.SysBotHunterCoordZCount.Name = "SysBotHunterCoordZCount";
            this.SysBotHunterCoordZCount.Size = new System.Drawing.Size(74, 20);
            this.SysBotHunterCoordZCount.TabIndex = 10;
            this.SysBotHunterCoordZCount.ValueChanged += new System.EventHandler(this.SysBotHunterCoordZCount_ValueChanged);
            // 
            // SysBotHunterCoordZLabel
            // 
            this.SysBotHunterCoordZLabel.AccessibleName = "SysBotHunterCoordZLabel";
            this.SysBotHunterCoordZLabel.AutoSize = true;
            this.SysBotHunterCoordZLabel.Location = new System.Drawing.Point(193, 18);
            this.SysBotHunterCoordZLabel.Name = "SysBotHunterCoordZLabel";
            this.SysBotHunterCoordZLabel.Size = new System.Drawing.Size(17, 13);
            this.SysBotHunterCoordZLabel.TabIndex = 9;
            this.SysBotHunterCoordZLabel.Text = "Z:";
            // 
            // SysBotHunterCoordYCount
            // 
            this.SysBotHunterCoordYCount.AccessibleName = "SysBotHunterCoordYCount";
            this.SysBotHunterCoordYCount.Enabled = false;
            this.SysBotHunterCoordYCount.Location = new System.Drawing.Point(119, 16);
            this.SysBotHunterCoordYCount.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.SysBotHunterCoordYCount.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.SysBotHunterCoordYCount.Name = "SysBotHunterCoordYCount";
            this.SysBotHunterCoordYCount.Size = new System.Drawing.Size(68, 20);
            this.SysBotHunterCoordYCount.TabIndex = 8;
            this.SysBotHunterCoordYCount.ValueChanged += new System.EventHandler(this.SysBotHunterCoordYCount_ValueChanged);
            // 
            // SysBotHunterCoordYLabel
            // 
            this.SysBotHunterCoordYLabel.AccessibleName = "SysBotHunterCoordYLabel";
            this.SysBotHunterCoordYLabel.AutoSize = true;
            this.SysBotHunterCoordYLabel.Location = new System.Drawing.Point(96, 18);
            this.SysBotHunterCoordYLabel.Name = "SysBotHunterCoordYLabel";
            this.SysBotHunterCoordYLabel.Size = new System.Drawing.Size(17, 13);
            this.SysBotHunterCoordYLabel.TabIndex = 7;
            this.SysBotHunterCoordYLabel.Text = "Y:";
            // 
            // SysBotHunterCoordXCount
            // 
            this.SysBotHunterCoordXCount.AccessibleName = "SysBotHunterCoordXCount";
            this.SysBotHunterCoordXCount.Enabled = false;
            this.SysBotHunterCoordXCount.Location = new System.Drawing.Point(26, 16);
            this.SysBotHunterCoordXCount.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.SysBotHunterCoordXCount.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.SysBotHunterCoordXCount.Name = "SysBotHunterCoordXCount";
            this.SysBotHunterCoordXCount.Size = new System.Drawing.Size(64, 20);
            this.SysBotHunterCoordXCount.TabIndex = 6;
            this.SysBotHunterCoordXCount.ValueChanged += new System.EventHandler(this.SysBotHunterCoordXCount_ValueChanged);
            // 
            // SysBotHunterCoordXLabel
            // 
            this.SysBotHunterCoordXLabel.AccessibleName = "SysBotHunterCoordXLabel";
            this.SysBotHunterCoordXLabel.AutoSize = true;
            this.SysBotHunterCoordXLabel.Location = new System.Drawing.Point(6, 18);
            this.SysBotHunterCoordXLabel.Name = "SysBotHunterCoordXLabel";
            this.SysBotHunterCoordXLabel.Size = new System.Drawing.Size(17, 13);
            this.SysBotHunterCoordXLabel.TabIndex = 5;
            this.SysBotHunterCoordXLabel.Text = "X:";
            // 
            // TabSysBot2Items
            // 
            this.TabSysBot2Items.AccessibleName = "TabSysBot2Items";
            this.TabSysBot2Items.Location = new System.Drawing.Point(4, 22);
            this.TabSysBot2Items.Name = "TabSysBot2Items";
            this.TabSysBot2Items.Padding = new System.Windows.Forms.Padding(3);
            this.TabSysBot2Items.Size = new System.Drawing.Size(767, 405);
            this.TabSysBot2Items.TabIndex = 1;
            this.TabSysBot2Items.Text = "Items";
            this.TabSysBot2Items.UseVisualStyleBackColor = true;
            // 
            // TabSysBot3Quest
            // 
            this.TabSysBot3Quest.AccessibleName = "TabSysBot3Quest";
            this.TabSysBot3Quest.Controls.Add(this.GroupQuestSysBotPouch);
            this.TabSysBot3Quest.Controls.Add(this.GroupQuestSysBotHunter);
            this.TabSysBot3Quest.Controls.Add(this.GroupQuestSysBotMonster);
            this.TabSysBot3Quest.Location = new System.Drawing.Point(4, 22);
            this.TabSysBot3Quest.Name = "TabSysBot3Quest";
            this.TabSysBot3Quest.Padding = new System.Windows.Forms.Padding(3);
            this.TabSysBot3Quest.Size = new System.Drawing.Size(767, 405);
            this.TabSysBot3Quest.TabIndex = 2;
            this.TabSysBot3Quest.Text = "Quest";
            this.TabSysBot3Quest.UseVisualStyleBackColor = true;
            // 
            // GroupQuestSysBotPouch
            // 
            this.GroupQuestSysBotPouch.AccessibleName = "GroupQuestSysBotPouch";
            this.GroupQuestSysBotPouch.Controls.Add(this.QuestSysBotTriesRemaining);
            this.GroupQuestSysBotPouch.Controls.Add(this.QuestSysBotPouchTriesLabel);
            this.GroupQuestSysBotPouch.Controls.Add(this.QuestSysBotPouchMegaPotionLabel);
            this.GroupQuestSysBotPouch.Controls.Add(this.QuestSysBotPouchMegaPotionCount);
            this.GroupQuestSysBotPouch.Location = new System.Drawing.Point(620, 6);
            this.GroupQuestSysBotPouch.Name = "GroupQuestSysBotPouch";
            this.GroupQuestSysBotPouch.Size = new System.Drawing.Size(141, 393);
            this.GroupQuestSysBotPouch.TabIndex = 4;
            this.GroupQuestSysBotPouch.TabStop = false;
            this.GroupQuestSysBotPouch.Text = "Item Pouch";
            // 
            // QuestSysBotTriesRemaining
            // 
            this.QuestSysBotTriesRemaining.AccessibleName = "QuestSysBotTriesRemaining";
            this.QuestSysBotTriesRemaining.Enabled = false;
            this.QuestSysBotTriesRemaining.Location = new System.Drawing.Point(87, 59);
            this.QuestSysBotTriesRemaining.Name = "QuestSysBotTriesRemaining";
            this.QuestSysBotTriesRemaining.Size = new System.Drawing.Size(47, 20);
            this.QuestSysBotTriesRemaining.TabIndex = 6;
            // 
            // QuestSysBotPouchTriesLabel
            // 
            this.QuestSysBotPouchTriesLabel.AccessibleName = "QuestSysBotPouchTriesLabel";
            this.QuestSysBotPouchTriesLabel.AutoSize = true;
            this.QuestSysBotPouchTriesLabel.Location = new System.Drawing.Point(6, 61);
            this.QuestSysBotPouchTriesLabel.Name = "QuestSysBotPouchTriesLabel";
            this.QuestSysBotPouchTriesLabel.Size = new System.Drawing.Size(33, 13);
            this.QuestSysBotPouchTriesLabel.TabIndex = 5;
            this.QuestSysBotPouchTriesLabel.Text = "Tries:";
            // 
            // QuestSysBotPouchMegaPotionLabel
            // 
            this.QuestSysBotPouchMegaPotionLabel.AccessibleName = "QuestSysBotPouchMegaPotionLabel";
            this.QuestSysBotPouchMegaPotionLabel.AutoSize = true;
            this.QuestSysBotPouchMegaPotionLabel.Location = new System.Drawing.Point(6, 28);
            this.QuestSysBotPouchMegaPotionLabel.Name = "QuestSysBotPouchMegaPotionLabel";
            this.QuestSysBotPouchMegaPotionLabel.Size = new System.Drawing.Size(75, 13);
            this.QuestSysBotPouchMegaPotionLabel.TabIndex = 1;
            this.QuestSysBotPouchMegaPotionLabel.Text = "Mega Potions:";
            // 
            // QuestSysBotPouchMegaPotionCount
            // 
            this.QuestSysBotPouchMegaPotionCount.AccessibleName = "QuestSysBotPouchMegaPotionCount";
            this.QuestSysBotPouchMegaPotionCount.Enabled = false;
            this.QuestSysBotPouchMegaPotionCount.Location = new System.Drawing.Point(87, 24);
            this.QuestSysBotPouchMegaPotionCount.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.QuestSysBotPouchMegaPotionCount.Name = "QuestSysBotPouchMegaPotionCount";
            this.QuestSysBotPouchMegaPotionCount.Size = new System.Drawing.Size(46, 20);
            this.QuestSysBotPouchMegaPotionCount.TabIndex = 0;
            this.QuestSysBotPouchMegaPotionCount.ValueChanged += new System.EventHandler(this.QuestSysBotPouchMegaPotionCount_ValueChanged);
            // 
            // GroupQuestSysBotHunter
            // 
            this.GroupQuestSysBotHunter.AccessibleName = "GroupQuestSysBotHunter";
            this.GroupQuestSysBotHunter.Controls.Add(this.QuestSysBotHunterHPCount);
            this.GroupQuestSysBotHunter.Controls.Add(this.QuestSysBotHunterHP);
            this.GroupQuestSysBotHunter.Location = new System.Drawing.Point(299, 6);
            this.GroupQuestSysBotHunter.Name = "GroupQuestSysBotHunter";
            this.GroupQuestSysBotHunter.Size = new System.Drawing.Size(315, 393);
            this.GroupQuestSysBotHunter.TabIndex = 3;
            this.GroupQuestSysBotHunter.TabStop = false;
            this.GroupQuestSysBotHunter.Text = "Hunter";
            // 
            // QuestSysBotHunterHPCount
            // 
            this.QuestSysBotHunterHPCount.AccessibleName = "QuestSysBotHunterHPCount";
            this.QuestSysBotHunterHPCount.Enabled = false;
            this.QuestSysBotHunterHPCount.Location = new System.Drawing.Point(53, 22);
            this.QuestSysBotHunterHPCount.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.QuestSysBotHunterHPCount.Name = "QuestSysBotHunterHPCount";
            this.QuestSysBotHunterHPCount.Size = new System.Drawing.Size(55, 20);
            this.QuestSysBotHunterHPCount.TabIndex = 6;
            this.QuestSysBotHunterHPCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.QuestSysBotHunterHPCount.ValueChanged += new System.EventHandler(this.QuestSysBotHunterHPCount_ValueChanged);
            // 
            // QuestSysBotHunterHP
            // 
            this.QuestSysBotHunterHP.AccessibleName = "QuestSysBotHunterHPLabel";
            this.QuestSysBotHunterHP.AutoSize = true;
            this.QuestSysBotHunterHP.Location = new System.Drawing.Point(6, 24);
            this.QuestSysBotHunterHP.Name = "QuestSysBotHunterHP";
            this.QuestSysBotHunterHP.Size = new System.Drawing.Size(41, 13);
            this.QuestSysBotHunterHP.TabIndex = 5;
            this.QuestSysBotHunterHP.Text = "Health:";
            // 
            // GroupQuestSysBotMonster
            // 
            this.GroupQuestSysBotMonster.AccessibleName = "GroupQuestSysBotMonster";
            this.GroupQuestSysBotMonster.Controls.Add(this.QuestSysBotMonsterHPCount);
            this.GroupQuestSysBotMonster.Controls.Add(this.QuestSysBotMonsterHPLabel);
            this.GroupQuestSysBotMonster.Location = new System.Drawing.Point(6, 6);
            this.GroupQuestSysBotMonster.Name = "GroupQuestSysBotMonster";
            this.GroupQuestSysBotMonster.Size = new System.Drawing.Size(287, 393);
            this.GroupQuestSysBotMonster.TabIndex = 2;
            this.GroupQuestSysBotMonster.TabStop = false;
            this.GroupQuestSysBotMonster.Text = "Monster";
            // 
            // QuestSysBotMonsterHPCount
            // 
            this.QuestSysBotMonsterHPCount.AccessibleName = "QuestSysBotMonsterHPCount";
            this.QuestSysBotMonsterHPCount.Enabled = false;
            this.QuestSysBotMonsterHPCount.Location = new System.Drawing.Point(53, 21);
            this.QuestSysBotMonsterHPCount.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.QuestSysBotMonsterHPCount.Name = "QuestSysBotMonsterHPCount";
            this.QuestSysBotMonsterHPCount.Size = new System.Drawing.Size(67, 20);
            this.QuestSysBotMonsterHPCount.TabIndex = 8;
            this.QuestSysBotMonsterHPCount.ValueChanged += new System.EventHandler(this.QuestSysBotMonsterHPCount_ValueChanged);
            // 
            // QuestSysBotMonsterHPLabel
            // 
            this.QuestSysBotMonsterHPLabel.AccessibleName = "QuestSysBotMonsterHPLabel";
            this.QuestSysBotMonsterHPLabel.AutoSize = true;
            this.QuestSysBotMonsterHPLabel.Location = new System.Drawing.Point(6, 22);
            this.QuestSysBotMonsterHPLabel.Name = "QuestSysBotMonsterHPLabel";
            this.QuestSysBotMonsterHPLabel.Size = new System.Drawing.Size(41, 13);
            this.QuestSysBotMonsterHPLabel.TabIndex = 7;
            this.QuestSysBotMonsterHPLabel.Text = "Health:";
            // 
            // TabSysBot4Log
            // 
            this.TabSysBot4Log.AccessibleName = "TabSysBot4Log";
            this.TabSysBot4Log.Controls.Add(this.SysBotLog);
            this.TabSysBot4Log.Location = new System.Drawing.Point(4, 22);
            this.TabSysBot4Log.Name = "TabSysBot4Log";
            this.TabSysBot4Log.Padding = new System.Windows.Forms.Padding(3);
            this.TabSysBot4Log.Size = new System.Drawing.Size(767, 405);
            this.TabSysBot4Log.TabIndex = 3;
            this.TabSysBot4Log.Text = "Log";
            this.TabSysBot4Log.UseVisualStyleBackColor = true;
            // 
            // SysBotLog
            // 
            this.SysBotLog.AccessibleName = "SysBotLog";
            this.SysBotLog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SysBotLog.Location = new System.Drawing.Point(6, 6);
            this.SysBotLog.Name = "SysBotLog";
            this.SysBotLog.Size = new System.Drawing.Size(755, 399);
            this.SysBotLog.TabIndex = 5;
            this.SysBotLog.Text = "Waiting for log...";
            // 
            // SysBotUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 563);
            this.Controls.Add(this.TabControlSysBot);
            this.Controls.Add(this.GroupSysBotStatus);
            this.Controls.Add(this.GroupSysBotConnection);
            this.Icon = global::RiseHax.WinForms.Properties.Resources.icon;
            this.Name = "SysBotUI";
            this.Text = "RiseHax";
            this.Load += new System.EventHandler(this.SysBotUI_Load);
            this.GroupSysBotConnection.ResumeLayout(false);
            this.GroupSysBotConnection.PerformLayout();
            this.GroupSysBotStatus.ResumeLayout(false);
            this.TabControlSysBot.ResumeLayout(false);
            this.TabSysBot1Player.ResumeLayout(false);
            this.GroupSysBotHunterCoords.ResumeLayout(false);
            this.GroupSysBotHunterCoords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SysBotHunterCoordZCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SysBotHunterCoordYCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SysBotHunterCoordXCount)).EndInit();
            this.TabSysBot3Quest.ResumeLayout(false);
            this.GroupQuestSysBotPouch.ResumeLayout(false);
            this.GroupQuestSysBotPouch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestSysBotTriesRemaining)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestSysBotPouchMegaPotionCount)).EndInit();
            this.GroupQuestSysBotHunter.ResumeLayout(false);
            this.GroupQuestSysBotHunter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestSysBotHunterHPCount)).EndInit();
            this.GroupQuestSysBotMonster.ResumeLayout(false);
            this.GroupQuestSysBotMonster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestSysBotMonsterHPCount)).EndInit();
            this.TabSysBot4Log.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxIP;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.GroupBox GroupSysBotConnection;
        private System.Windows.Forms.Label LabelPort;
        private System.Windows.Forms.Label LabelIP;
        private System.Windows.Forms.TextBox TextBoxPort;
        private System.Windows.Forms.GroupBox GroupSysBotStatus;
        private System.Windows.Forms.TabControl TabControlSysBot;
        private System.Windows.Forms.TabPage TabSysBot1Player;
        private System.Windows.Forms.TabPage TabSysBot2Items;
        private System.Windows.Forms.TabPage TabSysBot3Quest;
        private System.Windows.Forms.NumericUpDown QuestSysBotPouchMegaPotionCount;
        private System.Windows.Forms.Label QuestSysBotPouchMegaPotionLabel;
        private System.Windows.Forms.GroupBox GroupQuestSysBotPouch;
        private System.Windows.Forms.GroupBox GroupQuestSysBotHunter;
        private System.Windows.Forms.GroupBox GroupQuestSysBotMonster;
        private System.Windows.Forms.NumericUpDown QuestSysBotHunterHPCount;
        private System.Windows.Forms.Label QuestSysBotHunterHP;
        private System.Windows.Forms.NumericUpDown QuestSysBotMonsterHPCount;
        private System.Windows.Forms.Label QuestSysBotMonsterHPLabel;
        private System.Windows.Forms.Button ButtonSysbotQuestRead;
        private System.Windows.Forms.TabPage TabSysBot4Log;
        private System.Windows.Forms.RichTextBox SysBotLog;
        private System.Windows.Forms.Label QuestSysBotPouchTriesLabel;
        private System.Windows.Forms.NumericUpDown QuestSysBotTriesRemaining;
        private System.Windows.Forms.GroupBox GroupSysBotHunterCoords;
        private System.Windows.Forms.NumericUpDown SysBotHunterCoordZCount;
        private System.Windows.Forms.Label SysBotHunterCoordZLabel;
        private System.Windows.Forms.NumericUpDown SysBotHunterCoordYCount;
        private System.Windows.Forms.Label SysBotHunterCoordYLabel;
        private System.Windows.Forms.NumericUpDown SysBotHunterCoordXCount;
        private System.Windows.Forms.Label SysBotHunterCoordXLabel;
    }
}