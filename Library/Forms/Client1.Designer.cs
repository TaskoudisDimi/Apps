namespace Forms.Forms
{
    partial class Client1
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
            button2 = new Button();
            messageTextBox = new TextBox();
            portTextBox = new TextBox();
            ipTextBox = new TextBox();
            button1 = new Button();
            logListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(143, 167);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "Send";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // messageTextBox
            // 
            messageTextBox.Location = new Point(92, 92);
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(100, 23);
            messageTextBox.TabIndex = 10;
            // 
            // portTextBox
            // 
            portTextBox.Location = new Point(92, 51);
            portTextBox.Name = "portTextBox";
            portTextBox.Size = new Size(100, 23);
            portTextBox.TabIndex = 9;
            // 
            // ipTextBox
            // 
            ipTextBox.Location = new Point(92, 13);
            ipTextBox.Name = "ipTextBox";
            ipTextBox.Size = new Size(100, 23);
            ipTextBox.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(50, 167);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // logListBox
            // 
            logListBox.FormattingEnabled = true;
            logListBox.ItemHeight = 15;
            logListBox.Location = new Point(322, 51);
            logListBox.Name = "logListBox";
            logListBox.Size = new Size(400, 139);
            logListBox.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 14;
            label1.Text = "IP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 15;
            label2.Text = "Port";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 95);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 16;
            label3.Text = "Message";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(322, 16);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 17;
            label4.Text = "Log";
            // 
            // Client1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 229);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(logListBox);
            Controls.Add(button2);
            Controls.Add(messageTextBox);
            Controls.Add(portTextBox);
            Controls.Add(ipTextBox);
            Controls.Add(button1);
            Name = "Client1";
            Text = "Client1";
            Load += Client1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox messageTextBox;
        private TextBox portTextBox;
        private TextBox ipTextBox;
        private Button button1;
        private ListBox logListBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}