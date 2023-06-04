using ShopLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Excel = Microsoft.Office.Interop.Excel;



namespace Shop
{
    public partial class ConsignmentShop : Form
    {

        private Store store = new Store();

        public ConsignmentShop()
        {
            InitializeComponent();

            display();
            MainMenu();
            storeProfitSetValue();

        }

        private void storeProfitSetValue()
        {
            double store = 0;
            for (int i = 0; i < vendorDataGridView.Rows.Count; i++)
            {
                store += double.Parse(vendorDataGridView.Rows[i].Cells[4].Value.ToString());
            }
            storeProfitValue.Text = store.ToString();
        }
        private void refresh()
        {
            Connection loaddata21 = new Connection();
            loaddata21.retrieveData("Select * From Items");
            storeItemsDataGridView.DataSource = loaddata21.table;

            Connection loaddata22 = new Connection();
            loaddata22.retrieveData("Select * From Vendor");
            vendorDataGridView.DataSource = loaddata22.table;
        }

        private void MainMenu()
        {
            MenuStrip MnuStrip = new MenuStrip();
            //Control is added to the Form using the Add property
            this.Controls.Add(MnuStrip);

            string[] items = new string[] { "File", "Edit", "About" };
            foreach (string Row in items)
            {
                ToolStripMenuItem MnuStripItem = new ToolStripMenuItem(Row);
                MnuStrip.Items.Add(MnuStripItem);
                //SubMenu(MnuStripItem, Row);
                if (MnuStripItem.Text == "About")
                {
                    MnuStripItem.Click += new EventHandler(MnuStripItem_Click);
                }

            }


        }

        private void MnuStripItem_Click(object sender, EventArgs e)
        {
            About form = new About();
            form.Show();

        }

