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
            this.components = new System.ComponentModel.Container();
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
            this.excelDataGridView = new System.Windows.Forms.DataGridView();
            this.excelTextBox = new System.Windows.Forms.TextBox();
            this.txtLabel = new System.Windows.Forms.Label();
            this.excelLabel = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.exportButton = new System.Windows.Forms.Button();
            this.formButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.importFileDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelDataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // importFiletextBox
            // 
            this.importFiletextBox.Location = new System.Drawing.Point(9, 38);
            this.importFiletextBox.Name = "importFiletextBox";
            this.importFiletextBox.Size = new System.Drawing.Size(331, 23);
            this.importFiletextBox.TabIndex = 0;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(346, 38);
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
            this.importFileDataGridView.Location = new System.Drawing.Point(9, 67);
            this.importFileDataGridView.Name = "importFileDataGridView";
            this.importFileDataGridView.RowHeadersWidth = 62;
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
            this.copyDataGridView.RowHeadersWidth = 62;
            this.copyDataGridView.RowTemplate.Height = 25;
            this.copyDataGridView.Size = new System.Drawing.Size(311, 198);
            this.copyDataGridView.TabIndex = 3;
            this.copyDataGridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.copyDataGridView_CellMouseUp);
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.Width = 150;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Width = 150;
            // 
            // CatName
            // 
            this.CatName.HeaderText = "CatName";
            this.CatName.MinimumWidth = 8;
            this.CatName.Name = "CatName";
            this.CatName.Width = 150;
            // 
            // CatDesc
            // 
            this.CatDesc.HeaderText = "CatDesc";
            this.CatDesc.MinimumWidth = 8;
            this.CatDesc.Name = "CatDesc";
            this.CatDesc.Width = 150;
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
            this.pasteDataGridView.RowHeadersWidth = 62;
            this.pasteDataGridView.RowTemplate.Height = 25;
            this.pasteDataGridView.Size = new System.Drawing.Size(353, 198);
            this.pasteDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "CatName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "CatDesc";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // excelDataGridView
            // 
            this.excelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.excelDataGridView.Location = new System.Drawing.Point(454, 67);
            this.excelDataGridView.Name = "excelDataGridView";
            this.excelDataGridView.RowHeadersWidth = 62;
            this.excelDataGridView.RowTemplate.Height = 25;
            this.excelDataGridView.Size = new System.Drawing.Size(358, 198);
            this.excelDataGridView.TabIndex = 13;
            // 
            // excelTextBox
            // 
            this.excelTextBox.Location = new System.Drawing.Point(454, 38);
            this.excelTextBox.Name = "excelTextBox";
            this.excelTextBox.Size = new System.Drawing.Size(359, 23);
            this.excelTextBox.TabIndex = 11;
            // 
            // txtLabel
            // 
            this.txtLabel.AutoSize = true;
            this.txtLabel.Location = new System.Drawing.Point(93, 12);
            this.txtLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(84, 15);
            this.txtLabel.TabIndex = 14;
            this.txtLabel.Text = "Import txt files";
            // 
            // excelLabel
            // 
            this.excelLabel.AutoSize = true;
            this.excelLabel.Location = new System.Drawing.Point(656, 12);
            this.excelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.excelLabel.Name = "excelLabel";
            this.excelLabel.Size = new System.Drawing.Size(97, 15);
            this.excelLabel.TabIndex = 15;
            this.excelLabel.Text = "Import excel files";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(835, 131);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 17;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click_1);
            // 
            // formButton
            // 
            this.formButton.Location = new System.Drawing.Point(835, 511);
            this.formButton.Name = "formButton";
            this.formButton.Size = new System.Drawing.Size(75, 23);
            this.formButton.TabIndex = 20;
            this.formButton.Text = "Form 5";
            this.formButton.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRowToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 26);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.deleteRowToolStripMenuItem.Text = "Delete Row";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 537);
            this.Controls.Add(this.formButton);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.excelLabel);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.excelDataGridView);
            this.Controls.Add(this.excelTextBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.excelDataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private DataGridView excelDataGridView;
        private TextBox excelTextBox;
        private Label txtLabel;
        private Label excelLabel;
        private OpenFileDialog openFileDialog2;
        private Button exportButton;
        private Button formButton;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteRowToolStripMenuItem;
    }
}