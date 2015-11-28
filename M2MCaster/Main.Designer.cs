namespace M2MCaster
{
    partial class Main
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
            this.Btn_MQTT = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Btn_MQTT
            // 
            this.Btn_MQTT.Location = new System.Drawing.Point(26, 33);
            this.Btn_MQTT.Name = "Btn_MQTT";
            this.Btn_MQTT.Size = new System.Drawing.Size(180, 45);
            this.Btn_MQTT.TabIndex = 0;
            this.Btn_MQTT.Text = "MQTT Settings";
            this.Btn_MQTT.UseVisualStyleBackColor = true;
            this.Btn_MQTT.Click += new System.EventHandler(this.Btn_MQTT_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 343);
            this.Controls.Add(this.Btn_MQTT);
            this.Name = "Form1";
            this.Text = "M2MCaster";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_MQTT;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;

    }
}

