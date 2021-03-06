﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;

// Giao tiếp qua Serial
using System.IO;
using System.IO.Ports;
using System.Xml;


namespace AppVna
{
    public partial class ComName : Form
    {
        // biến string để lấy dữ liệu từ Serial
        // input
        string slave_id = String.Empty; // slave address 
        string slave_status = String.Empty; // slave status: 0: not controlled, error; 1: control signal is sent and working 
        string temp_sensor = String.Empty; // temparature from sensor 
        string humid_sensor = String.Empty; // humidity from sensor

        int status = 0; // status nhận gửi data 
        // status  = 0: không đọc data từ serial
        // status = 1: đọc data từ serial
        double temp_slave1 = 0; //convert string thành số để hiển thị
        double humid_slave1 = 0;
        double temp_slave2 = 0;
        double humid_slave2 = 0;
        // output điều khiển hệ thống
        decimal rotate_speed = 0; //motor rotate rate (rps)
        decimal percent_open = 0;// % valve open



        public ComName()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = SerialPort.GetPortNames(); // Lấy nguồn cho comboBox là tên của cổng COM
            comboBox1.Text = Properties.Settings.Default.ComName; // Lấy ComName đã làm ở bước 5 cho comboBox

        }
        // Hàm Tick bắt sự kiện cổng Serial mở hay không
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                progressBar1.Value = 0;
            }
            else if (serialPort1.IsOpen)
            {
                progressBar1.Value = 100;
                status = 0;
            }
        }

        // Hàm này lưu lại cổng COM đã chọn cho lần kết nối
        private void SaveSetting()
        {
            Properties.Settings.Default.ComName = comboBox1.Text;
            Properties.Settings.Default.Save();
        }
        // Nhận và xử lý string gửi từ Serial
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
           // DialogResult test;
            try
            {
                string data = serialPort1.ReadLine(); // Đọc một dòng của Serial, cắt chuỗi khi gặp ký tự gạch đứng
                string[] received_data = data.Split('|');
                //test = MessageBox.Show(data);
                slave_id = received_data[0];
                temp_sensor = received_data[1];
                humid_sensor = received_data[2];

                if (slave_id == "1")
                {
                    double.TryParse(temp_sensor, out temp_slave1); // Chuyển đổi sang kiểu double
                    double.TryParse(humid_sensor, out humid_slave1);
                }
                else
                {
                    double.TryParse(temp_sensor, out temp_slave2); // Chuyển đổi sang kiểu double
                    double.TryParse(humid_sensor, out humid_slave2);
                }
                
            }
            catch
            {
                return;
            }
        }

        // Sự kiện nhấn nút btConnect
        private void btConnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                //serialPort1.WriteLine("2"); //Gửi ký tự "2" qua Serial, tương ứng với state = 2
                serialPort1.Close();
                btConnect.Text = "Kết nối";
                btExit.Enabled = true;
                SaveSetting(); // Lưu cổng COM vào ComName
            }
            else
            {
                try
                {
                    serialPort1.PortName = comboBox1.Text; // Lấy cổng COM
                    serialPort1.BaudRate = 9600; // Baudrate là 9600, trùng với baudrate của Arduino
                    serialPort1.Open();
                    btConnect.Text = "Ngắt kết nối";
                    btExit.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Không thể mở cổng " + serialPort1.PortName, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // Sự kiện nhấn nút btExit
        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn thoát?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (traloi == DialogResult.OK)
            {
                Application.Exit(); // Đóng ứng dụng
            }
        }

        private void bt_setup_valve_Click(object sender, EventArgs e)
        {
            // gửi tín hiệu điều khiển
            // DialogResult test;
            valve_progress.Value = 0;
            int valve_address = 2; // địa chỉ slave valve, điều khiển = servo, fix cứng
            string text;
            percent_open = valve_control_updown.Value;
            if (percent_open < 10) 
            {
                text = valve_address.ToString() + "00" + percent_open.ToString();
            }
            else if (percent_open < 100)
            {
                text = valve_address.ToString() + "0" + percent_open.ToString();
            }    
            else text = valve_address.ToString() + percent_open.ToString();
            if (serialPort1.IsOpen)
            {
                foreach (char ch in text)
                {
                    try
                    {
                        serialPort1.Write(ch.ToString());
                        System.Threading.Thread.Sleep(50);
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi trong quá trình truyền tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                valve_progress.Value = 100;
            }
            else
                MessageBox.Show("Kiểm tra lại kết nối", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            System.Threading.Thread.Sleep(2000);
            // test = MessageBox.Show(text);
            // hiển thị dữ liệu sensor
            status = 1;
            valve_humid.Text = humid_slave2.ToString();
            valve_temp.Text = temp_slave2.ToString();
        }

        private void bt_setup_servo_Click(object sender, EventArgs e)
        {
            servo_progress.Value = 0;
            // gửi tín hiệu điều khiển
           // DialogResult test;
            int servo_address = 1; // địa chỉ slave động cơ 1 chiều - motor, fix cứng
            string text;
            rotate_speed = servo_control_updown.Value;
            if (rotate_speed < 10)
            {
                text = servo_address.ToString() + "00" + rotate_speed.ToString();
            }
            else if (rotate_speed < 100)
            {
                text = servo_address.ToString() + "0" + rotate_speed.ToString();
            }
            else text = servo_address.ToString() + rotate_speed.ToString();
            if (rotate_mode_list.SelectedIndex == 0)
            {
                text = text + "0";
            }
            else if (rotate_mode_list.SelectedIndex == 1) {
                text = text + "1";
            }
            if (serialPort1.IsOpen)
            {
                foreach (char ch in text)
                {
                    try
                    {
                        serialPort1.Write(ch.ToString());
                        System.Threading.Thread.Sleep(50);
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi trong quá trình truyền tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                servo_progress.Value = 100;
            }
            else 
                MessageBox.Show("Kiểm tra lại kết nối", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // test = MessageBox.Show(text);
            System.Threading.Thread.Sleep(2000);
            // đọc dữ liệu cảm biến
            status = 1;
            servo_humid.Text = humid_slave1.ToString();
            servo_temp.Text = temp_slave1.ToString();
        }

    }
}