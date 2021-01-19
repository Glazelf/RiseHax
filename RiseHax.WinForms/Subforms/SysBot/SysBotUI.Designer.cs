
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
            this.TabControlSysBot = new System.Windows.Forms.TabControl();
            this.TabSysBot1Player = new System.Windows.Forms.TabPage();
            this.TabSysBot2Items = new System.Windows.Forms.TabPage();
            this.TabSysBot3Mission = new System.Windows.Forms.TabPage();
            this.GroupSysBotConnection.SuspendLayout();
            this.TabControlSysBot.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxIP
            // 
            this.TextBoxIP.AccessibleName = "TextBoxIP";
            this.TextBoxIP.Location = new System.Drawing.Point(40, 28);
            this.TextBoxIP.Name = "TextBoxIP";
            this.TextBoxIP.Size = new System.Drawing.Size(87, 20);
            this.TextBoxIP.TabIndex = 0;
            this.TextBoxIP.Text = "192.168.0.1";
            this.TextBoxIP.TextChanged += new System.EventHandler(this.TextBoxIP_TextChanged);
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.AccessibleName = "ButtonConnect";
            this.ButtonConnect.Location = new System.Drawing.Point(40, 81);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(71, 20);
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
            this.GroupSysBotConnection.Location = new System.Drawing.Point(664, 341);
            this.GroupSysBotConnection.Name = "GroupSysBotConnection";
            this.GroupSysBotConnection.Size = new System.Drawing.Size(133, 107);
            this.GroupSysBotConnection.TabIndex = 3;
            this.GroupSysBotConnection.TabStop = false;
            this.GroupSysBotConnection.Text = "Connection";
            this.GroupSysBotConnection.Enter += new System.EventHandler(this.GroupConnection_Enter);
            // 
            // LabelPort
            // 
            this.LabelPort.AccessibleName = "LabelPort";
            this.LabelPort.AutoSize = true;
            this.LabelPort.Location = new System.Drawing.Point(5, 57);
            this.LabelPort.Name = "LabelPort";
            this.LabelPort.Size = new System.Drawing.Size(29, 13);
            this.LabelPort.TabIndex = 5;
            this.LabelPort.Text = "Port:";
            this.LabelPort.Click += new System.EventHandler(this.LabelPort_Click);
            // 
            // LabelIP
            // 
            this.LabelIP.AccessibleName = "LabelIP";
            this.LabelIP.AutoSize = true;
            this.LabelIP.Location = new System.Drawing.Point(14, 31);
            this.LabelIP.Name = "LabelIP";
            this.LabelIP.Size = new System.Drawing.Size(20, 13);
            this.LabelIP.TabIndex = 4;
            this.LabelIP.Text = "IP:";
            this.LabelIP.Click += new System.EventHandler(this.LabelIP_Click);
            // 
            // TextBoxPort
            // 
            this.TextBoxPort.AccessibleName = "TextBoxPort";
            this.TextBoxPort.Location = new System.Drawing.Point(40, 54);
            this.TextBoxPort.Name = "TextBoxPort";
            this.TextBoxPort.Size = new System.Drawing.Size(87, 20);
            this.TextBoxPort.TabIndex = 3;
            this.TextBoxPort.Text = "6000";
            this.TextBoxPort.TextChanged += new System.EventHandler(this.TextBoxPort_TextChanged);
            // 
            // GroupSysBotStatus
            // 
            this.GroupSysBotStatus.AccessibleName = "GroupSysBotStatus";
            this.GroupSysBotStatus.Location = new System.Drawing.Point(3, 341);
            this.GroupSysBotStatus.Name = "GroupSysBotStatus";
            this.GroupSysBotStatus.Size = new System.Drawing.Size(655, 107);
            this.GroupSysBotStatus.TabIndex = 4;
            this.GroupSysBotStatus.TabStop = false;
            this.GroupSysBotStatus.Text = "Status";
            // 
            // TabControlSysBot
            // 
            this.TabControlSysBot.AccessibleName = "TabControlSysBot";
            this.TabControlSysBot.Controls.Add(this.TabSysBot1Player);
            this.TabControlSysBot.Controls.Add(this.TabSysBot2Items);
            this.TabControlSysBot.Controls.Add(this.TabSysBot3Mission);
            this.TabControlSysBot.Location = new System.Drawing.Point(3, 3);
            this.TabControlSysBot.Name = "TabControlSysBot";
            this.TabControlSysBot.SelectedIndex = 0;
            this.TabControlSysBot.Size = new System.Drawing.Size(794, 332);
            this.TabControlSysBot.TabIndex = 0;
            // 
            // TabSysBot1Player
            // 
            this.TabSysBot1Player.AccessibleName = "TabSysBot1Player";
            this.TabSysBot1Player.Location = new System.Drawing.Point(4, 22);
            this.TabSysBot1Player.Name = "TabSysBot1Player";
            this.TabSysBot1Player.Padding = new System.Windows.Forms.Padding(3);
            this.TabSysBot1Player.Size = new System.Drawing.Size(786, 306);
            this.TabSysBot1Player.TabIndex = 0;
            this.TabSysBot1Player.Text = "Player";
            this.TabSysBot1Player.UseVisualStyleBackColor = true;
            // 
            // TabSysBot2Items
            // 
            this.TabSysBot2Items.AccessibleName = "TabSysBot2Items";
            this.TabSysBot2Items.Location = new System.Drawing.Point(4, 22);
            this.TabSysBot2Items.Name = "TabSysBot2Items";
            this.TabSysBot2Items.Padding = new System.Windows.Forms.Padding(3);
            this.TabSysBot2Items.Size = new System.Drawing.Size(629, 245);
            this.TabSysBot2Items.TabIndex = 1;
            this.TabSysBot2Items.Text = "Items";
            this.TabSysBot2Items.UseVisualStyleBackColor = true;
            // 
            // TabSysBot3Mission
            // 
            this.TabSysBot3Mission.AccessibleName = "TabSysBot3Mission";
            this.TabSysBot3Mission.Location = new System.Drawing.Point(4, 22);
            this.TabSysBot3Mission.Name = "TabSysBot3Mission";
            this.TabSysBot3Mission.Padding = new System.Windows.Forms.Padding(3);
            this.TabSysBot3Mission.Size = new System.Drawing.Size(786, 306);
            this.TabSysBot3Mission.TabIndex = 2;
            this.TabSysBot3Mission.Text = "Mission";
            this.TabSysBot3Mission.UseVisualStyleBackColor = true;
            // 
            // SysBotUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControlSysBot);
            this.Controls.Add(this.GroupSysBotStatus);
            this.Controls.Add(this.GroupSysBotConnection);
            this.Icon = global::RiseHax.WinForms.Properties.Resources.icon;
            this.Name = "SysBotUI";
            this.Text = "RiseHax";
            this.Load += new System.EventHandler(this.SysBotUI_Load);
            this.GroupSysBotConnection.ResumeLayout(false);
            this.GroupSysBotConnection.PerformLayout();
            this.TabControlSysBot.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage TabSysBot3Mission;
    }
}