namespace UDPServer
{
    partial class UDPClient
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
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.ClientPortTextBox = new System.Windows.Forms.TextBox();
            this.clientPortLabel = new System.Windows.Forms.Label();
            this.hostLabel = new System.Windows.Forms.Label();
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.hostPortTextBox = new System.Windows.Forms.TextBox();
            this.serverPortLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(18, 258);
            this.statusTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statusTextBox.Multiline = true;
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(746, 227);
            this.statusTextBox.TabIndex = 23;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(18, 105);
            this.messageTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(746, 76);
            this.messageTextBox.TabIndex = 22;
            // 
            // ClientPortTextBox
            // 
            this.ClientPortTextBox.Location = new System.Drawing.Point(342, 63);
            this.ClientPortTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClientPortTextBox.Name = "ClientPortTextBox";
            this.ClientPortTextBox.Size = new System.Drawing.Size(73, 26);
            this.ClientPortTextBox.TabIndex = 21;
            // 
            // clientPortLabel
            // 
            this.clientPortLabel.AutoSize = true;
            this.clientPortLabel.Location = new System.Drawing.Point(252, 68);
            this.clientPortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientPortLabel.Name = "clientPortLabel";
            this.clientPortLabel.Size = new System.Drawing.Size(82, 20);
            this.clientPortLabel.TabIndex = 20;
            this.clientPortLabel.Text = "Client Port";
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.Location = new System.Drawing.Point(20, 68);
            this.hostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(43, 20);
            this.hostLabel.TabIndex = 19;
            this.hostLabel.Text = "Host";
            // 
            // hostTextBox
            // 
            this.hostTextBox.Location = new System.Drawing.Point(72, 63);
            this.hostTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(148, 26);
            this.hostTextBox.TabIndex = 18;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(654, 212);
            this.sendButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(112, 35);
            this.sendButton.TabIndex = 17;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click_1);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(654, 60);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(112, 35);
            this.connectButton.TabIndex = 16;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // hostPortTextBox
            // 
            this.hostPortTextBox.Location = new System.Drawing.Point(536, 63);
            this.hostPortTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hostPortTextBox.Name = "hostPortTextBox";
            this.hostPortTextBox.Size = new System.Drawing.Size(73, 26);
            this.hostPortTextBox.TabIndex = 25;
            // 
            // serverPortLabel
            // 
            this.serverPortLabel.AutoSize = true;
            this.serverPortLabel.Location = new System.Drawing.Point(436, 68);
            this.serverPortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.serverPortLabel.Name = "serverPortLabel";
            this.serverPortLabel.Size = new System.Drawing.Size(88, 20);
            this.serverPortLabel.TabIndex = 24;
            this.serverPortLabel.Text = "Server Port";
            // 
            // UDPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 558);
            this.Controls.Add(this.hostPortTextBox);
            this.Controls.Add(this.serverPortLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.ClientPortTextBox);
            this.Controls.Add(this.clientPortLabel);
            this.Controls.Add(this.hostLabel);
            this.Controls.Add(this.hostTextBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.connectButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UDPClient";
            this.Text = "UDPClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.TextBox ClientPortTextBox;
        private System.Windows.Forms.Label clientPortLabel;
        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox hostPortTextBox;
        private System.Windows.Forms.Label serverPortLabel;
    }
}