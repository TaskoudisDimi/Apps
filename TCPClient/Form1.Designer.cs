namespace TCPClient
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
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.hostLabel = new System.Windows.Forms.Label();
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(52, 66);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(373, 51);
            this.messageTextBox.TabIndex = 14;
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(241, 35);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(50, 20);
            this.portTextBox.TabIndex = 13;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(209, 38);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(26, 13);
            this.portLabel.TabIndex = 12;
            this.portLabel.Text = "Port";
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.Location = new System.Drawing.Point(49, 38);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(29, 13);
            this.hostLabel.TabIndex = 11;
            this.hostLabel.Text = "Host";
            // 
            // hostTextBox
            // 
            this.hostTextBox.Location = new System.Drawing.Point(84, 35);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(100, 20);
            this.hostTextBox.TabIndex = 10;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(350, 133);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 9;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(350, 33);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 8;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(55, 163);
            this.statusTextBox.Multiline = true;
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(373, 149);
            this.statusTextBox.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 344);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.hostLabel);
            this.Controls.Add(this.hostTextBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.connectButton);
            this.Name = "Form1";
            this.Text = "TCPClient";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox statusTextBox;
    }
}

