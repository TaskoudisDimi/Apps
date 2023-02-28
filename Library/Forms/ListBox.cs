
using Lesson1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Library
{
    public partial class ListBox : Form
    {

        private List<Books> BuyBooks = new List<Books>();

        BindingSource bindingBooks = new BindingSource();

        BindingSource bindingbuyBooks = new BindingSource();

        Store store = new Store();


        //private double InitAmount = 100;
        //private decimal afterBuyAmount;



        public ListBox()
        {
            InitializeComponent();
            DateTimePicker date = new DateTimePicker();
            Label label_date = new Label();

            SetData();

            //Form1 form = new Form1();
            //form.StartPosition = FormStartPosition.CenterScreen;

            bookListBox.ValueMember = "Display";
            bookListBox.DisplayMember = "Display";

            bindingBooks.DataSource = store.books.Where(x => x.AgeBook > 200);
            bookListBox.DataSource = bindingBooks;

            BuyBooksListBox.DisplayMember = "Display";
            BuyBooksListBox.ValueMember = "Display";

            bindingbuyBooks.DataSource = BuyBooks;
            BuyBooksListBox.DataSource = bindingbuyBooks;

            StringBuilder sb = new StringBuilder();
            sb.Append("Test of String Builder");
            stringBuilderLabel.Text = sb.ToString();
            
        }


        public void SetData()
        {
            store.books.Add(new Books { TitleBook = "Test1", AgeBook = 200, Price = 20.90 });
            store.books.Add(new Books { TitleBook = "Test2", AgeBook = 201, Price = 29.90 });
            store.books.Add(new Books { TitleBook = "Test3", AgeBook = 180, Price = 30.90 });
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {

            Books selectedBook = (Books)bookListBox.SelectedItem;
            bindingbuyBooks.Add(selectedBook);
            //BuyBooks.Add(selectedBook);

            foreach (Books book in BuyBooks)
            {
                book.Sold = true;

                //if (book.Price > InitAmount)
                //{
                //    MessageBox.Show("Den ftanoun ta lefta!");

                //}
                //else
                //{
                //    InitAmount = InitAmount - book.Price;
                //    MessageBox.Show("To agorases!");
                //}

                //InitAmount += book.Price;

                //label.Text = String.Format("{0}", InitAmount);
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bookListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void formButton_Click(object sender, EventArgs e)
        {
            Datagridview_Events form = new Datagridview_Events();
            form.Show();
            this.Hide();


        }

        private void form3Button_Click(object sender, EventArgs e)
        {
            Datagridview_Event form = new Datagridview_Event();
            form.Show();
            this.Hide();
        }

        private void form4Button_Click(object sender, EventArgs e)
        {
            Select_Copy_Datagridview form = new Select_Copy_Datagridview();
            form.Show();
            this.Hide();
        }


        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime chosenDate = dateTimePicker.Value;

            int day = chosenDate.Day;
            int month = chosenDate.Month;
            int year = chosenDate.Year;

            dayLabel.Text = "Day: " + day;
            monthLabel.Text = "Month: " + month;
            yearLabel.Text = "Year: " + year;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}