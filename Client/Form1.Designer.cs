namespace CorCrypt
{
    partial class Form1
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
            this.ServerInput = new System.Windows.Forms.TextBox();
            this.PortInput = new System.Windows.Forms.TextBox();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.ChannelsInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelusername = new System.Windows.Forms.Label();
            this.labelsomething = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.ChatOutput = new System.Windows.Forms.RichTextBox();
            this.MessageInput = new System.Windows.Forms.TextBox();
            this.ShowDebugButton = new System.Windows.Forms.Button();
            this.OpenFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServerInput
            // 
            this.ServerInput.Location = new System.Drawing.Point(15, 37);
            this.ServerInput.Name = "ServerInput";
            this.ServerInput.Size = new System.Drawing.Size(162, 20);
            this.ServerInput.TabIndex = 0;
            this.ServerInput.Text = "irc.freenode.com";
            // 
            // PortInput
            // 
            this.PortInput.Location = new System.Drawing.Point(15, 76);
            this.PortInput.Name = "PortInput";
            this.PortInput.Size = new System.Drawing.Size(162, 20);
            this.PortInput.TabIndex = 1;
            this.PortInput.Text = "6667";
            // 
            // UsernameInput
            // 
            this.UsernameInput.Location = new System.Drawing.Point(15, 114);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(162, 20);
            this.UsernameInput.TabIndex = 2;
            this.UsernameInput.Text = "ClientTest";
            // 
            // ChannelsInput
            // 
            this.ChannelsInput.Location = new System.Drawing.Point(15, 152);
            this.ChannelsInput.Name = "ChannelsInput";
            this.ChannelsInput.Size = new System.Drawing.Size(162, 20);
            this.ChannelsInput.TabIndex = 3;
            this.ChannelsInput.Text = "#ClientTestChan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port";
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Location = new System.Drawing.Point(15, 99);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(55, 13);
            this.labelusername.TabIndex = 6;
            this.labelusername.Text = "Username";
            // 
            // labelsomething
            // 
            this.labelsomething.AutoSize = true;
            this.labelsomething.Location = new System.Drawing.Point(15, 137);
            this.labelsomething.Name = "labelsomething";
            this.labelsomething.Size = new System.Drawing.Size(46, 13);
            this.labelsomething.TabIndex = 7;
            this.labelsomething.Text = "Channel";
            this.labelsomething.Click += new System.EventHandler(this.labelsomething_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(15, 179);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(162, 23);
            this.ConnectButton.TabIndex = 8;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(15, 208);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(162, 23);
            this.DisconnectButton.TabIndex = 9;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // ChatOutput
            // 
            this.ChatOutput.Location = new System.Drawing.Point(183, 37);
            this.ChatOutput.Name = "ChatOutput";
            this.ChatOutput.ReadOnly = true;
            this.ChatOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.ChatOutput.Size = new System.Drawing.Size(916, 444);
            this.ChatOutput.TabIndex = 10;
            this.ChatOutput.Text = "";
            this.ChatOutput.TextChanged += new System.EventHandler(this.ChatOutput_TextChanged);
            // 
            // MessageInput
            // 
            this.MessageInput.Location = new System.Drawing.Point(183, 490);
            this.MessageInput.Name = "MessageInput";
            this.MessageInput.Size = new System.Drawing.Size(916, 20);
            this.MessageInput.TabIndex = 11;
            this.MessageInput.TextChanged += new System.EventHandler(this.MessageInput_TextChanged);
            this.MessageInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MessageInput_KeyDown);
            // 
            // ShowDebugButton
            // 
            this.ShowDebugButton.Location = new System.Drawing.Point(15, 237);
            this.ShowDebugButton.Name = "ShowDebugButton";
            this.ShowDebugButton.Size = new System.Drawing.Size(162, 23);
            this.ShowDebugButton.TabIndex = 14;
            this.ShowDebugButton.Text = "Show Debug";
            this.ShowDebugButton.UseVisualStyleBackColor = true;
            this.ShowDebugButton.Click += new System.EventHandler(this.ShowDebugButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1111, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 522);
            this.Controls.Add(this.ShowDebugButton);
            this.Controls.Add(this.MessageInput);
            this.Controls.Add(this.ChatOutput);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.labelsomething);
            this.Controls.Add(this.labelusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChannelsInput);
            this.Controls.Add(this.UsernameInput);
            this.Controls.Add(this.PortInput);
            this.Controls.Add(this.ServerInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "IRC Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ServerInput;
        private System.Windows.Forms.TextBox PortInput;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.TextBox ChannelsInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label labelsomething;
        private System.Windows.Forms.Button ConnectButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.RichTextBox ChatOutput;
        private System.Windows.Forms.TextBox MessageInput;
        private System.Windows.Forms.Button ShowDebugButton;
        private System.Windows.Forms.FolderBrowserDialog OpenFolderDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
    }
}

