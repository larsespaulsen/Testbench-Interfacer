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

        private void parse(object sender, EventArgs e)
        {
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
