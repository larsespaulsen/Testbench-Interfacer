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
using System.Globalization;

//99 little bugs in the code
//99 bugs in the code
//Take one down, patch it around
//117 little bugs in the code

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

        public int CurrentCarrier;

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

            switch (serialData.Substring(0,24))
            {

                case "Carrier I2C address     ":
                    //Start of Initializing Carrier
                    Carriers[InitializedCarriers] = new Carrier();
                    Carriers[InitializedCarriers].Carrier_I2C_address = serialData.Substring(27);
                    break;

                case "Carrier serial number   ":
                    Carriers[InitializedCarriers].Carrier_serial_number = serialData.Substring(27);
                    Add_Carrier_List_Item(Carriers[InitializedCarriers].Carrier_serial_number + "@" + Carriers[InitializedCarriers].Carrier_I2C_address);

                    
                    break;

                case "Sensor 1 name           ":
                    Carriers[InitializedCarriers].Sensor_1_name = serialData.Substring(27);
                    break;

                case "Sensor 2 name           ":
                    Carriers[InitializedCarriers].Sensor_2_name = serialData.Substring(27);
                    break;

                case "Sensor 1 active sensors ":
                    Carriers[InitializedCarriers].Sensor_1_active_sensors = Int32.Parse(serialData.Substring(27));
                    break;

                case "Sensor 1 installed bitma":
                    Carriers[InitializedCarriers].Sensor_1_installed_bitmap = Int32.Parse(serialData.Substring(27));
                    break;

                case "Sensor 1 enabled bitmap ":
                    Carriers[InitializedCarriers].Sensor_1_enabled_bitmap = Int32.Parse(serialData.Substring(27));
                    break;

                case "Sensor 1 faulty bitmap  ":
                    Carriers[InitializedCarriers].Sensor_1_faulty_bitmap = Int32.Parse(serialData.Substring(27));
                    break;

                case "Sensor 2 active sensors ":
                    Carriers[InitializedCarriers].Sensor_2_active_sensors = Int32.Parse(serialData.Substring(27));
                    break;

                case "Sensor 2 installed bitma":
                    Carriers[InitializedCarriers].Sensor_2_installed_bitmap = Int32.Parse(serialData.Substring(27));
                    break;

                case "Sensor 2 enabled bitmap ":
                    Carriers[InitializedCarriers].Sensor_2_enabled_bitmap = Int32.Parse(serialData.Substring(27));
                    break;

                case "Sensor 2 faulty bitmap  ":
                    Carriers[InitializedCarriers].Sensor_2_failty_bitmap = Int32.Parse(serialData.Substring(27));
                    break;

                case "Encoder offset          ":
                    Carriers[InitializedCarriers].Encoder_offset = Int32.Parse(serialData.Substring(27));
                    break;

                case "Sensor 1 Raw data format":
                    Carriers[InitializedCarriers].Sensor_1_Raw_data_format = Int32.Parse(serialData.Substring(27));
                    break;

                case "Sensor 2 Raw data format":
                    Carriers[InitializedCarriers].Sensor_2_Raw_data_format = Int32.Parse(serialData.Substring(27));
                    
                    break;

                case "Sensor 1 Sample rate    ":
                    Carriers[InitializedCarriers].Sensor_1_Sample_rate = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Sensor 1 Scale factor X ":
                    Carriers[InitializedCarriers].Sensor_1_Scale_factor_X = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Sensor 1 Scale factor Y ":
                    Carriers[InitializedCarriers].Sensor_1_Scale_factor_Y = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Sensor 1 Scale factor Z ":
                    Carriers[InitializedCarriers].Sensor_1_Scale_factor_Z = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Sensor 1 SF Tempco X    ":
                    Carriers[InitializedCarriers].Sensor_1_SF_Tempco_X = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Sensor 1 SF Tempco Y    ":
                    Carriers[InitializedCarriers].Sensor_1_SF_Tempco_Y = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Sensor 1 SF Tempco Z    ":
                    Carriers[InitializedCarriers].Sensor_1_SF_Tempco_Z = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Sensor 1 Offset X       ":
                    Carriers[InitializedCarriers].Sensor_1_Offset_X = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Sensor 1 Offset Y       ":
                    Carriers[InitializedCarriers].Sensor_1_Offset_Y = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Sensor 1 Offset Z       ":
                    Carriers[InitializedCarriers].Sensor_1_Offset_Z = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Sensor 1 Offset Tempco X":
                    Carriers[InitializedCarriers].Sensor_1_Offset_Tempco_X = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Sensor 1 Offset Tempco Y":
                    Carriers[InitializedCarriers].Sensor_1_Offset_Tempco_Y = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Sensor 1 Offset Tempco Z":
                    Carriers[InitializedCarriers].Sensor_1_Offset_Tempco_Z = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Sensor 1 Misalign Alpha ":
                    Carriers[InitializedCarriers].Sensor_1_Misalign_Alpha = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Sensor 1 Misalign Beta  ":
                    Carriers[InitializedCarriers].Sensor_1_Misalign_Beta = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Sensor 1 Misalign Gamma ":
                    Carriers[InitializedCarriers].Sensor_1_Misalign_Gamma = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Sensor 2 Sample rate    ":
                    Carriers[InitializedCarriers].Sensor_2_Sample_rate = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Sensor 2 Scale factor X ":
                    Carriers[InitializedCarriers].Sensor_2_Scale_factor_X = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Sensor 2 Scale factor Y ":
                    Carriers[InitializedCarriers].Sensor_2_Scale_factor_Y = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Sensor 2 Scale factor Z ":
                    Carriers[InitializedCarriers].Sensor_2_Scale_factor_Z = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Sensor 2 SF Tempco X    ":
                    Carriers[InitializedCarriers].Sensor_2_SF_Tempco_X = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Sensor 2 SF Tempco Y    ":
                    Carriers[InitializedCarriers].Sensor_2_SF_Tempco_Y = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Sensor 2 SF Tempco Z    ":
                    Carriers[InitializedCarriers].Sensor_2_SF_Tempco_Z = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Sensor 2 Offset X       ":
                    Carriers[InitializedCarriers].Sensor_2_Offset_X = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Sensor 2 Offset Y       ":
                    Carriers[InitializedCarriers].Sensor_2_Offset_Y = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Sensor 2 Offset Z       ":
                    Carriers[InitializedCarriers].Sensor_2_Offset_Z = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Sensor 2 Offset Tempco X":
                    Carriers[InitializedCarriers].Sensor_2_Offset_Tempco_X = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Sensor 2 Offset Tempco Y":
                    Carriers[InitializedCarriers].Sensor_2_Offset_Tempco_Y = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Sensor 2 Offset Tempco Z":
                    Carriers[InitializedCarriers].Sensor_2_Offset_Tempco_Z = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Sensor 2 Misalign Alpha ":
                    Carriers[InitializedCarriers].Sensor_2_Misalign_Alpha = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Sensor 2 Misalign Beta  ":
                    Carriers[InitializedCarriers].Sensor_2_Misalign_Beta = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Sensor 2 Misalign Gamma ":
                    Carriers[InitializedCarriers].Sensor_2_Misalign_Gamma = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Temperature offset      ":
                    Carriers[InitializedCarriers].Temperature_offset = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    break;

                case "Temperature scale factor":
                    Carriers[InitializedCarriers].Temperature_scale_factor = float.Parse(serialData.Substring(28), CultureInfo.InvariantCulture);
                    //Increment when done Initializing Carrier
                    InitializedCarriers++;
                    break;

                //case "No carrier at this I2C a":
                //    break;

                default:
                    Invoke(new Action(() => Console.AppendText(serialData)));
                    break;
            }
        }

        private void Add_Carrier_List_Item(string text)
        {
            if (this.listBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(Add_Carrier_List_Item);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                if (!listBox1.Items.Contains(text))
                {
                    listBox1.Items.Add(text);
                }
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
        //public float sensor_1_weight[16];
        //public float sensor_2_weight[16];
    }
}
