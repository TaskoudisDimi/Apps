namespace Shop
{
    partial class People
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
            this.PeopleListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.PeopleLabel = new System.Windows.Forms.Label();
            this.PeopleDataGridView = new System.Windows.Forms.DataGridView();
            this.editButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PeopleListBox
            // 
            this.PeopleListBox.FormattingEnabled = true;
            this.PeopleListBox.ItemHeight = 15;
            this.PeopleListBox.Location = new System.Drawing.Point(12, 319);
            this.PeopleListBox.Name = "PeopleListBox";
            this.PeopleListBox.Size = new System.Drawing.Size(270, 139);
            this.PeopleListBox.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 224);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // PeopleLabel
            // 
            this.PeopleLabel.AutoSize = true;
            this.PeopleLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PeopleLabel.Location = new System.Drawing.Point(4, 24);
            this.PeopleLabel.Name = "PeopleLabel";
            this.PeopleLabel.Size = new System.Drawing.Size(103, 40);
            this.PeopleLabel.TabIndex = 5;
            this.PeopleLabel.Text = "People";
            // 
            // PeopleDataGridView
            // 
            this.PeopleDataGridView.AllowUserToAddRows = false;
            this.PeopleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PeopleDataGridView.Location = new System.Drawing.Point(4, 67);
            this.PeopleDataGridView.Name = "PeopleDataGridView";
            this.PeopleDataGridView.RowTemplate.Height = 25;
            this.PeopleDataGridView.Size = new System.Drawing.Size(354, 150);
            this.PeopleDataGridView.TabIndex = 8;
            this.PeopleDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PeopleDataGridView_MouseDown_1);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(93, 224);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 9;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(173, 224);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 10;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // People
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 470);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.PeopleDataGridView);
            this.Controls.Add(this.PeopleLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.PeopleListBox);
            this.Name = "People";
            this.Text = "People - Items";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.People_Items_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PeopleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox PeopleListBox;
        private Button addButton;
        private Label PeopleLabel;
        private DataGridView PeopleDataGridView;
        private Button editButton;
        private Button RemoveButton;
    }
}