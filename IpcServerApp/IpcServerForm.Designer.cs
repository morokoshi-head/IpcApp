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
            this.SendButton = new System.Windows.Forms.Button();
            this.CommunicationSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.CommunicationSettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NamedPipeLabel
            // 
            this.NamedPipeLabel.AutoSize = true;
            this.NamedPipeLabel.Location = new System.Drawing.Point(4, 50);
            this.NamedPipeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NamedPipeLabel.Name = "NamedPipeLabel";
            this.NamedPipeLabel.Size = new System.Drawing.Size(78, 12);
            this.NamedPipeLabel.TabIndex = 0;
            this.NamedPipeLabel.Text = "名前付きパイプ";
            // 
            // pipeNameTextBox
            // 
            this.pipeNameTextBox.Location = new System.Drawing.Point(82, 44);
            this.pipeNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.pipeNameTextBox.MaxLength = 32;
            this.pipeNameTextBox.Name = "pipeNameTextBox";
            this.pipeNameTextBox.Size = new System.Drawing.Size(114, 19);
            this.pipeNameTextBox.TabIndex = 1;
            this.pipeNameTextBox.Text = "TestPipe";
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
            this.LogTextBox.TabIndex = 2;
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
            this.SendMessageTextBox.TabIndex = 4;
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(476, 38);
            this.DisconnectButton.Margin = new System.Windows.Forms.Padding(2);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(90, 24);
            this.DisconnectButton.TabIndex = 5;
            this.DisconnectButton.Text = "切断";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(381, 38);
            this.ConnectButton.Margin = new System.Windows.Forms.Padding(2);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(90, 24);
            this.ConnectButton.TabIndex = 6;
            this.ConnectButton.Text = "接続";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(496, 503);
            this.SendButton.Margin = new System.Windows.Forms.Padding(2);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(90, 24);
            this.SendButton.TabIndex = 9;
            this.SendButton.Text = "送信";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // CommunicationSettingsGroupBox
            // 
            this.CommunicationSettingsGroupBox.Controls.Add(this.NamedPipeLabel);
            this.CommunicationSettingsGroupBox.Controls.Add(this.pipeNameTextBox);
            this.CommunicationSettingsGroupBox.Controls.Add(this.ConnectButton);
            this.CommunicationSettingsGroupBox.Controls.Add(this.DisconnectButton);
            this.CommunicationSettingsGroupBox.Location = new System.Drawing.Point(9, 10);
            this.CommunicationSettingsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.CommunicationSettingsGroupBox.Name = "CommunicationSettingsGroupBox";
            this.CommunicationSettingsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.CommunicationSettingsGroupBox.Size = new System.Drawing.Size(577, 75);
            this.CommunicationSettingsGroupBox.TabIndex = 18;
            this.CommunicationSettingsGroupBox.TabStop = false;
            this.CommunicationSettingsGroupBox.Text = "通信設定";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 449);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "送信メッセージ";
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
            this.MessageTextBox.TabIndex = 20;
            // 
            // IpcServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 661);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CommunicationSettingsGroupBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.SendMessageTextBox);
            this.Controls.Add(this.LogTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.GroupBox CommunicationSettingsGroupBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox MessageTextBox;
    }
}

