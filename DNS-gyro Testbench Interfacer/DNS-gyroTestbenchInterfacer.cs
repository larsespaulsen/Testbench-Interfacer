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

        private List<string> contents = new List<string>();
        private const int MAX = 50;

        private bool booted = false;


        public Form1()
        {

            //var timer = new System.Windows.Forms.Timer();
            //timer.Tick += new EventHandler(update_Console);
            //timer.Interval = 100; //100 ms
            //timer.Start();



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
            ComStatus.Text = "This is a TextBox control.";

            statusStrip1.Text = "Disconnected";

            foreach (string s in SerialPort.GetPortNames())
            {
                comList.Items.Add(s);
            }
            update_ComStatus(this, new EventArgs());
        }

        private void Baudrate_TextChanged(object sender, EventArgs e)
        {
            _serialPort.BaudRate = Int32.Parse(Baudrate.Text);
            update_ComStatus(this, e);
        }

        private void comList_SelectChanged(object sender, EventArgs e)
        {
            _serialPort.PortName = comList.SelectedItem.ToString();
            update_ComStatus(this, e);
        }

        private void update_ComStatus(object sender, EventArgs e)
        {
                ComStatus.Text = "Port: " + _serialPort.PortName
                + "\nBaudrate: " + _serialPort.BaudRate.ToString()
                + "\nParity: " + _serialPort.Parity
                + "\nDataBits: " + _serialPort.DataBits.ToString()
                + "\nStopBits: " + _serialPort.StopBits
                + "\nHandshake: " + _serialPort.Handshake;
        }

        private void update_Console(object sender, EventArgs e)
        {
            if (_continue) {  }
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


        private void bt_send_Click(object sender, EventArgs e)
        {
            _serialPort.WriteLine(sendMessage.Text);
        }

        private void serial_Read_Worker(object sender, DoWorkEventArgs e)
        {
            while (_continue)
            {
                try
                {
                    string message = _serialPort.ReadLine();
                    lock (serialLock) { serialData = message.ToString();

                        switch (serialData[0])
                        {
                            case '2':
                                set_Carrier_Text(serialData);
                                break;
                            default:
                                set_Console_Text(serialData);
                                break;
                        }

                        
                    }
                   
                }
                catch (TimeoutException) { }
            }
            _serialPort.Close();
        }




        delegate void SetTextCallback(string text);

        private void set_Console_Text(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.Console.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(set_Console_Text);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                        this.Console.AppendText(text);                
            }
        }

        private void set_Carrier_Text(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.Carrier.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(set_Carrier_Text);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                Carrier.Text = text;
            }
        }
    }
}

