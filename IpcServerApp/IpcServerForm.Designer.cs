namespace IpcServerApp
{
    partial class IpcServerForm
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
            this.NamedPipeLabel = new System.Windows.Forms.Label();
            this.pipeNameTextBox = new System.Windows.Forms.TextBox();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.SendMessageTextBox = new System.Windows.Forms.TextBox();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ReceiveMessageTextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.CommunicationSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CommunicationSettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NamedPipeLabel
            // 
            this.NamedPipeLabel.AutoSize = true;
            this.NamedPipeLabel.Location = new System.Drawing.Point(6, 62);
            this.NamedPipeLabel.Name = "NamedPipeLabel";
            this.NamedPipeLabel.Size = new System.Drawing.Size(97, 15);
            this.NamedPipeLabel.TabIndex = 0;
            this.NamedPipeLabel.Text = "名前付きパイプ";
            // 
            // pipeNameTextBox
            // 
            this.pipeNameTextBox.Location = new System.Drawing.Point(109, 55);
            this.pipeNameTextBox.MaxLength = 32;
            this.pipeNameTextBox.Name = "pipeNameTextBox";
            this.pipeNameTextBox.Size = new System.Drawing.Size(150, 22);
            this.pipeNameTextBox.TabIndex = 1;
            this.pipeNameTextBox.Text = "TestPipe";
            // 
            // LogTextBox
            // 
            this.LogTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.LogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogTextBox.Location = new System.Drawing.Point(12, 396);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(769, 133);
            this.LogTextBox.TabIndex = 2;
            // 
            // SendMessageTextBox
            // 
            this.SendMessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SendMessageTextBox.Location = new System.Drawing.Point(398, 144);
            this.SendMessageTextBox.Multiline = true;
            this.SendMessageTextBox.Name = "SendMessageTextBox";
            this.SendMessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SendMessageTextBox.Size = new System.Drawing.Size(380, 192);
            this.SendMessageTextBox.TabIndex = 4;
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(634, 47);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(120, 30);
            this.DisconnectButton.TabIndex = 5;
            this.DisconnectButton.Text = "切断";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(508, 47);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(120, 30);
            this.ConnectButton.TabIndex = 6;
            this.ConnectButton.Text = "接続";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "受信メッセージ";
            // 
            // ReceiveMessageTextBox
            // 
            this.ReceiveMessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReceiveMessageTextBox.Location = new System.Drawing.Point(12, 144);
            this.ReceiveMessageTextBox.Multiline = true;
            this.ReceiveMessageTextBox.Name = "ReceiveMessageTextBox";
            this.ReceiveMessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReceiveMessageTextBox.Size = new System.Drawing.Size(380, 192);
            this.ReceiveMessageTextBox.TabIndex = 8;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(646, 342);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(120, 30);
            this.SendButton.TabIndex = 9;
            this.SendButton.Text = "送信";
            this.SendButton.UseVisualStyleBackColor = true;
            // 
            // CommunicationSettingsGroupBox
            // 
            this.CommunicationSettingsGroupBox.Controls.Add(this.NamedPipeLabel);
            this.CommunicationSettingsGroupBox.Controls.Add(this.pipeNameTextBox);
            this.CommunicationSettingsGroupBox.Controls.Add(this.ConnectButton);
            this.CommunicationSettingsGroupBox.Controls.Add(this.DisconnectButton);
            this.CommunicationSettingsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.CommunicationSettingsGroupBox.Name = "CommunicationSettingsGroupBox";
            this.CommunicationSettingsGroupBox.Size = new System.Drawing.Size(769, 94);
            this.CommunicationSettingsGroupBox.TabIndex = 18;
            this.CommunicationSettingsGroupBox.TabStop = false;
            this.CommunicationSettingsGroupBox.Text = "通信設定";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "送信メッセージ";
            // 
            // IpcServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 541);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CommunicationSettingsGroupBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.ReceiveMessageTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendMessageTextBox);
            this.Controls.Add(this.LogTextBox);
            this.Name = "IpcServerForm";
            this.Text = "IpcServerApp";
            this.CommunicationSettingsGroupBox.ResumeLayout(false);
            this.CommunicationSettingsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NamedPipeLabel;
        private System.Windows.Forms.TextBox pipeNameTextBox;
        public System.Windows.Forms.TextBox LogTextBox;
        public System.Windows.Forms.TextBox SendMessageTextBox;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox ReceiveMessageTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.GroupBox CommunicationSettingsGroupBox;
        private System.Windows.Forms.Label label2;
    }
}

