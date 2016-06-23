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
        public static Carrier[] Carriers = new Carrier[16];
        public static int InitializedCarriers = 0;

        private void fileInitialize()
        {
            //TODO Check if file and folders excists
            currentLogFileName = string.Format("{0:yyyy-MM-dd-HH-mm-ss}", DateTime.Now) + ".txt";// There are following custom format specifiers y (year), M (month), d (day), h (hour 12), H (hour 24), m (minute), s (second), f (second fraction), F (second fraction, trailing zeroes are trimmed), t (P.M or A.M) and z (time zone).
            startUpPath = /*TODO RELEASE USES CURRENT DIR + \log*/ Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "log");
            logfolder = Path.Combine(startUpPath, currentLogFileName);
            fs = File.Create(logfolder);
            file = new StreamWriter(fs);
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
                //case '0':
                //    set_Textbox5_Text("Address" + serialData[2] + serialData[3]);
                //    break;

                case '2':                    
                    set_Carrier_Text(serialData);
                    file.WriteLine(serialData);
                    break;

                //Detect carriers
                case 'C':
                        switch(serialData[8])
                        {
                        case 'I':
                            set_Console_Text("CASE 'I'"+serialData);
                            Carriers[InitializedCarriers] = new Carrier();
                            Carriers[InitializedCarriers].Carrier_I2C_address = serialData.Substring(27);
                            break;

                        case 's':
                            set_Console_Text("CASE 's'"+serialData);
                            Carriers[InitializedCarriers].Carrier_serial_number = serialData.Substring(27);
                            Add_Carrier_List_Item(Carriers[InitializedCarriers].Carrier_serial_number + "@" + Carriers[InitializedCarriers].Carrier_I2C_address);

                            //Increment when done
                            InitializedCarriers++;
                            break;

                        default:
                            set_Console_Text(serialData);
                            break;
                        }
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
            if (this.Carrier_Name.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(set_Textbox5_Text);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                Carrier_Name.Text = text;
            }
        }

        private void Add_Carrier_List_Item(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.listBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(Add_Carrier_List_Item);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                listBox1.Items.Add(text);
            }
        }

        private void detect_Carriers()
        {
            listBox1.Items.Clear();
            progressBar1.Value = 0;
            Console.Clear();
            int Addr;
            for (int i = 0; i < 16; i++)
            {
                Addr = 20 + i;
                serial_Write("DR" + Addr.ToString());
                Thread.Sleep(100);
                progressBar1.PerformStep();              
            }
        }

    }

    public class Carrier
    {
        public string Carrier_I2C_address;
        public string Carrier_serial_number;
        public string Sensor_1_name;
        public string Sensor_2_name;
        public int Sensor_1_active_sensors;
        public int Sensor_1_installed_bitmap;
        public int Sensor_1_enabled_bitmap;
        public int Sensor_1_faulty_bitmap;
        public int Sensor_2_active_sensors;
        public int Sensor_2_installed_bitmap;
        public int Sensor_2_enabled_bitmap;
        public int Sensor_2_failty_bitmap;
        public int Encoder_offset;
        public int Sensor_1_Raw_data_format;
        public int Sensor_2_Raw_data_format;
        public float Sensor_1_Sample_rate;
        public float Sensor_1_Scale_factor_X;
        public float Sensor_1_Scale_factor_Y;
        public float Sensor_1_Scale_factor_Z;
        public float Sensor_1_SF_Tempco_X;
        public float Sensor_1_SF_Tempco_Y;
        public float Sensor_1_SF_Tempco_Z;
        public float Sensor_1_Offset_X;
        public float Sensor_1_Offset_Y;
        public float Sensor_1_Offset_Z;
        public float Sensor_1_Offset_Tempco_X;
        public float Sensor_1_Offset_Tempco_Y;
        public float Sensor_1_Offset_Tempco_Z;
        public float Sensor_1_Misalign_Alpha;
        public float Sensor_1_Misalign_Beta;
        public float Sensor_1_Misalign_Gamma;
        public float Sensor_2_Sample_rate;
        public float Sensor_2_Scale_factor_X;
        public float Sensor_2_Scale_factor_Y;
        public float Sensor_2_Scale_factor_Z;
        public float Sensor_2_SF_Tempco_X;
        public float Sensor_2_SF_Tempco_Y;
        public float Sensor_2_SF_Tempco_Z;
        public float Sensor_2_Offset_X;
        public float Sensor_2_Offset_Y;
        public float Sensor_2_Offset_Z;
        public float Sensor_2_Offset_Tempco_X;
        public float Sensor_2_Offset_Tempco_Y;
        public float Sensor_2_Offset_Tempco_Z;
        public float Sensor_2_Misalign_Alpha;
        public float Sensor_2_Misalign_Beta;
        public float Sensor_2_Misalign_Gamma;
        public float Temperature_offset;
        public float Temperature_scale_factor;
    }
}
