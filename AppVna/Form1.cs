using System;
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
        string Srl_db = String.Empty; 
        string Sphi_deg = String.Empty;
        string Srs = String.Empty;
        string Sxs = String.Empty;
        string Sswr = String.Empty;
        string Sz = String.Empty;
        string Sre = String.Empty;
        string Sim = String.Empty;


        int status = 0; // Khai báo biến để xử lý sự kiện vẽ đồ thị
        double rl_db = 0; //convert string thành số để vẽ đồ thị
        double phi_deg = 0;
        double rs = 0;
        double xs = 0;
        double swr = 0;
        double z = 0;
        double re = 0;// dùng để vẽ smith chart
        double im = 0;// dùng để vẽ smith chart


        ViewModel vm = new ViewModel(); //Khai báo ...

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
            try
            {
                string[] measure_result = serialPort1.ReadLine().Split('|'); // Đọc một dòng của Serial, cắt chuỗi khi gặp ký tự gạch đứng
                Srl_db = measure_result[2]; 
                Sphi_deg = measure_result[3];
                Srs = measure_result[4];
                Sxs = measure_result[5];
                Sre = measure_result[6];
                Sim = measure_result[7];
                Sswr = measure_result[8];
                Sz = measure_result[9];


                double.TryParse(Srl_db, out rl_db); // Chuyển đổi sang kiểu double
                double.TryParse(Sphi_deg, out phi_deg);
                double.TryParse(Srs, out rs);
                double.TryParse(Sxs, out xs);
                double.TryParse(Sre, out re);
                double.TryParse(Sim, out im);
                double.TryParse(Sswr, out swr);
                double.TryParse(Sz, out z);
                status = 1; // Bắt sự kiện xử lý xong chuỗi, đổi starus về 1 để hiển thị dữ liệu trong ListView và vẽ đồ thị
            }
            catch
            {
                return;
            }
        }



         
        // Hàm xóa dữ liệu
        private void ResetValue()
        {
            status = 0; // Chuyển status về 0
        }





        // Hàm lưu ListView sang Excel
        private void SaveToExcel()
        {
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            xla.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = xla.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)xla.ActiveSheet;

            // Đặt tên cho hai ô A1. B1 lần lượt là "Thời gian (s)" và "Dữ liệu", sau đó tự động dãn độ rộng
            Microsoft.Office.Interop.Excel.Range rg = (Microsoft.Office.Interop.Excel.Range)ws.get_Range("A1", "B1");
            ws.Cells[1, 1] = "Thời gian (s)";
            ws.Cells[1, 2] = "Dữ liệu";
            rg.Columns.AutoFit();

            // Lưu từ ô đầu tiên của dòng thứ 2, tức ô A2
            int i = 2;
            int j = 1;

            foreach (ListViewItem comp in listView1.Items)
            {
                ws.Cells[i, j] = comp.Text.ToString();
                foreach (ListViewItem.ListViewSubItem drv in comp.SubItems)
                {
                    ws.Cells[i, j] = drv.Text.ToString();
                    j++;
                }
                j = 1;
                i++;
            }
        }




        // Sự kiện nhấn nút btConnect
        private void btConnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("2"); //Gửi ký tự "2" qua Serial, tương ứng với state = 2
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


        // Sự kiện nhấn nút btSave
        private void btSave_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn lưu số liệu?", "Lưu", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (traloi == DialogResult.OK)
            {
                SaveToExcel(); // Thực thi hàm lưu ListView sang Excel
            }
        }


        // Sự kiện nhấn nút btRun
        private void btRun_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("1"); //Gửi ký tự "1" qua Serial, chạy hàm tạo Random ở Arduino
            }
            else
                MessageBox.Show("Bạn không thể chạy khi chưa kết nối với thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        // Sự kiện nhấn nút btPause
        private void btPause_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("0"); //Gửi ký tự "0" qua Serial, Dừng Arduino
            }
            else
                MessageBox.Show("Bạn không thể dừng khi chưa kết nối với thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        // Sự kiện nhấn nút Clear
        private void btClear_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc muốn xóa?", "Xóa dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (traloi == DialogResult.OK)
                {
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.Write("2"); //Gửi ký tự "2" qua Serial
                        listView1.Items.Clear(); // Xóa listview

                        //Xóa dữ liệu trong Form
                        ResetValue();
                    }
                    else
                        MessageBox.Show("Bạn không thể dừng khi chưa kết nối với thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Bạn không thể xóa khi chưa kết nối với thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
    }


    public class Model
    {
        public double Resistance { get; set; }

        public double Reactance { get; set; }
    }


    public class ViewModel
    {
        public ViewModel()
        {
            Trace1 = new ObservableCollection<Model>();

            Trace1.Add(new Model() { Resistance = 0, Reactance = 0.05 });
            Trace1.Add(new Model() { Resistance = 0.3, Reactance = 0.1 });
            Trace1.Add(new Model() { Resistance = 0.5, Reactance = 0.2 });
            Trace1.Add(new Model() { Resistance = 1.0, Reactance = 0.4 });
            Trace1.Add(new Model() { Resistance = 1.5, Reactance = 0.5 });
            Trace1.Add(new Model() { Resistance = 2.0, Reactance = 0.5 });
            Trace1.Add(new Model() { Resistance = 2.5, Reactance = 0.4 });
            Trace1.Add(new Model() { Resistance = 3.5, Reactance = 0.0 });
            Trace1.Add(new Model() { Resistance = 4.5, Reactance = -0.5 });
            Trace1.Add(new Model() { Resistance = 5, Reactance = -1.0 });
            Trace1.Add(new Model() { Resistance = 6, Reactance = -1.5 });
            Trace1.Add(new Model() { Resistance = 7, Reactance = -2.5 });
            Trace1.Add(new Model() { Resistance = 8, Reactance = -3.5 });
            Trace1.Add(new Model() { Resistance = 9, Reactance = -4.5 });
            Trace1.Add(new Model() { Resistance = 10, Reactance = -10 });
            Trace1.Add(new Model() { Resistance = 20, Reactance = -50 });

            Trace2 = new ObservableCollection<Model>();

            Trace2.Add(new Model() { Resistance = 0, Reactance = 0.15 });
            Trace2.Add(new Model() { Resistance = 0.3, Reactance = 0.2 });
            Trace2.Add(new Model() { Resistance = 0.5, Reactance = 0.4 });
            Trace2.Add(new Model() { Resistance = 1.0, Reactance = 0.8 });
            Trace2.Add(new Model() { Resistance = 1.5, Reactance = 1.0 });
            Trace2.Add(new Model() { Resistance = 2.0, Reactance = 1.2 });
            Trace2.Add(new Model() { Resistance = 2.5, Reactance = 1.3 });
            Trace2.Add(new Model() { Resistance = 3.5, Reactance = 1.6 });
            Trace2.Add(new Model() { Resistance = 4.5, Reactance = 2.0 });
            Trace2.Add(new Model() { Resistance = 6, Reactance = 4.5 });
            Trace2.Add(new Model() { Resistance = 8, Reactance = 6 });
            Trace2.Add(new Model() { Resistance = 10, Reactance = 25 });
        }

        public ObservableCollection<Model> Trace1 { get; set; }
        public ObservableCollection<Model> Trace2 { get; set; }
    }
}
