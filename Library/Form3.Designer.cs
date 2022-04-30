namespace Library
{
    partial class Form3
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
            this.catIdTextBox = new System.Windows.Forms.TextBox();
            this.catNameTextBox = new System.Windows.Forms.TextBox();
            this.catDescTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // catIdTextBox
            // 
            this.catIdTextBox.Location = new System.Drawing.Point(363, 90);
            this.catIdTextBox.Name = "catIdTextBox";
            this.catIdTextBox.Size = new System.Drawing.Size(100, 23);
            this.catIdTextBox.TabIndex = 0;
            // 
            // catNameTextBox
            // 
            this.catNameTextBox.Location = new System.Drawing.Point(363, 146);
            this.catNameTextBox.Name = "catNameTextBox";
            this.catNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.catNameTextBox.TabIndex = 1;
            // 
            // catDescTextBox
            // 
            this.catDescTextBox.Location = new System.Drawing.Point(363, 202);
            this.catDescTextBox.Name = "catDescTextBox";
            this.catDescTextBox.Size = new System.Drawing.Size(100, 23);
            this.catDescTextBox.TabIndex = 2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.catDescTextBox);
            this.Controls.Add(this.catNameTextBox);
            this.Controls.Add(this.catIdTextBox);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox catIdTextBox;
        public TextBox catNameTextBox;
        public TextBox catDescTextBox;
    }
}