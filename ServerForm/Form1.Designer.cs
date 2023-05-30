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
            this.connectedClientsLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bufferSizeTextBox = new System.Windows.Forms.TextBox();
            this.buferSizeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // connectedClientsLabel
            // 
            this.connectedClientsLabel.AutoSize = true;
            this.connectedClientsLabel.Location = new System.Drawing.Point(13, 23);
            this.connectedClientsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.connectedClientsLabel.Name = "connectedClientsLabel";
            this.connectedClientsLabel.Size = new System.Drawing.Size(154, 25);
            this.connectedClientsLabel.TabIndex = 0;
            this.connectedClientsLabel.Text = "Connected Clients";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(56, 92);
            this.countLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(0, 25);
            this.countLabel.TabIndex = 1;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(17, 142);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(107, 38);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 232);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1139, 498);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.logListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1131, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // logListBox
            // 
            this.logListBox.FormattingEnabled = true;
            this.logListBox.ItemHeight = 25;
            this.logListBox.Location = new System.Drawing.Point(4, 5);
            this.logListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(1111, 429);
            this.logListBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1131, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bufferSizeTextBox
            // 
            this.bufferSizeTextBox.Location = new System.Drawing.Point(257, 53);
            this.bufferSizeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bufferSizeTextBox.Name = "bufferSizeTextBox";
            this.bufferSizeTextBox.Size = new System.Drawing.Size(141, 31);
            this.bufferSizeTextBox.TabIndex = 8;
            // 
            // buferSizeLabel
            // 
            this.buferSizeLabel.AutoSize = true;
            this.buferSizeLabel.Location = new System.Drawing.Point(257, 23);
            this.buferSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buferSizeLabel.Name = "buferSizeLabel";
            this.buferSizeLabel.Size = new System.Drawing.Size(95, 25);
            this.buferSizeLabel.TabIndex = 9;
            this.buferSizeLabel.Text = "Buffer Size";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox1.Location = new System.Drawing.Point(257, 142);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 38);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buferSizeLabel);
            this.Controls.Add(this.bufferSizeTextBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.connectedClientsLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private PictureBox pictureBox1;
    }
}