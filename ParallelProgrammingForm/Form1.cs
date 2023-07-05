using System.Net;

namespace ParallelProgrammingForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void calculateButton_Click(object sender, EventArgs e)
        {
            //var calculation = calculateValueAsync();
            //calculation.ContinueWith(t =>
            //{
            //    label1.Text = t.Result.ToString();

            //}, TaskScheduler.FromCurrentSynchronizationContext());
            int value = await calculateValueAsync();
            label1.Text = value.ToString();

            await Task.Delay(5000);
            using(var client = new WebClient())
            {
                string data = await client.DownloadStringTaskAsync("http://google.com/robots.txt");
                label1.Text = data.Split('\n')[0].Trim();
            }



        }

        public async Task<int> calculateValueAsync()
        {
            //return Task.Factory.StartNew(() =>
            //{
            //    Thread.Sleep(3000);
            //    return 123;
            //});
            await Task.Delay(5000);
            return 123;
        }
    }
}