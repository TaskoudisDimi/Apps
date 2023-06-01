using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;
using System.Text;
using System.Windows.Forms;

namespace MQTTClient
{
    public partial class Form1 : Form
    {
        private IMqttClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            client = new MqttFactory().CreateMqttClient();

            var options = new MqttClientOptionsBuilder()
                .WithTcpServer("localhost") // Replace with your MQTT broker IP or hostname
                .WithClientId("client1") // Set a client ID
                .Build();

            client.ConnectAsync(options).GetAwaiter().GetResult();

            client.UseApplicationMessageReceivedHandler(e =>
            {
                string message = Encoding.UTF8.GetString(e.ApplicationMessage.Payload);
                Invoke(new Action(() => messageTextBox.AppendText(message + Environment.NewLine)));
            });

            client.SubscribeAsync("topic1", MQTTnet.Protocol.MqttQualityOfServiceLevel.AtLeastOnce).GetAwaiter().GetResult();
        }

        private void publishButton_Click(object sender, EventArgs e)
        {
            client = new MqttFactory().CreateMqttClient();

            var options = new MqttClientOptionsBuilder()
                .WithTcpServer("localhost") // Replace with your MQTT broker IP or hostname
                .WithClientId("client1") // Set a client ID
                .Build();

            client.ConnectAsync(options).GetAwaiter().GetResult();

            client.UseApplicationMessageReceivedHandler(e =>
            {
                string message = Encoding.UTF8.GetString(e.ApplicationMessage.Payload);
                Invoke(new Action(() => messageTextBox.AppendText(message + Environment.NewLine)));
            });

            client.SubscribeAsync("topic1", MQTTnet.Protocol.MqttQualityOfServiceLevel.AtLeastOnce).GetAwaiter().GetResult();
        }
    }
}