        private void FileExit_clicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FileNew_clicked(object sender, EventArgs e)
        {
            MessageBox.Show("New", "MENU_CREATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FileOpen_clicked(object sender, EventArgs e)
        {
            MessageBox.Show("Open", "MENU_CREATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void About_clicked(object sender, EventArgs e)
        {
            MessageBox.Show("About", "About");
        }

        private void display()
        {
            Connection loaddata1 = new Connection();
            loaddata1.retrieveData("Select * From Items");
            storeItemsDataGridView.DataSource = loaddata1.table;


            Connection loaddata2 = new Connection();
            loaddata2.retrieveData("Select * From Vendor");
            vendorDataGridView.DataSource = loaddata2.table;
            vendorDataGridView.RowHeadersVisible = false;
            vendorDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            shoppingCartDataGridView.ColumnCount = 4;
            shoppingCartDataGridView.Columns[0].Name = "Title";
            shoppingCartDataGridView.Columns[1].Name = "ID";
            shoppingCartDataGridView.Columns[2].Name = "Description";
            shoppingCartDataGridView.Columns[3].Name = "Price";

            storeItemsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            storeItemsDataGridView.RowHeadersVisible = false;
            shoppingCartDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            shoppingCartDataGridView.RowHeadersVisible = false;
            DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            dataGridViewCheckBoxColumn.Name = "Select";
            dataGridViewCheckBoxColumn.HeaderText = "Select";
            dataGridViewCheckBoxColumn.ReadOnly = false;
            shoppingCartDataGridView.Columns.Add(dataGridViewCheckBoxColumn);
            shoppingCartDataGridView.Columns["Select"].DisplayIndex = 0;
            shoppingCartDataGridView.Columns["ID"].DisplayIndex = 1;
            shoppingCartDataGridView.Columns["Title"].DisplayIndex = 2;
            shoppingCartDataGridView.Columns["Description"].DisplayIndex = 3;



        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in storeItemsDataGridView.SelectedRows)
            {
                object[] rowData = new object[row.Cells.Count];
                for (int i = 0; i < rowData.Length; ++i)
                {
                    rowData[i] = row.Cells[i].Value;
                }
                this.shoppingCartDataGridView.Rows.Add(rowData);
            }
        }

        private void makePurchase_Click(object sender, EventArgs e)
        {
            try
            {
                Connection loaddata9 = new Connection();
                loaddata9.commandExc("Insert Into Vendor Values('" + firstNameTextBox.Text + "','" + lastNameTextBox.Text + "'," + phoneTextBox.Text + "," + sumTextBox.Text + ")");
                refresh();
                storeProfitSetValue();
            }
            catch
            {
                MessageBox.Show("error");
            }

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Connection loaddata3 = new Connection();
            loaddata3.commandExc("Delete From Items Where id=" + storeItemsDataGridView.CurrentRow.Cells[0].Value.ToString());
            foreach (DataGridViewRow row in storeItemsDataGridView.Rows)
            {
                storeItemsDataGridView.Rows.RemoveAt(row.Index);
            }
            refresh();
        }

        private void addItemsButton_Click(object sender, EventArgs e)
        {
            addItems frm = new addItems();
            frm.ShowDialog();
            refresh();

        }

        private void addPeopleButton_Click(object sender, EventArgs e)
        {
            addPeople frm = new addPeople();
            frm.ShowDialog();
        }

        private void ConsignmentShop_Load(object sender, EventArgs e)
        {

        }

        private void ConsignmentShop_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to exit from app", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void refresh2Button_Click(object sender, EventArgs e)
        {
            Connection loaddata4 = new Connection();
            loaddata4.retrieveData("Select * From Vendor");
            vendorDataGridView.DataSource = loaddata4.table;
        }

        private void CalcSum()
        {
            double sum = 0;
            for (int i = 0; i < shoppingCartDataGridView.Rows.Count; i++)
            {
                if (Convert.ToBoolean(shoppingCartDataGridView.Rows[i].Cells[4].Value) == true)
                {
                    sum += double.Parse(shoppingCartDataGridView.Rows[i].Cells[0].Value.ToString());

                }
            }

            sumTextBox.Text = sum.ToString();
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            CalcSum();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            if (vendorDataGridView.Rows.Count > 0)
            {
                SaveFileDialog dialog = new SaveFileDialog()
                {
                    Filter = "CSV (*.csv)|*.csv",
                    Title = "Csv Files",
                    RestoreDirectory = true
                };

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(dialog.FileName))
                    {
                        try
                        {
                            File.Delete(dialog.FileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    else
                    {
                        try
                        {
                            int colCount = vendorDataGridView.Columns.Count;
                            string colNames = string.Empty;
                            string[] outputCSV = new string[vendorDataGridView.Rows.Count + 1];
                            for (int i = 0; i < colCount; i++)
                            {
                                if (i == colCount - 1)
                                {
                                    colNames += vendorDataGridView.Columns[i].HeaderText.ToString();
                                }
                                else
                                {
                                    colNames += vendorDataGridView.Columns[i].HeaderText.ToString() + ",";
                                }
                            }
                            outputCSV[0] += colNames;

                            for (int i = 1; (i - 1) < vendorDataGridView.Rows.Count; i++)
                            {
                                for (int j = 0; j < colCount; j++)
                                {
                                    outputCSV[i] += vendorDataGridView.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }

                            File.WriteAllLines(dialog.FileName, outputCSV, Encoding.UTF8);
                            MessageBox.Show("Success");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }

                    }
                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Connection loaddata5 = new Connection();
            loaddata5.retrieveData("Select * From Items");
            storeItemsDataGridView.DataSource = loaddata5.table;
        }

        private void storeItemsDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem addItem = new ToolStripMenuItem("Add");
            ToolStripMenuItem editItem = new ToolStripMenuItem("Edit");
            ToolStripMenuItem removeItem = new ToolStripMenuItem("Remove");
            addItem.Click += new EventHandler(addItem_Click);
            editItem.Click += new EventHandler(editItem_Click);
            removeItem.Click += new EventHandler(removeItem_Click);
            menu.Items.AddRange(new ToolStripItem[] { addItem, editItem, removeItem });
            storeItemsDataGridView.ContextMenuStrip = menu;
            storeItemsDataGridView.AllowUserToAddRows = false;
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            addItems frm = new addItems();
            frm.ShowDialog();
        }

        private void editItem_Click(object sender, EventArgs e)
        {
            EditItems frm = new EditItems();
            frm.idTextBox.Text = storeItemsDataGridView.CurrentRow.Cells[0].Value.ToString();
            frm.TitleTextBox.Text = storeItemsDataGridView.CurrentRow.Cells[1].Value.ToString();
            frm.DescriptionTextBox.Text = storeItemsDataGridView.CurrentRow.Cells[2].Value.ToString();
            frm.PriceTextBox.Text = storeItemsDataGridView.CurrentRow.Cells[3].Value.ToString();
            frm.ShowDialog();
            refresh();
        }

        private void removeItem_Click(object sender, EventArgs e)
        {
            Connection loaddata6 = new Connection();
            loaddata6.commandExc("Delete From Items Where Price=" + storeItemsDataGridView.CurrentRow.Cells[2].Value.ToString() + "");
            foreach (DataGridViewRow row in storeItemsDataGridView.Rows)
            {
                storeItemsDataGridView.Rows.RemoveAt(row.Index);
            }
        }

        private void edit2Button_Click(object sender, EventArgs e)
        {
            EditVendor frm = new EditVendor();
            frm.idTextBox.Text = vendorDataGridView.CurrentRow.Cells[0].Value.ToString();
            frm.FirstNameTextBox.Text = vendorDataGridView.CurrentRow.Cells[1].Value.ToString();
            frm.LastNameTextBox.Text = vendorDataGridView.CurrentRow.Cells[2].Value.ToString();
            frm.PhoneTextBox.Text = vendorDataGridView.CurrentRow.Cells[3].Value.ToString();
            frm.sumTextBox.Text = vendorDataGridView.CurrentRow.Cells[4].Value.ToString();
            frm.ShowDialog();
            refresh();
        }

        private void remove2Button_Click(object sender, EventArgs e)
        {
            Connection loaddata7 = new Connection();
            loaddata7.commandExc("Delete From Vendor Where id = " + vendorDataGridView.CurrentRow.Cells[0].Value.ToString());

            foreach (DataGridViewRow row in vendorDataGridView.Rows)
            {
                vendorDataGridView.Rows.RemoveAt(row.Index);
            }
            refresh();

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditItems frm = new EditItems();
            frm.idTextBox.Text = storeItemsDataGridView.CurrentRow.Cells[0].Value.ToString();
            frm.TitleTextBox.Text = storeItemsDataGridView.CurrentRow.Cells[1].Value.ToString();
            frm.DescriptionTextBox.Text = storeItemsDataGridView.CurrentRow.Cells[2].Value.ToString();
            frm.PriceTextBox.Text = storeItemsDataGridView.CurrentRow.Cells[3].Value.ToString();
            frm.ShowDialog();
            refresh();

        }

        private void vendorDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem editItem = new ToolStripMenuItem("Edit");
            ToolStripMenuItem removeItem = new ToolStripMenuItem("Remove");
            editItem.Click += new EventHandler(editVendor_Click);
            removeItem.Click += new EventHandler(removeVendor_Click);
            menu.Items.AddRange(new ToolStripItem[] { editItem, removeItem });
            vendorDataGridView.ContextMenuStrip = menu;
            vendorDataGridView.AllowUserToAddRows = false;



        }


        private void editVendor_Click(object sender, EventArgs e)
        {
            EditVendor frm = new EditVendor();
            frm.idTextBox.Text = vendorDataGridView.CurrentRow.Cells[0].Value.ToString();
            frm.FirstNameTextBox.Text = vendorDataGridView.CurrentRow.Cells[1].Value.ToString();
            frm.LastNameTextBox.Text = vendorDataGridView.CurrentRow.Cells[2].Value.ToString();
            frm.PhoneTextBox.Text = vendorDataGridView.CurrentRow.Cells[3].Value.ToString();
            frm.sumTextBox.Text = vendorDataGridView.CurrentRow.Cells[4].Value.ToString();
            frm.ShowDialog();
            refresh();
        }

        private void removeVendor_Click(object sender, EventArgs e)
        {
            Connection loaddata8 = new Connection();
            loaddata8.commandExc("Delete From Vendor Where id=" + vendorDataGridView.CurrentRow.Cells[0].Value.ToString());

            foreach (DataGridViewRow row in vendorDataGridView.Rows)
            {
                vendorDataGridView.Rows.RemoveAt(row.Index);
            }
            refresh();
        }

        private void storeItemsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;

            DataGridViewCell cell = dataGridView[e.ColumnIndex, e.RowIndex];
            DataGridViewColumn col = dataGridView.Columns[e.ColumnIndex];
            DataGridViewRow row = dataGridView.Rows[e.RowIndex];
            int selectedRows_Count = dataGridView.SelectedRows.Count;

            if (e.Button == MouseButtons.Right)
            {

            }

            if (e.Button == MouseButtons.Left)
            {

            }



        }

    
    }

}

