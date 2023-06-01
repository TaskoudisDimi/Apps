using MQTTnet.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using MQTTnet;
using MQTTnet.Server;

namespace MQTTServer
{
    public partial class Form1 : Form
    {
        private IMqttServer server;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void publishButton_Click(object sender, EventArgs e)
        {
            string message = statusTextBox.Text;

            var mqttMessage = new MqttApplicationMessageBuilder()
                .WithTopic("topic2")
                .WithPayload(message)
                .WithQualityOfServiceLevel(MQTTnet.Protocol.MqttQualityOfServiceLevel.AtLeastOnce)
                .WithRetainFlag(false)
                .Build();

            server.PublishAsync(mqttMessage).GetAwaiter().GetResult();
            statusTextBox.Clear();
        }

        private void startButton_Click(object sender, EventArgs ev)
        {
            var options = new MqttServerOptionsBuilder().WithDefaultEndpoint().WithDefaultEndpointPort(1883).Build();

            server = new MqttFactory().CreateMqttServer();
            server.StartAsync(options).GetAwaiter().GetResult();

            server.UseApplicationMessageReceivedHandler(e =>
            {
                string message = Encoding.UTF8.GetString(e.ApplicationMessage.Payload);
                Invoke(new Action(() => statusTextBox.AppendText(message + Environment.NewLine)));
            });

            server.SubscribeAsync("topic2", null, MQTTnet.Protocol.MqttQualityOfServiceLevel.AtLeastOnce).GetAwaiter().GetResult();


        }
    }
}
