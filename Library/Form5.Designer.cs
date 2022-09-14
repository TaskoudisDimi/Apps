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
            ((System.ComponentModel.ISupportInitialize)(this.pagingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pagingDataGridView
            // 
            this.pagingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pagingDataGridView.Location = new System.Drawing.Point(17, 20);
            this.pagingDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pagingDataGridView.Name = "pagingDataGridView";
            this.pagingDataGridView.RowHeadersWidth = 62;
            this.pagingDataGridView.RowTemplate.Height = 25;
            this.pagingDataGridView.Size = new System.Drawing.Size(1109, 615);
            this.pagingDataGridView.TabIndex = 0;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.pagingDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pagingDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView pagingDataGridView;
    }
}