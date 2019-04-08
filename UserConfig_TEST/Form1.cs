using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenHardwareMonitor.Hardware;
using OpenHardwareMonitor;
using System.Threading;
using System.IO.Ports;
using System.Globalization;

namespace UserConfig_TEST
{
    public partial class main : Form
    {
        public bool flag = false;

        public main()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                txt_log.AppendText(port + "    ");
            }
            txt_log.AppendText("\r\n");
            load_setting();
            Thread thread = new Thread(new ThreadStart(loop));
            thread.Start();
        }

        public void loop()
        {
            int i = 0;
            double avg;
            SerialPort port = new SerialPort("COM7", 9600);
            port.Open();
            while (flag == false)
            {
                Computer myComputer = new Computer();
                myComputer.CPUEnabled = true;
                myComputer.Open();
                List<int> ctemp_value = new List<int>();

                foreach (var hardwareItem in myComputer.Hardware)
                {

                    foreach (var sensor in hardwareItem.Sensors)
                    {
                        if (sensor.Identifier.ToString() == "/intelcpu/0/temperature/0" || sensor.Identifier.ToString() == "/intelcpu/0/temperature/1" || sensor.Identifier.ToString() == "/intelcpu/0/temperature/2" || sensor.Identifier.ToString() == "/intelcpu/0/temperature/3")
                        {
                            string name = sensor.Identifier.ToString();
                            name = name.Replace("/intelcpu/0/temperature/", "CPU ");
                            ctemp_value.Add(Convert.ToInt32(sensor.Value));
                        }

                    }
                }
                if (ctemp_value.Count > 0)
                {
                    avg = ctemp_value.Average();
                    update_chart(avg);
                    Cv1.Invoke(new Action(() => Cv1.Text = ctemp_value[0].ToString() + " °C"));
                    Cv2.Invoke(new Action(() => Cv2.Text = ctemp_value[1].ToString() + " °C"));
                    Cv3.Invoke(new Action(() => Cv3.Text = ctemp_value[2].ToString() + " °C"));
                    Cv3.Invoke(new Action(() => Cv4.Text = ctemp_value[3].ToString() + " °C"));
                    Cavg.Invoke(new Action(() => Cavg.Text = avg.ToString() + " °C"));
                    i += 1;

                    if (i == 3)
                    {
                        if (avg < 80)
                        {
                            txt_log.Invoke(new Action(() => txt_log.AppendText("OFF" + "\r\n")));
                            port.WriteLine("1");
                            txt_log.Invoke(new Action(() => txt_log.AppendText("serail : " + port.ReadLine().ToString() + "\r\n")));
                            i = 0;
                        }
                        else
                        {
                            txt_log.Invoke(new Action(() => txt_log.AppendText("ON" + "\r\n")));
                            port.WriteLine("0");
                            txt_log.Invoke(new Action(() => txt_log.AppendText("serail : " + port.ReadLine().ToString() + "\r\n")));
                            i = 0;
                        }

                    }
                    Thread.Sleep(1000);
                }
            }
        }


        public void load_setting()
        {
            lblcpu0.ForeColor = System.Drawing.ColorTranslator.FromHtml(Properties.Settings.Default.cpu0);
            lblcpu1.ForeColor = System.Drawing.ColorTranslator.FromHtml(Properties.Settings.Default.cpu1);
            lblcpu2.ForeColor = System.Drawing.ColorTranslator.FromHtml(Properties.Settings.Default.cpu2);
            lblcpu3.ForeColor = System.Drawing.ColorTranslator.FromHtml(Properties.Settings.Default.cpu3);
            lblgpu.ForeColor = System.Drawing.ColorTranslator.FromHtml(Properties.Settings.Default.gpu);
            Gv1.ForeColor = System.Drawing.ColorTranslator.FromHtml(Properties.Settings.Default.gpu_value);
            Cv1.ForeColor = System.Drawing.ColorTranslator.FromHtml(Properties.Settings.Default.cpu0_value);
            Cv2.ForeColor = System.Drawing.ColorTranslator.FromHtml(Properties.Settings.Default.cpu1_value);
            Cv3.ForeColor = System.Drawing.ColorTranslator.FromHtml(Properties.Settings.Default.cpu2_value);
            Cv4.ForeColor = System.Drawing.ColorTranslator.FromHtml(Properties.Settings.Default.cpu3_value);
            this.Opacity = 1;

        }

        public void load_setting1(string value)
        {
            load_setting();
            lblcpu0.ForeColor = System.Drawing.ColorTranslator.FromHtml(value);
            MessageBox.Show("TEST ONCE");
        }

        private void update_chart(double value)
        {
            chartCpu.Invoke(new Action(() => chartCpu.Series["CPU"].Points.Add(value)));
            return;

        }

        private void Save_Click(object sender, EventArgs e)
        {
            flag = true;
        }

        private void pick_Click(object sender, EventArgs e)
        {
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            flag = true;
            Thread.Sleep(1000);
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_setting();
        }


        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = true;
            Thread.Sleep(1000);
            this.Close();
        }

        private void exit()
        {
            flag = true;
            Thread.Sleep(1000);
            this.Close();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1.ShowBalloonTip(10, "info1", "info2", ToolTipIcon.Info);
        }

        private void main_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.ShowBalloonTip(10, "info1", "info2", ToolTipIcon.Info);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(track_RED.Value, track_GREEN.Value, track_BLUE.Value);
            txt_BLUE.Text = track_BLUE.Value.ToString();
            txt_GREEN.Text = track_GREEN.Value.ToString();
            txt_RED.Text = track_RED.Value.ToString();

            txt_Rhtml.Text = track_RED.Value.ToString("X");
            txt_Ghtml.Text = track_GREEN.Value.ToString("X");
            txt_Bhtml.Text = track_BLUE.Value.ToString("X");

            lbl_RGB.Text = "RGB (" + track_RED.Value.ToString() + "," + track_GREEN.Value.ToString() + "," + track_BLUE.Value.ToString() + ")";
            lbl_HTML.Text = "HTML " + ColorTranslator.ToHtml(Color.FromArgb(track_RED.Value, track_GREEN.Value, track_BLUE.Value)).ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            string color = "";
            if (index == 0) { color = Properties.Settings.Default.cpu0.ToString(); }
            if (index == 1) { color = Properties.Settings.Default.cpu1.ToString(); }
            if (index == 2) { color = Properties.Settings.Default.cpu2.ToString(); }
            if (index == 3) { color = Properties.Settings.Default.cpu3.ToString(); }
            if (index == 4) { color = Properties.Settings.Default.cpu0_value.ToString(); }
            if (index == 5) { color = Properties.Settings.Default.cpu1_value.ToString(); }
            if (index == 6) { color = Properties.Settings.Default.cpu2_value.ToString(); }
            if (index == 7) { color = Properties.Settings.Default.cpu3_value.ToString(); }
            if (index == 8) { color = Properties.Settings.Default.gpu.ToString(); }
            if (index == 9) { color = Properties.Settings.Default.gpu_value.ToString(); }

            string R = Int64.Parse((color[1].ToString() + color[2].ToString()), NumberStyles.HexNumber).ToString();
            string G = Int64.Parse((color[3].ToString() + color[4].ToString()), NumberStyles.HexNumber).ToString();
            string B = Int64.Parse((color[5].ToString() + color[6].ToString()), NumberStyles.HexNumber).ToString();
            track_RED.Value = Convert.ToInt32(R);
            track_GREEN.Value = Convert.ToInt32(G);
            track_BLUE.Value = Convert.ToInt32(B);

            //MessageBox.Show("COLOR : " + R + " : " + G +" : " + B);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            string color = ColorTranslator.ToHtml(Color.FromArgb(track_RED.Value, track_GREEN.Value, track_BLUE.Value)).ToString();
            int index = comboBox1.SelectedIndex;
            if (index == 0) { 
                Properties.Settings.Default.cpu0 = color; 
                Properties.Settings.Default.Save(); 
            }
            if (index == 1)
            {
                Properties.Settings.Default.cpu1 = color;
                Properties.Settings.Default.Save();
            }
            if (index == 2)
            {
                Properties.Settings.Default.cpu2 = color;
                Properties.Settings.Default.Save();
            }
            if (index == 3)
            {
                Properties.Settings.Default.cpu3 = color;
                Properties.Settings.Default.Save();
            }
            if (index == 4)
            {
                Properties.Settings.Default.cpu0_value = color;
                Properties.Settings.Default.Save();
            }
            if (index == 5)
            {
                Properties.Settings.Default.cpu1_value = color;
                Properties.Settings.Default.Save();
            }
            if (index == 6)
            {
                Properties.Settings.Default.cpu2_value = color;
                Properties.Settings.Default.Save();
            }
            if (index == 7)
            {
                Properties.Settings.Default.cpu3_value = color;
                Properties.Settings.Default.Save();
            }
            if (index == 8)
            {
                Properties.Settings.Default.gpu = color;
                Properties.Settings.Default.Save();
            }
            if (index == 9)
            {
                Properties.Settings.Default.gpu_value = color;
                Properties.Settings.Default.Save();
            }
            load_setting();
        }
    }
}
