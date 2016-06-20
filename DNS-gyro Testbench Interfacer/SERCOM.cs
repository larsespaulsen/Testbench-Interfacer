using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;

namespace DNS_gyro_Testbench_Interfacer
{
    public partial class Interfacer
    {
        static SerialPort _serialPort;
        static bool _continue;

        private Object serialLock = new Object();
        string serialData = " ";

        public void SerialInitialize()
        {
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
            foreach (string s in SerialPort.GetPortNames())
            {
                comList.Items.Add(s);
            }
            update_ComStatus(this, new EventArgs());
        }

        private void bt_serialConnect_Click(object sender, EventArgs e)
        {
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
            if (!_continue)
            {
                _serialPort.Open();
                _continue = true;
                backgroundWorker1.RunWorkerAsync();
                bt_serialConnect.Text = "Disconnect";
                statusStrip1.Text = "Connected";
            }
            else
            {
                _continue = false;
                bt_serialConnect.Text = "Connect";
                statusStrip1.Text = "Disconnected";
                //backgroundWorker1.CancelAsync();
            }
        }
        private void serial_Read_Worker(object sender, DoWorkEventArgs e)
        {
            while (_continue)
            {
                try
                {
                    string message = _serialPort.ReadLine();
                    lock (serialLock)
                    {
                        serialData = message.ToString();
                    }

                }
                catch (TimeoutException) { }
            }
            _serialPort.Close();
        }
    }
}