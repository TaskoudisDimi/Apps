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
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.connectButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.method2DataGridView = new System.Windows.Forms.DataGridView();
            this.CatId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindDataGridView = new System.Windows.Forms.DataGridView();
            this.method1Label = new System.Windows.Forms.Label();
            this.method2Label = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.autoCompleteComboBox = new System.Windows.Forms.ComboBox();
            this.AutoCompleteLabel = new System.Windows.Forms.Label();
            this.addRowButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.method1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.method2DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // method1DataGridView
            // 
            this.method1DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.method1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.method1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select});
            this.method1DataGridView.Location = new System.Drawing.Point(24, 131);
            this.method1DataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.method1DataGridView.Name = "method1DataGridView";
            this.method1DataGridView.RowHeadersWidth = 62;
            this.method1DataGridView.RowTemplate.Height = 33;
            this.method1DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.method1DataGridView.Size = new System.Drawing.Size(321, 156);
            this.method1DataGridView.TabIndex = 1;
            this.method1DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.method1DataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.method1DataGridView_CellDoubleClick);
            // 
            // select
            // 
            this.select.HeaderText = "Select";
            this.select.Name = "select";
            this.select.Visible = false;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(24, 11);
            this.connectButton.Margin = new System.Windows.Forms.Padding(2);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(78, 20);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connection";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(443, 340);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(75, 23);
            this.displayButton.TabIndex = 3;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // method2DataGridView
            // 
            this.method2DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.method2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.method2DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CatId,
            this.CatName,
            this.CatDesc});
            this.method2DataGridView.Location = new System.Drawing.Point(443, 131);
            this.method2DataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.method2DataGridView.Name = "method2DataGridView";
            this.method2DataGridView.RowHeadersWidth = 62;
            this.method2DataGridView.RowTemplate.Height = 33;
            this.method2DataGridView.Size = new System.Drawing.Size(339, 156);
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
            this.bindDataGridView.Location = new System.Drawing.Point(24, 340);
            this.bindDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.bindDataGridView.Name = "bindDataGridView";
            this.bindDataGridView.RowHeadersWidth = 62;
            this.bindDataGridView.RowTemplate.Height = 33;
            this.bindDataGridView.Size = new System.Drawing.Size(321, 156);
            this.bindDataGridView.TabIndex = 5;
            // 
            // method1Label
            // 
            this.method1Label.AutoSize = true;
            this.method1Label.Location = new System.Drawing.Point(114, 91);
            this.method1Label.Name = "method1Label";
            this.method1Label.Size = new System.Drawing.Size(58, 15);
            this.method1Label.TabIndex = 6;
            this.method1Label.Text = "Method 1";
            // 
            // method2Label
            // 
            this.method2Label.AutoSize = true;
            this.method2Label.Location = new System.Drawing.Point(582, 91);
            this.method2Label.Name = "method2Label";
            this.method2Label.Size = new System.Drawing.Size(58, 15);
            this.method2Label.TabIndex = 7;
            this.method2Label.Text = "Method 2";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(565, 340);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(678, 340);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 9;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // autoCompleteComboBox
            // 
            this.autoCompleteComboBox.FormattingEnabled = true;
            this.autoCompleteComboBox.Location = new System.Drawing.Point(443, 437);
            this.autoCompleteComboBox.Name = "autoCompleteComboBox";
            this.autoCompleteComboBox.Size = new System.Drawing.Size(138, 23);
            this.autoCompleteComboBox.TabIndex = 10;
            this.autoCompleteComboBox.SelectedIndexChanged += new System.EventHandler(this.autoCompleteComboBox_SelectedIndexChanged);
            // 
            // AutoCompleteLabel
            // 
            this.AutoCompleteLabel.AutoSize = true;
            this.AutoCompleteLabel.Location = new System.Drawing.Point(443, 419);
            this.AutoCompleteLabel.Name = "AutoCompleteLabel";
            this.AutoCompleteLabel.Size = new System.Drawing.Size(85, 15);
            this.AutoCompleteLabel.TabIndex = 11;
            this.AutoCompleteLabel.Text = "AutoComplete";
            // 
            // addRowButton
            // 
            this.addRowButton.Location = new System.Drawing.Point(24, 523);
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.Size = new System.Drawing.Size(90, 33);
            this.addRowButton.TabIndex = 12;
            this.addRowButton.Text = "Add Row";
            this.addRowButton.UseVisualStyleBackColor = true;
            this.addRowButton.Click += new System.EventHandler(this.addRowButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(873, 684);
            this.Controls.Add(this.addRowButton);
            this.Controls.Add(this.AutoCompleteLabel);
            this.Controls.Add(this.autoCompleteComboBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.method2Label);
            this.Controls.Add(this.method1Label);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.bindDataGridView);
            this.Controls.Add(this.method2DataGridView);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.method1DataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.method1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.method2DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView method1DataGridView;
        private Button connectButton;
        private Button displayButton;
        private DataGridView method2DataGridView;
        private DataGridViewTextBoxColumn CatId;
        private DataGridViewTextBoxColumn CatName;
        private DataGridViewTextBoxColumn CatDesc;
        private DataGridView bindDataGridView;
        private Label method1Label;
        private Label method2Label;
        private Button addButton;
        private Button removeButton;
        private ComboBox autoCompleteComboBox;
        private Label AutoCompleteLabel;
        private DataGridViewCheckBoxColumn select;
        private Button addRowButton;
    }
}