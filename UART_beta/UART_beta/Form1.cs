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

namespace UART_beta
{
    public partial class Form1 : Form
    {
        SerialPort ComPort = new SerialPort();
        Byte[] WriteBuffer = new Byte[11];

        public Form1() //main
        {
            InitializeComponent();
            button_Disconnect.Enabled = false;
            comboBox_Com.Items.Clear();
            String[] a = SerialPort.GetPortNames(); //回傳String Array
            if (a.Length > 0)
            {
                for (int i = 0; i < a.Length; i++)
                    comboBox_Com.Items.Add(a[i]);
            }
        }

        private void comboBox_Com_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            ComPort.BaudRate = Convert.ToInt32(comboBox_BaudRate.Text);
            //serialPort1.BaudRate = 9600;
            ComPort.PortName = comboBox_Com.Text;
            ComPort.Parity = Parity.None;   //關閉同位元檢查法
            ComPort.DataBits = 8;   //5-8
            ComPort.StopBits = StopBits.One;    //StopBits就是資料停止位元，代表這組資料單元到此為止(這裡使用一個停止位元)
            ComPort.ReadTimeout = 1000;
            ComPort.WriteTimeout = 1000;
            if ((ComPort != null) && (!ComPort.IsOpen))
            {
                ComPort.Open();
            }
            button_connect.Enabled = false;
            button_Disconnect.Enabled = true;
            //serialPort1.BaudRate
        }

        private void comboBox_BaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox_BaudRate.
        }

        private void button_ComUpdate_Click(object sender, EventArgs e)
        {
            comboBox_Com.Items.Clear();
            string[] a = SerialPort.GetPortNames(); //回傳String Array
            if (a.Length > 0)
            {
                for (int i = 0; i < a.Length; i++)
                    comboBox_Com.Items.Add(a[i]);
                comboBox_Com.SelectedIndex = 0;
            }
            else
            {

            }
        }

        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            ComPort.Close();
            button_connect.Enabled = true;
            button_Disconnect.Enabled = false;
        }

        private void Send_Click(object sender, EventArgs e)
        {
            WriteBuffer[0] = 0x11;
            WriteBuffer[1] = 0x22;
            WriteBuffer[2] = 0x01;
            WriteBuffer[3] = 0x02;
            WriteBuffer[4] = 0x03;
            WriteBuffer[5] = 0x04;
            WriteBuffer[6] = 0x05;
            WriteBuffer[7] = ;

            ComPort.Write(WriteBuffer, 0, WriteBuffer.Length);
        }

    }
}
