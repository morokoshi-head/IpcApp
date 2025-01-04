namespace IpcClientApp
{
    partial class IpcClientForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.pipeNameTextBox = new System.Windows.Forms.TextBox();
            this.NamedPipeLabel = new System.Windows.Forms.Label();
            this.SendMessageTextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IpAddressTextBox = new System.Windows.Forms.TextBox();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.CommunicationSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.CommunicationSettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogTextBox
            // 
            this.LogTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.LogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogTextBox.Location = new System.Drawing.Point(11, 543);
            this.LogTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(577, 107);
            this.LogTextBox.TabIndex = 3;
            // 
            // pipeNameTextBox
            // 
            this.pipeNameTextBox.HideSelection = false;
            this.pipeNameTextBox.Location = new System.Drawing.Point(82, 44);
            this.pipeNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.pipeNameTextBox.MaxLength = 32;
            this.pipeNameTextBox.Name = "pipeNameTextBox";
            this.pipeNameTextBox.Size = new System.Drawing.Size(114, 19);
            this.pipeNameTextBox.TabIndex = 5;
            this.pipeNameTextBox.Text = "TestPipe";
            // 
            // NamedPipeLabel
            // 
            this.NamedPipeLabel.AutoSize = true;
            this.NamedPipeLabel.Location = new System.Drawing.Point(4, 50);
            this.NamedPipeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NamedPipeLabel.Name = "NamedPipeLabel";
            this.NamedPipeLabel.Size = new System.Drawing.Size(78, 12);
            this.NamedPipeLabel.TabIndex = 6;
            this.NamedPipeLabel.Text = "名前付きパイプ";
            // 
            // SendMessageTextBox
            // 
            this.SendMessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SendMessageTextBox.Location = new System.Drawing.Point(9, 463);
            this.SendMessageTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SendMessageTextBox.Multiline = true;
            this.SendMessageTextBox.Name = "SendMessageTextBox";
            this.SendMessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SendMessageTextBox.Size = new System.Drawing.Size(577, 36);
            this.SendMessageTextBox.TabIndex = 7;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(496, 503);
            this.SendButton.Margin = new System.Windows.Forms.Padding(2);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(90, 24);
            this.SendButton.TabIndex = 8;
            this.SendButton.Text = "送信";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(381, 38);
            this.ConnectButton.Margin = new System.Windows.Forms.Padding(2);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(90, 24);
            this.ConnectButton.TabIndex = 9;
            this.ConnectButton.Text = "接続";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(476, 38);
            this.DisconnectButton.Margin = new System.Windows.Forms.Padding(2);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(90, 24);
            this.DisconnectButton.TabIndex = 10;
            this.DisconnectButton.Text = "切断";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(7, 449);
            this.MessageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(74, 12);
            this.MessageLabel.TabIndex = 11;
            this.MessageLabel.Text = "送信メッセージ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "IPアドレス";
            // 
            // IpAddressTextBox
            // 
            this.IpAddressTextBox.Location = new System.Drawing.Point(82, 16);
            this.IpAddressTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.IpAddressTextBox.MaxLength = 32;
            this.IpAddressTextBox.Name = "IpAddressTextBox";
            this.IpAddressTextBox.Size = new System.Drawing.Size(114, 19);
            this.IpAddressTextBox.TabIndex = 14;
            this.IpAddressTextBox.Text = "127.0.0.1";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageTextBox.Location = new System.Drawing.Point(9, 89);
            this.MessageTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MessageTextBox.Size = new System.Drawing.Size(577, 347);
            this.MessageTextBox.TabIndex = 15;
            // 
            // CommunicationSettingsGroupBox
            // 
            this.CommunicationSettingsGroupBox.Controls.Add(this.label1);
            this.CommunicationSettingsGroupBox.Controls.Add(this.IpAddressTextBox);
            this.CommunicationSettingsGroupBox.Controls.Add(this.NamedPipeLabel);
            this.CommunicationSettingsGroupBox.Controls.Add(this.pipeNameTextBox);
            this.CommunicationSettingsGroupBox.Controls.Add(this.ConnectButton);
            this.CommunicationSettingsGroupBox.Controls.Add(this.DisconnectButton);
            this.CommunicationSettingsGroupBox.Location = new System.Drawing.Point(9, 10);
            this.CommunicationSettingsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.CommunicationSettingsGroupBox.Name = "CommunicationSettingsGroupBox";
            this.CommunicationSettingsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.CommunicationSettingsGroupBox.Size = new System.Drawing.Size(577, 75);
            this.CommunicationSettingsGroupBox.TabIndex = 17;
            this.CommunicationSettingsGroupBox.TabStop = false;
            this.CommunicationSettingsGroupBox.Text = "通信設定";
            // 
            // IpcClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 661);
            this.Controls.Add(this.CommunicationSettingsGroupBox);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.SendMessageTextBox);
            this.Controls.Add(this.LogTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IpcClientForm";
            this.Text = "IpcClientApp";
            this.CommunicationSettingsGroupBox.ResumeLayout(false);
            this.CommunicationSettingsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.TextBox pipeNameTextBox;
        private System.Windows.Forms.Label NamedPipeLabel;
        public System.Windows.Forms.TextBox SendMessageTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IpAddressTextBox;
        public System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.GroupBox CommunicationSettingsGroupBox;
    }
}

