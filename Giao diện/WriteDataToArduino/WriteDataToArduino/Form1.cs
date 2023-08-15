using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WriteDataToArduino

{
    public partial class Main : Form
    {
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Timer sendDataTimer; // Timer để gửi tín hiệu định kỳ
        private bool sendingData = false;
        public Main()
        {
            InitializeComponent();

            // Cứ 100ms lại thục hiện hàm Sendata 
            // Tạo đối tượng Timer  với thời gian 100ms 
            sendDataTimer = new System.Windows.Forms.Timer();
            sendDataTimer.Interval = 100;
            // Gán sự kiên Tick cho sendata 
            sendDataTimer.Tick += SendData;
           
            string[] Baudrate = { "1200", "2400", "4800", "9600", "115200" }; // Các giá trị tùy chọn của Baudrate
            cbxBaudrate.Items.AddRange(Baudrate); // Set các giá trị tùy chọn trên vào comboBox Baudrate


            Control.CheckForIllegalCrossThreadCalls = false; // Cho phép các lưồng hoạt động đa luồng 
        }

        // Tạo 3 biến đếm số lượng sản phẩm cho 3 màu red yelllow blue 
        private int rCount = 0;
        private int yCount = 0;
        private int bCount = 0;

        // Hàm lấy dữ liệu 
        private void SendData(object sender, EventArgs e)
        {
            serCOM.Write("B1"); // Gửi tín hiệu "B1" đến Arduino (có nghĩa là chạy các lệnh)
            textRedCount.Text = rCount.ToString(); // Cập nhật giá trị phân loại của sản phẩm màu đỏ
            textYellowCount.Text = yCount.ToString(); // Cập nhật giá trị phân loại của sản phẩm màu xanh lá
            textBlueCount.Text = bCount.ToString(); // Cập nhật giá trị phân loại của sản phẩm màu xanh 
        }

        private void Main_Load(object sender, EventArgs e)
        {
            cbxBaudrate.Text = "9600"; // Giá trị mặc định của Baudrate là 9600 

            // Cập nhật cổng vào liên tục 
            updateTimer = new System.Windows.Forms.Timer();
            updateTimer.Interval = 100; // Đặt thời gian là 100ms (0.1 giây)
            updateTimer.Tick += UpdateTimer_Tick; // Gắn phương thức xử lý sự kiện Tick của Timer
            updateTimer.Start(); //
        }

         // Lấy dữ liệu danh sách các cổng COM 
        private void UpdateTimer_Tick(object sender, EventArgs e)
        //Cập nhật giá trị rCount lên TextBox textRedCount
        {
            if (SerialPort.GetPortNames().Length <= 0)
            {
                cbxCom.SelectedItem = null;
            }
                cbxCom.DataSource = SerialPort.GetPortNames(); // Gán danh sách các cổng COM được kết nối cho comboBox 
        }

        // Nút kết nối với Arduino với tùy chọn Baudrate và cổng COM
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!serCOM.IsOpen)
            {
                if (SerialPort.GetPortNames().Length <= 0)
                {
                    MessageBox.Show("Bạn chưa chọn cổng COM. Hãy kiểm Arduino đã kết nối với máy tính của bạn chưa.");
                }
                else
                {
                    serCOM.PortName = cbxCom.Text;
                    button1.Text = "Ngắt kết nối";
                    serCOM.BaudRate = Convert.ToInt32(cbxBaudrate.Text);
                    serCOM.Open();
                }
            }
            else
            {
                button1.Text = "Kết nối";
                serCOM.Close();
            }
        }

        // Nút thoát 
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        // Nút bắt đầu 
        private void btnStart_Click(object sender, EventArgs e)
        {
            if(!serCOM.IsOpen)
            {
                MessageBox.Show("Bạn chưa kết nối cổng COM");   
            }
            else if (!sendingData)
            {
                sendingData = true;
                sendDataTimer.Start(); // Bắt đầu gửi tín hiệu
                //updateTimer.Start(); // Bắt đầu Timer
            }
        }

        // Nút kết thúc 
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (!serCOM.IsOpen)
            {
                MessageBox.Show("Bạn chưa kết nối cổng COM");
            }
            else { 
                sendingData = false; // Dừng gửi tín hiệu
                sendDataTimer.Stop(); 
                //updateTimer.Stop(); 
            }
            serCOM.Write("T1");
        }

        // Nhận dữ liệu từ cổng serial 
        private void serCOM_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Chuỗi hiển thị RGB   
            String alldata = "";
            alldata = serCOM.ReadLine(); // Đọc dữ liệu từ cổng rồi gán vào alldata 
            //int len = alldata.Length;

            //if (len > 0)
            //{
            // Hiển thị giá trị cổng serial lên Textbox 
                textDateReceive.AppendText(alldata + Environment.NewLine);
            //}

            //String alldata = "";
            //alldata = serCOM.ReadLine();
            string valueOfRed, valueOfGreen, valueOfBlue;

            // Tách giá trị Red
            int startIndexRed = alldata.IndexOf(':') + 2;
            int lengthRed = alldata.IndexOf(' ', startIndexRed) - startIndexRed;
            valueOfRed = alldata.Substring(startIndexRed, lengthRed);

            // Tách giá trị Green
            int startIndexGreen = alldata.IndexOf("Green:") + 7;
            int lengthGreen = alldata.IndexOf(' ', startIndexGreen) - startIndexGreen;
            valueOfGreen = alldata.Substring(startIndexGreen, lengthGreen);

            // Tách giá trị Blue
            int startIndexBlue = alldata.IndexOf("Blue:") + 6;
            int lengthBlue = alldata.Length - startIndexBlue;
            valueOfBlue = alldata.Substring(startIndexBlue, lengthBlue);

            // Chuyển giá trị tách được từ kiểu string sang kiểu nguyên 
            int redValue = int.Parse(valueOfRed);
            int greenValue = int.Parse(valueOfGreen);
            int blueValue = int.Parse(valueOfBlue);


            // Kiểm tra màu đỏ 
            if (redValue >= 1700 && redValue <= 3700 && greenValue >= 5000 && greenValue <= 7000 && blueValue >= 5000 && blueValue <= 7000)
            {
                rCount++;
            }
            // Kiểm tra màu xanh lá
            else if (redValue >= 3200 && redValue <= 5200 && greenValue >= 3200 && greenValue <= 5200 && blueValue >= 3800 && blueValue <= 5800)
            {
                yCount++;
            }
            // Kiểm tra màu xanh 
            else if (redValue >= 5800 && redValue <= 7800 && greenValue >= 4300 && greenValue <= 6300 && blueValue >= 3200 && blueValue <= 5200)
            {
                bCount++;
            }
            else {
            }
        }
    }
}
