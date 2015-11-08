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
            this.label4 = new System.Windows.Forms.Label();
            this.Box_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Box_Username = new System.Windows.Forms.TextBox();
            this.Bttn_Save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Box_ServerPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Box_ServerAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Password";
            // 
            // Box_Password
            // 
            this.Box_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Password.Location = new System.Drawing.Point(120, 172);
            this.Box_Password.Name = "Box_Password";
            this.Box_Password.PasswordChar = '*';
            this.Box_Password.Size = new System.Drawing.Size(178, 22);
            this.Box_Password.TabIndex = 25;
            this.Box_Password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Username";
            // 
            // Box_Username
            // 
            this.Box_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Username.Location = new System.Drawing.Point(120, 144);
            this.Box_Username.Name = "Box_Username";
            this.Box_Username.Size = new System.Drawing.Size(178, 22);
            this.Box_Username.TabIndex = 23;
            // 
            // Bttn_Save
            // 
            this.Bttn_Save.Location = new System.Drawing.Point(188, 236);
            this.Bttn_Save.Name = "Bttn_Save";
            this.Bttn_Save.Size = new System.Drawing.Size(110, 33);
            this.Bttn_Save.TabIndex = 22;
            this.Bttn_Save.Text = "Save";
            this.Bttn_Save.UseVisualStyleBackColor = true;
            this.Bttn_Save.Click += new System.EventHandler(this.Bttn_Save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Server Port";
            // 
            // Box_ServerPort
            // 
            this.Box_ServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_ServerPort.Location = new System.Drawing.Point(120, 69);
            this.Box_ServerPort.Name = "Box_ServerPort";
            this.Box_ServerPort.Size = new System.Drawing.Size(89, 22);
            this.Box_ServerPort.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Server Address";
            // 
            // Box_ServerAddress
            // 
            this.Box_ServerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_ServerAddress.Location = new System.Drawing.Point(120, 41);
            this.Box_ServerAddress.Name = "Box_ServerAddress";
            this.Box_ServerAddress.Size = new System.Drawing.Size(272, 22);
            this.Box_ServerAddress.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Enter the settings for connecting to your MQTT Broker below.";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 281);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Box_Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Box_Username);
            this.Controls.Add(this.Bttn_Save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Box_ServerPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Box_ServerAddress);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Box_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Box_Username;
        private System.Windows.Forms.Button Bttn_Save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Box_ServerPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Box_ServerAddress;
        private System.Windows.Forms.Label label5;
    }
}