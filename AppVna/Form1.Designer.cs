namespace AppVna
{
    partial class ComName
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
            this.components = new System.ComponentModel.Container();
            this.btConnect = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Write = new System.Windows.Forms.Button();
            this.Test = new System.Windows.Forms.Button();
            this.slave_address = new System.Windows.Forms.TextBox();
            this.Control = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.Measurement = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.Measurement.SuspendLayout();
            this.SuspendLayout();
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(93, 12);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(75, 26);
            this.btConnect.TabIndex = 3;
            this.btConnect.Text = "Kết nối";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(938, 12);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(87, 26);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "COM9"});
            this.comboBox1.Location = new System.Drawing.Point(12, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(175, 14);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(757, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Write
            // 
            this.Write.Location = new System.Drawing.Point(53, 320);
            this.Write.Name = "Write";
            this.Write.Size = new System.Drawing.Size(75, 23);
            this.Write.TabIndex = 10;
            this.Write.Text = "Write";
            this.Write.UseVisualStyleBackColor = true;
            this.Write.Click += new System.EventHandler(this.Write_Click);
            // 
            // Test
            // 
            this.Test.Location = new System.Drawing.Point(874, 552);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(75, 23);
            this.Test.TabIndex = 11;
            this.Test.Text = "Test";
            this.Test.UseVisualStyleBackColor = true;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // slave_address
            // 
            this.slave_address.Location = new System.Drawing.Point(176, 51);
            this.slave_address.Multiline = true;
            this.slave_address.Name = "slave_address";
            this.slave_address.Size = new System.Drawing.Size(184, 20);
            this.slave_address.TabIndex = 12;
            // 
            // Control
            // 
            this.Control.Controls.Add(this.label3);
            this.Control.Controls.Add(this.label2);
            this.Control.Controls.Add(this.label1);
            this.Control.Controls.Add(this.numericUpDown2);
            this.Control.Controls.Add(this.numericUpDown1);
            this.Control.Controls.Add(this.slave_address);
            this.Control.Controls.Add(this.Write);
            this.Control.Location = new System.Drawing.Point(12, 75);
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(404, 378);
            this.Control.TabIndex = 13;
            this.Control.TabStop = false;
            this.Control.Text = "Control";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tốc độ quay Motor: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Độ mở van:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Địa chỉ Slave:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown2.Location = new System.Drawing.Point(176, 213);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(184, 22);
            this.numericUpDown2.TabIndex = 14;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown1.Location = new System.Drawing.Point(176, 134);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(184, 22);
            this.numericUpDown1.TabIndex = 13;
            // 
            // Measurement
            // 
            this.Measurement.Controls.Add(this.label7);
            this.Measurement.Controls.Add(this.textBox4);
            this.Measurement.Controls.Add(this.label6);
            this.Measurement.Controls.Add(this.textBox3);
            this.Measurement.Controls.Add(this.label5);
            this.Measurement.Controls.Add(this.textBox2);
            this.Measurement.Controls.Add(this.label4);
            this.Measurement.Controls.Add(this.textBox1);
            this.Measurement.Controls.Add(this.button1);
            this.Measurement.Location = new System.Drawing.Point(445, 75);
            this.Measurement.Name = "Measurement";
            this.Measurement.Size = new System.Drawing.Size(404, 378);
            this.Measurement.TabIndex = 15;
            this.Measurement.TabStop = false;
            this.Measurement.Text = "Measurement";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Trạng thái Slave:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(197, 103);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 23);
            this.textBox2.TabIndex = 19;
            this.textBox2.Text = "Slave Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Địa chỉ Slave:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 48);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 23);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Slave Address";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Nhiệt độ:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(196, 163);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(184, 23);
            this.textBox3.TabIndex = 21;
            this.textBox3.Text = "Nhiệt độ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Độ ẩm:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(196, 215);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(184, 23);
            this.textBox4.TabIndex = 23;
            this.textBox4.Text = "Slave Address";
            // 
            // ComName
            // 
            this.ClientSize = new System.Drawing.Size(1037, 587);
            this.Controls.Add(this.Measurement);
            this.Controls.Add(this.Control);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btConnect);
            this.Name = "ComName";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Control.ResumeLayout(false);
            this.Control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.Measurement.ResumeLayout(false);
            this.Measurement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button Write;
        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.TextBox slave_address;
        private System.Windows.Forms.GroupBox Control;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.GroupBox Measurement;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
    }
}

