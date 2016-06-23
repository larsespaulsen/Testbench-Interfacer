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
            fileInitialize();
            
            //var timer = new System.Windows.Forms.Timer();
            //timer.Tick += new EventHandler(parse);
            //timer.Interval = 100; //100 ms
            //timer.Start();
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
            Console.Clear();
            serial_Write(sendMessage.Text);
        }

        delegate void SetTextCallback(string text);


        //open file dialog
        private void button1_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                //file = openFileDialog1;
                string filename = openFileDialog1.FileName;
                try
                {
                    string text = System.IO.File.ReadAllText(filename);
                    size = text.Length;
                }
                catch //(IOException)
                {
                    //TODO
                }
            }
        }

        private void bt_Reload_Carrier_List_Click(object sender, EventArgs e)
        {
            try
            {
                SendWorker.RunWorkerAsync();
            }
            catch (Exception ex)
            { 
                if (ex is InvalidOperationException)
                {
                    MessageBox.Show("BUSY!");
                }
                else
                {
                    throw;
                }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = listBox1.GetItemText(listBox1.SelectedItem);
            for (int i = 0; i < InitializedCarriers; i++)
            {
                try
                {
                    if (Carriers[i].Carrier_serial_number.Substring(0, 4) == selected.Substring(0, 4))
                    {
                        Carrier_serial_number.Text = Carriers[i].Carrier_serial_number;

                        CurrentCarrier = i;
                    }
                }
                catch (Exception ex)
                {
                    if (ex is ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("Argument is out of range");
                    }
                    else if (ex is FormatException)
                    {
                        MessageBox.Show("Format Exception");
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            
        }

        private void bt_Set_Carrier_Click(object sender, EventArgs e)
        {
            Console.Clear();
            string carrierSettings = "DW" + Carriers[CurrentCarrier].Carrier_I2C_address.Substring(2, 3) + ",ADXRS290,None," + Carriers[CurrentCarrier].Carrier_serial_number;
            serial_Write(carrierSettings);
            textBox7.Text = carrierSettings;
        }

        private void Carrier_Name_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Carrier_serial_number = Carrier_serial_number.Text;
        }

        private void Find_Carriers(object sender, DoWorkEventArgs e)
        {
            Invoke(new Action(() => progressBar1.Maximum = 16));
            Invoke(new Action(() => progressBar1.Value = 0));
            Invoke(new Action(() => Console.Clear()));
            int Addr;
            for (int i = 0; i < 16; i++)
            {
                Addr = 20 + i;
                serial_Write("DR" + Addr.ToString());
                Invoke(new Action(() => progressBar1.Increment(1)));
            }
        }

        private void bt_Reload_Carrier_List_Click_1(object sender, EventArgs e)
        {
            SendWorker.RunWorkerAsync();
        }

    }
}

