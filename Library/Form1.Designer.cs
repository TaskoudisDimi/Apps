namespace Library
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
            this.bookListBox = new System.Windows.Forms.ListBox();
            this.BuyBooksListBox = new System.Windows.Forms.ListBox();
            this.BuyButton = new System.Windows.Forms.Button();
            this.InitAmountLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // bookListBox
            // 
            this.bookListBox.FormattingEnabled = true;
            this.bookListBox.ItemHeight = 15;
            this.bookListBox.Location = new System.Drawing.Point(68, 64);
            this.bookListBox.Margin = new System.Windows.Forms.Padding(2);
            this.bookListBox.Name = "bookListBox";
            this.bookListBox.Size = new System.Drawing.Size(260, 124);
            this.bookListBox.TabIndex = 1;
            // 
            // BuyBooksListBox
            // 
            this.BuyBooksListBox.FormattingEnabled = true;
            this.BuyBooksListBox.ItemHeight = 15;
            this.BuyBooksListBox.Location = new System.Drawing.Point(491, 64);
            this.BuyBooksListBox.Margin = new System.Windows.Forms.Padding(2);
            this.BuyBooksListBox.Name = "BuyBooksListBox";
            this.BuyBooksListBox.Size = new System.Drawing.Size(276, 124);
            this.BuyBooksListBox.TabIndex = 2;
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(590, 264);
            this.BuyButton.Margin = new System.Windows.Forms.Padding(2);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(88, 43);
            this.BuyButton.TabIndex = 3;
            this.BuyButton.Text = "Buy";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // InitAmountLabel
            // 
            this.InitAmountLabel.AutoSize = true;
            this.InitAmountLabel.Location = new System.Drawing.Point(95, 249);
            this.InitAmountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InitAmountLabel.Name = "InitAmountLabel";
            this.InitAmountLabel.Size = new System.Drawing.Size(71, 15);
            this.InitAmountLabel.TabIndex = 4;
            this.InitAmountLabel.Text = "Init Amount";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(203, 249);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(13, 15);
            this.label.TabIndex = 6;
            this.label.Text = "$";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(68, 325);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(68, 367);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 19);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 563);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.InitAmountLabel);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.BuyBooksListBox);
            this.Controls.Add(this.bookListBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListBox bookListBox;
        private ListBox BuyBooksListBox;
        private Button BuyButton;
        private Label InitAmountLabel;
        private Label label;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
    }
}