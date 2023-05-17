namespace ServerForm
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
            connectedClientsLabel = new Label();
            countLabel = new Label();
            startButton = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            logListBox = new ListBox();
            tabPage2 = new TabPage();
            bufferSizeTextBox = new TextBox();
            buferSizeLabel = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // connectedClientsLabel
            // 
            connectedClientsLabel.AutoSize = true;
            connectedClientsLabel.Location = new Point(-3, 14);
            connectedClientsLabel.Name = "connectedClientsLabel";
            connectedClientsLabel.Size = new Size(104, 15);
            connectedClientsLabel.TabIndex = 0;
            connectedClientsLabel.Text = "Connected Clients";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new Point(39, 55);
            countLabel.Name = "countLabel";
            countLabel.Size = new Size(0, 15);
            countLabel.TabIndex = 1;
            // 
            // startButton
            // 
            startButton.Location = new Point(12, 85);
            startButton.Name = "startButton";
            startButton.Size = new Size(75, 23);
            startButton.TabIndex = 4;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(2, 139);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(797, 299);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(logListBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(789, 271);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // logListBox
            // 
            logListBox.FormattingEnabled = true;
            logListBox.ItemHeight = 15;
            logListBox.Location = new Point(3, 3);
            logListBox.Name = "logListBox";
            logListBox.Size = new Size(779, 259);
            logListBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(789, 271);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // bufferSizeTextBox
            // 
            bufferSizeTextBox.Location = new Point(180, 32);
            bufferSizeTextBox.Name = "bufferSizeTextBox";
            bufferSizeTextBox.Size = new Size(100, 23);
            bufferSizeTextBox.TabIndex = 8;
            // 
            // buferSizeLabel
            // 
            buferSizeLabel.AutoSize = true;
            buferSizeLabel.Location = new Point(180, 14);
            buferSizeLabel.Name = "buferSizeLabel";
            buferSizeLabel.Size = new Size(62, 15);
            buferSizeLabel.TabIndex = 9;
            buferSizeLabel.Text = "Buffer Size";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buferSizeLabel);
            Controls.Add(bufferSizeTextBox);
            Controls.Add(tabControl1);
            Controls.Add(startButton);
            Controls.Add(countLabel);
            Controls.Add(connectedClientsLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label connectedClientsLabel;
        private Label countLabel;
        private Button startButton;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox bufferSizeTextBox;
        private Label buferSizeLabel;
        private ListBox logListBox;
    }
}