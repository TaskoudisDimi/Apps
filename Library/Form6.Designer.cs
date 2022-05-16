namespace Library
{
    partial class Form6
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
            this.exportDataGridView = new System.Windows.Forms.DataGridView();
            this.exportButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.exportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // exportDataGridView
            // 
            this.exportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exportDataGridView.Location = new System.Drawing.Point(8, 84);
            this.exportDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exportDataGridView.Name = "exportDataGridView";
            this.exportDataGridView.RowHeadersWidth = 62;
            this.exportDataGridView.RowTemplate.Height = 33;
            this.exportDataGridView.Size = new System.Drawing.Size(821, 499);
            this.exportDataGridView.TabIndex = 0;
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(734, 49);
            this.exportButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(78, 20);
            this.exportButton.TabIndex = 1;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 606);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.exportDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form6";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.exportDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView exportDataGridView;
        private Button exportButton;
        private SaveFileDialog saveFileDialog;
    }
}