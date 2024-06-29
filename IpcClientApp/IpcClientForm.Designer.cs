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
            this.PipeTextBox = new System.Windows.Forms.TextBox();
            this.NamedPipeLabel = new System.Windows.Forms.Label();
            this.SendMessageTextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IpAddressTextBox = new System.Windows.Forms.TextBox();
            this.ReceiveMessageTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CommunicationSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.CommunicationSettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogTextBox
            // 
            this.LogTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.LogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogTextBox.Location = new System.Drawing.Point(15, 396);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(769, 133);
            this.LogTextBox.TabIndex = 3;
            // 
            // PipeTextBox
            // 
            this.PipeTextBox.HideSelection = false;
            this.PipeTextBox.Location = new System.Drawing.Point(109, 55);
            this.PipeTextBox.MaxLength = 32;
            this.PipeTextBox.Name = "PipeTextBox";
            this.PipeTextBox.Size = new System.Drawing.Size(150, 22);
            this.PipeTextBox.TabIndex = 5;
            this.PipeTextBox.Text = "TestPipe";
            // 
            // NamedPipeLabel
            // 
            this.NamedPipeLabel.AutoSize = true;
            this.NamedPipeLabel.Location = new System.Drawing.Point(6, 62);
            this.NamedPipeLabel.Name = "NamedPipeLabel";
            this.NamedPipeLabel.Size = new System.Drawing.Size(97, 15);
            this.NamedPipeLabel.TabIndex = 6;
            this.NamedPipeLabel.Text = "名前付きパイプ";
            // 
            // SendMessageTextBox
            // 
            this.SendMessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SendMessageTextBox.Location = new System.Drawing.Point(398, 144);
            this.SendMessageTextBox.Multiline = true;
            this.SendMessageTextBox.Name = "SendMessageTextBox";
            this.SendMessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SendMessageTextBox.Size = new System.Drawing.Size(380, 192);
            this.SendMessageTextBox.TabIndex = 7;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(646, 342);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(120, 30);
            this.SendButton.TabIndex = 8;
            this.SendButton.Text = "送信";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(508, 47);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(120, 30);
            this.ConnectButton.TabIndex = 9;
            this.ConnectButton.Text = "接続";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(634, 47);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(120, 30);
            this.DisconnectButton.TabIndex = 10;
            this.DisconnectButton.Text = "切断";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(395, 126);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(92, 15);
            this.MessageLabel.TabIndex = 11;
            this.MessageLabel.Text = "送信メッセージ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "IPアドレス";
            // 
            // IpAddressTextBox
            // 
            this.IpAddressTextBox.Location = new System.Drawing.Point(109, 20);
            this.IpAddressTextBox.MaxLength = 32;
            this.IpAddressTextBox.Name = "IpAddressTextBox";
            this.IpAddressTextBox.Size = new System.Drawing.Size(150, 22);
            this.IpAddressTextBox.TabIndex = 14;
            this.IpAddressTextBox.Text = "127.0.0.1";
            // 
            // ReceiveMessageTextBox
            // 
            this.ReceiveMessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReceiveMessageTextBox.Location = new System.Drawing.Point(12, 144);
            this.ReceiveMessageTextBox.Multiline = true;
            this.ReceiveMessageTextBox.Name = "ReceiveMessageTextBox";
            this.ReceiveMessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReceiveMessageTextBox.Size = new System.Drawing.Size(380, 192);
            this.ReceiveMessageTextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "受信メッセージ";
            // 
            // CommunicationSettingsGroupBox
            // 
            this.CommunicationSettingsGroupBox.Controls.Add(this.label1);
            this.CommunicationSettingsGroupBox.Controls.Add(this.IpAddressTextBox);
            this.CommunicationSettingsGroupBox.Controls.Add(this.NamedPipeLabel);
            this.CommunicationSettingsGroupBox.Controls.Add(this.PipeTextBox);
            this.CommunicationSettingsGroupBox.Controls.Add(this.ConnectButton);
            this.CommunicationSettingsGroupBox.Controls.Add(this.DisconnectButton);
            this.CommunicationSettingsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.CommunicationSettingsGroupBox.Name = "CommunicationSettingsGroupBox";
            this.CommunicationSettingsGroupBox.Size = new System.Drawing.Size(769, 94);
            this.CommunicationSettingsGroupBox.TabIndex = 17;
            this.CommunicationSettingsGroupBox.TabStop = false;
            this.CommunicationSettingsGroupBox.Text = "通信設定";
            // 
            // IpcClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 541);
            this.Controls.Add(this.CommunicationSettingsGroupBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReceiveMessageTextBox);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.SendMessageTextBox);
            this.Controls.Add(this.LogTextBox);
            this.Name = "IpcClientForm";
            this.Text = "IpcClientApp";
            this.CommunicationSettingsGroupBox.ResumeLayout(false);
            this.CommunicationSettingsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.TextBox PipeTextBox;
        private System.Windows.Forms.Label NamedPipeLabel;
        public System.Windows.Forms.TextBox SendMessageTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IpAddressTextBox;
        public System.Windows.Forms.TextBox ReceiveMessageTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox CommunicationSettingsGroupBox;
    }
}

