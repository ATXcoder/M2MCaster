using Plugin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;


namespace M2MCaster
{
    public partial class Form1 : Form
    {
        public Dictionary<string, IPlugin> _Plugins;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_MQTT_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load plugins
            string pluginPath = "path_to_plugin_folder";

            PlugInLoader<IPlugin> loader = new PlugInLoader<IPlugin>(pluginPath);

            _Plugins = new Dictionary<string, IPlugin>();

            IEnumerable<IPlugin> plugins = loader.Plugins;

            foreach(var plugin in plugins)
            {
                _Plugins.Add(plugin.Name, plugin);
            }
        }

        private void ConnectToMQTT()
        {
            string serverAddress = AppSettings.Default.server;
            int port = Convert.ToInt32(AppSettings.Default.port);

            // Connect to MQTT Broker
            MqttClient client = new MqttClient(IPAddress.Parse(serverAddress), port, false, null, MqttSslProtocols.None);

            // register to message received 
            client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

            string clientId = Guid.NewGuid().ToString();
            client.Connect(clientId);

            // subscribe to all topics with QoS 2 
            client.Subscribe(new string[] { "#" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
        }


        private void client_MqttMsgPublishReceived(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
            string msg = System.Text.Encoding.UTF8.GetString(e.Message);
            string topic = e.Topic;

            //Notify the plugins
            foreach (var item in _Plugins)
            {
                IPlugin plug = _Plugins[item.Key];
                plug.Message(topic, msg);
                
            }
        }

    }
}
