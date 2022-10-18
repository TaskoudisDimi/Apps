using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSMap
{
    public partial class GMap : Form
    {
        GMapControl map = new GMapControl();
        public GMap()
        {
            InitializeComponent();

            //GMapControl map = new GMapControl();

            this.Controls.Add(map);
            map.Dock = DockStyle.Fill;
            map.MapProvider = GoogleMapProvider.Instance;
            panel1.Controls.Add(map);
            map.Position = new PointLatLng(54.6961334816182, 25.2985095977783);
            map.MinZoom = 0;
            map.MaxZoom = 24;
            map.Zoom = 9;

           

        }
        private async void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string test = textBox1.Text;
            string url = "https://maps.googleapis.com/maps/api/geocode/json?address={0}&key=AIzaSyDY6zcNwFxO2KSWvn4U1FMYlagBomOEpNw";
            var response = await client.GetAsync(string.Format(url, test));
            string result = await response.Content.ReadAsStringAsync();
            Root root = JsonConvert.DeserializeObject<Root>(result);
            Northeast coor = new Northeast();
            foreach (var item in root.results)
            {
                coor.lat = item.geometry.location.lat;
                coor.lng = item.geometry.location.lng;

            }
            map.Position = new PointLatLng(coor.lat, coor.lng);
        }


        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class AddressComponent
        {
            public string long_name { get; set; }
            public string short_name { get; set; }
            public List<string> types { get; set; }
        }

        public class Bounds
        {
            public Northeast northeast { get; set; }
            public Southwest southwest { get; set; }
        }

        public class Geometry
        {
            public Bounds bounds { get; set; }
            public Location location { get; set; }
            public string location_type { get; set; }
            public Viewport viewport { get; set; }
        }

        public class Location
        {
            public double lat { get; set; }
            public double lng { get; set; }
        }

        public class Northeast
        {
            public double lat { get; set; }
            public double lng { get; set; }
        }

        public class Result
        {
            public List<AddressComponent> address_components { get; set; }
            public string formatted_address { get; set; }
            public Geometry geometry { get; set; }
            public string place_id { get; set; }
            public List<string> types { get; set; }
        }

        public class Root
        {
            public List<Result> results { get; set; }
            public string status { get; set; }
        }

        public class Southwest
        {
            public double lat { get; set; }
            public double lng { get; set; }
        }

        public class Viewport
        {
            public Northeast northeast { get; set; }
            public Southwest southwest { get; set; }
        }

        
    }
}
