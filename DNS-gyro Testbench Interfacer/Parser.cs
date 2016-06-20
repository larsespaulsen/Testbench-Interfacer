using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
        private string startUpPath;
        private string currentLogFileName;
        private string logfolder;
        FileStream fs;
        StreamWriter file;
        //public string LogKeyWord_text;

        private void fileInitialize()
        {
            //TODO Check if file and folders excists
            currentLogFileName = string.Format("{0:yyyy-MM-dd-HH-mm-ss}", DateTime.Now) + ".txt";// There are following custom format specifiers y (year), M (month), d (day), h (hour 12), H (hour 24), m (minute), s (second), f (second fraction), F (second fraction, trailing zeroes are trimmed), t (P.M or A.M) and z (time zone).
            startUpPath = /*TODO RELEASE USES CURRENT DIR + \log*/ Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "log");
            logfolder = Path.Combine(startUpPath, currentLogFileName);
            fs = File.Create(logfolder);
            file = new StreamWriter(fs) ;
        }

        private void fileClose()
        {
            file.Close();
        }

        private void parse(object sender, EventArgs e)
        {
            //if(serialData[0] == LogKeyWord.Text[0]) file.WriteLine(serialData);

            switch (serialData[0])
            {
                case '0':
                    set_Textbox5_Text("Address" + serialData[2] + serialData[3]);
                    break;

                case '2':                    
                    set_Carrier_Text(serialData);
                    file.WriteLine(serialData);
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

        private void set_Textbox5_Text(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.textBox5.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(set_Textbox5_Text);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                textBox5.Text = text;
            }
        }
    }
}
