namespace Forms.Forms
{
    partial class AttributeTest
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
            button1 = new Button();
            labelTest = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(175, 57);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelTest
            // 
            labelTest.AutoSize = true;
            labelTest.Location = new Point(195, 9);
            labelTest.Name = "labelTest";
            labelTest.Size = new Size(27, 15);
            labelTest.TabIndex = 1;
            labelTest.Text = "Test";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 153);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(435, 23);
            progressBar1.TabIndex = 2;
            // 
            // AttributeTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 206);
            Controls.Add(progressBar1);
            Controls.Add(labelTest);
            Controls.Add(button1);
            Name = "AttributeTest";
            Text = "Attribute";
            Load += AttributeTest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label labelTest;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ProgressBar progressBar1;
    }
}