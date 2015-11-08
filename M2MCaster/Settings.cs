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

            Box_ServerAddress.Text = server;
            Box_ServerPort.Text = port;
            Box_Username.Text = username;
            Box_Password.Text = password;
        }

        private void Bttn_Save_Click(object sender, EventArgs e)
        {
            AppSettings.Default.server = Box_ServerAddress.Text;
            AppSettings.Default.port = Box_ServerPort.Text;
            AppSettings.Default.username = Box_Username.Text;
            AppSettings.Default.password = Box_Password.Text;
            AppSettings.Default.Save();
        }
    }
}
