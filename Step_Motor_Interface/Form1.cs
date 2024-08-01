using System.IO.Ports;
using System.Windows.Forms;

namespace Step_Motor_Interface
{
    public partial class Form1 : Form
    {
        private SerialPort serial;
        private string[] ports = SerialPort.GetPortNames();
        private String[] degrees = { "0,703125", "1,40625", "2,109375", "2,8125", "3,515625",
                "4,21875", "4,921875", "5,625", "6,328125", "7,03125", "7,734375", "8,4375"};
        private int stepNum = 0;

        public Form1()
        {
            InitializeComponent();
            InitDegreeBox();
            disconnectBtn.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serial = new SerialPort();
            foreach (string port in ports)
            {
                portsBox.Items.Add(port);
            }
            if (portsBox.Items.Count > 0)
            {
                portsBox.SelectedIndex = 0;
            }

            serial.DataReceived += new SerialDataReceivedEventHandler(serial_DataReceived);
        }

        private void serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serial.ReadLine();
            data = data.Trim();
            if (data == "OK")
            {
                startButton.Enabled = true;
                disconnectBtn.Enabled = true;
                resultListBox.Items.Add("Tamamlandý!");
            }
            else
            {
                resultListBox.Items.Add(data);
            }
            resultListBox.TopIndex = resultListBox.Items.Count - 1;
        }

        private void InitDegreeBox()
        {
            for (int i = 0; i < degrees.Length; i++)
            {
                degreeBox.Items.Add(degrees[i]);
            }
            degreeBox.SelectedIndex = 0;
        }

        private async void startButton_ClickAsync(object sender, EventArgs e)
        {
            if (disconnectBtn.Enabled)
            {
                bool flag = int.TryParse(stepBox.Text, out int num);
                if (flag)
                {
                    if (num > 0 && num < 1000)
                    {
                        startButton.Enabled = false;
                        disconnectBtn.Enabled = false;
                        serial.WriteLine(num.ToString());
                        await Task.Delay(3000);
                        serial.WriteLine(degreeBox.SelectedIndex.ToString());
                        resultListBox.Items.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen adým deðerini 1 ile 999 arasýnda giriniz!", "Uyarý"
                            , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen adým yerine sayý giriniz!", "Uyarý"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir cihaza baðlanýn!", "Uyarý"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            if (!serial.IsOpen)
            {
                serial.PortName = portsBox.Text;
                serial.BaudRate = 9600;
                serial.Parity = Parity.None;
                serial.StopBits = StopBits.One;
                serial.DataBits = 8;

                try
                {
                    serial.Open();
                }
                catch (Exception)
                {
                    Console.WriteLine("Baðlantý kurulamadý");
                    throw;
                }

                connectBtn.Enabled = false;
                disconnectBtn.Enabled = true;
            }
        }

        private void disconnectBtn_Click(object sender, EventArgs e)
        {
            if (serial.IsOpen)
            {
                serial.Close();
                connectBtn.Enabled = true;
                disconnectBtn.Enabled = false;
            }
        }

        private void stepBox_TextChanged(object sender, EventArgs e)
        {
            bool flag = int.TryParse(stepBox.Text, out int num);
            if (flag) 
            {
                float result = Convert.ToSingle(num) * Convert.ToSingle(degrees[degreeBox.SelectedIndex]);
                resultBox.Text = "Toplam açý = " + result;
                stepNum = num;
            }
        }

        private void degreeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(degreeBox.SelectedItem != null)
            {
                float result = Convert.ToSingle(stepNum) * Convert.ToSingle(degrees[degreeBox.SelectedIndex]);
                resultBox.Text = "Toplam açý = " + result;
            }
        }
    }
}
