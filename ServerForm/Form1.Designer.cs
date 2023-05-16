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
            SuspendLayout();
            // 
            // connectedClientsLabel
            // 
            connectedClientsLabel.AutoSize = true;
            connectedClientsLabel.Location = new Point(24, 30);
            connectedClientsLabel.Name = "connectedClientsLabel";
            connectedClientsLabel.Size = new Size(104, 15);
            connectedClientsLabel.TabIndex = 0;
            connectedClientsLabel.Text = "Connected Clients";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new Point(24, 71);
            countLabel.Name = "countLabel";
            countLabel.Size = new Size(13, 15);
            countLabel.TabIndex = 1;
            countLabel.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(countLabel);
            Controls.Add(connectedClientsLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label connectedClientsLabel;
        private Label countLabel;
    }
}