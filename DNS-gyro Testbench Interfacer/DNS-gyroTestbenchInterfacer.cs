

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
using System.IO;
using System.Runtime.InteropServices;
using EposCmd.Net;
using EposCmd.Net.DeviceCmdSet.Operation;

namespace DNS_gyro_Testbench_Interfacer
{
    public partial class Interfacer : Form
    {
        //Motor Controller
        private StateMachine sm;
        private DeviceManager _mConnector;
        private Device _mEpos;
        private ProfilePositionMode ppm;
        private uint errorCode;



        /// <summary>
        /// Variables for implementing the logging session
        /// </summary>
        private bool ToggleBool = true;
        private bool CancelLogging;

        //
        private List<string> contents = new List<string>();
        private const int MAX = 50;
        private bool booted = false;

        /// <summary>
        /// Windows forms initializer
        /// Added custom culture for "." instead of "," when parsing float to string
        /// 
        /// </summary>
        public Interfacer()
        {
            InitializeComponent();

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            SerialInitialize();
            update_ComStatus(this, new EventArgs());
            statusStrip1.Text = "Disconnected";
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


        //open file dialog TODO
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
                        cb_Logg_Enabled.Checked = Carriers[i].Logg_Active;

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

        public void UpdateLoggingProgress(object sender, EventArgs e)
        {
                Invoke(new Action(() => LoggProgress.Increment(1)));
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
        private void cb_Logg_Enabled_CheckedChanged(object sender, EventArgs e)
        {
            Carriers[CurrentCarrier].Logg_Active = cb_Logg_Enabled.Checked;
        }
        #endregion


        public int totalTicks;
        public int Ticks = 0;

        /// <summary>
        /// Reset variables and start Logg thread.
        /// </summary>
        private void InitializeLoggSession(object sender, EventArgs e)
        {
            Ticks = 0;
            CancelLogging = false;




            //Create loggfiles for enabled addresses
            int Addr;
            for (int i = 0; i < 16; i++)
            {
                Addr = 20 + i;
                try
                {
                    if (Carriers[i].Logg_Active)
                    {
                        Carriers[i].Logg_Target = initializeLoggFile(Addr.ToString());
                    }
                }
                catch
                {
                    //TODO
                }
            }
            
            try
            {
                LoggWorker.RunWorkerAsync();
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

        /// <summary>
        /// Cancel Loggsession early.
        /// </summary>
        private void CancelLoggSession(object sender, EventArgs e)
        {
            try
            {
                CancelLogging = true;
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



        /// <summary>
        /// Work executed in the LoggWorker thread.
        /// TimeTick executed with a given interval.
        /// </summary>
        public void LoggSession(object sender, EventArgs e)
        {
            var timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(TimeTick);
            timer.Interval = Int32.Parse(Toggle_Delay.Text)*1000; //1000 ms
            timer.Start();
            totalTicks = int.Parse(Logging_Period.Text) / (int.Parse(Toggle_Delay.Text));
            Invoke(new Action(() => LoggProgress.Maximum = totalTicks));
            Invoke(new Action(() => LoggProgress.Value = 0));
            Invoke(new Action(() => LoggProgress.Maximum = totalTicks));

            //MR{xx} instruction sent to MCU
            int Addr;
            for (int i = 0; i < 16; i++)
            {
                Addr = 20 + i;
                try
                {
                    if (Carriers[i].Logg_Active)
                    {
                        serial_Write("MR" + Addr.ToString());
                    }
                }
                catch
                {
                    //TODO
                }
                
            }

            while (!CancelLogging && Ticks < totalTicks)
            {
                Application.DoEvents();
            }

            timer.Dispose();

            //Close loggfiles for enabled addresses
            for (int i = 0; i < 16; i++)
            {
                Addr = 20 + i;
                try
                {
                    if (Carriers[i].Logg_Active)
                    {
                        Carriers[i].Logg_Target.Close();
                    }
                }
                catch
                {
                    //TODO
                }
            }
        }

        /// <summary>
        /// Work to be executed with a given interval.
        /// Toggles motor back and forth.
        /// </summary>
        public void TimeTick(object sender, EventArgs e)
        {
            Ticks++;
            Invoke(new Action(() => LoggProgress.Increment(1)));

            if (ToggleBool)
            {
                ppm.MoveToPosition(12, true, true);
                ToggleBool = false;
            }
            else
            {
                ppm.MoveToPosition(0, true, true);
                ToggleBool = true;
            }
            Thread.Sleep(1);
        }


        /// <summary>
        /// Loggworker thread
        /// </summary>
        private void LoggWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Invoke(new Action(() => bt_Start_Logging.Enabled = false));
            Invoke(new Action(() => bt_Cancel_Logging.Enabled = true));
            LoggSession(this, e);
            Invoke(new Action(() => bt_Start_Logging.Enabled = true));
            Invoke(new Action(() => bt_Cancel_Logging.Enabled = false));
        }



        //Motor Controller
        private void buttonSettings_Click(object sender, EventArgs ea)
        {
            try
            {
                if (_mConnector != null)
                {
                    /*                    
                     * Important notice:
                     * It's recommended to call the Dispose function before application close 
                     */
                    _mConnector.Dispose();
                }

                _mConnector = new DeviceManager();

                //get baudrate info
                uint b = _mConnector.Baudrate;

                //set connection properties
                _mConnector.Baudrate = b;
                _mConnector.Timeout = 500;
                    
                //buttonEnable.Enabled = true;
            }
            catch (DeviceException e)
            {
                //StopRefresh();
                ShowMessageBox(e.ErrorMessage, e.ErrorCode);
            }
            catch (Exception e)
            {
                //StopRefresh();

                MessageBox.Show(e.Message);
            }

            try
            {
                _mEpos = _mConnector.CreateDevice(Convert.ToUInt16(Convert.ToUInt16("1")));

                sm = _mEpos.Operation.StateMachine;

                if (sm.GetFaultState())
                    sm.ClearFault();

                sm.SetEnableState();

                ppm = _mEpos.Operation.ProfilePositionMode;
                ppm.ActivateProfilePositionMode();

                
            }
            catch (DeviceException e)
            {
                ShowMessageBox(e.ErrorMessage, e.ErrorCode);
            }
            catch(AccessViolationException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            Motor1_status();
        }

        
        /// <summary>
        /// Set Motor Velocity and Acceleration.
        /// </summary>
        private void bt_Motor1_Save_Setting_Click(object sender, EventArgs e)
        {
            try
            {
                ppm.SetPositionProfile(UInt32.Parse(Motor1_Velocity.Text), UInt32.Parse(Motor1_Acceleration.Text), UInt32.Parse(Motor1_Acceleration.Text));
            }
            catch (Exception ex)
            {
                if (ex is DeviceException || ex is OverflowException)
                {
                    MessageBox.Show("Failed to update Velocity and Acceleration.\nRead manual for valid values.");
                }
                else if (ex is InvalidOperationException)
                {
                    MessageBox.Show("Invalid Operation.");
                }
                else if (ex is FormatException)
                {
                    MessageBox.Show("Invalid formating.");
                }
                else
                {
                    throw;
                }
            }
        }



        /// <summary>
        /// Shows Error Message
        /// </summary>
        private void ShowMessageBox(string text, uint errorCode)
        {
            string msg;

            msg = String.Format("{0}\nErrorCode: {1:X8}", text, errorCode);
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Motor1_status()
        {
            //DEBUG COMPANION
            Invoke(new Action(() => Console.Text = errorCode.ToString()));
            //TODO FIX MOTOR STATUS

            if (errorCode == 0)
            {
                Motor1_Status.BackColor = Color.Green;
                Motor1_Status.Text = "";

                bt_Start_Logging.Enabled = true;
                bt_Motor1_Save_Setting.Enabled = true;
            }
            else
            {
                Motor1_Status.BackColor = Color.Red;
                Motor1_Status.Text = errorCode.ToString();
            }
        }

        private void Interfacer_Load(object sender, EventArgs e)
        {

        }


    }



}

