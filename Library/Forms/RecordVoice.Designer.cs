namespace Forms.Forms
{
    partial class RecordVoice
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
            recordButton = new Button();
            stopButton = new Button();
            SuspendLayout();
            // 
            // recordButton
            // 
            recordButton.Location = new Point(35, 214);
            recordButton.Margin = new Padding(2, 2, 2, 2);
            recordButton.Name = "recordButton";
            recordButton.Size = new Size(78, 20);
            recordButton.TabIndex = 0;
            recordButton.Text = "Record";
            recordButton.UseVisualStyleBackColor = true;
            // 
            // stopButton
            // 
            stopButton.Location = new Point(206, 214);
            stopButton.Margin = new Padding(2, 2, 2, 2);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(78, 20);
            stopButton.TabIndex = 2;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            // 
            // RecordVoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 270);
            Controls.Add(stopButton);
            Controls.Add(recordButton);
            Margin = new Padding(2, 2, 2, 2);
            Name = "RecordVoice";
            Text = "RecordVoice";
            ResumeLayout(false);
        }

        #endregion

        private Button recordButton;
        private Button stopButton;
    }
}