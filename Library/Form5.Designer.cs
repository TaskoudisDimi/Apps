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
            this.pagingDataGridView = new System.Windows.Forms.DataGridView();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.pageLabel = new System.Windows.Forms.Label();
            this.formButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pagingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pagingDataGridView
            // 
            this.pagingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pagingDataGridView.Location = new System.Drawing.Point(12, 12);
            this.pagingDataGridView.Name = "pagingDataGridView";
            this.pagingDataGridView.RowTemplate.Height = 25;
            this.pagingDataGridView.Size = new System.Drawing.Size(776, 369);
            this.pagingDataGridView.TabIndex = 0;
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(219, 404);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 23);
            this.previousButton.TabIndex = 1;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(405, 400);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // pageLabel
            // 
            this.pageLabel.AutoSize = true;
            this.pageLabel.Location = new System.Drawing.Point(330, 404);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(33, 15);
            this.pageLabel.TabIndex = 3;
            this.pageLabel.Text = "page";
            // 
            // formButton
            // 
            this.formButton.Location = new System.Drawing.Point(713, 415);
            this.formButton.Name = "formButton";
            this.formButton.Size = new System.Drawing.Size(75, 23);
            this.formButton.TabIndex = 10;
            this.formButton.Text = "Form 6";
            this.formButton.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.formButton);
            this.Controls.Add(this.pageLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.pagingDataGridView);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pagingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView pagingDataGridView;
        private Button previousButton;
        private Button nextButton;
        private Label pageLabel;
        private Button formButton;
    }
}