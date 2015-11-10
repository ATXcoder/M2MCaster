using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2MCaster
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            // Load setting from settings file (if any)
            string server = AppSettings.Default.server;
            string port = AppSettings.Default.port;
            string username = AppSettings.Default.username;
            string password = AppSettings.Default.password;
            string pluginFolder = AppSettings.Default.plugins;

            Box_ServerAddress.Text = server;
            Box_ServerPort.Text = port;
            Box_Username.Text = username;
            Box_Password.Text = password;
            Box_Plugin_Path.Text = pluginFolder;

            
        }

        private void Bttn_Save_Click(object sender, EventArgs e)
        {
            // MQTT Settings
            AppSettings.Default.server = Box_ServerAddress.Text;
            AppSettings.Default.port = Box_ServerPort.Text;
            AppSettings.Default.username = Box_Username.Text;
            AppSettings.Default.password = Box_Password.Text;

            // Plugin Settings
            AppSettings.Default.plugins = Box_Plugin_Path.Text;

            // Save settings
            AppSettings.Default.Save();
        }

        private void BTN_PluginBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            Box_Plugin_Path.Text = folderBrowserDialog1.SelectedPath.ToString();
        }
    }
}
