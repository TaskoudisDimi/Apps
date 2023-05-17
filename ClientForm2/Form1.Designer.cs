namespace ClientForm2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            logListBox = new ListBox();
            button2 = new Button();
            messageTextBox = new TextBox();
            portTextBox = new TextBox();
            ipTextBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(328, 21);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 27;
            label4.Text = "Log";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 100);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 26;
            label3.Text = "Message";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 59);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 25;
            label2.Text = "Port";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 21);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 24;
            label1.Text = "IP";
            // 
            // logListBox
            // 
            logListBox.FormattingEnabled = true;
            logListBox.ItemHeight = 15;
            logListBox.Location = new Point(328, 56);
            logListBox.Name = "logListBox";
            logListBox.Size = new Size(400, 139);
            logListBox.TabIndex = 23;
            // 
            // button2
            // 
            button2.Location = new Point(149, 172);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 22;
            button2.Text = "Send";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // messageTextBox
            // 
            messageTextBox.Location = new Point(98, 97);
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(100, 23);
            messageTextBox.TabIndex = 21;
            // 
            // portTextBox
            // 
            portTextBox.Location = new Point(98, 56);
            portTextBox.Name = "portTextBox";
            portTextBox.Size = new Size(100, 23);
            portTextBox.TabIndex = 20;
            // 
            // ipTextBox
            // 
            ipTextBox.Location = new Point(98, 18);
            ipTextBox.Name = "ipTextBox";
            ipTextBox.Size = new Size(100, 23);
            ipTextBox.TabIndex = 19;
            // 
            // button1
            // 
            button1.Location = new Point(56, 172);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 18;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 225);
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
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox logListBox;
        private Button button2;
        private TextBox messageTextBox;
        private TextBox portTextBox;
        private TextBox ipTextBox;
        private Button button1;
    }
}