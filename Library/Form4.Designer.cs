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
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiselectAllButton = new System.Windows.Forms.Button();
            this.selectAllButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.copyAllButton = new System.Windows.Forms.Button();
            this.pasteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.copyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Status,
            this.Id,
            this.CatName,
            this.CatDesc});
            this.copyDataGridView.Location = new System.Drawing.Point(12, 294);
            this.copyDataGridView.Name = "copyDataGridView";
            this.copyDataGridView.RowTemplate.Height = 25;
            this.copyDataGridView.Size = new System.Drawing.Size(311, 198);
            this.copyDataGridView.TabIndex = 3;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // CatName
            // 
            this.CatName.HeaderText = "CatName";
            this.CatName.Name = "CatName";
            // 
            // CatDesc
            // 
            this.CatDesc.HeaderText = "CatDesc";
            this.CatDesc.Name = "CatDesc";
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
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
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
            // copyAllButton
            // 
            this.copyAllButton.Location = new System.Drawing.Point(413, 427);
            this.copyAllButton.Name = "copyAllButton";
            this.copyAllButton.Size = new System.Drawing.Size(75, 23);
            this.copyAllButton.TabIndex = 9;
            this.copyAllButton.Text = "Copy All";
            this.copyAllButton.UseVisualStyleBackColor = true;
            this.copyAllButton.Click += new System.EventHandler(this.copyAllButton_Click);
            // 
            // pasteDataGridView
            // 
            this.pasteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pasteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.pasteDataGridView.Location = new System.Drawing.Point(534, 294);
            this.pasteDataGridView.Name = "pasteDataGridView";
            this.pasteDataGridView.RowTemplate.Height = 25;
            this.pasteDataGridView.Size = new System.Drawing.Size(353, 198);
            this.pasteDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "CatName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "CatDesc";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 537);
            this.Controls.Add(this.pasteDataGridView);
            this.Controls.Add(this.copyAllButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.selectAllButton);
            this.Controls.Add(this.DiselectAllButton);
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
        private Button DiselectAllButton;
        private Button selectAllButton;
        private Button CopyButton;
        private Button ClearButton;
        private Button copyAllButton;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn CatName;
        private DataGridViewTextBoxColumn CatDesc;
        private DataGridView pasteDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}