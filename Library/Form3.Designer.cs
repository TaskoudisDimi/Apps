﻿namespace Library
{
    partial class Form3
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
            this.catIdTextBox = new System.Windows.Forms.TextBox();
            this.catNameTextBox = new System.Windows.Forms.TextBox();
            this.catDescTextBox = new System.Windows.Forms.TextBox();
            this.sqlTextBox = new System.Windows.Forms.TextBox();
            this.sqlButton = new System.Windows.Forms.Button();
            this.sqlDataGridView = new System.Windows.Forms.DataGridView();
            this.readOnlyDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sqlDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readOnlyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // catIdTextBox
            // 
            this.catIdTextBox.Location = new System.Drawing.Point(84, 49);
            this.catIdTextBox.Name = "catIdTextBox";
            this.catIdTextBox.Size = new System.Drawing.Size(100, 23);
            this.catIdTextBox.TabIndex = 0;
            // 
            // catNameTextBox
            // 
            this.catNameTextBox.Location = new System.Drawing.Point(84, 105);
            this.catNameTextBox.Name = "catNameTextBox";
            this.catNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.catNameTextBox.TabIndex = 1;
            // 
            // catDescTextBox
            // 
            this.catDescTextBox.Location = new System.Drawing.Point(84, 161);
            this.catDescTextBox.Name = "catDescTextBox";
            this.catDescTextBox.Size = new System.Drawing.Size(100, 23);
            this.catDescTextBox.TabIndex = 2;
            // 
            // sqlTextBox
            // 
            this.sqlTextBox.Location = new System.Drawing.Point(383, 31);
            this.sqlTextBox.Name = "sqlTextBox";
            this.sqlTextBox.Size = new System.Drawing.Size(240, 23);
            this.sqlTextBox.TabIndex = 3;
            // 
            // sqlButton
            // 
            this.sqlButton.Location = new System.Drawing.Point(642, 31);
            this.sqlButton.Name = "sqlButton";
            this.sqlButton.Size = new System.Drawing.Size(75, 23);
            this.sqlButton.TabIndex = 4;
            this.sqlButton.Text = "Execute Sql";
            this.sqlButton.UseVisualStyleBackColor = true;
            this.sqlButton.Click += new System.EventHandler(this.sqlButton_Click);
            // 
            // sqlDataGridView
            // 
            this.sqlDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqlDataGridView.Location = new System.Drawing.Point(383, 70);
            this.sqlDataGridView.Name = "sqlDataGridView";
            this.sqlDataGridView.RowTemplate.Height = 25;
            this.sqlDataGridView.Size = new System.Drawing.Size(240, 150);
            this.sqlDataGridView.TabIndex = 5;
            // 
            // readOnlyDataGridView
            // 
            this.readOnlyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readOnlyDataGridView.Location = new System.Drawing.Point(38, 259);
            this.readOnlyDataGridView.Name = "readOnlyDataGridView";
            this.readOnlyDataGridView.RowTemplate.Height = 25;
            this.readOnlyDataGridView.Size = new System.Drawing.Size(311, 150);
            this.readOnlyDataGridView.TabIndex = 6;
            this.readOnlyDataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.readOnlyDataGridView_CellValidated);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.readOnlyDataGridView);
            this.Controls.Add(this.sqlDataGridView);
            this.Controls.Add(this.sqlButton);
            this.Controls.Add(this.sqlTextBox);
            this.Controls.Add(this.catDescTextBox);
            this.Controls.Add(this.catNameTextBox);
            this.Controls.Add(this.catIdTextBox);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.sqlDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readOnlyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox catIdTextBox;
        public TextBox catNameTextBox;
        public TextBox catDescTextBox;
        private TextBox sqlTextBox;
        private Button sqlButton;
        private DataGridView qlDataGridView;
        private DataGridView sqlDataGridView;
        private DataGridView readOnlyDataGridView;
    }
}