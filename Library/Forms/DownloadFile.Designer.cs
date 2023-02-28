namespace Forms.Forms
{
    partial class DownloadFile
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
            this.startButton = new System.Windows.Forms.Button();
            this.url = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.Status = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.pauseButton = new System.Windows.Forms.Button();
            this.resumeButton = new System.Windows.Forms.Button();
            this.mb = new System.Windows.Forms.Label();
            this.download = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(286, 159);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // url
            // 
            this.url.AutoSize = true;
            this.url.Location = new System.Drawing.Point(33, 20);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(22, 15);
            this.url.TabIndex = 1;
            this.url.Text = "Url";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(113, 107);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(429, 23);
            this.progressBar.TabIndex = 3;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(33, 72);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(39, 15);
            this.Status.TabIndex = 4;
            this.Status.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(113, 17);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(429, 23);
            this.txtUrl.TabIndex = 6;
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(376, 159);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 22);
            this.pauseButton.TabIndex = 7;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            // 
            // resumeButton
            // 
            this.resumeButton.Location = new System.Drawing.Point(467, 159);
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.Size = new System.Drawing.Size(75, 22);
            this.resumeButton.TabIndex = 8;
            this.resumeButton.Text = "Resume";
            this.resumeButton.UseVisualStyleBackColor = true;
            // 
            // mb
            // 
            this.mb.AutoSize = true;
            this.mb.Location = new System.Drawing.Point(113, 283);
            this.mb.Name = "mb";
            this.mb.Size = new System.Drawing.Size(25, 15);
            this.mb.TabIndex = 10;
            this.mb.Text = "mb";
            // 
            // download
            // 
            this.download.AutoSize = true;
            this.download.Location = new System.Drawing.Point(33, 283);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(61, 15);
            this.download.TabIndex = 9;
            this.download.Text = "Download";
            // 
            // DownloadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mb);
            this.Controls.Add(this.download);
            this.Controls.Add(this.resumeButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.url);
            this.Controls.Add(this.startButton);
            this.Name = "DownloadFile";
            this.Text = "DownlodFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button startButton;
        private Label url;
        private ProgressBar progressBar;
        private Label Status;
        private Label label3;
        private TextBox txtUrl;
        private Button pauseButton;
        private Button resumeButton;
        private Label mb;
        private Label download;
    }
}