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
            this.Valve = new System.Windows.Forms.GroupBox();
            this.valve_control_updown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.valve_humid = new System.Windows.Forms.TextBox();
            this.valve_temp = new System.Windows.Forms.TextBox();
            this.valve_progress = new System.Windows.Forms.ProgressBar();
            this.bt_setup_valve = new System.Windows.Forms.Button();
            this.Servo = new System.Windows.Forms.GroupBox();
            this.rotate_mode = new System.Windows.Forms.Label();
            this.servo_control_updown = new System.Windows.Forms.NumericUpDown();
            this.servo_progress = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_setup_servo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.servo_temp = new System.Windows.Forms.TextBox();
            this.servo_humid = new System.Windows.Forms.TextBox();
            this.rotate_mode_list = new System.Windows.Forms.ComboBox();
            this.Valve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valve_control_updown)).BeginInit();
            this.Servo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servo_control_updown)).BeginInit();
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
            this.btExit.Location = new System.Drawing.Point(730, 14);
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
            this.progressBar1.Size = new System.Drawing.Size(549, 23);
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
            // Valve
            // 
            this.Valve.Controls.Add(this.valve_control_updown);
            this.Valve.Controls.Add(this.label3);
            this.Valve.Controls.Add(this.label2);
            this.Valve.Controls.Add(this.label1);
            this.Valve.Controls.Add(this.valve_humid);
            this.Valve.Controls.Add(this.valve_temp);
            this.Valve.Controls.Add(this.valve_progress);
            this.Valve.Controls.Add(this.bt_setup_valve);
            this.Valve.Location = new System.Drawing.Point(12, 67);
            this.Valve.Name = "Valve";
            this.Valve.Size = new System.Drawing.Size(386, 294);
            this.Valve.TabIndex = 12;
            this.Valve.TabStop = false;
            this.Valve.Text = "Van";
            // 
            // valve_control_updown
            // 
            this.valve_control_updown.Location = new System.Drawing.Point(184, 57);
            this.valve_control_updown.Name = "valve_control_updown";
            this.valve_control_updown.Size = new System.Drawing.Size(130, 22);
            this.valve_control_updown.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Độ ẩm (%):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nhiệt độ (°C):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Độ mở van (%):";
            // 
            // valve_humid
            // 
            this.valve_humid.Location = new System.Drawing.Point(184, 176);
            this.valve_humid.Name = "valve_humid";
            this.valve_humid.Size = new System.Drawing.Size(130, 22);
            this.valve_humid.TabIndex = 4;
            // 
            // valve_temp
            // 
            this.valve_temp.Location = new System.Drawing.Point(184, 116);
            this.valve_temp.Name = "valve_temp";
            this.valve_temp.Size = new System.Drawing.Size(130, 22);
            this.valve_temp.TabIndex = 3;
            // 
            // valve_progress
            // 
            this.valve_progress.Location = new System.Drawing.Point(184, 230);
            this.valve_progress.Name = "valve_progress";
            this.valve_progress.Size = new System.Drawing.Size(130, 23);
            this.valve_progress.TabIndex = 1;
            // 
            // bt_setup_valve
            // 
            this.bt_setup_valve.Location = new System.Drawing.Point(81, 230);
            this.bt_setup_valve.Name = "bt_setup_valve";
            this.bt_setup_valve.Size = new System.Drawing.Size(75, 23);
            this.bt_setup_valve.TabIndex = 0;
            this.bt_setup_valve.Text = "Cài đặt";
            this.bt_setup_valve.UseVisualStyleBackColor = true;
            this.bt_setup_valve.Click += new System.EventHandler(this.bt_setup_valve_Click);
            // 
            // Servo
            // 
            this.Servo.Controls.Add(this.rotate_mode_list);
            this.Servo.Controls.Add(this.rotate_mode);
            this.Servo.Controls.Add(this.servo_control_updown);
            this.Servo.Controls.Add(this.servo_progress);
            this.Servo.Controls.Add(this.label4);
            this.Servo.Controls.Add(this.bt_setup_servo);
            this.Servo.Controls.Add(this.label5);
            this.Servo.Controls.Add(this.label6);
            this.Servo.Controls.Add(this.servo_temp);
            this.Servo.Controls.Add(this.servo_humid);
            this.Servo.Location = new System.Drawing.Point(425, 67);
            this.Servo.Name = "Servo";
            this.Servo.Size = new System.Drawing.Size(392, 294);
            this.Servo.TabIndex = 0;
            this.Servo.TabStop = false;
            this.Servo.Text = "Động cơ 1 chiều";
            // 
            // rotate_mode
            // 
            this.rotate_mode.AutoSize = true;
            this.rotate_mode.Location = new System.Drawing.Point(64, 76);
            this.rotate_mode.Name = "rotate_mode";
            this.rotate_mode.Size = new System.Drawing.Size(92, 17);
            this.rotate_mode.TabIndex = 15;
            this.rotate_mode.Text = "Chế độ quay:";
            // 
            // servo_control_updown
            // 
            this.servo_control_updown.Location = new System.Drawing.Point(218, 29);
            this.servo_control_updown.Name = "servo_control_updown";
            this.servo_control_updown.Size = new System.Drawing.Size(130, 22);
            this.servo_control_updown.TabIndex = 14;
            // 
            // servo_progress
            // 
            this.servo_progress.Location = new System.Drawing.Point(218, 233);
            this.servo_progress.Name = "servo_progress";
            this.servo_progress.Size = new System.Drawing.Size(130, 23);
            this.servo_progress.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Độ ẩm (%):";
            // 
            // bt_setup_servo
            // 
            this.bt_setup_servo.Location = new System.Drawing.Point(83, 233);
            this.bt_setup_servo.Name = "bt_setup_servo";
            this.bt_setup_servo.Size = new System.Drawing.Size(75, 23);
            this.bt_setup_servo.TabIndex = 2;
            this.bt_setup_servo.Text = "Cài đặt";
            this.bt_setup_servo.UseVisualStyleBackColor = true;
            this.bt_setup_servo.Click += new System.EventHandler(this.bt_setup_servo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nhiệt độ (°C):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tốc độ (%):";
            // 
            // servo_temp
            // 
            this.servo_temp.Location = new System.Drawing.Point(218, 116);
            this.servo_temp.Name = "servo_temp";
            this.servo_temp.Size = new System.Drawing.Size(130, 22);
            this.servo_temp.TabIndex = 9;
            // 
            // servo_humid
            // 
            this.servo_humid.Location = new System.Drawing.Point(218, 176);
            this.servo_humid.Name = "servo_humid";
            this.servo_humid.Size = new System.Drawing.Size(130, 22);
            this.servo_humid.TabIndex = 10;
            // 
            // rotate_mode_list
            // 
            this.rotate_mode_list.FormattingEnabled = true;
            this.rotate_mode_list.Items.AddRange(new object[] {
            "Quay thuận",
            "Quay ngược"});
            this.rotate_mode_list.Location = new System.Drawing.Point(218, 69);
            this.rotate_mode_list.Name = "rotate_mode_list";
            this.rotate_mode_list.Size = new System.Drawing.Size(130, 24);
            this.rotate_mode_list.TabIndex = 16;
            this.rotate_mode_list.Text = "Chọn";
            // 
            // ComName
            // 
            this.ClientSize = new System.Drawing.Size(844, 409);
            this.Controls.Add(this.Servo);
            this.Controls.Add(this.Valve);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btConnect);
            this.Name = "ComName";
            this.Text = "KSCLC Tin Hoc Cong Nghiep K61";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Valve.ResumeLayout(false);
            this.Valve.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valve_control_updown)).EndInit();
            this.Servo.ResumeLayout(false);
            this.Servo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servo_control_updown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox Valve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valve_humid;
        private System.Windows.Forms.TextBox valve_temp;
        private System.Windows.Forms.ProgressBar valve_progress;
        private System.Windows.Forms.Button bt_setup_valve;
        private System.Windows.Forms.GroupBox Servo;
        private System.Windows.Forms.ProgressBar servo_progress;
        private System.Windows.Forms.Button bt_setup_servo;
        private System.Windows.Forms.NumericUpDown valve_control_updown;
        private System.Windows.Forms.NumericUpDown servo_control_updown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox servo_humid;
        private System.Windows.Forms.TextBox servo_temp;
        private System.Windows.Forms.Label rotate_mode;
        private System.Windows.Forms.ComboBox rotate_mode_list;
    }
}