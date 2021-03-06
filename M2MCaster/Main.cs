﻿using Plugin;
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
//Log4Net
using log4net;
using log4net.Config;



namespace M2MCaster
{

    public partial class Main : Form
    {
        public Dictionary<string, IPlugin> _Plugins;
        public MqttClient client;

        // Define a static logger variable so that it references the
        // Logger instance named "Main".
        private static readonly ILog log = LogManager.GetLogger(typeof(Main));

        public Main()
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
            XmlConfigurator.Configure();
            log.Info("Starting M2MCaster");
            string bdir = AppDomain.CurrentDomain.BaseDirectory;
            MessageBox.Show(bdir);

            // Get the path to the plugins folder from settings
            string pluginPath = AppSettings.Default.plugins;

            // Check if path exist
            if (!Directory.Exists(pluginPath)) 
            {
                MessageBox.Show("Plugin folder not found. Please go to File > Settings > Plugins to browse for folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Debug("Plugin folder ( " + pluginPath + " ) not found");
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

            log.Info("Connecting to MQTT Broker at " + serverAddress + ":" + port);

            // register to message received 
            client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

            try
            {
                client.Connect(Guid.NewGuid().ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message,ex.Message);
                log.Error(ex.InnerException.Message + " - " + ex.Message);
            }

            // subscribe to all topics
            client.Subscribe(new string[] { "#" }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE});
        }


        private void client_MqttMsgPublishReceived(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
            string msg = System.Text.Encoding.UTF8.GetString(e.Message);
            string topic = e.Topic;
            string flag = e.DupFlag.ToString();

            log.Info("Message recieved on topic: " + topic);

            //Notify the plugins
            foreach (var item in _Plugins)
            {
                IPlugin plug = _Plugins[item.Key];
                plug.Message(topic, msg);
                
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            log.Info("Loading plugins");
            PlugInLoader<IPlugin> loader = new PlugInLoader<IPlugin>(e.Argument.ToString());

            _Plugins = new Dictionary<string, IPlugin>();

            IEnumerable<IPlugin> plugins = loader.Plugins;

            foreach (var plugin in plugins)
            {
                _Plugins.Add(plugin.Name, plugin);
                log.Info("Loaded plugin: " + plugin.Name);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ConnectToMQTT();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check to see if we are connected and disconnect if we are
            if (client.IsConnected)
            {
                client.Disconnect();
                log.Info("Disconnected from MQTT Broker");
            }
                
        }

    }
}
