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
using System.IO;


namespace M2MCaster
{
    public partial class Form1 : Form
    {
        public Dictionary<string, IPlugin> _Plugins;
        public MqttClient client;

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
            // Get the path to the plugins folder from settings
            string pluginPath = AppSettings.Default.plugins;

            // Check if path exist
            if (!Directory.Exists(pluginPath)) 
            {
                MessageBox.Show("Plugin folder not found. Please go to File > Settings > Plugins to browse for folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               
                

                backgroundWorker1.RunWorkerAsync(pluginPath);
            }
        }

        private void ConnectToMQTT()
        {
            string serverAddress = AppSettings.Default.server;
            int port = Convert.ToInt32(AppSettings.Default.port);

            client = new MqttClient(IPAddress.Parse(serverAddress), port, false, null, MqttSslProtocols.None);
            

            // register to message received 
            client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;


            client.Connect(Guid.NewGuid().ToString());
            

            // subscribe to all topics with QoS 2 
            client.Subscribe(new string[] { "#" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
        }


        private void client_MqttMsgPublishReceived(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
            string msg = System.Text.Encoding.UTF8.GetString(e.Message);
            string topic = e.Topic;
            string flag = e.DupFlag.ToString();

            //MessageBox.Show(msg);

            //Notify the plugins
            foreach (var item in _Plugins)
            {
                IPlugin plug = _Plugins[item.Key];
                plug.Message(topic, flag);
                
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            PlugInLoader<IPlugin> loader = new PlugInLoader<IPlugin>(e.Argument.ToString());

            _Plugins = new Dictionary<string, IPlugin>();

            IEnumerable<IPlugin> plugins = loader.Plugins;

            foreach (var plugin in plugins)
            {
                _Plugins.Add(plugin.Name, plugin);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ConnectToMQTT();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Disconnect();
            Console.WriteLine("Disconnecting");
        }

    }
}
