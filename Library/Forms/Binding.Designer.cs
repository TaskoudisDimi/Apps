namespace Forms
{
    partial class Binding
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catIdDataGridViewTextBoxColumn,
            this.catNameDataGridViewTextBoxColumn,
            this.catDescDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.productsBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(49, 50);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(986, 643);
            this.dataGridView.TabIndex = 0;
            // 
            // productsBindingSource
            // 
            // 
            // catIdDataGridViewTextBoxColumn
            // 
            this.catIdDataGridViewTextBoxColumn.DataPropertyName = "CatId";
            this.catIdDataGridViewTextBoxColumn.HeaderText = "CatId";
            this.catIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.catIdDataGridViewTextBoxColumn.Name = "catIdDataGridViewTextBoxColumn";
            this.catIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // catNameDataGridViewTextBoxColumn
            // 
            this.catNameDataGridViewTextBoxColumn.DataPropertyName = "CatName";
            this.catNameDataGridViewTextBoxColumn.HeaderText = "CatName";
            this.catNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.catNameDataGridViewTextBoxColumn.Name = "catNameDataGridViewTextBoxColumn";
            this.catNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // catDescDataGridViewTextBoxColumn
            // 
            this.catDescDataGridViewTextBoxColumn.DataPropertyName = "CatDesc";
            this.catDescDataGridViewTextBoxColumn.HeaderText = "CatDesc";
            this.catDescDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.catDescDataGridViewTextBoxColumn.Name = "catDescDataGridViewTextBoxColumn";
            this.catDescDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // Binding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Binding";
            this.Text = "Binding";
            this.Load += new System.EventHandler(this.Binding_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prodNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prodQtyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prodPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prodCatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prodDateDataGridViewTextBoxColumn;
        private BindingSource productsBindingSource;
        private DataGridViewTextBoxColumn catIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn catNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn catDescDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}