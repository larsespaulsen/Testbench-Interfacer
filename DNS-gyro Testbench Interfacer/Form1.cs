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
using System.Threading;
using SERCOM;
using System.Timers;

namespace DNS_gyro_Testbench_Interfacer
{
    public partial class Form1 : Form
    {
        
        static SerialPort _serialPort;
        static bool _continue;

        private Object serialLock = new Object();
        string serialData = " ";
        private bool booted = false;

        public Form1()
        {

            var timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(UpdateConsole);
            timer.Interval = 100; //100 ms
            timer.Start();



            InitializeComponent();
            _serialPort = new SerialPort();
            _serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), "None", true);
            _serialPort.DataBits = 8;
            _serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "One", true);
            _serialPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), "None", true);
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;
            _serialPort.BaudRate = 230400;
            _serialPort.PortName = "COM4";
            _serialPort.Close();
            console.Text = "This is a TextBox control.";

            statusStrip1.Text = "Disconnected";
            foreach (string s in SerialPort.GetPortNames())
            {
                comList.Items.Add(s);
            }
        }

        private void Baudrate_TextChanged(object sender, EventArgs e)
        {
            _serialPort.BaudRate = Int32.Parse(Baudrate.Text);
        }

        private void comList_SelectChanged(object sender, EventArgs e)
        {
            _serialPort.PortName = comList.SelectedItem.ToString();
        }

        private void UpdateConsole(object sender, EventArgs e)
        {
            if (!_continue)
            {
                console.Text = "Port: " + _serialPort.PortName
                + "\nBaudrate: " + _serialPort.BaudRate.ToString()
                + "\nParity: " + _serialPort.Parity
                + "\nDataBits: " + _serialPort.DataBits.ToString()
                + "\nStopBits: " + _serialPort.StopBits
                + "\nHandshake: " + _serialPort.Handshake;
            }
            else
            {
                lock (serialLock) { console.Text = serialData; }
            }

        }

        private void bt_serialConnect_Click(object sender, EventArgs e)
        {

                StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
                Thread readThread = new Thread(serial_Read);

            
            if (!_continue)
            {
                _serialPort.Open();
                _continue = true;
                readThread.Start();
                bt_serialConnect.Text = "Disconnect";
                statusStrip1.Text = "Connected";
            }
            else
            {
                _continue = false;
                readThread.Join();
                _serialPort.Close();
                bt_serialConnect.Text = "Connect";
                statusStrip1.Text = "Disconnected";
            }
        }

        private void serial_Read()
        {
            while (_continue)
            {
                try
                {
                    string message = _serialPort.ReadLine();
                    lock (serialLock) { serialData = message.ToString(); }
                }
                catch (TimeoutException) { }
            }
        }

        private void bt_send_Click(object sender, EventArgs e)
        {
            _serialPort.WriteLine(sendMessage.Text);
        }


    }
}

