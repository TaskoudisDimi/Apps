namespace Library
{
    partial class Form2
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
            this.method1DataGridView = new System.Windows.Forms.DataGridView();
            this.connectButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.method2DataGridView = new System.Windows.Forms.DataGridView();
            this.CatId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.method1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.method2DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // method1DataGridView
            // 
            this.method1DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.method1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.method1DataGridView.Location = new System.Drawing.Point(24, 82);
            this.method1DataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.method1DataGridView.Name = "method1DataGridView";
            this.method1DataGridView.RowHeadersWidth = 62;
            this.method1DataGridView.RowTemplate.Height = 33;
            this.method1DataGridView.Size = new System.Drawing.Size(295, 156);
            this.method1DataGridView.TabIndex = 1;
            this.method1DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(47, 34);
            this.connectButton.Margin = new System.Windows.Forms.Padding(2);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(78, 20);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connection";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(326, 34);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // method2DataGridView
            // 
            this.method2DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.method2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.method2DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CatId,
            this.CatName,
            this.CatDesc});
            this.method2DataGridView.Location = new System.Drawing.Point(390, 82);
            this.method2DataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.method2DataGridView.Name = "method2DataGridView";
            this.method2DataGridView.RowHeadersWidth = 62;
            this.method2DataGridView.RowTemplate.Height = 33;
            this.method2DataGridView.Size = new System.Drawing.Size(295, 156);
            this.method2DataGridView.TabIndex = 4;
            // 
            // CatId
            // 
            this.CatId.DataPropertyName = "CatId";
            this.CatId.HeaderText = "CatId";
            this.CatId.Name = "CatId";
            // 
            // CatName
            // 
            this.CatName.DataPropertyName = "CatName";
            this.CatName.HeaderText = "CatName";
            this.CatName.Name = "CatName";
            // 
            // CatDesc
            // 
            this.CatDesc.DataPropertyName = "CatDesc";
            this.CatDesc.HeaderText = "CatDesc";
            this.CatDesc.Name = "CatDesc";
            // 
            // bindDataGridView
            // 
            this.bindDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bindDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bindDataGridView.Location = new System.Drawing.Point(24, 274);
            this.bindDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.bindDataGridView.Name = "bindDataGridView";
            this.bindDataGridView.RowHeadersWidth = 62;
            this.bindDataGridView.RowTemplate.Height = 33;
            this.bindDataGridView.Size = new System.Drawing.Size(295, 156);
            this.bindDataGridView.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(725, 455);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.bindDataGridView);
            this.Controls.Add(this.method2DataGridView);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.method1DataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.method1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.method2DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView method1DataGridView;
        private Button connectButton;
        private Button addButton;
        private DataGridView method2DataGridView;
        private DataGridViewTextBoxColumn CatId;
        private DataGridViewTextBoxColumn CatName;
        private DataGridViewTextBoxColumn CatDesc;
        private DataGridView bindDataGridView;
    }
}