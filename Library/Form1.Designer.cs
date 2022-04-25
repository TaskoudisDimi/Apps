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
            this.SuspendLayout();
            // 
            // bookListBox
            // 
            this.bookListBox.FormattingEnabled = true;
            this.bookListBox.ItemHeight = 25;
            this.bookListBox.Location = new System.Drawing.Point(43, 61);
            this.bookListBox.Name = "bookListBox";
            this.bookListBox.Size = new System.Drawing.Size(336, 154);
            this.bookListBox.TabIndex = 1;
            // 
            // BuyBooksListBox
            // 
            this.BuyBooksListBox.FormattingEnabled = true;
            this.BuyBooksListBox.ItemHeight = 25;
            this.BuyBooksListBox.Location = new System.Drawing.Point(552, 61);
            this.BuyBooksListBox.Name = "BuyBooksListBox";
            this.BuyBooksListBox.Size = new System.Drawing.Size(369, 154);
            this.BuyBooksListBox.TabIndex = 2;
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(403, 289);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(112, 34);
            this.BuyButton.TabIndex = 3;
            this.BuyButton.Text = "Buy";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // InitAmountLabel
            // 
            this.InitAmountLabel.AutoSize = true;
            this.InitAmountLabel.Location = new System.Drawing.Point(43, 267);
            this.InitAmountLabel.Name = "InitAmountLabel";
            this.InitAmountLabel.Size = new System.Drawing.Size(107, 25);
            this.InitAmountLabel.TabIndex = 4;
            this.InitAmountLabel.Text = "Init Amount";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(196, 267);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(22, 25);
            this.label.TabIndex = 6;
            this.label.Text = "$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 690);
            this.Controls.Add(this.label);
            this.Controls.Add(this.InitAmountLabel);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.BuyBooksListBox);
            this.Controls.Add(this.bookListBox);
            this.Name = "Form1";
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
    }
}