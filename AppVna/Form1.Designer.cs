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
            this.Control = new System.Windows.Forms.GroupBox();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.Measurement = new System.Windows.Forms.GroupBox();
<<<<<<< Updated upstream:AppVna/Form1.Designer.cs
=======
<<<<<<< Updated upstream:AppVna/.Designer.cs
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
>>>>>>> Stashed changes:AppVna/.Designer.cs
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
<<<<<<< Updated upstream:AppVna/Form1.Designer.cs
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
=======
=======
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
>>>>>>> Stashed changes:AppVna/Form1.Designer.cs
>>>>>>> Stashed changes:AppVna/.Designer.cs
            this.Control.SuspendLayout();
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
            this.Write.Location = new System.Drawing.Point(107, 296);
            this.Write.Name = "Write";
            this.Write.Size = new System.Drawing.Size(75, 23);
            this.Write.TabIndex = 10;
            this.Write.Text = "Cài đặt";
            this.Write.UseVisualStyleBackColor = true;
            this.Write.Click += new System.EventHandler(this.Write_Click);
            // 
            // Control
            // 
            this.Control.Controls.Add(this.progressBar3);
            this.Control.Controls.Add(this.label10);
            this.Control.Controls.Add(this.textBox9);
            this.Control.Controls.Add(this.label9);
            this.Control.Controls.Add(this.textBox8);
            this.Control.Controls.Add(this.Write);
            this.Control.Controls.Add(this.label8);
            this.Control.Controls.Add(this.textBox7);
            this.Control.Location = new System.Drawing.Point(532, 73);
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(493, 443);
            this.Control.TabIndex = 13;
            this.Control.TabStop = false;
            this.Control.Text = "Van";
            // 
            // Measurement
            // 
            this.Measurement.Controls.Add(this.progressBar2);
            this.Measurement.Controls.Add(this.label4);
            this.Measurement.Controls.Add(this.textBox3);
            this.Measurement.Controls.Add(this.label3);
            this.Measurement.Controls.Add(this.textBox2);
            this.Measurement.Controls.Add(this.label2);
            this.Measurement.Controls.Add(this.textBox1);
            this.Measurement.Controls.Add(this.button1);
            this.Measurement.Location = new System.Drawing.Point(12, 73);
            this.Measurement.Name = "Measurement";
            this.Measurement.Size = new System.Drawing.Size(501, 443);
            this.Measurement.TabIndex = 15;
            this.Measurement.TabStop = false;
            this.Measurement.Text = "Motor";
            // 
            // button1
            // 
<<<<<<< Updated upstream:AppVna/Form1.Designer.cs
=======
            this.button1.Location = new System.Drawing.Point(81, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cài đặt";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 219);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 16;
            // 
<<<<<<< Updated upstream:AppVna/.Designer.cs
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
>>>>>>> Stashed changes:AppVna/.Designer.cs
            // label5
=======
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tốc độ (vòng/phút): ";
>>>>>>> Stashed changes:AppVna/Form1.Designer.cs
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Độ ẩm (%):";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(163, 120);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 20);
            this.textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(163, 58);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(184, 20);
            this.textBox3.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 58);
            this.label4.Name = "label4";
<<<<<<< Updated upstream:AppVna/Form1.Designer.cs
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
=======
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nhiệt độ (°C): ";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(188, 222);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(184, 20);
            this.textBox7.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tốc độ (vòng/phút): ";
            // 
<<<<<<< Updated upstream:AppVna/.Designer.cs
=======
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(189, 123);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(184, 20);
            this.textBox8.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Độ ẩm (%):";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(189, 61);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(184, 20);
            this.textBox9.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Nhiệt độ (°C): ";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(254, 296);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(93, 23);
            this.progressBar2.TabIndex = 16;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(279, 296);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(93, 23);
            this.progressBar3.TabIndex = 19;
            // 
>>>>>>> Stashed changes:AppVna/Form1.Designer.cs
>>>>>>> Stashed changes:AppVna/.Designer.cs
            // ComName
            // 
            this.ClientSize = new System.Drawing.Size(1037, 587);
            this.Controls.Add(this.Measurement);
            this.Controls.Add(this.Control);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btConnect);
            this.Name = "ComName";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Control.ResumeLayout(false);
            this.Control.PerformLayout();
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
        private System.Windows.Forms.GroupBox Control;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.GroupBox Measurement;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar2;
    }
}

