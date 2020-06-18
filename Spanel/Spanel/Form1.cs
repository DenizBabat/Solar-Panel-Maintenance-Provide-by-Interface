using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO.Ports;
using System.Drawing;
using System.Globalization;


namespace Spanel
{
    public partial class form_panel : Form
    {
        Timer chartTimer = new Timer();
        string[] ports = SerialPort.GetPortNames();
        bool flag_auto = true;
        bool flag_open = false;
        bool flag_close = false;

        public float prevolt = 0f;
        public float preamper = 0f;
        public string predirection = "";

        public float ver_angle = 0f;
        public float hor_angle = 0f;

        public form_panel()
        {
           

            InitializeComponent();

            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.PortName = ports[0];
                    serialPort1.Open();
                    display.Text = "\n" + serialPort1.PortName + " have opened" + display.Text;
                }
                catch (Exception e)
                {
                    display.Text = "\nPort Error: " + e.Message;
                }

            }
           
            InitChart();


         
        }

        private void InitChart()
        {
            DateTime time = DateTime.Now;
            chartTimer.Interval = 1000;
            chartTimer.Tick += chartTimer_Tick;
            chart1.DoubleClick += chartDemo_DoubleClick;

            Series series = chart1.Series[0];
            series.ChartType = SeriesChartType.Spline;

            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            chart1.ChartAreas[0].AxisX.ScaleView.Size = 5;
            chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            chart1.ChartAreas[0].AxisX.ScrollBar.Enabled = true;

            chartTimer.Start();

        }

        void chartDemo_DoubleClick(object sender, EventArgs e)//show the scrollBar
        {
            chart1.ChartAreas[0].AxisX.ScaleView.Size = 5;
            chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            chart1.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
        }

        void chartTimer_Tick(object sender, EventArgs e)
        {
            
            
            DateTime time = DateTime.Now;
            float voltValue = -1f;
            float amperValue = 0f;
            float voltValue2 = -1f;
            string strvolt ="";
            string strvolt2 = "";
            string stramper = "";
            string str = serialPort1.ReadExisting(); 
            string direct = "";
            string strdir = "";
            string strupdown = "";
            Console.WriteLine(str);
            bool flag_r = true, flag_l = true;

            if (str != "")
            {
                string[] words = str.Split('|');
                strvolt = words[0];
                stramper = words[1];
                direct = words[2];
                strvolt2 = words[3];
                strdir = words[4];
                strupdown = words[5];

                voltValue = float.Parse(strvolt, CultureInfo.InvariantCulture.NumberFormat);
                amperValue = float.Parse(stramper, CultureInfo.InvariantCulture.NumberFormat);
                voltValue2 = float.Parse(strvolt2, CultureInfo.InvariantCulture.NumberFormat);
                hor_angle = float.Parse(strdir, CultureInfo.InvariantCulture.NumberFormat);
                ver_angle = float.Parse(strupdown, CultureInfo.InvariantCulture.NumberFormat);
                Console.WriteLine("hor_angle:"+hor_angle+"  ver_angle:"+ver_angle);

                if (voltValue >= 0.30)
                {
                    ledleft.On = true;
                }
                else if (voltValue <0.30)
                {
                    ledleft.On = false;
                }
                else
                {
                    if (flag_l)
                    {
                        MessageBox.Show("Left Panel is not work. Please, check it", "Alert Panel", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        flag_l = false;
                    }
                }

                if(voltValue2 > 0)
                {
                    ledright.On = true;
                }
                else if (voltValue2 == 0)
                {
                    ledright.On = false;
                }
                else
                {
                    if (flag_r)
                    {
                        MessageBox.Show("Right Panel is not work. Please, check it", "Alert Panel", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        flag_r = false;
                    }
                }
            }
            else
            {
                voltValue = prevolt;
                amperValue = preamper;
                direct = predirection;
            }

            prevolt = voltValue;
            preamper = amperValue;
            predirection = direct;

         /*   Console.WriteLine("voltvalue:"+voltValue );
            Console.WriteLine("ampervalue:"+amperValue );
            Console.WriteLine("direction:"+direct);
            */

            t_volt.Text = strvolt.ToString() +" Volt";
            t_amper.Text = stramper.ToString() + " Amper";
            t_angle.Text = direct.ToString() + " "+ strupdown+"°";
            

           
            chart1.Series["amper"].Points.AddXY(time, amperValue);
            chart1.ChartAreas[0].AxisX.ScaleView.Position = chart1.Series["amper"].Points.Count - 5;

            chart1.Series["volt"].Points.AddXY(time, voltValue);
            chart1.ChartAreas[0].AxisX.ScaleView.Position = chart1.Series["volt"].Points.Count - 5;

            chart1.DataBind();

            t_date.Text = time.Year.ToString() + "." + time.Month.ToString() + "." + time.Day.ToString();
            if(time.Minute<10)
                t_hour.Text = time.Hour.ToString() + ":"+"0" + time.Minute.ToString() + ":" + time.Second.ToString();
            else t_hour.Text = time.Hour.ToString() + ":" + time.Minute.ToString() + ":" + time.Second.ToString();
        }

        private void btn_openPanel_Click(object sender, EventArgs e)
        {

            if (!flag_open)
            {
                serialPort1.Write("o");
                display.Text = "\nPanel have opened." + display.Text;
                flag_open = true;
                redled.On = true;

                t_volt.Text = prevolt.ToString() + " Volt";
                t_amper.Text = preamper.ToString() + " Amper";
                t_angle.Text = predirection.ToString() + "°";
            }
            else
            {
                MessageBox.Show("System already open", "Warning!", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void btn_closePanel_Click(object sender, EventArgs e)
        {
            if (flag_open)
            {
                serialPort1.Write("c");
                display.Text = "\nPanel have closed." + display.Text;
                flag_open = false;
                flag_auto = false;
                redled.On = false;
                autoled.On = false;
            }
            else
            {
                MessageBox.Show("System already close", "Warning!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btn_autoPanel_Click(object sender, EventArgs e)
        {
            if (flag_open)
            {
                if (flag_auto)
                {
                    serialPort1.Write("a");
                    display.Text = "\nSystem have work automatically." + display.Text;
                    flag_auto = false;
                    autoled.On = true;
                }
                else
                {
                    serialPort1.Write("n");
                    display.Text = "\nSystem have not work automatically." + display.Text;
                    flag_auto = true;
                    autoled.On = false;
                }
            }
            else
            {
                MessageBox.Show("System do not open. Firstly you can open system", "Warning!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
           
        }

        private void eAngle_MouseClick(object sender, MouseEventArgs e)
        {
            eAngle.Text = "";
            eAngle.ForeColor = Color.Black;
        }
        
        private void eAngle_Leave(object sender, EventArgs e)
        {
            if (eAngle.Text == "")
            {
                eAngle.Text = "Enter Angle";
                eAngle.ForeColor = System.Drawing.SystemColors.GrayText;
            }

        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            String strAng = eAngle.Text;
            int angleVal = 0;
            bool flag = false;
            bool flag2 = true;
            int tempangle = 0;
            if (flag_open)
            {
                if (strAng.Equals("Enter Angle"))
                {
                    angleVal = 3;
                    flag = true;
                }
                else
                {
                    try
                    {
                        angleVal = System.Convert.ToInt32(strAng);

                    }
                    catch
                    {

                        MessageBox.Show("Wrong Angle input. Enter integer value", "Wrong Entered", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        flag = false;
                    }
                }
                tempangle = angleVal + ((int)ver_angle);
                if (tempangle > 80)
                {
                    flag = false;
                }
                else
                {
                    flag = true;
                }
                if (!flag)
                {
                    if (tempangle < 20 || tempangle > 80)
                    {
                        flag2 = false;
                        MessageBox.Show("Angle must be between 20° and 80°", "Wrong Angle", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                    }
                }

                if (flag2)
                {
                    display.Text = "\nAngle UP value: " + angleVal + " was send to motors" + display.Text;
                    serialPort1.Write("UP," + angleVal.ToString());
                    ver_angle = tempangle;

                }
            }
            else
            {
                MessageBox.Show("System do not open. Firstly you can open system", "Warning!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            String strAng = eAngle.Text;
            int angleVal = 0;
            bool flag = false;
            bool flag2 = true;
            int tempangle = 0;

            if (flag_open)
            {
                if (strAng.Equals("Enter Angle"))
                {
                    angleVal = 3;
                    flag = true;
                }
                else
                {
                    try
                    {
                        angleVal = System.Convert.ToInt32(strAng);

                    }
                    catch
                    {
                        MessageBox.Show("Wrong Angle input. Enter integer value", "Wrong Entered", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        flag = false;
                    }
                }

                tempangle = ((int)ver_angle) - angleVal;
                if (tempangle < 20)
                {
                    flag = false;
                }
                else
                {
                    flag = true;
                }
                if (!flag)
                {
                    if (tempangle < 20 || tempangle > 80)
                    {
                        flag2 = false;
                        MessageBox.Show("Angle must be between 0° and 180°", "Wrong Angle", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                    }
                }

                if (flag2)
                {
                    display.Text = "\nAngle DOWN value: " + angleVal + " was send to motors" + display.Text;
                    serialPort1.Write("DOWN," + angleVal.ToString());
                    ver_angle = tempangle;
                }
            }
            else
            {
                MessageBox.Show("System do not open. Firstly you can open system", "Warning!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            String strAng = eAngle.Text;
            int angleVal = 0;
            bool flag = false;
            bool flag2 = true;
            int tempangle = 0;

            if (flag_open)
            {
                if (strAng.Equals("Enter Angle"))
                {
                    angleVal = 3;
                    flag = true;
                }
                else
                {
                    try
                    {
                        angleVal = System.Convert.ToInt32(strAng);

                    }
                    catch
                    {

                        MessageBox.Show("Wrong Angle input. Enter integer value", "Wrong Entered", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        flag = false;
                    }
                }

                tempangle = ((int)hor_angle) - angleVal;
                if (tempangle < 0)
                {
                    flag = false;
                }
                else
                {
                    flag = true;
                }

                if (!flag)
                {
                    if (tempangle < 0 || tempangle > 180)
                    {
                        flag2 = false;
                        MessageBox.Show("Angle must be between 0° and 100°", "Wrong Angle", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                    }

                }

                if (flag2)
                {
                    display.Text = "\nAngle WEST value: " + angleVal + " was send to motors" + display.Text;
                    serialPort1.Write("LEFT," + angleVal.ToString());
                    hor_angle = tempangle;
                }
            }
            else
            {
                MessageBox.Show("System do not open. Firstly you can open system", "Warning!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            String strAng = eAngle.Text;
            int angleVal = 0;
            bool flag = false;
            bool flag2 = true;
            int tempangle = 0;

            if (flag_open)
            {
                if (strAng.Equals("Enter Angle"))
                {
                    angleVal = 3;
                    flag = true;
                }
                else
                {
                    try
                    {
                        angleVal = System.Convert.ToInt32(strAng);

                    }
                    catch
                    {

                        MessageBox.Show("Wrong Angle input. Enter integer value", "Wrong Entered", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        flag = false;
                    }
                }

                tempangle = ((int)hor_angle) + angleVal;
                if (tempangle > 180)
                {
                    flag = false;
                }
                else
                {
                    flag = true;
                }

                if (!flag)
                {

                    if (tempangle < 0 || tempangle > 180)
                    {
                        flag2 = false;
                        MessageBox.Show("Angle must be between 0° and 180°", "Wrong Angle", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                    }
                }

                if (flag2)
                {
                    display.Text = "\nAngle EAST value: " + angleVal + " was send to motors" + display.Text;
                    serialPort1.Write("RIGHT," + angleVal.ToString());
                }
            }
            else
            {
                MessageBox.Show("System do not open. Firstly you can open system", "Warning!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void form_panel_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void form_panel_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Write("c");
            display.Text = "\nPanel have closed." + display.Text;
        }

    }
}
