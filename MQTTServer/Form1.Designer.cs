namespace MQTTServer
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
            this.publishButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // publishButton
            // 
            this.publishButton.Location = new System.Drawing.Point(173, 166);
            this.publishButton.Name = "publishButton";
            this.publishButton.Size = new System.Drawing.Size(111, 47);
            this.publishButton.TabIndex = 0;
            this.publishButton.Text = "Publish";
            this.publishButton.UseVisualStyleBackColor = true;
            this.publishButton.Click += new System.EventHandler(this.publishButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(28, 166);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(111, 47);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(28, 280);
            this.statusTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statusTextBox.Multiline = true;
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(674, 272);
            this.statusTextBox.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 635);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.publishButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button publishButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox statusTextBox;
    }
}

