namespace Library
{
    partial class Form5
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
            this.conButton = new System.Windows.Forms.Button();
            this.commitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // conButton
            // 
            this.conButton.Location = new System.Drawing.Point(78, 57);
            this.conButton.Name = "conButton";
            this.conButton.Size = new System.Drawing.Size(89, 23);
            this.conButton.TabIndex = 1;
            this.conButton.Text = "Connection";
            this.conButton.UseVisualStyleBackColor = true;
            this.conButton.Click += new System.EventHandler(this.conButton_Click);
            // 
            // commitButton
            // 
            this.commitButton.Location = new System.Drawing.Point(78, 125);
            this.commitButton.Name = "commitButton";
            this.commitButton.Size = new System.Drawing.Size(89, 23);
            this.commitButton.TabIndex = 2;
            this.commitButton.Text = "Commit";
            this.commitButton.UseVisualStyleBackColor = true;
            this.commitButton.Click += new System.EventHandler(this.commitButton_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.commitButton);
            this.Controls.Add(this.conButton);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);

        }

        #endregion

        private Button conButton;
        private Button commitButton;
    }
}