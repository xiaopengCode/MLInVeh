using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;  //chart 相关引用

using System.Runtime.InteropServices;  //设置鼠标位置所引用的命名空间

namespace MLInVehSensorAnalysis
{
    public partial class GeomagneticSensorAnalysis : Form
    {
        public GeomagneticSensorAnalysis()
        {
            InitializeComponent();
        }

        private void GeomagneticSensorAnalysis_Load(object sender, EventArgs e)
        {
            SerialPort1Param_Load(serialPort1, comboBoxForSerialPort);//串口参数加载
        }

        private void SearchAndAddSerialToComboBox(SerialPort myPort, ComboBox myBox)
        {
            try
            {
                myBox.Items.Clear();
                string[] portName = SerialPort.GetPortNames();
                for (int i = 0; i < portName.Length; i++)
                {
                    myBox.Items.Add(portName[i]);
                }
                if (portName.Length != 0)
                {
                    myBox.Text = portName[0];
                }
                else
                {
                    myBox.Text = myPort.PortName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static string[] baudRateParam = { "110", "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "38400", "56000", "57600", "115200" };
        public static string[] dataBits = { "6", "7", "8" };
        public static string[,] checkBits = { { "无", "None" }, { "奇校验", "Odd" }, { "偶校验", "Even" }, { "Mark", "Mark" }, { "空格校验", "Space" } };
        public static string[,] stopBits = { { "无", "None" }, { "1", "One" }, { "2", "Two" }, { "1.5", "OnePointFive" } };

        private void SerialPort1Param_Load(SerialPort myPort, ComboBox myBox)
        {
            for (int i = 0; i < baudRateParam.Length; i++)
            {
                comboBoxForBaudRate.Items.Add(baudRateParam[i]);
            }
            comboBoxForBaudRate.Text = myPort.BaudRate.ToString();

            for (int i = 0; i < dataBits.Length; i++)
            {
                comboBoxForDataBit.Items.Add(dataBits[i]);
            }
            comboBoxForDataBit.Text = myPort.DataBits.ToString();

            for (int i = 0; i < checkBits.GetLength(0); i++)
            {
                comboBoxForCheckBit.Items.Add(checkBits[i, 0]);

                if (checkBits[i, 1] == myPort.Parity.ToString())//将对应的英文字符替换为中文字符
                {
                    comboBoxForCheckBit.Text = checkBits[i, 0];
                }

            }
            for (int i = 0; i < stopBits.GetLength(0); i++)
            {
                comboBoxForStopBit.Items.Add(stopBits[i, 0]);

                if (stopBits[i, 1] == myPort.StopBits.ToString())//将对应的英文字符替换为中文字符
                {
                    comboBoxForStopBit.Text = stopBits[i, 0];
                }

            }

            //chartForXYZ.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Milliseconds;
            //chartForXYZ.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            //chartForXYZ.ChartAreas[0].AxisX.LabelStyle.IsEndLabelVisible = false;
            chartForXYZ.ChartAreas[0].AxisX.Maximum = 100;
            chartForXYZ.ChartAreas[0].AxisX.Minimum = 1;

            //chartForXYZ.ChartAreas[0].AxisX.MajorGrid.IntervalType = DateTimeIntervalType.Milliseconds;
            //chartForXYZ.ChartAreas[0].AxisX.MajorGrid.Interval = 10;
            chartForXYZ.ChartAreas[0].AxisY.Maximum = 32768;
            chartForXYZ.ChartAreas[0].AxisY.Minimum = -32768;

            /* 显示选项 */
            checkBoxXDisplay.Checked = true;
            checkBoxYDisplay.Checked = true;
            checkBoxZDisplay.Checked = true;

            /* groupBox字体颜色 */
            groupBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            groupBox2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            groupBox3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            groupBox4.ForeColor = System.Drawing.Color.DeepSkyBlue;
        }

        private void serialPort_button_Click(object sender, EventArgs e)//串口打开和关闭
        {
            //打开前对串口参数进行设置


            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                    buttonForSerialOpenClose.Text = "打开串口";

                    timerForSerialAutoScan.Start();  //开启定时器对串口进行扫描
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    serialPort1.PortName = comboBoxForSerialPort.Text;             //打开串口前需获取该端口的名称，否则会出现异常
                    serialPort1.Open();

                    serialPort1.BaudRate = int.Parse(comboBoxForBaudRate.Text);    //打开串口成功后设置串口参数
                    serialPort1.DataBits = int.Parse(comboBoxForDataBit.Text);

                    for (int i = 0; i < checkBits.GetLength(0); i++)
                    {
                        if (checkBits[i, 0] == comboBoxForCheckBit.Text)
                        {
                            serialPort1.Parity = (Parity)i;
                            break;
                        }

                    }

                    for (int i = 0; i < stopBits.GetLength(0); i++)
                    {
                        if (stopBits[i, 0] == comboBoxForStopBit.Text)
                        {
                            serialPort1.StopBits = (StopBits)i;
                            break;
                        }

                    }

                    buttonForSerialOpenClose.Text = "关闭串口";

                    timerForSerialAutoScan.Stop();  //关闭定时器扫描
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        public class SerialPortByteQueue  //串口字节队列类
        {
            private List<byte> serialDataQueue = new List<byte>();

            static int packetLength = 0;
            public int getPacketLength()
            {
                return packetLength;
            }

            /***
             *数据包格式： |帧头（0x55 0x55） |有效数据长度|X轴高字节|X轴低字节|Y轴高字节|Y轴低字节|Z轴高字节|Z轴低字节|时间戳|包序号|CRC校验|
             *    字节数：       2               1              1         1         1         1          1         1       4     1     2
             *    说明：crc校验低字节在前
             ***/
            public bool PacketCheck()
            {
                if ((serialDataQueue.Count == 0) || ((serialDataQueue.Count != 0) && (((packetLength == 0) && (serialDataQueue.Count < 3)) || ((packetLength != 0) && (serialDataQueue.Count < (packetLength+2))))))
                {
                    return false;
                }

                int headIndex = 0;

                //headIndex = serialDataBuf.FindIndex(headIndex,o => o == 0x55);  //
                headIndex = serialDataQueue.IndexOf(0x55);
                if (headIndex == -1)  //没找到
                {
                    serialDataQueue.Clear();
                    return false;
                }
                else if (headIndex != 0)  //不为开头，则移除之前的字节
                {
                    serialDataQueue.RemoveRange(0, headIndex);
                    headIndex = 0;
                }

                if (serialDataQueue[headIndex + 1] == 0x55)  //开头：0x55,0x55
                {
                    if ((packetLength != 0)&&(packetLength!=serialDataQueue[2]))
                    {//说明是错误的数据包
                        serialDataQueue.RemoveRange(0, headIndex+1);  //移除前一个字节  继续查找
                        return false;
                    }
                    else if(packetLength==0)
                    {
                        packetLength = serialDataQueue[2];  //获取数据包长度
                    }

                    if (serialDataQueue.Count >= (packetLength + 2))
                    {
                        byte[] onePacket = new byte[packetLength + 2]; //+2：加2字节crc校验
                        serialDataQueue.CopyTo(0,onePacket,0,packetLength+2);

                        UInt16 crcValue;
                        crcValue = CalcArrayCrc16(onePacket, packetLength);
                        if (crcValue != ((onePacket[packetLength + 1] << 8) + onePacket[packetLength]))
                        {
                            serialDataQueue.RemoveRange(0, packetLength+2);
                            return false;
                        }
                    }
                    else
                    {
                        packetLength = 0;  //重新查找
                        return false;
                    }

                }
                else
                {
                    serialDataQueue.RemoveRange(0, headIndex + 2);  //移除前两个字节  继续查找
                    return false;
                }

                return true;
            }

            private static readonly UInt16[] crc16Table =
            {
                0x0000, 0xC0C1, 0xC181, 0x0140, 0xC301, 0x03C0, 0x0280, 0xC241, 0xC601, 0x06C0, 0x0780, 0xC741, 0x0500, 0xC5C1, 0xC481, 0x0440,
                0xCC01, 0x0CC0, 0x0D80, 0xCD41, 0x0F00, 0xCFC1, 0xCE81, 0x0E40, 0x0A00, 0xCAC1, 0xCB81, 0x0B40, 0xC901, 0x09C0, 0x0880, 0xC841,
                0xD801, 0x18C0, 0x1980, 0xD941, 0x1B00, 0xDBC1, 0xDA81, 0x1A40, 0x1E00, 0xDEC1, 0xDF81, 0x1F40, 0xDD01, 0x1DC0, 0x1C80, 0xDC41,
                0x1400, 0xD4C1, 0xD581, 0x1540, 0xD701, 0x17C0, 0x1680, 0xD641, 0xD201, 0x12C0, 0x1380, 0xD341, 0x1100, 0xD1C1, 0xD081, 0x1040,
                0xF001, 0x30C0, 0x3180, 0xF141, 0x3300, 0xF3C1, 0xF281, 0x3240, 0x3600, 0xF6C1, 0xF781, 0x3740, 0xF501, 0x35C0, 0x3480, 0xF441,
                0x3C00, 0xFCC1, 0xFD81, 0x3D40, 0xFF01, 0x3FC0, 0x3E80, 0xFE41, 0xFA01, 0x3AC0, 0x3B80, 0xFB41, 0x3900, 0xF9C1, 0xF881, 0x3840,
                0x2800, 0xE8C1, 0xE981, 0x2940, 0xEB01, 0x2BC0, 0x2A80, 0xEA41, 0xEE01, 0x2EC0, 0x2F80, 0xEF41, 0x2D00, 0xEDC1, 0xEC81, 0x2C40,
                0xE401, 0x24C0, 0x2580, 0xE541, 0x2700, 0xE7C1, 0xE681, 0x2640, 0x2200, 0xE2C1, 0xE381, 0x2340, 0xE101, 0x21C0, 0x2080, 0xE041,
                0xA001, 0x60C0, 0x6180, 0xA141, 0x6300, 0xA3C1, 0xA281, 0x6240, 0x6600, 0xA6C1, 0xA781, 0x6740, 0xA501, 0x65C0, 0x6480, 0xA441,
                0x6C00, 0xACC1, 0xAD81, 0x6D40, 0xAF01, 0x6FC0, 0x6E80, 0xAE41, 0xAA01, 0x6AC0, 0x6B80, 0xAB41, 0x6900, 0xA9C1, 0xA881, 0x6840,
                0x7800, 0xB8C1, 0xB981, 0x7940, 0xBB01, 0x7BC0, 0x7A80, 0xBA41, 0xBE01, 0x7EC0, 0x7F80, 0xBF41, 0x7D00, 0xBDC1, 0xBC81, 0x7C40,
                0xB401, 0x74C0, 0x7580, 0xB541, 0x7700, 0xB7C1, 0xB681, 0x7640, 0x7200, 0xB2C1, 0xB381, 0x7340, 0xB101, 0x71C0, 0x7080, 0xB041,
                0x5000, 0x90C1, 0x9181, 0x5140, 0x9301, 0x53C0, 0x5280, 0x9241, 0x9601, 0x56C0, 0x5780, 0x9741, 0x5500, 0x95C1, 0x9481, 0x5440,
                0x9C01, 0x5CC0, 0x5D80, 0x9D41, 0x5F00, 0x9FC1, 0x9E81, 0x5E40, 0x5A00, 0x9AC1, 0x9B81, 0x5B40, 0x9901, 0x59C0, 0x5880, 0x9841,
                0x8801, 0x48C0, 0x4980, 0x8941, 0x4B00, 0x8BC1, 0x8A81, 0x4A40, 0x4E00, 0x8EC1, 0x8F81, 0x4F40, 0x8D01, 0x4DC0, 0x4C80, 0x8C41,
                0x4400, 0x84C1, 0x8581, 0x4540, 0x8701, 0x47C0, 0x4680, 0x8641, 0x8201, 0x42C0, 0x4380, 0x8341, 0x4100, 0x81C1, 0x8081, 0x4040,

             };

            private static UInt16 CalcArrayCrc16(byte[] data, int dataLen)  //crc16 查表法
            {
                int i = 0;
                byte nTemp;
                UInt16 crc = 0xFFFF;

                while (dataLen > 0)
                {
                    dataLen--;
                    nTemp = (byte)(data[i] ^ crc);
                    crc >>= 8;
                    crc ^= crc16Table[nTemp];
                    i++;
                }
                return crc;
            }

            public void getNewPacket(Byte[] buf,int len) //出队
            {
                serialDataQueue.CopyTo(0,buf,0,len);
                serialDataQueue.RemoveRange(0,len);
            }

            public void dataToQueue(Byte[] buf)  //入队
            {
                serialDataQueue.AddRange(buf);
            }
        }

        private SerialPortByteQueue serialByteQueue = new SerialPortByteQueue();
        private delegate void serialPort1_DataReceivedDelegate(string msg);  //定义相应事件处理函数委托
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)//串口数据接收
        {
            try
            {

                Byte[] dataReceived = new Byte[serialPort1.BytesToRead];  //数据接收数组
                serialPort1.Read(dataReceived, 0, dataReceived.Length);     //读取数据
                serialPort1.DiscardInBuffer();//清空缓冲区

                serialByteQueue.dataToQueue(dataReceived);
                while(serialByteQueue.PacketCheck())
                {
                    Byte[] newPacket = new Byte[serialByteQueue.getPacketLength()];
                    serialByteQueue.getNewPacket(newPacket,newPacket.Length);

                    string revStr = null;
                    for (int i = 0; i < newPacket.Length; i++)
                    {
                        revStr += newPacket[i].ToString("X2"); //16进制
                    }
                    serialPortDataDelegateShow(revStr);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static int writeLines = 0;
        private void serialPortDataDelegateShow(string s)
        {
            char[] XYZData = new char[12];
            s.CopyTo(6, XYZData, 0, 12);

            Int16 XData, YData, ZData;
            XData = Convert.ToInt16(XYZData[0].ToString() + XYZData[1].ToString() + XYZData[2].ToString() + XYZData[3].ToString(), 16);
            YData = Convert.ToInt16(XYZData[4].ToString() + XYZData[5].ToString() + XYZData[6].ToString() + XYZData[7].ToString(), 16);
            ZData = Convert.ToInt16(XYZData[8].ToString() + XYZData[9].ToString() + XYZData[10].ToString() + XYZData[11].ToString(), 16);
            if (chartForXYZ.InvokeRequired)
            {
                //Lambda表达式 匿名委托  Lambda给指定委托填写对应方法的简化写法
                this.Invoke(new Action(() =>
                    {
                        chartForXYZ.Series[0].Points.AddY(XData);
                        chartForXYZ.Series[1].Points.AddY(YData);
                        chartForXYZ.Series[2].Points.AddY(ZData);

                        if (chartForXYZ.Series[0].Points.Count >= chartForXYZ.ChartAreas[0].AxisX.Maximum)
                        {
                            chartForXYZ.Series[0].Points.RemoveAt(0);
                            chartForXYZ.Series[1].Points.RemoveAt(0);
                            chartForXYZ.Series[2].Points.RemoveAt(0);
                        }
                    }
                    ));
            }
            else
            {
                chartForXYZ.Series[0].Points.AddY(XData);
                chartForXYZ.Series[1].Points.AddY(YData);
                chartForXYZ.Series[2].Points.AddY(ZData);
            }
            
            if (richTextBox1.InvokeRequired)  //判断是否需要调用Invoke函数进行处理，保证线程安全
            {
                int boxTextLine = (int)(richTextBox1.Height / (richTextBox1.Font.Height+ richTextBox1.Font.Size));
                if (writeLines> (boxTextLine+1))  //+1：Show multiple rows
                {
                    writeLines = 0;
                    this.Invoke(new Action(() =>
                    {
                        richTextBox1.Clear();
                    }
                    ));
                }
                writeLines++;

                int dataLength = (s.Length / 2)+ s.Length;
                char[] data = new char[dataLength];
                for (int i=0,j=0;i<data.Length;i++)
                {
                    if (((i+1)%3)==0)
                    {
                        data[i] = ' ';
                    }
                    else
                    {
                        data[i] = s[j++];
                    }
                }
                string strData = string.Join("",data);

                string showData = '['+DateTime.Now.ToString()+']'+ strData+"\r\n";
                this.Invoke(new Action(() =>
                {
                    richTextBox1.Text += showData;
                }
                ));
            }
            else
            {
                richTextBox1.Text += s + "\r\n";
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            timerForSerialAutoScan.Stop(); 
        }

        private void timerForSerialAutoScan_Tick(object sender, EventArgs e)  //在串口打开后应当关闭
        {
            SearchAndAddSerialToComboBox(serialPort1, comboBoxForSerialPort);

            //以下为模拟测试
            //Random r = new Random();
            //int t = DateTime.Now.Second;

            //if (chartForXYZ.Series[0].Points.Count >= chartForXYZ.ChartAreas[0].AxisX.Maximum)
            //{
            //    chartForXYZ.Series[0].Points.RemoveAt(0);
            //    chartForXYZ.Series[1].Points.RemoveAt(0);
            //    chartForXYZ.Series[2].Points.RemoveAt(0);
            //}
            //chartForXYZ.Series[0].Points.AddY(r.Next(-32760, 32760));
            //chartForXYZ.Series[1].Points.AddY(r.Next(-32760, 32760));
            //chartForXYZ.Series[2].Points.AddY(r.Next(-32760, 32760));

        }

        private void chartForXYZ_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            if (e.HitTestResult.ChartElementType==ChartElementType.DataPoint)
            {
                int i = e.HitTestResult.PointIndex;
                DataPoint dp = e.HitTestResult.Series.Points[i];
                e.Text = string.Format("{0:N0}",dp.YValues[0]);
            }
        }

        /* 数据点自动选中和显示（可同时多轴数据显示）待完善 */
        //[DllImport("User32.dll")]  //引用user32.dll动态链接库
        //private static extern bool SetCursorPos(int x,int y);  //使用库中定义的api
        //private void chartForXYZ_MouseMove(object sender, MouseEventArgs e)
        //{
        //    //double xViewMinPixelPos = chartForXYZ.ChartAreas[0].AxisX.ValueToPixelPosition(chartForXYZ.ChartAreas[0].AxisX.ScaleView.ViewMinimum);  //转换为对应的像素坐标
        //    //double xViewMaxPixelPos = chartForXYZ.ChartAreas[0].AxisX.ValueToPixelPosition(chartForXYZ.ChartAreas[0].AxisX.ScaleView.ViewMaximum);
        //    ////double yViewMinPixelPos = chartForXYZ.ChartAreas[0].AxisY.ValueToPixelPosition(chartForXYZ.ChartAreas[0].AxisY.ScaleView.ViewMinimum);
        //    ////double yViewMaxPixelPos = chartForXYZ.ChartAreas[0].AxisY.ValueToPixelPosition(chartForXYZ.ChartAreas[0].AxisY.ScaleView.ViewMaximum);

        //    //if ((e.X >= xViewMinPixelPos) && (e.X <= xViewMaxPixelPos))
        //    //{//在chart图表数据示图内
        //    //    //ToolTipEventArgs tip= chartForXYZ_GetToolTipText;

        //    //    var area = chartForXYZ.ChartAreas[0];
        //    //    double xValue = chartForXYZ.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
        //    //    double yValue = chartForXYZ.ChartAreas[0].AxisX.PixelPositionToValue(e.Y);
        //    //}
        //}

        private void AxisXDisplay_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxXDisplay.Checked)
            {
                chartForXYZ.Series[0].Enabled = true;
            }
            else
            {
                chartForXYZ.Series[0].Enabled = false;
            }
        }

        private void AxisYDisplay_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxYDisplay.Checked)
            {
                chartForXYZ.Series[1].Enabled = true;
            }
            else
            {
                chartForXYZ.Series[1].Enabled = false;
            }
        }

        private void AxisZDisplay_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxZDisplay.Checked)
            {
                chartForXYZ.Series[2].Enabled = true;
            }
            else
            {
                chartForXYZ.Series[2].Enabled = false;
            }
        }

        private void AxisXMark_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBoxXDisplay.Checked) && (checkBoxXMark.Checked))
            {
                chartForXYZ.Series[0].MarkerStyle = MarkerStyle.Circle;
            }
            else
            {
                chartForXYZ.Series[0].MarkerStyle = MarkerStyle.None;
            }
        }

        private void AxisYMark_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBoxYDisplay.Checked)&&(checkBoxYMark.Checked))
            {
                chartForXYZ.Series[1].MarkerStyle = MarkerStyle.Circle;
            }
            else
            {
                chartForXYZ.Series[1].MarkerStyle = MarkerStyle.None;
            }
        }

        private void AxisZMark_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBoxZDisplay.Checked) && (checkBoxZMark.Checked))
            {
                chartForXYZ.Series[2].MarkerStyle = MarkerStyle.Circle;
            }
            else
            {
                chartForXYZ.Series[2].MarkerStyle = MarkerStyle.None;
            }
        }
    }
    }





