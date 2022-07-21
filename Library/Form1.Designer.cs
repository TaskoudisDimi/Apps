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
            this.formButton = new System.Windows.Forms.Button();
            this.form3Button = new System.Windows.Forms.Button();
            this.form4Button = new System.Windows.Forms.Button();
            this.form5Button = new System.Windows.Forms.Button();
            this.form6Button = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dayLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stringBuilderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookListBox
            // 
            this.bookListBox.FormattingEnabled = true;
            this.bookListBox.ItemHeight = 15;
            this.bookListBox.Location = new System.Drawing.Point(11, 109);
            this.bookListBox.Margin = new System.Windows.Forms.Padding(2);
            this.bookListBox.Name = "bookListBox";
            this.bookListBox.Size = new System.Drawing.Size(260, 124);
            this.bookListBox.TabIndex = 1;
            this.bookListBox.SelectedIndexChanged += new System.EventHandler(this.bookListBox_SelectedIndexChanged);
            // 
            // BuyBooksListBox
            // 
            this.BuyBooksListBox.FormattingEnabled = true;
            this.BuyBooksListBox.ItemHeight = 15;
            this.BuyBooksListBox.Location = new System.Drawing.Point(417, 109);
            this.BuyBooksListBox.Margin = new System.Windows.Forms.Padding(2);
            this.BuyBooksListBox.Name = "BuyBooksListBox";
            this.BuyBooksListBox.Size = new System.Drawing.Size(276, 124);
            this.BuyBooksListBox.TabIndex = 2;
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(514, 249);
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
            this.InitAmountLabel.Location = new System.Drawing.Point(48, 249);
            this.InitAmountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InitAmountLabel.Name = "InitAmountLabel";
            this.InitAmountLabel.Size = new System.Drawing.Size(71, 15);
            this.InitAmountLabel.TabIndex = 4;
            this.InitAmountLabel.Text = "Init Amount";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(156, 249);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(13, 15);
            this.label.TabIndex = 6;
            this.label.Text = "$";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 384);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(11, 426);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 19);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // formButton
            // 
            this.formButton.Location = new System.Drawing.Point(316, 528);
            this.formButton.Name = "formButton";
            this.formButton.Size = new System.Drawing.Size(75, 23);
            this.formButton.TabIndex = 9;
            this.formButton.Text = "Form 2";
            this.formButton.UseVisualStyleBackColor = true;
            this.formButton.Click += new System.EventHandler(this.formButton_Click);
            // 
            // form3Button
            // 
            this.form3Button.Location = new System.Drawing.Point(417, 528);
            this.form3Button.Name = "form3Button";
            this.form3Button.Size = new System.Drawing.Size(75, 23);
            this.form3Button.TabIndex = 10;
            this.form3Button.Text = "Form 3";
            this.form3Button.UseVisualStyleBackColor = true;
            this.form3Button.Click += new System.EventHandler(this.form3Button_Click);
            // 
            // form4Button
            // 
            this.form4Button.Location = new System.Drawing.Point(514, 528);
            this.form4Button.Name = "form4Button";
            this.form4Button.Size = new System.Drawing.Size(75, 23);
            this.form4Button.TabIndex = 11;
            this.form4Button.Text = "Form 4";
            this.form4Button.UseVisualStyleBackColor = true;
            this.form4Button.Click += new System.EventHandler(this.form4Button_Click);
            // 
            // form5Button
            // 
            this.form5Button.Location = new System.Drawing.Point(603, 528);
            this.form5Button.Name = "form5Button";
            this.form5Button.Size = new System.Drawing.Size(75, 23);
            this.form5Button.TabIndex = 12;
            this.form5Button.Text = "Form 5";
            this.form5Button.UseVisualStyleBackColor = true;
            this.form5Button.Click += new System.EventHandler(this.form5Button_Click);
            // 
            // form6Button
            // 
            this.form6Button.Location = new System.Drawing.Point(692, 528);
            this.form6Button.Name = "form6Button";
            this.form6Button.Size = new System.Drawing.Size(75, 23);
            this.form6Button.TabIndex = 13;
            this.form6Button.Text = "Form 6";
            this.form6Button.UseVisualStyleBackColor = true;
            this.form6Button.Click += new System.EventHandler(this.form6Button_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(36, 29);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker.TabIndex = 14;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(316, 29);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(33, 15);
            this.dayLabel.TabIndex = 15;
            this.dayLabel.Text = "Day: ";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(384, 29);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(46, 15);
            this.monthLabel.TabIndex = 16;
            this.monthLabel.Text = "Month:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(454, 29);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 15);
            this.yearLabel.TabIndex = 17;
            this.yearLabel.Text = "Year:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(417, 331);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(276, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // stringBuilderLabel
            // 
            this.stringBuilderLabel.AutoSize = true;
            this.stringBuilderLabel.Location = new System.Drawing.Point(677, 29);
            this.stringBuilderLabel.Name = "stringBuilderLabel";
            this.stringBuilderLabel.Size = new System.Drawing.Size(78, 15);
            this.stringBuilderLabel.TabIndex = 19;
            this.stringBuilderLabel.Text = "String Builder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 563);
            this.Controls.Add(this.stringBuilderLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.form6Button);
            this.Controls.Add(this.form5Button);
            this.Controls.Add(this.form4Button);
            this.Controls.Add(this.form3Button);
            this.Controls.Add(this.formButton);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private Button formButton;
        private Button form3Button;
        private Button form4Button;
        private Button form5Button;
        private Button form6Button;
        private DateTimePicker dateTimePicker;
        private Label dayLabel;
        private Label monthLabel;
        private Label yearLabel;
        private DataGridView dataGridView1;
        private Label stringBuilderLabel;
    }
}