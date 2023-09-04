namespace Forms
{
    partial class ExcelForm
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
            this.saveExcelButton = new System.Windows.Forms.Button();
            this.getExcelButton = new System.Windows.Forms.Button();
            this.csvButton = new System.Windows.Forms.Button();
            this.getCsvButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.displayButton = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // saveExcelButton
            // 
            this.saveExcelButton.Location = new System.Drawing.Point(417, 622);
            this.saveExcelButton.Name = "saveExcelButton";
            this.saveExcelButton.Size = new System.Drawing.Size(111, 50);
            this.saveExcelButton.TabIndex = 0;
            this.saveExcelButton.Text = "Save xlsx";
            this.saveExcelButton.UseVisualStyleBackColor = true;
            this.saveExcelButton.Click += new System.EventHandler(this.saveExcelButton_Click);
            // 
            // getExcelButton
            // 
            this.getExcelButton.Location = new System.Drawing.Point(591, 622);
            this.getExcelButton.Name = "getExcelButton";
            this.getExcelButton.Size = new System.Drawing.Size(111, 50);
            this.getExcelButton.TabIndex = 1;
            this.getExcelButton.Text = "Get xlsx";
            this.getExcelButton.UseVisualStyleBackColor = true;
            this.getExcelButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // csvButton
            // 
            this.csvButton.Location = new System.Drawing.Point(417, 703);
            this.csvButton.Name = "csvButton";
            this.csvButton.Size = new System.Drawing.Size(111, 42);
            this.csvButton.TabIndex = 2;
            this.csvButton.Text = "Save Csv";
            this.csvButton.UseVisualStyleBackColor = true;
            this.csvButton.Click += new System.EventHandler(this.csvButton_Click);
            // 
            // getCsvButton
            // 
            this.getCsvButton.Location = new System.Drawing.Point(591, 703);
            this.getCsvButton.Name = "getCsvButton";
            this.getCsvButton.Size = new System.Drawing.Size(111, 42);
            this.getCsvButton.TabIndex = 3;
            this.getCsvButton.Text = "Get csv";
            this.getCsvButton.UseVisualStyleBackColor = true;
            this.getCsvButton.Click += new System.EventHandler(this.getCsvButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(24, 27);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(1101, 543);
            this.dataGridView.TabIndex = 4;
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(24, 603);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(159, 52);
            this.displayButton.TabIndex = 5;
            this.displayButton.Text = "Display Data";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(950, 605);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(175, 50);
            this.testButton.TabIndex = 6;
            this.testButton.Text = "Test ProgressBar";
            this.testButton.UseVisualStyleBackColor = true;
            // 
            // ExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 763);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.getCsvButton);
            this.Controls.Add(this.csvButton);
            this.Controls.Add(this.getExcelButton);
            this.Controls.Add(this.saveExcelButton);
            this.Name = "ExcelForm";
            this.Text = "ExcelForm";
            this.Load += new System.EventHandler(this.ExcelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button saveExcelButton;
        private Button getExcelButton;
        private Button csvButton;
        private Button getCsvButton;
        private DataGridView dataGridView;
        private Button displayButton;
        private Button testButton;
    }
}