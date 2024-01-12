using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.Forms
{
    public partial class Entity : Form
    {
        private BindingSource bindingSource;
        public Entity()
        {
            InitializeComponent();
        }

        private void Entity_Load(object sender, EventArgs e)
        {
            var dbContext = new DatabaseContext();
            // Initialize the binding source and connect it to the database using Entity Framework
            bindingSource = new BindingSource();
            bindingSource.DataSource = dbContext.CategoryTbl.ToList();
            // Set the binding source as the data source for the DataGridView control
            dataGridView.DataSource = bindingSource;
        }

        private void createButton_Click(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
