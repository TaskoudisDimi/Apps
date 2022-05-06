namespace Library
{
    partial class Form4
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
            this.importFiletextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.importFileDataGridView = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.copyDataGridView = new System.Windows.Forms.DataGridView();
            this.pasteDataGridView = new System.Windows.Forms.DataGridView();
            this.DiselectAllButton = new System.Windows.Forms.Button();
            this.selectAllButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.importFileDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // importFiletextBox
            // 
            this.importFiletextBox.Location = new System.Drawing.Point(3, 12);
            this.importFiletextBox.Name = "importFiletextBox";
            this.importFiletextBox.Size = new System.Drawing.Size(331, 23);
            this.importFiletextBox.TabIndex = 0;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(340, 12);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // importFileDataGridView
            // 
            this.importFileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.importFileDataGridView.Location = new System.Drawing.Point(3, 41);
            this.importFileDataGridView.Name = "importFileDataGridView";
            this.importFileDataGridView.RowTemplate.Height = 25;
            this.importFileDataGridView.Size = new System.Drawing.Size(412, 198);
            this.importFileDataGridView.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // copyDataGridView
            // 
            this.copyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.copyDataGridView.Location = new System.Drawing.Point(12, 294);
            this.copyDataGridView.Name = "copyDataGridView";
            this.copyDataGridView.RowTemplate.Height = 25;
            this.copyDataGridView.Size = new System.Drawing.Size(311, 198);
            this.copyDataGridView.TabIndex = 3;
            // 
            // pasteDataGridView
            // 
            this.pasteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pasteDataGridView.Location = new System.Drawing.Point(555, 294);
            this.pasteDataGridView.Name = "pasteDataGridView";
            this.pasteDataGridView.RowTemplate.Height = 25;
            this.pasteDataGridView.Size = new System.Drawing.Size(311, 198);
            this.pasteDataGridView.TabIndex = 4;
            // 
            // DiselectAllButton
            // 
            this.DiselectAllButton.Location = new System.Drawing.Point(111, 502);
            this.DiselectAllButton.Name = "DiselectAllButton";
            this.DiselectAllButton.Size = new System.Drawing.Size(75, 23);
            this.DiselectAllButton.TabIndex = 5;
            this.DiselectAllButton.Text = "Diselect All";
            this.DiselectAllButton.UseVisualStyleBackColor = true;
            this.DiselectAllButton.Click += new System.EventHandler(this.DiselectAllButton_Click);
            // 
            // selectAllButton
            // 
            this.selectAllButton.Location = new System.Drawing.Point(12, 502);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(75, 23);
            this.selectAllButton.TabIndex = 6;
            this.selectAllButton.Text = "Select All";
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(413, 381);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(75, 23);
            this.CopyButton.TabIndex = 7;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(555, 502);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(743, 166);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(75, 23);
            this.reportButton.TabIndex = 9;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 537);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.selectAllButton);
            this.Controls.Add(this.DiselectAllButton);
            this.Controls.Add(this.pasteDataGridView);
            this.Controls.Add(this.copyDataGridView);
            this.Controls.Add(this.importFileDataGridView);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.importFiletextBox);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.importFileDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox importFiletextBox;
        private Button browseButton;
        private DataGridView importFileDataGridView;
        private OpenFileDialog openFileDialog1;
        private DataGridView copyDataGridView;
        private DataGridView pasteDataGridView;
        private Button DiselectAllButton;
        private Button selectAllButton;
        private Button CopyButton;
        private Button ClearButton;
        private Button reportButton;
    }
}