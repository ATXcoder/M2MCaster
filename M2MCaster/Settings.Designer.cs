namespace M2MCaster
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bttn_Save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tab_MQTT = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.Box_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Box_Username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Box_ServerPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Box_ServerAddress = new System.Windows.Forms.TextBox();
            this.Tab_Plugin = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.Box_Plugin_Path = new System.Windows.Forms.TextBox();
            this.BTN_PluginBrowse = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.Tab_MQTT.SuspendLayout();
            this.Tab_Plugin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Bttn_Save
            // 
            this.Bttn_Save.Location = new System.Drawing.Point(295, 337);
            this.Bttn_Save.Name = "Bttn_Save";
            this.Bttn_Save.Size = new System.Drawing.Size(110, 33);
            this.Bttn_Save.TabIndex = 22;
            this.Bttn_Save.Text = "Save";
            this.Bttn_Save.UseVisualStyleBackColor = true;
            this.Bttn_Save.Click += new System.EventHandler(this.Bttn_Save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Enter the settings for connecting to your MQTT Broker below.";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tab_MQTT);
            this.tabControl1.Controls.Add(this.Tab_Plugin);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(692, 311);
            this.tabControl1.TabIndex = 28;
            // 
            // Tab_MQTT
            // 
            this.Tab_MQTT.Controls.Add(this.label4);
            this.Tab_MQTT.Controls.Add(this.label5);
            this.Tab_MQTT.Controls.Add(this.Box_Password);
            this.Tab_MQTT.Controls.Add(this.label3);
            this.Tab_MQTT.Controls.Add(this.Box_Username);
            this.Tab_MQTT.Controls.Add(this.label2);
            this.Tab_MQTT.Controls.Add(this.Box_ServerPort);
            this.Tab_MQTT.Controls.Add(this.label1);
            this.Tab_MQTT.Controls.Add(this.Box_ServerAddress);
            this.Tab_MQTT.Location = new System.Drawing.Point(4, 22);
            this.Tab_MQTT.Name = "Tab_MQTT";
            this.Tab_MQTT.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_MQTT.Size = new System.Drawing.Size(684, 285);
            this.Tab_MQTT.TabIndex = 0;
            this.Tab_MQTT.Text = "MQTT Broker";
            this.Tab_MQTT.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Password";
            // 
            // Box_Password
            // 
            this.Box_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Password.Location = new System.Drawing.Point(117, 163);
            this.Box_Password.Name = "Box_Password";
            this.Box_Password.PasswordChar = '*';
            this.Box_Password.Size = new System.Drawing.Size(178, 22);
            this.Box_Password.TabIndex = 33;
            this.Box_Password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Username";
            // 
            // Box_Username
            // 
            this.Box_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Username.Location = new System.Drawing.Point(117, 135);
            this.Box_Username.Name = "Box_Username";
            this.Box_Username.Size = new System.Drawing.Size(178, 22);
            this.Box_Username.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Server Port";
            // 
            // Box_ServerPort
            // 
            this.Box_ServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_ServerPort.Location = new System.Drawing.Point(117, 60);
            this.Box_ServerPort.Name = "Box_ServerPort";
            this.Box_ServerPort.Size = new System.Drawing.Size(89, 22);
            this.Box_ServerPort.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Server Address";
            // 
            // Box_ServerAddress
            // 
            this.Box_ServerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_ServerAddress.Location = new System.Drawing.Point(117, 32);
            this.Box_ServerAddress.Name = "Box_ServerAddress";
            this.Box_ServerAddress.Size = new System.Drawing.Size(272, 22);
            this.Box_ServerAddress.TabIndex = 27;
            // 
            // Tab_Plugin
            // 
            this.Tab_Plugin.Controls.Add(this.dataGridView1);
            this.Tab_Plugin.Controls.Add(this.label6);
            this.Tab_Plugin.Controls.Add(this.Box_Plugin_Path);
            this.Tab_Plugin.Controls.Add(this.BTN_PluginBrowse);
            this.Tab_Plugin.Location = new System.Drawing.Point(4, 22);
            this.Tab_Plugin.Name = "Tab_Plugin";
            this.Tab_Plugin.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Plugin.Size = new System.Drawing.Size(684, 285);
            this.Tab_Plugin.TabIndex = 1;
            this.Tab_Plugin.Text = "Plugins";
            this.Tab_Plugin.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Plugin Folder";
            // 
            // Box_Plugin_Path
            // 
            this.Box_Plugin_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Plugin_Path.Location = new System.Drawing.Point(102, 29);
            this.Box_Plugin_Path.Name = "Box_Plugin_Path";
            this.Box_Plugin_Path.Size = new System.Drawing.Size(495, 22);
            this.Box_Plugin_Path.TabIndex = 1;
            // 
            // BTN_PluginBrowse
            // 
            this.BTN_PluginBrowse.Location = new System.Drawing.Point(603, 29);
            this.BTN_PluginBrowse.Name = "BTN_PluginBrowse";
            this.BTN_PluginBrowse.Size = new System.Drawing.Size(75, 23);
            this.BTN_PluginBrowse.TabIndex = 0;
            this.BTN_PluginBrowse.Text = "Browse";
            this.BTN_PluginBrowse.UseVisualStyleBackColor = true;
            this.BTN_PluginBrowse.Click += new System.EventHandler(this.BTN_PluginBrowse_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 208);
            this.dataGridView1.TabIndex = 3;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 382);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Bttn_Save);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tabControl1.ResumeLayout(false);
            this.Tab_MQTT.ResumeLayout(false);
            this.Tab_MQTT.PerformLayout();
            this.Tab_Plugin.ResumeLayout(false);
            this.Tab_Plugin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bttn_Save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tab_MQTT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Box_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Box_Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Box_ServerPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Box_ServerAddress;
        private System.Windows.Forms.TabPage Tab_Plugin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Box_Plugin_Path;
        private System.Windows.Forms.Button BTN_PluginBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}