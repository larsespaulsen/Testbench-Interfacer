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
using System.Globalization;
using System.Collections;

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
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
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

        private void CarrierList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Invoke(new Action(() => bt_Set_Carrier.Enabled = true));
            string selected = CarrierList.GetItemText(CarrierList.SelectedItem);


            for (int i = 0; i < InitializedCarriers; i++)
            {
                try
                {
                    if (Carriers[i].Carrier_serial_number.Substring(0, 4) == selected.Substring(0, 4))
                    {
                        Carrier_serial_number.Text = Carriers[i].Carrier_serial_number;
                        Sensor_1_name.Text = Carriers[i].Sensor_1_name;
                        Sensor_2_name.Text = Carriers[i].Sensor_2_name;
                        Sensor_1_active_sensors.Text = Carriers[i].Sensor_1_active_sensors.ToString();
                        Sensor_1_installed_bitmap.Text = Carriers[i].Sensor_1_installed_bitmap.ToString();
                        Sensor_1_enabled_bitmap.Text = Carriers[i].Sensor_1_enabled_bitmap.ToString();
                        Sensor_1_faulty_bitmap.Text = Carriers[i].Sensor_1_faulty_bitmap.ToString();
                        Sensor_2_active_sensors.Text = Carriers[i].Sensor_2_active_sensors.ToString();
                        Sensor_2_installed_bitmap.Text = Carriers[i].Sensor_2_installed_bitmap.ToString();
                        Sensor_2_enabled_bitmap.Text = Carriers[i].Sensor_2_enabled_bitmap.ToString();
                        Sensor_2_failty_bitmap.Text = Carriers[i].Sensor_2_failty_bitmap.ToString();
                        Encoder_offset.Text = Carriers[i].Encoder_offset.ToString();
                        Sensor_1_Raw_data_format.Text = Carriers[i].Sensor_1_Raw_data_format.ToString();
                        Sensor_2_Raw_data_format.Text = Carriers[i].Sensor_2_Raw_data_format.ToString();
                        Sensor_1_Sample_rate.Text = Carriers[i].Sensor_1_Sample_rate.ToString();
                        Sensor_1_Scale_factor_X.Text = Carriers[i].Sensor_1_Scale_factor_X.ToString();
                        Sensor_1_Scale_factor_Y.Text = Carriers[i].Sensor_1_Scale_factor_Y.ToString();
                        Sensor_1_Scale_factor_Z.Text = Carriers[i].Sensor_1_Scale_factor_Z.ToString();
                        Sensor_1_SF_Tempco_X.Text = Carriers[i].Sensor_1_SF_Tempco_X.ToString();
                        Sensor_1_SF_Tempco_Y.Text = Carriers[i].Sensor_1_SF_Tempco_Y.ToString();
                        Sensor_1_SF_Tempco_Z.Text = Carriers[i].Sensor_1_SF_Tempco_Z.ToString();
                        Sensor_1_Offset_X.Text = Carriers[i].Sensor_1_Offset_X.ToString();
                        Sensor_1_Offset_Y.Text = Carriers[i].Sensor_1_Offset_Y.ToString();
                        Sensor_1_Offset_Z.Text = Carriers[i].Sensor_1_Offset_Z.ToString();
                        Sensor_1_Offset_Tempco_X.Text = Carriers[i].Sensor_1_Offset_Tempco_X.ToString();
                        Sensor_1_Offset_Tempco_Y.Text = Carriers[i].Sensor_1_Offset_Tempco_Y.ToString();
                        Sensor_1_Offset_Tempco_Z.Text = Carriers[i].Sensor_1_Offset_Tempco_Z.ToString();
                        Sensor_1_Misalign_Alpha.Text = Carriers[i].Sensor_1_Misalign_Alpha.ToString();
                        Sensor_1_Misalign_Beta.Text = Carriers[i].Sensor_1_Misalign_Beta.ToString();
                        Sensor_1_Misalign_Gamma.Text = Carriers[i].Sensor_1_Misalign_Gamma.ToString();
                        Sensor_2_Sample_rate.Text = Carriers[i].Sensor_2_Sample_rate.ToString();
                        Sensor_2_Scale_factor_X.Text = Carriers[i].Sensor_2_Scale_factor_X.ToString();
                        Sensor_2_Scale_factor_Y.Text = Carriers[i].Sensor_2_Scale_factor_Y.ToString();
                        Sensor_2_Scale_factor_Z.Text = Carriers[i].Sensor_2_Scale_factor_Z.ToString();
                        Sensor_2_SF_Tempco_X.Text = Carriers[i].Sensor_2_SF_Tempco_X.ToString();
                        Sensor_2_SF_Tempco_Y.Text = Carriers[i].Sensor_2_SF_Tempco_Y.ToString();
                        Sensor_2_SF_Tempco_Z.Text = Carriers[i].Sensor_2_SF_Tempco_Z.ToString();
                        Sensor_2_Offset_X.Text = Carriers[i].Sensor_2_Offset_X.ToString();
                        Sensor_2_Offset_Y.Text = Carriers[i].Sensor_2_Offset_Y.ToString();
                        Sensor_2_Offset_Z.Text = Carriers[i].Sensor_2_Offset_Z.ToString();
                        Sensor_2_Offset_Tempco_X.Text = Carriers[i].Sensor_2_Offset_Tempco_X.ToString();
                        Sensor_2_Offset_Tempco_Y.Text = Carriers[i].Sensor_2_Offset_Tempco_Y.ToString();
                        Sensor_2_Offset_Tempco_Z.Text = Carriers[i].Sensor_2_Offset_Tempco_Z.ToString();
                        Sensor_2_Misalign_Alpha.Text = Carriers[i].Sensor_2_Misalign_Alpha.ToString();
                        Sensor_2_Misalign_Beta.Text = Carriers[i].Sensor_2_Misalign_Beta.ToString();
                        Sensor_2_Misalign_Gamma.Text = Carriers[i].Sensor_2_Misalign_Gamma.ToString();
                        Temperature_offset.Text = Carriers[i].Temperature_offset.ToString();
                        Temperature_scale_factor.Text = Carriers[i].Temperature_scale_factor.ToString();


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
            try
            {
                Invoke(new Action(() => Console.Clear()));
                string carrierSettings = "DW" + Carriers[CurrentCarrier].Carrier_I2C_address.Substring(2, 3).TrimEnd(new char[] { '\r', '\n', ' ' }) + ","
                + Carriers[CurrentCarrier].Sensor_1_name.TrimEnd(new char[] { '\r', '\n', ' ' }) + ","
                + Carriers[CurrentCarrier].Sensor_2_name.TrimEnd(new char[] { '\r', '\n', ' ' }) + ","
                + Carriers[CurrentCarrier].Carrier_serial_number.TrimEnd(new char[] { '\r', '\n', ' ' }) + ","
                + string_bitmap_to_string_int(Carriers[CurrentCarrier].Sensor_1_installed_bitmap) + ","
                + string_bitmap_to_string_int(Carriers[CurrentCarrier].Sensor_1_enabled_bitmap) + ","
                + string_bitmap_to_string_int(Carriers[CurrentCarrier].Sensor_1_faulty_bitmap) + ","
                + string_bitmap_to_string_int(Carriers[CurrentCarrier].Sensor_2_installed_bitmap) + ","
                + string_bitmap_to_string_int(Carriers[CurrentCarrier].Sensor_2_enabled_bitmap) + ","
                + string_bitmap_to_string_int(Carriers[CurrentCarrier].Sensor_2_failty_bitmap) + ","
                + Carriers[CurrentCarrier].Encoder_offset + ","
                + Carriers[CurrentCarrier].Sensor_1_Raw_data_format + ","
                + Carriers[CurrentCarrier].Sensor_2_Raw_data_format + ","
                + Carriers[CurrentCarrier].Sensor_1_Sample_rate + ","
                + Carriers[CurrentCarrier].Sensor_1_Scale_factor_X + ","
                + Carriers[CurrentCarrier].Sensor_1_Scale_factor_Y + ","
                + Carriers[CurrentCarrier].Sensor_1_Scale_factor_Z + ","
                + Carriers[CurrentCarrier].Sensor_1_SF_Tempco_X + ","
                + Carriers[CurrentCarrier].Sensor_1_SF_Tempco_Y + ","
                + Carriers[CurrentCarrier].Sensor_1_SF_Tempco_Z + ","
                + Carriers[CurrentCarrier].Sensor_1_Offset_X + ","
                + Carriers[CurrentCarrier].Sensor_1_Offset_Y + ","
                + Carriers[CurrentCarrier].Sensor_1_Offset_Z + ","
                + Carriers[CurrentCarrier].Sensor_1_Offset_Tempco_X + ","
                + Carriers[CurrentCarrier].Sensor_1_Offset_Tempco_Y + ","
                + Carriers[CurrentCarrier].Sensor_1_Offset_Tempco_Z + ","
                + Carriers[CurrentCarrier].Sensor_1_Misalign_Alpha + ","
                + Carriers[CurrentCarrier].Sensor_1_Misalign_Beta + ","
                + Carriers[CurrentCarrier].Sensor_1_Misalign_Gamma + ","
                + Carriers[CurrentCarrier].Sensor_2_Sample_rate + ","
                + Carriers[CurrentCarrier].Sensor_2_Scale_factor_X + ","
                + Carriers[CurrentCarrier].Sensor_2_Scale_factor_Y + ","
                + Carriers[CurrentCarrier].Sensor_2_Scale_factor_Z + ","
                + Carriers[CurrentCarrier].Sensor_2_SF_Tempco_X + ","
                + Carriers[CurrentCarrier].Sensor_2_SF_Tempco_Y + ","
                + Carriers[CurrentCarrier].Sensor_2_SF_Tempco_Z + ","
                + Carriers[CurrentCarrier].Sensor_2_Offset_X + ","
                + Carriers[CurrentCarrier].Sensor_2_Offset_Y + ","
                + Carriers[CurrentCarrier].Sensor_2_Offset_Z + ","
                + Carriers[CurrentCarrier].Sensor_2_Offset_Tempco_X + ","
                + Carriers[CurrentCarrier].Sensor_2_Offset_Tempco_Y + ","
                + Carriers[CurrentCarrier].Sensor_2_Offset_Tempco_Z + ","
                + Carriers[CurrentCarrier].Sensor_2_Misalign_Alpha + ","
                + Carriers[CurrentCarrier].Sensor_2_Misalign_Beta + ","
                + Carriers[CurrentCarrier].Sensor_2_Misalign_Gamma;


            /*               
            + Carriers[CurrentCarrier].Temperature offset;
            + Carriers[CurrentCarrier].Temperature scale factor;
            */


            serial_Write(carrierSettings);
            }
            catch (Exception ex)
            {
                if (ex is InvalidOperationException)
                {
                    MessageBox.Show("BUSY!");
                }
                if (ex is FormatException)
                {
                    MessageBox.Show("Error");
                }
                if (ex is NullReferenceException)
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    throw;
                }
            }

            //Invoke(new Action(() => Console.Text = carrierSettings));

        }



        private void Find_Carriers(object sender, DoWorkEventArgs e)
        {
            Invoke(new Action(() => CarrierList.Enabled = false));
            if (_continue) {
                Invoke(new Action(() => bt_Reload_Carrier_List.Enabled = false));
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
            else
            {
                MessageBox.Show("No active connection");
            }
            Invoke(new Action(() => CarrierList.SetSelected(0,true)));
            Invoke(new Action(() => CarrierList_SelectedIndexChanged(this, e)));
            Invoke(new Action(() => CarrierList.Enabled = true));
            Invoke(new Action(() => bt_Reload_Carrier_List.Enabled = true));
        }

        private void bt_Reload_Carrier_List_Click_1(object sender, EventArgs e)
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

        private string string_bitmap_to_string_int(string string_bitmap)
        {
            string txt = RemoveLineEndings(string_bitmap);
            int temp = Convert.ToUInt16(txt, 2);
            return temp.ToString();
        }

        #region Sensor Parameter inputs
        private void Carrier_serial_number_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Carrier_serial_number = Carrier_serial_number.Text;
        }
        private void Sensor_1_name_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_1_name = Sensor_1_name.Text;
        }
        private void Sensor_2_name_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_2_name = Sensor_2_name.Text;
        }
        private void Sensor_1_active_sensors_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_1_active_sensors = Sensor_1_active_sensors.Text;
        }
        private void Sensor_1_installed_bitmap_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_1_installed_bitmap = Sensor_1_installed_bitmap.Text;
        }
        private void Sensor_1_enabled_bitmap_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_1_enabled_bitmap = Sensor_1_enabled_bitmap.Text;
        }
        private void Sensor_1_faulty_bitmap_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_1_faulty_bitmap = Sensor_1_faulty_bitmap.Text;
        }
        private void Sensor_2_active_sensors_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_2_active_sensors = Sensor_2_active_sensors.Text;
        }
        private void Sensor_2_installed_bitmap_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_2_installed_bitmap = Sensor_2_installed_bitmap.Text;
        }
        private void Sensor_2_enabled_bitmap_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_2_enabled_bitmap = Sensor_2_enabled_bitmap.Text;
        }
        private void Sensor_2_failty_bitmap_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_2_failty_bitmap = Sensor_2_failty_bitmap.Text;
        }
        private void Encoder_offset_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Encoder_offset = Encoder_offset.Text;
        }
        private void Sensor_1_Raw_data_format_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_1_Raw_data_format = Sensor_1_Raw_data_format.Text;
        }
        private void Sensor_2_Raw_data_format_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_2_Raw_data_format = Sensor_2_Raw_data_format.Text;
        }
        private void Sensor_1_Sample_rate_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_1_Sample_rate = float.Parse(Sensor_1_Sample_rate.Text);
        }
        private void Sensor_1_Scale_factor_X_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_1_Scale_factor_X = float.Parse(Sensor_1_Scale_factor_X.Text);
        }
        private void Sensor_1_Scale_factor_Y_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_1_Scale_factor_Y = float.Parse(Sensor_1_Scale_factor_Y.Text);
        }
        private void Sensor_1_Scale_factor_Z_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_1_Scale_factor_Z = float.Parse(Sensor_1_Scale_factor_Z.Text);
        }
        private void Sensor_1_SF_Tempco_X_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_1_SF_Tempco_X = float.Parse(Sensor_1_SF_Tempco_X.Text);
        }
        private void Sensor_1_SF_Tempco_Y_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_1_SF_Tempco_Y = float.Parse(Sensor_1_SF_Tempco_Y.Text);
        }
        private void Sensor_1_SF_Tempco_Z_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_1_SF_Tempco_Z = float.Parse(Sensor_1_SF_Tempco_Z.Text);
        }
        private void Sensor_1_Offset_X_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_1_Offset_X = float.Parse(Sensor_1_Offset_X.Text);
        }
        private void Sensor_1_Offset_Y_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_1_Offset_Y = float.Parse(Sensor_1_Offset_Y.Text);
        }
        private void Sensor_1_Offset_Z_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_1_Offset_Z = float.Parse(Sensor_1_Offset_Z.Text);
        }
        private void Sensor_1_Offset_Tempco_X_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_1_Offset_Tempco_X = float.Parse(Sensor_1_Offset_Tempco_X.Text);
        }
        private void Sensor_1_Offset_Tempco_Y_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_1_Offset_Tempco_Y = float.Parse(Sensor_1_Offset_Tempco_Y.Text);
        }
        private void Sensor_1_Offset_Tempco_Z_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_1_Offset_Tempco_Z = float.Parse(Sensor_1_Offset_Tempco_Z.Text);
        }
        private void Sensor_1_Misalign_Alpha_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_1_Misalign_Alpha = float.Parse(Sensor_1_Misalign_Alpha.Text);
        }
        private void Sensor_1_Misalign_Beta_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_1_Misalign_Beta = float.Parse(Sensor_1_Misalign_Beta.Text);
        }
        private void Sensor_1_Misalign_Gamma_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_1_Misalign_Gamma = float.Parse(Sensor_1_Misalign_Gamma.Text);
        }
        private void Sensor_2_Sample_rate_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_2_Sample_rate = float.Parse(Sensor_2_Sample_rate.Text);
        }
        private void Sensor_2_Scale_factor_X_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_2_Scale_factor_X = float.Parse(Sensor_2_Scale_factor_X.Text);
        }
        private void Sensor_2_Scale_factor_Y_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_2_Scale_factor_Y = float.Parse(Sensor_2_Scale_factor_Y.Text);
        }
        private void Sensor_2_Scale_factor_Z_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_2_Scale_factor_Z = float.Parse(Sensor_2_Scale_factor_Z.Text);
        }
        private void Sensor_2_SF_Tempco_X_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_2_SF_Tempco_X = float.Parse(Sensor_2_SF_Tempco_X.Text);
        }
        private void Sensor_2_SF_Tempco_Y_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_2_SF_Tempco_Y = float.Parse(Sensor_2_SF_Tempco_Y.Text);
        }
        private void Sensor_2_SF_Tempco_Z_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_2_SF_Tempco_Z = float.Parse(Sensor_2_SF_Tempco_Z.Text);
        }
        private void Sensor_2_Offset_X_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_2_Offset_X = float.Parse(Sensor_2_Offset_X.Text);
        }
        private void Sensor_2_Offset_Y_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_2_Offset_Y = float.Parse(Sensor_2_Offset_Y.Text);
        }
        private void Sensor_2_Offset_Z_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_2_Offset_Z = float.Parse(Sensor_2_Offset_Z.Text);
        }
        private void Sensor_2_Offset_Tempco_X_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_2_Offset_Tempco_X = float.Parse(Sensor_2_Offset_Tempco_X.Text);
        }
        private void Sensor_2_Offset_Tempco_Y_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_2_Offset_Tempco_Y = float.Parse(Sensor_2_Offset_Tempco_Y.Text);
        }
        private void Sensor_2_Offset_Tempco_Z_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_2_Offset_Tempco_Z = float.Parse(Sensor_2_Offset_Tempco_Z.Text);
        }
        private void Sensor_2_Misalign_Alpha_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_2_Misalign_Alpha = float.Parse(Sensor_2_Misalign_Alpha.Text);
        }
        private void Sensor_2_Misalign_Beta_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_2_Misalign_Beta = float.Parse(Sensor_2_Misalign_Beta.Text);
        }
        private void Sensor_2_Misalign_Gamma_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Sensor_2_Misalign_Gamma = float.Parse(Sensor_2_Misalign_Gamma.Text);
        }
        private void Temperature_offset_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Temperature_offset = float.Parse(Temperature_offset.Text);
        }
        private void Temperature_scale_factor_TextChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Temperature_scale_factor = float.Parse(Temperature_scale_factor.Text);
        }
        #endregion
    }


}

