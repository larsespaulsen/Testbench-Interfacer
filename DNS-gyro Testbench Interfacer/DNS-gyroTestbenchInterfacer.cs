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
    public partial class Interfacer : Form
    {
        private List<string> contents = new List<string>();
        private const int MAX = 50;
        private bool booted = false;

        public Interfacer()
        {


            InitializeComponent();
            SerialInitialize();
            update_ComStatus(this, new EventArgs());
            statusStrip1.Text = "Disconnected";

            var timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(parse);
            timer.Interval = 100; //100 ms
            timer.Start();
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

        private void bt_send_Click(object sender, EventArgs e)
        {
            _serialPort.WriteLine(sendMessage.Text);
        }

        delegate void SetTextCallback(string text);


    }
}

