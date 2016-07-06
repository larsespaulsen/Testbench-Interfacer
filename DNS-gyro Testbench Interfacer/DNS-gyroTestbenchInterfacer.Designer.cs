namespace DNS_gyro_Testbench_Interfacer
{
    partial class Interfacer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interfacer));
            this.bt_serialConnect = new System.Windows.Forms.Button();
            this.Baudrate = new System.Windows.Forms.TextBox();
            this.sendMessage = new System.Windows.Forms.TextBox();
            this.ComStatus = new System.Windows.Forms.RichTextBox();
            this.ReceiveWorker = new System.ComponentModel.BackgroundWorker();
            this.comList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Baudrate = new System.Windows.Forms.Label();
            this.bt_send = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Console = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CarrierList = new System.Windows.Forms.ListBox();
            this.bt_Reload_Carrier_List = new System.Windows.Forms.Button();
            this.bt_Set_Carrier = new System.Windows.Forms.Button();
            this.SendWorker = new System.ComponentModel.BackgroundWorker();
            this.Carrier_serial_number = new System.Windows.Forms.TextBox();
            this.Sensor_1_name = new System.Windows.Forms.TextBox();
            this.Sensor_2_name = new System.Windows.Forms.TextBox();
            this.Sensor_1_active_sensors = new System.Windows.Forms.TextBox();
            this.Sensor_1_installed_bitmap = new System.Windows.Forms.TextBox();
            this.Sensor_1_enabled_bitmap = new System.Windows.Forms.TextBox();
            this.Sensor_1_faulty_bitmap = new System.Windows.Forms.TextBox();
            this.Sensor_2_active_sensors = new System.Windows.Forms.TextBox();
            this.Sensor_2_installed_bitmap = new System.Windows.Forms.TextBox();
            this.Sensor_2_enabled_bitmap = new System.Windows.Forms.TextBox();
            this.Sensor_2_failty_bitmap = new System.Windows.Forms.TextBox();
            this.Encoder_offset = new System.Windows.Forms.TextBox();
            this.Sensor_1_Raw_data_format = new System.Windows.Forms.TextBox();
            this.Sensor_2_Raw_data_format = new System.Windows.Forms.TextBox();
            this.Sensor_1_Sample_rate = new System.Windows.Forms.TextBox();
            this.Sensor_1_Scale_factor_X = new System.Windows.Forms.TextBox();
            this.Sensor_1_Scale_factor_Y = new System.Windows.Forms.TextBox();
            this.Sensor_1_Scale_factor_Z = new System.Windows.Forms.TextBox();
            this.Sensor_1_SF_Tempco_X = new System.Windows.Forms.TextBox();
            this.Sensor_1_SF_Tempco_Y = new System.Windows.Forms.TextBox();
            this.Sensor_1_SF_Tempco_Z = new System.Windows.Forms.TextBox();
            this.Sensor_1_Offset_X = new System.Windows.Forms.TextBox();
            this.Sensor_1_Offset_Y = new System.Windows.Forms.TextBox();
            this.Sensor_1_Offset_Z = new System.Windows.Forms.TextBox();
            this.Sensor_1_Offset_Tempco_X = new System.Windows.Forms.TextBox();
            this.Sensor_1_Offset_Tempco_Y = new System.Windows.Forms.TextBox();
            this.Sensor_1_Offset_Tempco_Z = new System.Windows.Forms.TextBox();
            this.Sensor_1_Misalign_Alpha = new System.Windows.Forms.TextBox();
            this.Sensor_1_Misalign_Beta = new System.Windows.Forms.TextBox();
            this.Sensor_1_Misalign_Gamma = new System.Windows.Forms.TextBox();
            this.Sensor_2_Sample_rate = new System.Windows.Forms.TextBox();
            this.Sensor_2_Scale_factor_X = new System.Windows.Forms.TextBox();
            this.Sensor_2_Scale_factor_Y = new System.Windows.Forms.TextBox();
            this.Sensor_2_Scale_factor_Z = new System.Windows.Forms.TextBox();
            this.Sensor_2_SF_Tempco_X = new System.Windows.Forms.TextBox();
            this.Sensor_2_SF_Tempco_Y = new System.Windows.Forms.TextBox();
            this.Sensor_2_SF_Tempco_Z = new System.Windows.Forms.TextBox();
            this.Sensor_2_Offset_X = new System.Windows.Forms.TextBox();
            this.Sensor_2_Offset_Y = new System.Windows.Forms.TextBox();
            this.Sensor_2_Offset_Z = new System.Windows.Forms.TextBox();
            this.Sensor_2_Offset_Tempco_X = new System.Windows.Forms.TextBox();
            this.Sensor_2_Offset_Tempco_Y = new System.Windows.Forms.TextBox();
            this.Sensor_2_Offset_Tempco_Z = new System.Windows.Forms.TextBox();
            this.Sensor_2_Misalign_Alpha = new System.Windows.Forms.TextBox();
            this.Sensor_2_Misalign_Beta = new System.Windows.Forms.TextBox();
            this.Sensor_2_Misalign_Gamma = new System.Windows.Forms.TextBox();
            this.Temperature_offset = new System.Windows.Forms.TextBox();
            this.Temperature_scale_factor = new System.Windows.Forms.TextBox();
            this.label_Carrier_serial_number = new System.Windows.Forms.Label();
            this.label_Sensor_1_name = new System.Windows.Forms.Label();
            this.label_Sensor_2_name = new System.Windows.Forms.Label();
            this.label_Sensor_1_active_sensors = new System.Windows.Forms.Label();
            this.label_Sensor_1_installed_bitmap = new System.Windows.Forms.Label();
            this.label_Sensor_1_enabled_bitmap = new System.Windows.Forms.Label();
            this.label_Sensor_1_faulty_bitmap = new System.Windows.Forms.Label();
            this.label_Sensor_2_active_sensors = new System.Windows.Forms.Label();
            this.label_Sensor_2_installed_bitmap = new System.Windows.Forms.Label();
            this.label_Sensor_2_enabled_bitmap = new System.Windows.Forms.Label();
            this.label_Sensor_2_failty_bitmap = new System.Windows.Forms.Label();
            this.label_Encoder_offset = new System.Windows.Forms.Label();
            this.label_Sensor_1_Raw_data_format = new System.Windows.Forms.Label();
            this.label_Sensor_2_Raw_data_format = new System.Windows.Forms.Label();
            this.label_Sensor_1_Sample_rate = new System.Windows.Forms.Label();
            this.label_Sensor_1_Scale_factor_X = new System.Windows.Forms.Label();
            this.label_Sensor_1_Scale_factor_Y = new System.Windows.Forms.Label();
            this.label_Sensor_1_Scale_factor_Z = new System.Windows.Forms.Label();
            this.label_Sensor_1_SF_Tempco_X = new System.Windows.Forms.Label();
            this.label_Sensor_1_SF_Tempco_Y = new System.Windows.Forms.Label();
            this.label_Sensor_1_SF_Tempco_Z = new System.Windows.Forms.Label();
            this.label_Sensor_1_Offset_X = new System.Windows.Forms.Label();
            this.label_Sensor_1_Offset_Y = new System.Windows.Forms.Label();
            this.label_Sensor_1_Offset_Z = new System.Windows.Forms.Label();
            this.label_Sensor_1_Offset_Tempco_X = new System.Windows.Forms.Label();
            this.label_Sensor_1_Offset_Tempco_Y = new System.Windows.Forms.Label();
            this.label_Sensor_1_Offset_Tempco_Z = new System.Windows.Forms.Label();
            this.label_Sensor_1_Misalign_Alpha = new System.Windows.Forms.Label();
            this.label_Sensor_1_Misalign_Beta = new System.Windows.Forms.Label();
            this.label_Sensor_1_Misalign_Gamma = new System.Windows.Forms.Label();
            this.label_Sensor_2_Sample_rate = new System.Windows.Forms.Label();
            this.label_Sensor_2_Scale_factor_X = new System.Windows.Forms.Label();
            this.label_Sensor_2_Scale_factor_Y = new System.Windows.Forms.Label();
            this.label_Sensor_2_Scale_factor_Z = new System.Windows.Forms.Label();
            this.label_Sensor_2_SF_Tempco_X = new System.Windows.Forms.Label();
            this.label_Sensor_2_SF_Tempco_Y = new System.Windows.Forms.Label();
            this.label_Sensor_2_SF_Tempco_Z = new System.Windows.Forms.Label();
            this.label_Sensor_2_Offset_X = new System.Windows.Forms.Label();
            this.label_Sensor_2_Offset_Y = new System.Windows.Forms.Label();
            this.label_Sensor_2_Offset_Z = new System.Windows.Forms.Label();
            this.label_Sensor_2_Offset_Tempco_X = new System.Windows.Forms.Label();
            this.label_Sensor_2_Offset_Tempco_Y = new System.Windows.Forms.Label();
            this.label_Sensor_2_Offset_Tempco_Z = new System.Windows.Forms.Label();
            this.label_Sensor_2_Misalign_Alpha = new System.Windows.Forms.Label();
            this.label_Sensor_2_Misalign_Beta = new System.Windows.Forms.Label();
            this.label_Sensor_2_Misalign_Gamma = new System.Windows.Forms.Label();
            this.label_Temperature_offset = new System.Windows.Forms.Label();
            this.label_Temperature_scale_factor = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Sent = new System.Windows.Forms.TextBox();
            this.LoggProgress = new System.Windows.Forms.ProgressBar();
            this.bt_Start_Logging = new System.Windows.Forms.Button();
            this.LoggWorker = new System.ComponentModel.BackgroundWorker();
            this.bt_Cancel_Logging = new System.Windows.Forms.Button();
            this.bt_Motor1_Setup = new System.Windows.Forms.Button();
            this.lb_Motor_Controller1 = new System.Windows.Forms.Label();
            this.Motor1_Velocity = new System.Windows.Forms.TextBox();
            this.Motor1_Acceleration = new System.Windows.Forms.TextBox();
            this.bt_Motor1_Save_Setting = new System.Windows.Forms.Button();
            this.Logging_Period = new System.Windows.Forms.TextBox();
            this.Toggle_Delay = new System.Windows.Forms.TextBox();
            this.lb_Logging_Period = new System.Windows.Forms.Label();
            this.lb_Toggle_Delay = new System.Windows.Forms.Label();
            this.lb_Motor1_Velocity = new System.Windows.Forms.Label();
            this.lb_Motor1_Acceleration = new System.Windows.Forms.Label();
            this.Motor1_Status = new System.Windows.Forms.TextBox();
            this.cb_Logg_Enabled = new System.Windows.Forms.CheckBox();
            this.cb_Motor1_Enabled = new System.Windows.Forms.CheckBox();
            this.cb_Motor2_Enabled = new System.Windows.Forms.CheckBox();
            this.Motor2_Status = new System.Windows.Forms.TextBox();
            this.lb_Motor2_Acceleration = new System.Windows.Forms.Label();
            this.lb_Motor2_Velocity = new System.Windows.Forms.Label();
            this.bt_Motor2_Save_Setting = new System.Windows.Forms.Button();
            this.Motor2_Acceleration = new System.Windows.Forms.TextBox();
            this.Motor2_Velocity = new System.Windows.Forms.TextBox();
            this.lb_Motor_Controller2 = new System.Windows.Forms.Label();
            this.bt_Motor2_Setup = new System.Windows.Forms.Button();
            this.cb_Motor3_Enabled = new System.Windows.Forms.CheckBox();
            this.Motor3_Status = new System.Windows.Forms.TextBox();
            this.lb_Motor3_Acceleration = new System.Windows.Forms.Label();
            this.lb_Motor3_Velocity = new System.Windows.Forms.Label();
            this.bt_Motor3_Save_Setting = new System.Windows.Forms.Button();
            this.Motor3_Acceleration = new System.Windows.Forms.TextBox();
            this.Motor3_Velocity = new System.Windows.Forms.TextBox();
            this.lb_Motor_Controller3 = new System.Windows.Forms.Label();
            this.bt_Motor3_Setup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_serialConnect
            // 
            this.bt_serialConnect.Location = new System.Drawing.Point(93, 144);
            this.bt_serialConnect.Name = "bt_serialConnect";
            this.bt_serialConnect.Size = new System.Drawing.Size(163, 23);
            this.bt_serialConnect.TabIndex = 0;
            this.bt_serialConnect.Text = "Connect";
            this.bt_serialConnect.UseVisualStyleBackColor = true;
            this.bt_serialConnect.Click += new System.EventHandler(this.bt_serialConnect_Click);
            // 
            // Baudrate
            // 
            this.Baudrate.Location = new System.Drawing.Point(12, 144);
            this.Baudrate.Name = "Baudrate";
            this.Baudrate.Size = new System.Drawing.Size(75, 20);
            this.Baudrate.TabIndex = 1;
            this.Baudrate.TextChanged += new System.EventHandler(this.Baudrate_TextChanged);
            // 
            // sendMessage
            // 
            this.sendMessage.Location = new System.Drawing.Point(12, 652);
            this.sendMessage.Name = "sendMessage";
            this.sendMessage.Size = new System.Drawing.Size(448, 20);
            this.sendMessage.TabIndex = 2;
            // 
            // ComStatus
            // 
            this.ComStatus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ComStatus.Location = new System.Drawing.Point(93, 26);
            this.ComStatus.Name = "ComStatus";
            this.ComStatus.ReadOnly = true;
            this.ComStatus.Size = new System.Drawing.Size(163, 95);
            this.ComStatus.TabIndex = 11;
            this.ComStatus.Text = "";
            // 
            // ReceiveWorker
            // 
            this.ReceiveWorker.WorkerSupportsCancellation = true;
            this.ReceiveWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.serial_Read_Worker);
            // 
            // comList
            // 
            this.comList.FormattingEnabled = true;
            this.comList.Location = new System.Drawing.Point(12, 26);
            this.comList.Name = "comList";
            this.comList.Size = new System.Drawing.Size(75, 95);
            this.comList.TabIndex = 12;
            this.comList.SelectedIndexChanged += new System.EventHandler(this.comList_SelectChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // lb_Baudrate
            // 
            this.lb_Baudrate.AutoSize = true;
            this.lb_Baudrate.Location = new System.Drawing.Point(12, 125);
            this.lb_Baudrate.Name = "lb_Baudrate";
            this.lb_Baudrate.Size = new System.Drawing.Size(50, 13);
            this.lb_Baudrate.TabIndex = 13;
            this.lb_Baudrate.Text = "Baudrate";
            // 
            // bt_send
            // 
            this.bt_send.Location = new System.Drawing.Point(466, 651);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(75, 23);
            this.bt_send.TabIndex = 14;
            this.bt_send.Text = "Send";
            this.bt_send.UseVisualStyleBackColor = true;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 952);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1152, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // Console
            // 
            this.Console.BackColor = System.Drawing.Color.FloralWhite;
            this.Console.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Console.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Console.Location = new System.Drawing.Point(12, 173);
            this.Console.MaxLength = 2000000;
            this.Console.Name = "Console";
            this.Console.ReadOnly = true;
            this.Console.Size = new System.Drawing.Size(529, 473);
            this.Console.TabIndex = 15;
            this.Console.Text = "";
            // 
            // CarrierList
            // 
            this.CarrierList.CausesValidation = false;
            this.CarrierList.Cursor = System.Windows.Forms.Cursors.Default;
            this.CarrierList.FormattingEnabled = true;
            this.CarrierList.Location = new System.Drawing.Point(262, 26);
            this.CarrierList.Name = "CarrierList";
            this.CarrierList.Size = new System.Drawing.Size(279, 95);
            this.CarrierList.TabIndex = 17;
            this.CarrierList.SelectedIndexChanged += new System.EventHandler(this.CarrierList_SelectedIndexChanged);
            // 
            // bt_Reload_Carrier_List
            // 
            this.bt_Reload_Carrier_List.Location = new System.Drawing.Point(262, 145);
            this.bt_Reload_Carrier_List.Name = "bt_Reload_Carrier_List";
            this.bt_Reload_Carrier_List.Size = new System.Drawing.Size(279, 22);
            this.bt_Reload_Carrier_List.TabIndex = 3;
            this.bt_Reload_Carrier_List.Text = "Reload Carrier List";
            this.bt_Reload_Carrier_List.Click += new System.EventHandler(this.bt_Reload_Carrier_List_Click_1);
            // 
            // bt_Set_Carrier
            // 
            this.bt_Set_Carrier.Enabled = false;
            this.bt_Set_Carrier.Location = new System.Drawing.Point(558, 651);
            this.bt_Set_Carrier.Name = "bt_Set_Carrier";
            this.bt_Set_Carrier.Size = new System.Drawing.Size(400, 23);
            this.bt_Set_Carrier.TabIndex = 1;
            this.bt_Set_Carrier.Text = "Set Carrier";
            this.bt_Set_Carrier.Click += new System.EventHandler(this.bt_Set_Carrier_Click);
            // 
            // SendWorker
            // 
            this.SendWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Find_Carriers);
            // 
            // Carrier_serial_number
            // 
            this.Carrier_serial_number.Location = new System.Drawing.Point(558, 25);
            this.Carrier_serial_number.Name = "Carrier_serial_number";
            this.Carrier_serial_number.Size = new System.Drawing.Size(100, 20);
            this.Carrier_serial_number.TabIndex = 27;
            this.Carrier_serial_number.TextChanged += new System.EventHandler(this.Carrier_serial_number_TextChanged);
            // 
            // Sensor_1_name
            // 
            this.Sensor_1_name.Location = new System.Drawing.Point(558, 65);
            this.Sensor_1_name.Name = "Sensor_1_name";
            this.Sensor_1_name.Size = new System.Drawing.Size(100, 20);
            this.Sensor_1_name.TabIndex = 27;
            this.Sensor_1_name.TextChanged += new System.EventHandler(this.Sensor_1_name_TextChanged);
            // 
            // Sensor_2_name
            // 
            this.Sensor_2_name.Location = new System.Drawing.Point(558, 105);
            this.Sensor_2_name.Name = "Sensor_2_name";
            this.Sensor_2_name.Size = new System.Drawing.Size(100, 20);
            this.Sensor_2_name.TabIndex = 27;
            this.Sensor_2_name.TextChanged += new System.EventHandler(this.Sensor_2_name_TextChanged);
            // 
            // Sensor_1_active_sensors
            // 
            this.Sensor_1_active_sensors.Location = new System.Drawing.Point(558, 145);
            this.Sensor_1_active_sensors.Name = "Sensor_1_active_sensors";
            this.Sensor_1_active_sensors.Size = new System.Drawing.Size(100, 20);
            this.Sensor_1_active_sensors.TabIndex = 27;
            this.Sensor_1_active_sensors.TextChanged += new System.EventHandler(this.Sensor_1_active_sensors_TextChanged);
            // 
            // Sensor_1_installed_bitmap
            // 
            this.Sensor_1_installed_bitmap.Location = new System.Drawing.Point(558, 185);
            this.Sensor_1_installed_bitmap.Name = "Sensor_1_installed_bitmap";
            this.Sensor_1_installed_bitmap.Size = new System.Drawing.Size(100, 20);
            this.Sensor_1_installed_bitmap.TabIndex = 27;
            this.Sensor_1_installed_bitmap.TextChanged += new System.EventHandler(this.Sensor_1_installed_bitmap_TextChanged);
            // 
            // Sensor_1_enabled_bitmap
            // 
            this.Sensor_1_enabled_bitmap.Location = new System.Drawing.Point(558, 225);
            this.Sensor_1_enabled_bitmap.Name = "Sensor_1_enabled_bitmap";
            this.Sensor_1_enabled_bitmap.Size = new System.Drawing.Size(100, 20);
            this.Sensor_1_enabled_bitmap.TabIndex = 27;
            this.Sensor_1_enabled_bitmap.TextChanged += new System.EventHandler(this.Sensor_1_enabled_bitmap_TextChanged);
            // 
            // Sensor_1_faulty_bitmap
            // 
            this.Sensor_1_faulty_bitmap.Location = new System.Drawing.Point(558, 265);
            this.Sensor_1_faulty_bitmap.Name = "Sensor_1_faulty_bitmap";
            this.Sensor_1_faulty_bitmap.Size = new System.Drawing.Size(100, 20);
            this.Sensor_1_faulty_bitmap.TabIndex = 27;
            this.Sensor_1_faulty_bitmap.TextChanged += new System.EventHandler(this.Sensor_1_faulty_bitmap_TextChanged);
            // 
            // Sensor_2_active_sensors
            // 
            this.Sensor_2_active_sensors.Location = new System.Drawing.Point(558, 305);
            this.Sensor_2_active_sensors.Name = "Sensor_2_active_sensors";
            this.Sensor_2_active_sensors.Size = new System.Drawing.Size(100, 20);
            this.Sensor_2_active_sensors.TabIndex = 27;
            this.Sensor_2_active_sensors.TextChanged += new System.EventHandler(this.Sensor_2_active_sensors_TextChanged);
            // 
            // Sensor_2_installed_bitmap
            // 
            this.Sensor_2_installed_bitmap.Location = new System.Drawing.Point(558, 345);
            this.Sensor_2_installed_bitmap.Name = "Sensor_2_installed_bitmap";
            this.Sensor_2_installed_bitmap.Size = new System.Drawing.Size(100, 20);
            this.Sensor_2_installed_bitmap.TabIndex = 27;
            this.Sensor_2_installed_bitmap.TextChanged += new System.EventHandler(this.Sensor_2_installed_bitmap_TextChanged);
            // 
            // Sensor_2_enabled_bitmap
            // 
            this.Sensor_2_enabled_bitmap.Location = new System.Drawing.Point(558, 385);
            this.Sensor_2_enabled_bitmap.Name = "Sensor_2_enabled_bitmap";
            this.Sensor_2_enabled_bitmap.Size = new System.Drawing.Size(100, 20);
            this.Sensor_2_enabled_bitmap.TabIndex = 27;
            this.Sensor_2_enabled_bitmap.TextChanged += new System.EventHandler(this.Sensor_2_enabled_bitmap_TextChanged);
            // 
            // Sensor_2_failty_bitmap
            // 
            this.Sensor_2_failty_bitmap.Location = new System.Drawing.Point(558, 425);
            this.Sensor_2_failty_bitmap.Name = "Sensor_2_failty_bitmap";
            this.Sensor_2_failty_bitmap.Size = new System.Drawing.Size(100, 20);
            this.Sensor_2_failty_bitmap.TabIndex = 27;
            this.Sensor_2_failty_bitmap.TextChanged += new System.EventHandler(this.Sensor_2_failty_bitmap_TextChanged);
            // 
            // Encoder_offset
            // 
            this.Encoder_offset.Location = new System.Drawing.Point(558, 465);
            this.Encoder_offset.Name = "Encoder_offset";
            this.Encoder_offset.Size = new System.Drawing.Size(100, 20);
            this.Encoder_offset.TabIndex = 27;
            this.Encoder_offset.TextChanged += new System.EventHandler(this.Encoder_offset_TextChanged);
            // 
            // Sensor_1_Raw_data_format
            // 
            this.Sensor_1_Raw_data_format.Location = new System.Drawing.Point(558, 505);
            this.Sensor_1_Raw_data_format.Name = "Sensor_1_Raw_data_format";
            this.Sensor_1_Raw_data_format.Size = new System.Drawing.Size(100, 20);
            this.Sensor_1_Raw_data_format.TabIndex = 27;
            this.Sensor_1_Raw_data_format.TextChanged += new System.EventHandler(this.Sensor_1_Raw_data_format_TextChanged);
            // 
            // Sensor_2_Raw_data_format
            // 
            this.Sensor_2_Raw_data_format.Location = new System.Drawing.Point(558, 545);
            this.Sensor_2_Raw_data_format.Name = "Sensor_2_Raw_data_format";
            this.Sensor_2_Raw_data_format.Size = new System.Drawing.Size(100, 20);
            this.Sensor_2_Raw_data_format.TabIndex = 27;
            this.Sensor_2_Raw_data_format.TextChanged += new System.EventHandler(this.Sensor_2_Raw_data_format_TextChanged);
            // 
            // Sensor_1_Sample_rate
            // 
            this.Sensor_1_Sample_rate.Location = new System.Drawing.Point(558, 585);
            this.Sensor_1_Sample_rate.Name = "Sensor_1_Sample_rate";
            this.Sensor_1_Sample_rate.Size = new System.Drawing.Size(100, 20);
            this.Sensor_1_Sample_rate.TabIndex = 27;
            this.Sensor_1_Sample_rate.TextChanged += new System.EventHandler(this.Sensor_1_Sample_rate_TextChanged);
            // 
            // Sensor_1_Scale_factor_X
            // 
            this.Sensor_1_Scale_factor_X.Location = new System.Drawing.Point(558, 625);
            this.Sensor_1_Scale_factor_X.Name = "Sensor_1_Scale_factor_X";
            this.Sensor_1_Scale_factor_X.Size = new System.Drawing.Size(100, 20);
            this.Sensor_1_Scale_factor_X.TabIndex = 27;
            this.Sensor_1_Scale_factor_X.TextChanged += new System.EventHandler(this.Sensor_1_Scale_factor_X_TextChanged);
            // 
            // Sensor_1_Scale_factor_Y
            // 
            this.Sensor_1_Scale_factor_Y.Location = new System.Drawing.Point(708, 25);
            this.Sensor_1_Scale_factor_Y.Name = "Sensor_1_Scale_factor_Y";
            this.Sensor_1_Scale_factor_Y.Size = new System.Drawing.Size(100, 20);
            this.Sensor_1_Scale_factor_Y.TabIndex = 27;
            this.Sensor_1_Scale_factor_Y.TextChanged += new System.EventHandler(this.Sensor_1_Scale_factor_Y_TextChanged);
            // 
            // Sensor_1_Scale_factor_Z
            // 
            this.Sensor_1_Scale_factor_Z.Location = new System.Drawing.Point(708, 65);
            this.Sensor_1_Scale_factor_Z.Name = "Sensor_1_Scale_factor_Z";
            this.Sensor_1_Scale_factor_Z.Size = new System.Drawing.Size(100, 20);
            this.Sensor_1_Scale_factor_Z.TabIndex = 27;
            this.Sensor_1_Scale_factor_Z.TextChanged += new System.EventHandler(this.Sensor_1_Scale_factor_Z_TextChanged);
            // 
            // Sensor_1_SF_Tempco_X
            // 
            this.Sensor_1_SF_Tempco_X.Location = new System.Drawing.Point(708, 105);
            this.Sensor_1_SF_Tempco_X.Name = "Sensor_1_SF_Tempco_X";
            this.Sensor_1_SF_Tempco_X.Size = new System.Drawing.Size(100, 20);
            this.Sensor_1_SF_Tempco_X.TabIndex = 27;
            this.Sensor_1_SF_Tempco_X.TextChanged += new System.EventHandler(this.Sensor_1_SF_Tempco_X_TextChanged);
            // 
            // Sensor_1_SF_Tempco_Y
            // 
            this.Sensor_1_SF_Tempco_Y.Location = new System.Drawing.Point(708, 145);
            this.Sensor_1_SF_Tempco_Y.Name = "Sensor_1_SF_Tempco_Y";
            this.Sensor_1_SF_Tempco_Y.Size = new System.Drawing.Size(100, 20);
            this.Sensor_1_SF_Tempco_Y.TabIndex = 27;
            this.Sensor_1_SF_Tempco_Y.TextChanged += new System.EventHandler(this.Sensor_1_SF_Tempco_Y_TextChanged);
            // 
            // Sensor_1_SF_Tempco_Z
            // 
            this.Sensor_1_SF_Tempco_Z.Location = new System.Drawing.Point(708, 185);
            this.Sensor_1_SF_Tempco_Z.Name = "Sensor_1_SF_Tempco_Z";
            this.Sensor_1_SF_Tempco_Z.Size = new System.Drawing.Size(100, 20);
            this.Sensor_1_SF_Tempco_Z.TabIndex = 27;
            this.Sensor_1_SF_Tempco_Z.TextChanged += new System.EventHandler(this.Sensor_1_SF_Tempco_Z_TextChanged);
            // 
            // Sensor_1_Offset_X
            // 
            this.Sensor_1_Offset_X.Location = new System.Drawing.Point(708, 225);
            this.Sensor_1_Offset_X.Name = "Sensor_1_Offset_X";
            this.Sensor_1_Offset_X.Size = new System.Drawing.Size(100, 20);
            this.Sensor_1_Offset_X.TabIndex = 27;
            this.Sensor_1_Offset_X.TextChanged += new System.EventHandler(this.Sensor_1_Offset_X_TextChanged);
            // 
            // Sensor_1_Offset_Y
            // 
            this.Sensor_1_Offset_Y.Location = new System.Drawing.Point(708, 265);
            this.Sensor_1_Offset_Y.Name = "Sensor_1_Offset_Y";
            this.Sensor_1_Offset_Y.Size = new System.Drawing.Size(100, 20);
            this.Sensor_1_Offset_Y.TabIndex = 27;
            this.Sensor_1_Offset_Y.TextChanged += new System.EventHandler(this.Sensor_1_Offset_Y_TextChanged);
            // 
            // Sensor_1_Offset_Z
            // 
            this.Sensor_1_Offset_Z.Location = new System.Drawing.Point(708, 305);
            this.Sensor_1_Offset_Z.Name = "Sensor_1_Offset_Z";
            this.Sensor_1_Offset_Z.Size = new System.Drawing.Size(100, 20);
            this.Sensor_1_Offset_Z.TabIndex = 27;
            this.Sensor_1_Offset_Z.TextChanged += new System.EventHandler(this.Sensor_1_Offset_Z_TextChanged);
            // 
            // Sensor_1_Offset_Tempco_X
            // 
            this.Sensor_1_Offset_Tempco_X.Location = new System.Drawing.Point(708, 345);
            this.Sensor_1_Offset_Tempco_X.Name = "Sensor_1_Offset_Tempco_X";
            this.Sensor_1_Offset_Tempco_X.Size = new System.Drawing.Size(100, 20);
            this.Sensor_1_Offset_Tempco_X.TabIndex = 27;
            this.Sensor_1_Offset_Tempco_X.TextChanged += new System.EventHandler(this.Sensor_1_Offset_Tempco_X_TextChanged);
            // 
            // Sensor_1_Offset_Tempco_Y
            // 
            this.Sensor_1_Offset_Tempco_Y.Location = new System.Drawing.Point(708, 385);
            this.Sensor_1_Offset_Tempco_Y.Name = "Sensor_1_Offset_Tempco_Y";
            this.Sensor_1_Offset_Tempco_Y.Size = new System.Drawing.Size(100, 20);
            this.Sensor_1_Offset_Tempco_Y.TabIndex = 27;
            this.Sensor_1_Offset_Tempco_Y.TextChanged += new System.EventHandler(this.Sensor_1_Offset_Tempco_Y_TextChanged);
            // 
            // Sensor_1_Offset_Tempco_Z
            // 
            this.Sensor_1_Offset_Tempco_Z.Location = new System.Drawing.Point(708, 425);
            this.Sensor_1_Offset_Tempco_Z.Name = "Sensor_1_Offset_Tempco_Z";
            this.Sensor_1_Offset_Tempco_Z.Size = new System.Drawing.Size(100, 20);
            this.Sensor_1_Offset_Tempco_Z.TabIndex = 27;
            this.Sensor_1_Offset_Tempco_Z.TextChanged += new System.EventHandler(this.Sensor_1_Offset_Tempco_Z_TextChanged);
            // 
            // Sensor_1_Misalign_Alpha
            // 
            this.Sensor_1_Misalign_Alpha.Location = new System.Drawing.Point(708, 465);
            this.Sensor_1_Misalign_Alpha.Name = "Sensor_1_Misalign_Alpha";
            this.Sensor_1_Misalign_Alpha.Size = new System.Drawing.Size(100, 20);
            this.Sensor_1_Misalign_Alpha.TabIndex = 27;
            this.Sensor_1_Misalign_Alpha.TextChanged += new System.EventHandler(this.Sensor_1_Misalign_Alpha_TextChanged);
            // 
            // Sensor_1_Misalign_Beta
            // 
            this.Sensor_1_Misalign_Beta.Location = new System.Drawing.Point(708, 505);
            this.Sensor_1_Misalign_Beta.Name = "Sensor_1_Misalign_Beta";
            this.Sensor_1_Misalign_Beta.Size = new System.Drawing.Size(100, 20);
            this.Sensor_1_Misalign_Beta.TabIndex = 27;
            this.Sensor_1_Misalign_Beta.TextChanged += new System.EventHandler(this.Sensor_1_Misalign_Beta_TextChanged);
            // 
            // Sensor_1_Misalign_Gamma
            // 
            this.Sensor_1_Misalign_Gamma.Location = new System.Drawing.Point(708, 545);
            this.Sensor_1_Misalign_Gamma.Name = "Sensor_1_Misalign_Gamma";
            this.Sensor_1_Misalign_Gamma.Size = new System.Drawing.Size(100, 20);
            this.Sensor_1_Misalign_Gamma.TabIndex = 27;
            this.Sensor_1_Misalign_Gamma.TextChanged += new System.EventHandler(this.Sensor_1_Misalign_Gamma_TextChanged);
            // 
            // Sensor_2_Sample_rate
            // 
            this.Sensor_2_Sample_rate.Location = new System.Drawing.Point(708, 585);
            this.Sensor_2_Sample_rate.Name = "Sensor_2_Sample_rate";
            this.Sensor_2_Sample_rate.Size = new System.Drawing.Size(100, 20);
            this.Sensor_2_Sample_rate.TabIndex = 27;
            this.Sensor_2_Sample_rate.TextChanged += new System.EventHandler(this.Sensor_2_Sample_rate_TextChanged);
            // 
            // Sensor_2_Scale_factor_X
            // 
            this.Sensor_2_Scale_factor_X.Location = new System.Drawing.Point(708, 625);
            this.Sensor_2_Scale_factor_X.Name = "Sensor_2_Scale_factor_X";
            this.Sensor_2_Scale_factor_X.Size = new System.Drawing.Size(100, 20);
            this.Sensor_2_Scale_factor_X.TabIndex = 27;
            this.Sensor_2_Scale_factor_X.TextChanged += new System.EventHandler(this.Sensor_2_Scale_factor_X_TextChanged);
            // 
            // Sensor_2_Scale_factor_Y
            // 
            this.Sensor_2_Scale_factor_Y.Location = new System.Drawing.Point(858, 25);
            this.Sensor_2_Scale_factor_Y.Name = "Sensor_2_Scale_factor_Y";
            this.Sensor_2_Scale_factor_Y.Size = new System.Drawing.Size(100, 20);
            this.Sensor_2_Scale_factor_Y.TabIndex = 27;
            this.Sensor_2_Scale_factor_Y.TextChanged += new System.EventHandler(this.Sensor_2_Scale_factor_Y_TextChanged);
            // 
            // Sensor_2_Scale_factor_Z
            // 
            this.Sensor_2_Scale_factor_Z.Location = new System.Drawing.Point(858, 65);
            this.Sensor_2_Scale_factor_Z.Name = "Sensor_2_Scale_factor_Z";
            this.Sensor_2_Scale_factor_Z.Size = new System.Drawing.Size(100, 20);
            this.Sensor_2_Scale_factor_Z.TabIndex = 27;
            this.Sensor_2_Scale_factor_Z.TextChanged += new System.EventHandler(this.Sensor_2_Scale_factor_Z_TextChanged);
            // 
            // Sensor_2_SF_Tempco_X
            // 
            this.Sensor_2_SF_Tempco_X.Location = new System.Drawing.Point(858, 105);
            this.Sensor_2_SF_Tempco_X.Name = "Sensor_2_SF_Tempco_X";
            this.Sensor_2_SF_Tempco_X.Size = new System.Drawing.Size(100, 20);
            this.Sensor_2_SF_Tempco_X.TabIndex = 27;
            this.Sensor_2_SF_Tempco_X.TextChanged += new System.EventHandler(this.Sensor_2_SF_Tempco_X_TextChanged);
            // 
            // Sensor_2_SF_Tempco_Y
            // 
            this.Sensor_2_SF_Tempco_Y.Location = new System.Drawing.Point(858, 145);
            this.Sensor_2_SF_Tempco_Y.Name = "Sensor_2_SF_Tempco_Y";
            this.Sensor_2_SF_Tempco_Y.Size = new System.Drawing.Size(100, 20);
            this.Sensor_2_SF_Tempco_Y.TabIndex = 27;
            this.Sensor_2_SF_Tempco_Y.TextChanged += new System.EventHandler(this.Sensor_2_SF_Tempco_Y_TextChanged);
            // 
            // Sensor_2_SF_Tempco_Z
            // 
            this.Sensor_2_SF_Tempco_Z.Location = new System.Drawing.Point(858, 185);
            this.Sensor_2_SF_Tempco_Z.Name = "Sensor_2_SF_Tempco_Z";
            this.Sensor_2_SF_Tempco_Z.Size = new System.Drawing.Size(100, 20);
            this.Sensor_2_SF_Tempco_Z.TabIndex = 27;
            this.Sensor_2_SF_Tempco_Z.TextChanged += new System.EventHandler(this.Sensor_2_SF_Tempco_Z_TextChanged);
            // 
            // Sensor_2_Offset_X
            // 
            this.Sensor_2_Offset_X.Location = new System.Drawing.Point(858, 225);
            this.Sensor_2_Offset_X.Name = "Sensor_2_Offset_X";
            this.Sensor_2_Offset_X.Size = new System.Drawing.Size(100, 20);
            this.Sensor_2_Offset_X.TabIndex = 27;
            this.Sensor_2_Offset_X.TextChanged += new System.EventHandler(this.Sensor_2_Offset_X_TextChanged);
            // 
            // Sensor_2_Offset_Y
            // 
            this.Sensor_2_Offset_Y.Location = new System.Drawing.Point(858, 265);
            this.Sensor_2_Offset_Y.Name = "Sensor_2_Offset_Y";
            this.Sensor_2_Offset_Y.Size = new System.Drawing.Size(100, 20);
            this.Sensor_2_Offset_Y.TabIndex = 27;
            this.Sensor_2_Offset_Y.TextChanged += new System.EventHandler(this.Sensor_2_Offset_Y_TextChanged);
            // 
            // Sensor_2_Offset_Z
            // 
            this.Sensor_2_Offset_Z.Location = new System.Drawing.Point(858, 305);
            this.Sensor_2_Offset_Z.Name = "Sensor_2_Offset_Z";
            this.Sensor_2_Offset_Z.Size = new System.Drawing.Size(100, 20);
            this.Sensor_2_Offset_Z.TabIndex = 27;
            this.Sensor_2_Offset_Z.TextChanged += new System.EventHandler(this.Sensor_2_Offset_Z_TextChanged);
            // 
            // Sensor_2_Offset_Tempco_X
            // 
            this.Sensor_2_Offset_Tempco_X.Location = new System.Drawing.Point(858, 345);
            this.Sensor_2_Offset_Tempco_X.Name = "Sensor_2_Offset_Tempco_X";
            this.Sensor_2_Offset_Tempco_X.Size = new System.Drawing.Size(100, 20);
            this.Sensor_2_Offset_Tempco_X.TabIndex = 27;
            this.Sensor_2_Offset_Tempco_X.TextChanged += new System.EventHandler(this.Sensor_2_Offset_Tempco_X_TextChanged);
            // 
            // Sensor_2_Offset_Tempco_Y
            // 
            this.Sensor_2_Offset_Tempco_Y.Location = new System.Drawing.Point(858, 385);
            this.Sensor_2_Offset_Tempco_Y.Name = "Sensor_2_Offset_Tempco_Y";
            this.Sensor_2_Offset_Tempco_Y.Size = new System.Drawing.Size(100, 20);
            this.Sensor_2_Offset_Tempco_Y.TabIndex = 27;
            this.Sensor_2_Offset_Tempco_Y.TextChanged += new System.EventHandler(this.Sensor_2_Offset_Tempco_Y_TextChanged);
            // 
            // Sensor_2_Offset_Tempco_Z
            // 
            this.Sensor_2_Offset_Tempco_Z.Location = new System.Drawing.Point(858, 425);
            this.Sensor_2_Offset_Tempco_Z.Name = "Sensor_2_Offset_Tempco_Z";
            this.Sensor_2_Offset_Tempco_Z.Size = new System.Drawing.Size(100, 20);
            this.Sensor_2_Offset_Tempco_Z.TabIndex = 27;
            this.Sensor_2_Offset_Tempco_Z.TextChanged += new System.EventHandler(this.Sensor_2_Offset_Tempco_Z_TextChanged);
            // 
            // Sensor_2_Misalign_Alpha
            // 
            this.Sensor_2_Misalign_Alpha.Location = new System.Drawing.Point(858, 465);
            this.Sensor_2_Misalign_Alpha.Name = "Sensor_2_Misalign_Alpha";
            this.Sensor_2_Misalign_Alpha.Size = new System.Drawing.Size(100, 20);
            this.Sensor_2_Misalign_Alpha.TabIndex = 27;
            this.Sensor_2_Misalign_Alpha.TextChanged += new System.EventHandler(this.Sensor_2_Misalign_Alpha_TextChanged);
            // 
            // Sensor_2_Misalign_Beta
            // 
            this.Sensor_2_Misalign_Beta.Location = new System.Drawing.Point(858, 505);
            this.Sensor_2_Misalign_Beta.Name = "Sensor_2_Misalign_Beta";
            this.Sensor_2_Misalign_Beta.Size = new System.Drawing.Size(100, 20);
            this.Sensor_2_Misalign_Beta.TabIndex = 27;
            this.Sensor_2_Misalign_Beta.TextChanged += new System.EventHandler(this.Sensor_2_Misalign_Beta_TextChanged);
            // 
            // Sensor_2_Misalign_Gamma
            // 
            this.Sensor_2_Misalign_Gamma.Location = new System.Drawing.Point(858, 545);
            this.Sensor_2_Misalign_Gamma.Name = "Sensor_2_Misalign_Gamma";
            this.Sensor_2_Misalign_Gamma.Size = new System.Drawing.Size(100, 20);
            this.Sensor_2_Misalign_Gamma.TabIndex = 27;
            this.Sensor_2_Misalign_Gamma.TextChanged += new System.EventHandler(this.Sensor_2_Misalign_Gamma_TextChanged);
            // 
            // Temperature_offset
            // 
            this.Temperature_offset.Location = new System.Drawing.Point(858, 585);
            this.Temperature_offset.Name = "Temperature_offset";
            this.Temperature_offset.Size = new System.Drawing.Size(100, 20);
            this.Temperature_offset.TabIndex = 27;
            this.Temperature_offset.TextChanged += new System.EventHandler(this.Temperature_offset_TextChanged);
            // 
            // Temperature_scale_factor
            // 
            this.Temperature_scale_factor.Location = new System.Drawing.Point(858, 625);
            this.Temperature_scale_factor.Name = "Temperature_scale_factor";
            this.Temperature_scale_factor.Size = new System.Drawing.Size(100, 20);
            this.Temperature_scale_factor.TabIndex = 27;
            this.Temperature_scale_factor.TextChanged += new System.EventHandler(this.Temperature_scale_factor_TextChanged);
            // 
            // label_Carrier_serial_number
            // 
            this.label_Carrier_serial_number.AutoSize = true;
            this.label_Carrier_serial_number.Location = new System.Drawing.Point(558, 5);
            this.label_Carrier_serial_number.Name = "label_Carrier_serial_number";
            this.label_Carrier_serial_number.Size = new System.Drawing.Size(108, 13);
            this.label_Carrier_serial_number.TabIndex = 28;
            this.label_Carrier_serial_number.Text = "Carrier_serial_number";
            // 
            // label_Sensor_1_name
            // 
            this.label_Sensor_1_name.AutoSize = true;
            this.label_Sensor_1_name.Location = new System.Drawing.Point(558, 45);
            this.label_Sensor_1_name.Name = "label_Sensor_1_name";
            this.label_Sensor_1_name.Size = new System.Drawing.Size(84, 13);
            this.label_Sensor_1_name.TabIndex = 28;
            this.label_Sensor_1_name.Text = "Sensor_1_name";
            // 
            // label_Sensor_2_name
            // 
            this.label_Sensor_2_name.AutoSize = true;
            this.label_Sensor_2_name.Location = new System.Drawing.Point(558, 85);
            this.label_Sensor_2_name.Name = "label_Sensor_2_name";
            this.label_Sensor_2_name.Size = new System.Drawing.Size(84, 13);
            this.label_Sensor_2_name.TabIndex = 28;
            this.label_Sensor_2_name.Text = "Sensor_2_name";
            // 
            // label_Sensor_1_active_sensors
            // 
            this.label_Sensor_1_active_sensors.AutoSize = true;
            this.label_Sensor_1_active_sensors.Location = new System.Drawing.Point(558, 125);
            this.label_Sensor_1_active_sensors.Name = "label_Sensor_1_active_sensors";
            this.label_Sensor_1_active_sensors.Size = new System.Drawing.Size(129, 13);
            this.label_Sensor_1_active_sensors.TabIndex = 28;
            this.label_Sensor_1_active_sensors.Text = "Sensor_1_active_sensors";
            // 
            // label_Sensor_1_installed_bitmap
            // 
            this.label_Sensor_1_installed_bitmap.AutoSize = true;
            this.label_Sensor_1_installed_bitmap.Location = new System.Drawing.Point(558, 165);
            this.label_Sensor_1_installed_bitmap.Name = "label_Sensor_1_installed_bitmap";
            this.label_Sensor_1_installed_bitmap.Size = new System.Drawing.Size(133, 13);
            this.label_Sensor_1_installed_bitmap.TabIndex = 28;
            this.label_Sensor_1_installed_bitmap.Text = "Sensor_1_installed_bitmap";
            // 
            // label_Sensor_1_enabled_bitmap
            // 
            this.label_Sensor_1_enabled_bitmap.AutoSize = true;
            this.label_Sensor_1_enabled_bitmap.Location = new System.Drawing.Point(558, 205);
            this.label_Sensor_1_enabled_bitmap.Name = "label_Sensor_1_enabled_bitmap";
            this.label_Sensor_1_enabled_bitmap.Size = new System.Drawing.Size(133, 13);
            this.label_Sensor_1_enabled_bitmap.TabIndex = 28;
            this.label_Sensor_1_enabled_bitmap.Text = "Sensor_1_enabled_bitmap";
            // 
            // label_Sensor_1_faulty_bitmap
            // 
            this.label_Sensor_1_faulty_bitmap.AutoSize = true;
            this.label_Sensor_1_faulty_bitmap.Location = new System.Drawing.Point(558, 245);
            this.label_Sensor_1_faulty_bitmap.Name = "label_Sensor_1_faulty_bitmap";
            this.label_Sensor_1_faulty_bitmap.Size = new System.Drawing.Size(120, 13);
            this.label_Sensor_1_faulty_bitmap.TabIndex = 28;
            this.label_Sensor_1_faulty_bitmap.Text = "Sensor_1_faulty_bitmap";
            // 
            // label_Sensor_2_active_sensors
            // 
            this.label_Sensor_2_active_sensors.AutoSize = true;
            this.label_Sensor_2_active_sensors.Location = new System.Drawing.Point(558, 285);
            this.label_Sensor_2_active_sensors.Name = "label_Sensor_2_active_sensors";
            this.label_Sensor_2_active_sensors.Size = new System.Drawing.Size(129, 13);
            this.label_Sensor_2_active_sensors.TabIndex = 28;
            this.label_Sensor_2_active_sensors.Text = "Sensor_2_active_sensors";
            // 
            // label_Sensor_2_installed_bitmap
            // 
            this.label_Sensor_2_installed_bitmap.AutoSize = true;
            this.label_Sensor_2_installed_bitmap.Location = new System.Drawing.Point(558, 325);
            this.label_Sensor_2_installed_bitmap.Name = "label_Sensor_2_installed_bitmap";
            this.label_Sensor_2_installed_bitmap.Size = new System.Drawing.Size(133, 13);
            this.label_Sensor_2_installed_bitmap.TabIndex = 28;
            this.label_Sensor_2_installed_bitmap.Text = "Sensor_2_installed_bitmap";
            // 
            // label_Sensor_2_enabled_bitmap
            // 
            this.label_Sensor_2_enabled_bitmap.AutoSize = true;
            this.label_Sensor_2_enabled_bitmap.Location = new System.Drawing.Point(558, 365);
            this.label_Sensor_2_enabled_bitmap.Name = "label_Sensor_2_enabled_bitmap";
            this.label_Sensor_2_enabled_bitmap.Size = new System.Drawing.Size(133, 13);
            this.label_Sensor_2_enabled_bitmap.TabIndex = 28;
            this.label_Sensor_2_enabled_bitmap.Text = "Sensor_2_enabled_bitmap";
            // 
            // label_Sensor_2_failty_bitmap
            // 
            this.label_Sensor_2_failty_bitmap.AutoSize = true;
            this.label_Sensor_2_failty_bitmap.Location = new System.Drawing.Point(558, 405);
            this.label_Sensor_2_failty_bitmap.Name = "label_Sensor_2_failty_bitmap";
            this.label_Sensor_2_failty_bitmap.Size = new System.Drawing.Size(116, 13);
            this.label_Sensor_2_failty_bitmap.TabIndex = 28;
            this.label_Sensor_2_failty_bitmap.Text = "Sensor_2_failty_bitmap";
            // 
            // label_Encoder_offset
            // 
            this.label_Encoder_offset.AutoSize = true;
            this.label_Encoder_offset.Location = new System.Drawing.Point(558, 445);
            this.label_Encoder_offset.Name = "label_Encoder_offset";
            this.label_Encoder_offset.Size = new System.Drawing.Size(79, 13);
            this.label_Encoder_offset.TabIndex = 28;
            this.label_Encoder_offset.Text = "Encoder_offset";
            // 
            // label_Sensor_1_Raw_data_format
            // 
            this.label_Sensor_1_Raw_data_format.AutoSize = true;
            this.label_Sensor_1_Raw_data_format.Location = new System.Drawing.Point(558, 485);
            this.label_Sensor_1_Raw_data_format.Name = "label_Sensor_1_Raw_data_format";
            this.label_Sensor_1_Raw_data_format.Size = new System.Drawing.Size(142, 13);
            this.label_Sensor_1_Raw_data_format.TabIndex = 28;
            this.label_Sensor_1_Raw_data_format.Text = "Sensor_1_Raw_data_format";
            // 
            // label_Sensor_2_Raw_data_format
            // 
            this.label_Sensor_2_Raw_data_format.AutoSize = true;
            this.label_Sensor_2_Raw_data_format.Location = new System.Drawing.Point(558, 525);
            this.label_Sensor_2_Raw_data_format.Name = "label_Sensor_2_Raw_data_format";
            this.label_Sensor_2_Raw_data_format.Size = new System.Drawing.Size(142, 13);
            this.label_Sensor_2_Raw_data_format.TabIndex = 28;
            this.label_Sensor_2_Raw_data_format.Text = "Sensor_2_Raw_data_format";
            // 
            // label_Sensor_1_Sample_rate
            // 
            this.label_Sensor_1_Sample_rate.AutoSize = true;
            this.label_Sensor_1_Sample_rate.Location = new System.Drawing.Point(558, 565);
            this.label_Sensor_1_Sample_rate.Name = "label_Sensor_1_Sample_rate";
            this.label_Sensor_1_Sample_rate.Size = new System.Drawing.Size(117, 13);
            this.label_Sensor_1_Sample_rate.TabIndex = 28;
            this.label_Sensor_1_Sample_rate.Text = "Sensor_1_Sample_rate";
            // 
            // label_Sensor_1_Scale_factor_X
            // 
            this.label_Sensor_1_Scale_factor_X.AutoSize = true;
            this.label_Sensor_1_Scale_factor_X.Location = new System.Drawing.Point(558, 605);
            this.label_Sensor_1_Scale_factor_X.Name = "label_Sensor_1_Scale_factor_X";
            this.label_Sensor_1_Scale_factor_X.Size = new System.Drawing.Size(131, 13);
            this.label_Sensor_1_Scale_factor_X.TabIndex = 28;
            this.label_Sensor_1_Scale_factor_X.Text = "Sensor_1_Scale_factor_X";
            // 
            // label_Sensor_1_Scale_factor_Y
            // 
            this.label_Sensor_1_Scale_factor_Y.AutoSize = true;
            this.label_Sensor_1_Scale_factor_Y.Location = new System.Drawing.Point(708, 5);
            this.label_Sensor_1_Scale_factor_Y.Name = "label_Sensor_1_Scale_factor_Y";
            this.label_Sensor_1_Scale_factor_Y.Size = new System.Drawing.Size(131, 13);
            this.label_Sensor_1_Scale_factor_Y.TabIndex = 28;
            this.label_Sensor_1_Scale_factor_Y.Text = "Sensor_1_Scale_factor_Y";
            // 
            // label_Sensor_1_Scale_factor_Z
            // 
            this.label_Sensor_1_Scale_factor_Z.AutoSize = true;
            this.label_Sensor_1_Scale_factor_Z.Location = new System.Drawing.Point(708, 45);
            this.label_Sensor_1_Scale_factor_Z.Name = "label_Sensor_1_Scale_factor_Z";
            this.label_Sensor_1_Scale_factor_Z.Size = new System.Drawing.Size(131, 13);
            this.label_Sensor_1_Scale_factor_Z.TabIndex = 28;
            this.label_Sensor_1_Scale_factor_Z.Text = "Sensor_1_Scale_factor_Z";
            // 
            // label_Sensor_1_SF_Tempco_X
            // 
            this.label_Sensor_1_SF_Tempco_X.AutoSize = true;
            this.label_Sensor_1_SF_Tempco_X.Location = new System.Drawing.Point(708, 85);
            this.label_Sensor_1_SF_Tempco_X.Name = "label_Sensor_1_SF_Tempco_X";
            this.label_Sensor_1_SF_Tempco_X.Size = new System.Drawing.Size(129, 13);
            this.label_Sensor_1_SF_Tempco_X.TabIndex = 28;
            this.label_Sensor_1_SF_Tempco_X.Text = "Sensor_1_SF_Tempco_X";
            // 
            // label_Sensor_1_SF_Tempco_Y
            // 
            this.label_Sensor_1_SF_Tempco_Y.AutoSize = true;
            this.label_Sensor_1_SF_Tempco_Y.Location = new System.Drawing.Point(708, 125);
            this.label_Sensor_1_SF_Tempco_Y.Name = "label_Sensor_1_SF_Tempco_Y";
            this.label_Sensor_1_SF_Tempco_Y.Size = new System.Drawing.Size(129, 13);
            this.label_Sensor_1_SF_Tempco_Y.TabIndex = 28;
            this.label_Sensor_1_SF_Tempco_Y.Text = "Sensor_1_SF_Tempco_Y";
            // 
            // label_Sensor_1_SF_Tempco_Z
            // 
            this.label_Sensor_1_SF_Tempco_Z.AutoSize = true;
            this.label_Sensor_1_SF_Tempco_Z.Location = new System.Drawing.Point(708, 165);
            this.label_Sensor_1_SF_Tempco_Z.Name = "label_Sensor_1_SF_Tempco_Z";
            this.label_Sensor_1_SF_Tempco_Z.Size = new System.Drawing.Size(129, 13);
            this.label_Sensor_1_SF_Tempco_Z.TabIndex = 28;
            this.label_Sensor_1_SF_Tempco_Z.Text = "Sensor_1_SF_Tempco_Z";
            // 
            // label_Sensor_1_Offset_X
            // 
            this.label_Sensor_1_Offset_X.AutoSize = true;
            this.label_Sensor_1_Offset_X.Location = new System.Drawing.Point(708, 205);
            this.label_Sensor_1_Offset_X.Name = "label_Sensor_1_Offset_X";
            this.label_Sensor_1_Offset_X.Size = new System.Drawing.Size(99, 13);
            this.label_Sensor_1_Offset_X.TabIndex = 28;
            this.label_Sensor_1_Offset_X.Text = "Sensor_1_Offset_X";
            // 
            // label_Sensor_1_Offset_Y
            // 
            this.label_Sensor_1_Offset_Y.AutoSize = true;
            this.label_Sensor_1_Offset_Y.Location = new System.Drawing.Point(708, 245);
            this.label_Sensor_1_Offset_Y.Name = "label_Sensor_1_Offset_Y";
            this.label_Sensor_1_Offset_Y.Size = new System.Drawing.Size(99, 13);
            this.label_Sensor_1_Offset_Y.TabIndex = 28;
            this.label_Sensor_1_Offset_Y.Text = "Sensor_1_Offset_Y";
            // 
            // label_Sensor_1_Offset_Z
            // 
            this.label_Sensor_1_Offset_Z.AutoSize = true;
            this.label_Sensor_1_Offset_Z.Location = new System.Drawing.Point(708, 285);
            this.label_Sensor_1_Offset_Z.Name = "label_Sensor_1_Offset_Z";
            this.label_Sensor_1_Offset_Z.Size = new System.Drawing.Size(99, 13);
            this.label_Sensor_1_Offset_Z.TabIndex = 28;
            this.label_Sensor_1_Offset_Z.Text = "Sensor_1_Offset_Z";
            // 
            // label_Sensor_1_Offset_Tempco_X
            // 
            this.label_Sensor_1_Offset_Tempco_X.AutoSize = true;
            this.label_Sensor_1_Offset_Tempco_X.Location = new System.Drawing.Point(708, 325);
            this.label_Sensor_1_Offset_Tempco_X.Name = "label_Sensor_1_Offset_Tempco_X";
            this.label_Sensor_1_Offset_Tempco_X.Size = new System.Drawing.Size(144, 13);
            this.label_Sensor_1_Offset_Tempco_X.TabIndex = 28;
            this.label_Sensor_1_Offset_Tempco_X.Text = "Sensor_1_Offset_Tempco_X";
            // 
            // label_Sensor_1_Offset_Tempco_Y
            // 
            this.label_Sensor_1_Offset_Tempco_Y.AutoSize = true;
            this.label_Sensor_1_Offset_Tempco_Y.Location = new System.Drawing.Point(708, 365);
            this.label_Sensor_1_Offset_Tempco_Y.Name = "label_Sensor_1_Offset_Tempco_Y";
            this.label_Sensor_1_Offset_Tempco_Y.Size = new System.Drawing.Size(144, 13);
            this.label_Sensor_1_Offset_Tempco_Y.TabIndex = 28;
            this.label_Sensor_1_Offset_Tempco_Y.Text = "Sensor_1_Offset_Tempco_Y";
            // 
            // label_Sensor_1_Offset_Tempco_Z
            // 
            this.label_Sensor_1_Offset_Tempco_Z.AutoSize = true;
            this.label_Sensor_1_Offset_Tempco_Z.Location = new System.Drawing.Point(708, 405);
            this.label_Sensor_1_Offset_Tempco_Z.Name = "label_Sensor_1_Offset_Tempco_Z";
            this.label_Sensor_1_Offset_Tempco_Z.Size = new System.Drawing.Size(144, 13);
            this.label_Sensor_1_Offset_Tempco_Z.TabIndex = 28;
            this.label_Sensor_1_Offset_Tempco_Z.Text = "Sensor_1_Offset_Tempco_Z";
            // 
            // label_Sensor_1_Misalign_Alpha
            // 
            this.label_Sensor_1_Misalign_Alpha.AutoSize = true;
            this.label_Sensor_1_Misalign_Alpha.Location = new System.Drawing.Point(708, 445);
            this.label_Sensor_1_Misalign_Alpha.Name = "label_Sensor_1_Misalign_Alpha";
            this.label_Sensor_1_Misalign_Alpha.Size = new System.Drawing.Size(129, 13);
            this.label_Sensor_1_Misalign_Alpha.TabIndex = 28;
            this.label_Sensor_1_Misalign_Alpha.Text = "Sensor_1_Misalign_Alpha";
            // 
            // label_Sensor_1_Misalign_Beta
            // 
            this.label_Sensor_1_Misalign_Beta.AutoSize = true;
            this.label_Sensor_1_Misalign_Beta.Location = new System.Drawing.Point(708, 485);
            this.label_Sensor_1_Misalign_Beta.Name = "label_Sensor_1_Misalign_Beta";
            this.label_Sensor_1_Misalign_Beta.Size = new System.Drawing.Size(124, 13);
            this.label_Sensor_1_Misalign_Beta.TabIndex = 28;
            this.label_Sensor_1_Misalign_Beta.Text = "Sensor_1_Misalign_Beta";
            // 
            // label_Sensor_1_Misalign_Gamma
            // 
            this.label_Sensor_1_Misalign_Gamma.AutoSize = true;
            this.label_Sensor_1_Misalign_Gamma.Location = new System.Drawing.Point(708, 525);
            this.label_Sensor_1_Misalign_Gamma.Name = "label_Sensor_1_Misalign_Gamma";
            this.label_Sensor_1_Misalign_Gamma.Size = new System.Drawing.Size(138, 13);
            this.label_Sensor_1_Misalign_Gamma.TabIndex = 28;
            this.label_Sensor_1_Misalign_Gamma.Text = "Sensor_1_Misalign_Gamma";
            // 
            // label_Sensor_2_Sample_rate
            // 
            this.label_Sensor_2_Sample_rate.AutoSize = true;
            this.label_Sensor_2_Sample_rate.Location = new System.Drawing.Point(708, 565);
            this.label_Sensor_2_Sample_rate.Name = "label_Sensor_2_Sample_rate";
            this.label_Sensor_2_Sample_rate.Size = new System.Drawing.Size(117, 13);
            this.label_Sensor_2_Sample_rate.TabIndex = 28;
            this.label_Sensor_2_Sample_rate.Text = "Sensor_2_Sample_rate";
            // 
            // label_Sensor_2_Scale_factor_X
            // 
            this.label_Sensor_2_Scale_factor_X.AutoSize = true;
            this.label_Sensor_2_Scale_factor_X.Location = new System.Drawing.Point(708, 605);
            this.label_Sensor_2_Scale_factor_X.Name = "label_Sensor_2_Scale_factor_X";
            this.label_Sensor_2_Scale_factor_X.Size = new System.Drawing.Size(131, 13);
            this.label_Sensor_2_Scale_factor_X.TabIndex = 28;
            this.label_Sensor_2_Scale_factor_X.Text = "Sensor_2_Scale_factor_X";
            // 
            // label_Sensor_2_Scale_factor_Y
            // 
            this.label_Sensor_2_Scale_factor_Y.AutoSize = true;
            this.label_Sensor_2_Scale_factor_Y.Location = new System.Drawing.Point(858, 5);
            this.label_Sensor_2_Scale_factor_Y.Name = "label_Sensor_2_Scale_factor_Y";
            this.label_Sensor_2_Scale_factor_Y.Size = new System.Drawing.Size(131, 13);
            this.label_Sensor_2_Scale_factor_Y.TabIndex = 28;
            this.label_Sensor_2_Scale_factor_Y.Text = "Sensor_2_Scale_factor_Y";
            // 
            // label_Sensor_2_Scale_factor_Z
            // 
            this.label_Sensor_2_Scale_factor_Z.AutoSize = true;
            this.label_Sensor_2_Scale_factor_Z.Location = new System.Drawing.Point(858, 45);
            this.label_Sensor_2_Scale_factor_Z.Name = "label_Sensor_2_Scale_factor_Z";
            this.label_Sensor_2_Scale_factor_Z.Size = new System.Drawing.Size(131, 13);
            this.label_Sensor_2_Scale_factor_Z.TabIndex = 28;
            this.label_Sensor_2_Scale_factor_Z.Text = "Sensor_2_Scale_factor_Z";
            // 
            // label_Sensor_2_SF_Tempco_X
            // 
            this.label_Sensor_2_SF_Tempco_X.AutoSize = true;
            this.label_Sensor_2_SF_Tempco_X.Location = new System.Drawing.Point(858, 85);
            this.label_Sensor_2_SF_Tempco_X.Name = "label_Sensor_2_SF_Tempco_X";
            this.label_Sensor_2_SF_Tempco_X.Size = new System.Drawing.Size(129, 13);
            this.label_Sensor_2_SF_Tempco_X.TabIndex = 28;
            this.label_Sensor_2_SF_Tempco_X.Text = "Sensor_2_SF_Tempco_X";
            // 
            // label_Sensor_2_SF_Tempco_Y
            // 
            this.label_Sensor_2_SF_Tempco_Y.AutoSize = true;
            this.label_Sensor_2_SF_Tempco_Y.Location = new System.Drawing.Point(858, 125);
            this.label_Sensor_2_SF_Tempco_Y.Name = "label_Sensor_2_SF_Tempco_Y";
            this.label_Sensor_2_SF_Tempco_Y.Size = new System.Drawing.Size(129, 13);
            this.label_Sensor_2_SF_Tempco_Y.TabIndex = 28;
            this.label_Sensor_2_SF_Tempco_Y.Text = "Sensor_2_SF_Tempco_Y";
            // 
            // label_Sensor_2_SF_Tempco_Z
            // 
            this.label_Sensor_2_SF_Tempco_Z.AutoSize = true;
            this.label_Sensor_2_SF_Tempco_Z.Location = new System.Drawing.Point(858, 165);
            this.label_Sensor_2_SF_Tempco_Z.Name = "label_Sensor_2_SF_Tempco_Z";
            this.label_Sensor_2_SF_Tempco_Z.Size = new System.Drawing.Size(129, 13);
            this.label_Sensor_2_SF_Tempco_Z.TabIndex = 28;
            this.label_Sensor_2_SF_Tempco_Z.Text = "Sensor_2_SF_Tempco_Z";
            // 
            // label_Sensor_2_Offset_X
            // 
            this.label_Sensor_2_Offset_X.AutoSize = true;
            this.label_Sensor_2_Offset_X.Location = new System.Drawing.Point(858, 205);
            this.label_Sensor_2_Offset_X.Name = "label_Sensor_2_Offset_X";
            this.label_Sensor_2_Offset_X.Size = new System.Drawing.Size(99, 13);
            this.label_Sensor_2_Offset_X.TabIndex = 28;
            this.label_Sensor_2_Offset_X.Text = "Sensor_2_Offset_X";
            // 
            // label_Sensor_2_Offset_Y
            // 
            this.label_Sensor_2_Offset_Y.AutoSize = true;
            this.label_Sensor_2_Offset_Y.Location = new System.Drawing.Point(858, 245);
            this.label_Sensor_2_Offset_Y.Name = "label_Sensor_2_Offset_Y";
            this.label_Sensor_2_Offset_Y.Size = new System.Drawing.Size(99, 13);
            this.label_Sensor_2_Offset_Y.TabIndex = 28;
            this.label_Sensor_2_Offset_Y.Text = "Sensor_2_Offset_Y";
            // 
            // label_Sensor_2_Offset_Z
            // 
            this.label_Sensor_2_Offset_Z.AutoSize = true;
            this.label_Sensor_2_Offset_Z.Location = new System.Drawing.Point(858, 285);
            this.label_Sensor_2_Offset_Z.Name = "label_Sensor_2_Offset_Z";
            this.label_Sensor_2_Offset_Z.Size = new System.Drawing.Size(99, 13);
            this.label_Sensor_2_Offset_Z.TabIndex = 28;
            this.label_Sensor_2_Offset_Z.Text = "Sensor_2_Offset_Z";
            // 
            // label_Sensor_2_Offset_Tempco_X
            // 
            this.label_Sensor_2_Offset_Tempco_X.AutoSize = true;
            this.label_Sensor_2_Offset_Tempco_X.Location = new System.Drawing.Point(858, 325);
            this.label_Sensor_2_Offset_Tempco_X.Name = "label_Sensor_2_Offset_Tempco_X";
            this.label_Sensor_2_Offset_Tempco_X.Size = new System.Drawing.Size(144, 13);
            this.label_Sensor_2_Offset_Tempco_X.TabIndex = 28;
            this.label_Sensor_2_Offset_Tempco_X.Text = "Sensor_2_Offset_Tempco_X";
            // 
            // label_Sensor_2_Offset_Tempco_Y
            // 
            this.label_Sensor_2_Offset_Tempco_Y.AutoSize = true;
            this.label_Sensor_2_Offset_Tempco_Y.Location = new System.Drawing.Point(858, 365);
            this.label_Sensor_2_Offset_Tempco_Y.Name = "label_Sensor_2_Offset_Tempco_Y";
            this.label_Sensor_2_Offset_Tempco_Y.Size = new System.Drawing.Size(144, 13);
            this.label_Sensor_2_Offset_Tempco_Y.TabIndex = 28;
            this.label_Sensor_2_Offset_Tempco_Y.Text = "Sensor_2_Offset_Tempco_Y";
            // 
            // label_Sensor_2_Offset_Tempco_Z
            // 
            this.label_Sensor_2_Offset_Tempco_Z.AutoSize = true;
            this.label_Sensor_2_Offset_Tempco_Z.Location = new System.Drawing.Point(858, 405);
            this.label_Sensor_2_Offset_Tempco_Z.Name = "label_Sensor_2_Offset_Tempco_Z";
            this.label_Sensor_2_Offset_Tempco_Z.Size = new System.Drawing.Size(144, 13);
            this.label_Sensor_2_Offset_Tempco_Z.TabIndex = 28;
            this.label_Sensor_2_Offset_Tempco_Z.Text = "Sensor_2_Offset_Tempco_Z";
            // 
            // label_Sensor_2_Misalign_Alpha
            // 
            this.label_Sensor_2_Misalign_Alpha.AutoSize = true;
            this.label_Sensor_2_Misalign_Alpha.Location = new System.Drawing.Point(858, 445);
            this.label_Sensor_2_Misalign_Alpha.Name = "label_Sensor_2_Misalign_Alpha";
            this.label_Sensor_2_Misalign_Alpha.Size = new System.Drawing.Size(129, 13);
            this.label_Sensor_2_Misalign_Alpha.TabIndex = 28;
            this.label_Sensor_2_Misalign_Alpha.Text = "Sensor_2_Misalign_Alpha";
            // 
            // label_Sensor_2_Misalign_Beta
            // 
            this.label_Sensor_2_Misalign_Beta.AutoSize = true;
            this.label_Sensor_2_Misalign_Beta.Location = new System.Drawing.Point(858, 485);
            this.label_Sensor_2_Misalign_Beta.Name = "label_Sensor_2_Misalign_Beta";
            this.label_Sensor_2_Misalign_Beta.Size = new System.Drawing.Size(124, 13);
            this.label_Sensor_2_Misalign_Beta.TabIndex = 28;
            this.label_Sensor_2_Misalign_Beta.Text = "Sensor_2_Misalign_Beta";
            // 
            // label_Sensor_2_Misalign_Gamma
            // 
            this.label_Sensor_2_Misalign_Gamma.AutoSize = true;
            this.label_Sensor_2_Misalign_Gamma.Location = new System.Drawing.Point(858, 525);
            this.label_Sensor_2_Misalign_Gamma.Name = "label_Sensor_2_Misalign_Gamma";
            this.label_Sensor_2_Misalign_Gamma.Size = new System.Drawing.Size(138, 13);
            this.label_Sensor_2_Misalign_Gamma.TabIndex = 28;
            this.label_Sensor_2_Misalign_Gamma.Text = "Sensor_2_Misalign_Gamma";
            // 
            // label_Temperature_offset
            // 
            this.label_Temperature_offset.AutoSize = true;
            this.label_Temperature_offset.Location = new System.Drawing.Point(858, 565);
            this.label_Temperature_offset.Name = "label_Temperature_offset";
            this.label_Temperature_offset.Size = new System.Drawing.Size(99, 13);
            this.label_Temperature_offset.TabIndex = 28;
            this.label_Temperature_offset.Text = "Temperature_offset";
            // 
            // label_Temperature_scale_factor
            // 
            this.label_Temperature_scale_factor.AutoSize = true;
            this.label_Temperature_scale_factor.Location = new System.Drawing.Point(858, 605);
            this.label_Temperature_scale_factor.Name = "label_Temperature_scale_factor";
            this.label_Temperature_scale_factor.Size = new System.Drawing.Size(131, 13);
            this.label_Temperature_scale_factor.TabIndex = 28;
            this.label_Temperature_scale_factor.Text = "Temperature_scale_factor";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(529, 20);
            this.progressBar1.TabIndex = 29;
            // 
            // Sent
            // 
            this.Sent.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Sent.Location = new System.Drawing.Point(12, 674);
            this.Sent.Name = "Sent";
            this.Sent.ReadOnly = true;
            this.Sent.Size = new System.Drawing.Size(945, 20);
            this.Sent.TabIndex = 30;
            // 
            // LoggProgress
            // 
            this.LoggProgress.Location = new System.Drawing.Point(12, 916);
            this.LoggProgress.Maximum = 20;
            this.LoggProgress.Name = "LoggProgress";
            this.LoggProgress.Size = new System.Drawing.Size(945, 23);
            this.LoggProgress.TabIndex = 32;
            // 
            // bt_Start_Logging
            // 
            this.bt_Start_Logging.Enabled = false;
            this.bt_Start_Logging.Location = new System.Drawing.Point(12, 887);
            this.bt_Start_Logging.Name = "bt_Start_Logging";
            this.bt_Start_Logging.Size = new System.Drawing.Size(143, 23);
            this.bt_Start_Logging.TabIndex = 33;
            this.bt_Start_Logging.Text = "Start Logging";
            this.bt_Start_Logging.UseVisualStyleBackColor = true;
            this.bt_Start_Logging.Click += new System.EventHandler(this.InitializeLoggSession);
            // 
            // LoggWorker
            // 
            this.LoggWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.LoggWorker_DoWork);
            // 
            // bt_Cancel_Logging
            // 
            this.bt_Cancel_Logging.Enabled = false;
            this.bt_Cancel_Logging.Location = new System.Drawing.Point(161, 887);
            this.bt_Cancel_Logging.Name = "bt_Cancel_Logging";
            this.bt_Cancel_Logging.Size = new System.Drawing.Size(137, 23);
            this.bt_Cancel_Logging.TabIndex = 34;
            this.bt_Cancel_Logging.Text = "Cancel Logging";
            this.bt_Cancel_Logging.UseVisualStyleBackColor = true;
            this.bt_Cancel_Logging.Click += new System.EventHandler(this.CancelLoggSession);
            // 
            // bt_Motor1_Setup
            // 
            this.bt_Motor1_Setup.Location = new System.Drawing.Point(441, 752);
            this.bt_Motor1_Setup.Name = "bt_Motor1_Setup";
            this.bt_Motor1_Setup.Size = new System.Drawing.Size(100, 23);
            this.bt_Motor1_Setup.TabIndex = 35;
            this.bt_Motor1_Setup.Text = "Motor1 Setup";
            this.bt_Motor1_Setup.UseVisualStyleBackColor = true;
            this.bt_Motor1_Setup.Click += new System.EventHandler(this.bt_Motor1_Setup_Click);
            // 
            // lb_Motor_Controller1
            // 
            this.lb_Motor_Controller1.AutoSize = true;
            this.lb_Motor_Controller1.Location = new System.Drawing.Point(438, 715);
            this.lb_Motor_Controller1.Name = "lb_Motor_Controller1";
            this.lb_Motor_Controller1.Size = new System.Drawing.Size(40, 13);
            this.lb_Motor_Controller1.TabIndex = 36;
            this.lb_Motor_Controller1.Text = "Motor1";
            // 
            // Motor1_Velocity
            // 
            this.Motor1_Velocity.Location = new System.Drawing.Point(441, 814);
            this.Motor1_Velocity.Name = "Motor1_Velocity";
            this.Motor1_Velocity.Size = new System.Drawing.Size(100, 20);
            this.Motor1_Velocity.TabIndex = 37;
            this.Motor1_Velocity.Text = "2000";
            // 
            // Motor1_Acceleration
            // 
            this.Motor1_Acceleration.Location = new System.Drawing.Point(441, 862);
            this.Motor1_Acceleration.Name = "Motor1_Acceleration";
            this.Motor1_Acceleration.Size = new System.Drawing.Size(100, 20);
            this.Motor1_Acceleration.TabIndex = 38;
            this.Motor1_Acceleration.Text = "1000";
            // 
            // bt_Motor1_Save_Setting
            // 
            this.bt_Motor1_Save_Setting.Enabled = false;
            this.bt_Motor1_Save_Setting.Location = new System.Drawing.Point(441, 887);
            this.bt_Motor1_Save_Setting.Name = "bt_Motor1_Save_Setting";
            this.bt_Motor1_Save_Setting.Size = new System.Drawing.Size(100, 23);
            this.bt_Motor1_Save_Setting.TabIndex = 41;
            this.bt_Motor1_Save_Setting.Text = "Save Settings";
            this.bt_Motor1_Save_Setting.UseVisualStyleBackColor = true;
            this.bt_Motor1_Save_Setting.Click += new System.EventHandler(this.bt_Motor1_Save_Setting_Click);
            // 
            // Logging_Period
            // 
            this.Logging_Period.Location = new System.Drawing.Point(12, 793);
            this.Logging_Period.Name = "Logging_Period";
            this.Logging_Period.Size = new System.Drawing.Size(100, 20);
            this.Logging_Period.TabIndex = 42;
            this.Logging_Period.Text = "6";
            // 
            // Toggle_Delay
            // 
            this.Toggle_Delay.Location = new System.Drawing.Point(12, 838);
            this.Toggle_Delay.Name = "Toggle_Delay";
            this.Toggle_Delay.Size = new System.Drawing.Size(100, 20);
            this.Toggle_Delay.TabIndex = 43;
            this.Toggle_Delay.Text = "1";
            // 
            // lb_Logging_Period
            // 
            this.lb_Logging_Period.AutoSize = true;
            this.lb_Logging_Period.Location = new System.Drawing.Point(12, 774);
            this.lb_Logging_Period.Name = "lb_Logging_Period";
            this.lb_Logging_Period.Size = new System.Drawing.Size(92, 13);
            this.lb_Logging_Period.TabIndex = 44;
            this.lb_Logging_Period.Text = "Logging Period (s)";
            // 
            // lb_Toggle_Delay
            // 
            this.lb_Toggle_Delay.AutoSize = true;
            this.lb_Toggle_Delay.Location = new System.Drawing.Point(9, 822);
            this.lb_Toggle_Delay.Name = "lb_Toggle_Delay";
            this.lb_Toggle_Delay.Size = new System.Drawing.Size(84, 13);
            this.lb_Toggle_Delay.TabIndex = 45;
            this.lb_Toggle_Delay.Text = "Toggle Delay (s)";
            // 
            // lb_Motor1_Velocity
            // 
            this.lb_Motor1_Velocity.AutoSize = true;
            this.lb_Motor1_Velocity.Location = new System.Drawing.Point(438, 798);
            this.lb_Motor1_Velocity.Name = "lb_Motor1_Velocity";
            this.lb_Motor1_Velocity.Size = new System.Drawing.Size(44, 13);
            this.lb_Motor1_Velocity.TabIndex = 46;
            this.lb_Motor1_Velocity.Text = "Velocity";
            // 
            // lb_Motor1_Acceleration
            // 
            this.lb_Motor1_Acceleration.AutoSize = true;
            this.lb_Motor1_Acceleration.Location = new System.Drawing.Point(443, 846);
            this.lb_Motor1_Acceleration.Name = "lb_Motor1_Acceleration";
            this.lb_Motor1_Acceleration.Size = new System.Drawing.Size(66, 13);
            this.lb_Motor1_Acceleration.TabIndex = 47;
            this.lb_Motor1_Acceleration.Text = "Acceleration";
            // 
            // Motor1_Status
            // 
            this.Motor1_Status.BackColor = System.Drawing.Color.Red;
            this.Motor1_Status.Location = new System.Drawing.Point(512, 729);
            this.Motor1_Status.Name = "Motor1_Status";
            this.Motor1_Status.ReadOnly = true;
            this.Motor1_Status.Size = new System.Drawing.Size(29, 20);
            this.Motor1_Status.TabIndex = 48;
            // 
            // cb_Logg_Enabled
            // 
            this.cb_Logg_Enabled.AutoSize = true;
            this.cb_Logg_Enabled.Location = new System.Drawing.Point(1011, 6);
            this.cb_Logg_Enabled.Name = "cb_Logg_Enabled";
            this.cb_Logg_Enabled.Size = new System.Drawing.Size(92, 17);
            this.cb_Logg_Enabled.TabIndex = 49;
            this.cb_Logg_Enabled.Text = "Logg Enabled";
            this.cb_Logg_Enabled.UseVisualStyleBackColor = true;
            this.cb_Logg_Enabled.CheckedChanged += new System.EventHandler(this.cb_Logg_Enabled_CheckedChanged);
            // 
            // cb_Motor1_Enabled
            // 
            this.cb_Motor1_Enabled.AutoSize = true;
            this.cb_Motor1_Enabled.Location = new System.Drawing.Point(441, 732);
            this.cb_Motor1_Enabled.Name = "cb_Motor1_Enabled";
            this.cb_Motor1_Enabled.Size = new System.Drawing.Size(65, 17);
            this.cb_Motor1_Enabled.TabIndex = 50;
            this.cb_Motor1_Enabled.Text = "Enabled";
            this.cb_Motor1_Enabled.UseVisualStyleBackColor = true;
            // 
            // cb_Motor2_Enabled
            // 
            this.cb_Motor2_Enabled.AutoSize = true;
            this.cb_Motor2_Enabled.Location = new System.Drawing.Point(613, 732);
            this.cb_Motor2_Enabled.Name = "cb_Motor2_Enabled";
            this.cb_Motor2_Enabled.Size = new System.Drawing.Size(65, 17);
            this.cb_Motor2_Enabled.TabIndex = 59;
            this.cb_Motor2_Enabled.Text = "Enabled";
            this.cb_Motor2_Enabled.UseVisualStyleBackColor = true;
            // 
            // Motor2_Status
            // 
            this.Motor2_Status.BackColor = System.Drawing.Color.Red;
            this.Motor2_Status.Location = new System.Drawing.Point(684, 729);
            this.Motor2_Status.Name = "Motor2_Status";
            this.Motor2_Status.ReadOnly = true;
            this.Motor2_Status.Size = new System.Drawing.Size(29, 20);
            this.Motor2_Status.TabIndex = 58;
            // 
            // lb_Motor2_Acceleration
            // 
            this.lb_Motor2_Acceleration.AutoSize = true;
            this.lb_Motor2_Acceleration.Location = new System.Drawing.Point(615, 846);
            this.lb_Motor2_Acceleration.Name = "lb_Motor2_Acceleration";
            this.lb_Motor2_Acceleration.Size = new System.Drawing.Size(66, 13);
            this.lb_Motor2_Acceleration.TabIndex = 57;
            this.lb_Motor2_Acceleration.Text = "Acceleration";
            // 
            // lb_Motor2_Velocity
            // 
            this.lb_Motor2_Velocity.AutoSize = true;
            this.lb_Motor2_Velocity.Location = new System.Drawing.Point(610, 798);
            this.lb_Motor2_Velocity.Name = "lb_Motor2_Velocity";
            this.lb_Motor2_Velocity.Size = new System.Drawing.Size(44, 13);
            this.lb_Motor2_Velocity.TabIndex = 56;
            this.lb_Motor2_Velocity.Text = "Velocity";
            // 
            // bt_Motor2_Save_Setting
            // 
            this.bt_Motor2_Save_Setting.Enabled = false;
            this.bt_Motor2_Save_Setting.Location = new System.Drawing.Point(613, 887);
            this.bt_Motor2_Save_Setting.Name = "bt_Motor2_Save_Setting";
            this.bt_Motor2_Save_Setting.Size = new System.Drawing.Size(100, 23);
            this.bt_Motor2_Save_Setting.TabIndex = 55;
            this.bt_Motor2_Save_Setting.Text = "Save Settings";
            this.bt_Motor2_Save_Setting.UseVisualStyleBackColor = true;
            this.bt_Motor2_Save_Setting.Click += new System.EventHandler(this.bt_Motor2_Save_Setting_Click);
            // 
            // Motor2_Acceleration
            // 
            this.Motor2_Acceleration.Location = new System.Drawing.Point(613, 862);
            this.Motor2_Acceleration.Name = "Motor2_Acceleration";
            this.Motor2_Acceleration.Size = new System.Drawing.Size(100, 20);
            this.Motor2_Acceleration.TabIndex = 54;
            this.Motor2_Acceleration.Text = "1000";
            // 
            // Motor2_Velocity
            // 
            this.Motor2_Velocity.Location = new System.Drawing.Point(613, 814);
            this.Motor2_Velocity.Name = "Motor2_Velocity";
            this.Motor2_Velocity.Size = new System.Drawing.Size(100, 20);
            this.Motor2_Velocity.TabIndex = 53;
            this.Motor2_Velocity.Text = "2000";
            // 
            // lb_Motor_Controller2
            // 
            this.lb_Motor_Controller2.AutoSize = true;
            this.lb_Motor_Controller2.Location = new System.Drawing.Point(610, 715);
            this.lb_Motor_Controller2.Name = "lb_Motor_Controller2";
            this.lb_Motor_Controller2.Size = new System.Drawing.Size(40, 13);
            this.lb_Motor_Controller2.TabIndex = 52;
            this.lb_Motor_Controller2.Text = "Motor2";
            // 
            // bt_Motor2_Setup
            // 
            this.bt_Motor2_Setup.Location = new System.Drawing.Point(613, 752);
            this.bt_Motor2_Setup.Name = "bt_Motor2_Setup";
            this.bt_Motor2_Setup.Size = new System.Drawing.Size(100, 23);
            this.bt_Motor2_Setup.TabIndex = 51;
            this.bt_Motor2_Setup.Text = "Motor2 Setup";
            this.bt_Motor2_Setup.UseVisualStyleBackColor = true;
            this.bt_Motor2_Setup.Click += new System.EventHandler(this.bt_Motor2_Setup_Click);
            // 
            // cb_Motor3_Enabled
            // 
            this.cb_Motor3_Enabled.AutoSize = true;
            this.cb_Motor3_Enabled.Location = new System.Drawing.Point(778, 732);
            this.cb_Motor3_Enabled.Name = "cb_Motor3_Enabled";
            this.cb_Motor3_Enabled.Size = new System.Drawing.Size(65, 17);
            this.cb_Motor3_Enabled.TabIndex = 68;
            this.cb_Motor3_Enabled.Text = "Enabled";
            this.cb_Motor3_Enabled.UseVisualStyleBackColor = true;
            // 
            // Motor3_Status
            // 
            this.Motor3_Status.BackColor = System.Drawing.Color.Red;
            this.Motor3_Status.Location = new System.Drawing.Point(849, 729);
            this.Motor3_Status.Name = "Motor3_Status";
            this.Motor3_Status.ReadOnly = true;
            this.Motor3_Status.Size = new System.Drawing.Size(29, 20);
            this.Motor3_Status.TabIndex = 67;
            // 
            // lb_Motor3_Acceleration
            // 
            this.lb_Motor3_Acceleration.AutoSize = true;
            this.lb_Motor3_Acceleration.Location = new System.Drawing.Point(780, 846);
            this.lb_Motor3_Acceleration.Name = "lb_Motor3_Acceleration";
            this.lb_Motor3_Acceleration.Size = new System.Drawing.Size(66, 13);
            this.lb_Motor3_Acceleration.TabIndex = 66;
            this.lb_Motor3_Acceleration.Text = "Acceleration";
            // 
            // lb_Motor3_Velocity
            // 
            this.lb_Motor3_Velocity.AutoSize = true;
            this.lb_Motor3_Velocity.Location = new System.Drawing.Point(775, 798);
            this.lb_Motor3_Velocity.Name = "lb_Motor3_Velocity";
            this.lb_Motor3_Velocity.Size = new System.Drawing.Size(44, 13);
            this.lb_Motor3_Velocity.TabIndex = 65;
            this.lb_Motor3_Velocity.Text = "Velocity";
            // 
            // bt_Motor3_Save_Setting
            // 
            this.bt_Motor3_Save_Setting.Enabled = false;
            this.bt_Motor3_Save_Setting.Location = new System.Drawing.Point(778, 887);
            this.bt_Motor3_Save_Setting.Name = "bt_Motor3_Save_Setting";
            this.bt_Motor3_Save_Setting.Size = new System.Drawing.Size(100, 23);
            this.bt_Motor3_Save_Setting.TabIndex = 64;
            this.bt_Motor3_Save_Setting.Text = "Save Settings";
            this.bt_Motor3_Save_Setting.UseVisualStyleBackColor = true;
            this.bt_Motor3_Save_Setting.Click += new System.EventHandler(this.bt_Motor3_Save_Setting_Click);
            // 
            // Motor3_Acceleration
            // 
            this.Motor3_Acceleration.Location = new System.Drawing.Point(778, 862);
            this.Motor3_Acceleration.Name = "Motor3_Acceleration";
            this.Motor3_Acceleration.Size = new System.Drawing.Size(100, 20);
            this.Motor3_Acceleration.TabIndex = 63;
            this.Motor3_Acceleration.Text = "1000";
            // 
            // Motor3_Velocity
            // 
            this.Motor3_Velocity.Location = new System.Drawing.Point(778, 814);
            this.Motor3_Velocity.Name = "Motor3_Velocity";
            this.Motor3_Velocity.Size = new System.Drawing.Size(100, 20);
            this.Motor3_Velocity.TabIndex = 62;
            this.Motor3_Velocity.Text = "2000";
            // 
            // lb_Motor_Controller3
            // 
            this.lb_Motor_Controller3.AutoSize = true;
            this.lb_Motor_Controller3.Location = new System.Drawing.Point(775, 715);
            this.lb_Motor_Controller3.Name = "lb_Motor_Controller3";
            this.lb_Motor_Controller3.Size = new System.Drawing.Size(40, 13);
            this.lb_Motor_Controller3.TabIndex = 61;
            this.lb_Motor_Controller3.Text = "Motor3";
            // 
            // bt_Motor3_Setup
            // 
            this.bt_Motor3_Setup.Location = new System.Drawing.Point(778, 752);
            this.bt_Motor3_Setup.Name = "bt_Motor3_Setup";
            this.bt_Motor3_Setup.Size = new System.Drawing.Size(100, 23);
            this.bt_Motor3_Setup.TabIndex = 60;
            this.bt_Motor3_Setup.Text = "Motor3 Setup";
            this.bt_Motor3_Setup.UseVisualStyleBackColor = true;
            this.bt_Motor3_Setup.Click += new System.EventHandler(this.bt_Motor3_Setup_Click);
            // 
            // Interfacer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 974);
            this.Controls.Add(this.cb_Motor3_Enabled);
            this.Controls.Add(this.Motor3_Status);
            this.Controls.Add(this.lb_Motor3_Acceleration);
            this.Controls.Add(this.lb_Motor3_Velocity);
            this.Controls.Add(this.bt_Motor3_Save_Setting);
            this.Controls.Add(this.Motor3_Acceleration);
            this.Controls.Add(this.Motor3_Velocity);
            this.Controls.Add(this.lb_Motor_Controller3);
            this.Controls.Add(this.bt_Motor3_Setup);
            this.Controls.Add(this.cb_Motor2_Enabled);
            this.Controls.Add(this.Motor2_Status);
            this.Controls.Add(this.lb_Motor2_Acceleration);
            this.Controls.Add(this.lb_Motor2_Velocity);
            this.Controls.Add(this.bt_Motor2_Save_Setting);
            this.Controls.Add(this.Motor2_Acceleration);
            this.Controls.Add(this.Motor2_Velocity);
            this.Controls.Add(this.lb_Motor_Controller2);
            this.Controls.Add(this.bt_Motor2_Setup);
            this.Controls.Add(this.cb_Motor1_Enabled);
            this.Controls.Add(this.cb_Logg_Enabled);
            this.Controls.Add(this.Motor1_Status);
            this.Controls.Add(this.lb_Motor1_Acceleration);
            this.Controls.Add(this.lb_Motor1_Velocity);
            this.Controls.Add(this.lb_Toggle_Delay);
            this.Controls.Add(this.lb_Logging_Period);
            this.Controls.Add(this.Toggle_Delay);
            this.Controls.Add(this.Logging_Period);
            this.Controls.Add(this.bt_Motor1_Save_Setting);
            this.Controls.Add(this.Motor1_Acceleration);
            this.Controls.Add(this.Motor1_Velocity);
            this.Controls.Add(this.lb_Motor_Controller1);
            this.Controls.Add(this.bt_Motor1_Setup);
            this.Controls.Add(this.bt_Cancel_Logging);
            this.Controls.Add(this.bt_Start_Logging);
            this.Controls.Add(this.LoggProgress);
            this.Controls.Add(this.Sent);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.bt_Set_Carrier);
            this.Controls.Add(this.bt_Reload_Carrier_List);
            this.Controls.Add(this.CarrierList);
            this.Controls.Add(this.Console);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bt_send);
            this.Controls.Add(this.lb_Baudrate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comList);
            this.Controls.Add(this.ComStatus);
            this.Controls.Add(this.sendMessage);
            this.Controls.Add(this.Baudrate);
            this.Controls.Add(this.bt_serialConnect);
            this.Controls.Add(this.Carrier_serial_number);
            this.Controls.Add(this.Sensor_1_name);
            this.Controls.Add(this.Sensor_2_name);
            this.Controls.Add(this.Sensor_1_active_sensors);
            this.Controls.Add(this.Sensor_1_installed_bitmap);
            this.Controls.Add(this.Sensor_1_enabled_bitmap);
            this.Controls.Add(this.Sensor_1_faulty_bitmap);
            this.Controls.Add(this.Sensor_2_active_sensors);
            this.Controls.Add(this.Sensor_2_installed_bitmap);
            this.Controls.Add(this.Sensor_2_enabled_bitmap);
            this.Controls.Add(this.Sensor_2_failty_bitmap);
            this.Controls.Add(this.Encoder_offset);
            this.Controls.Add(this.Sensor_1_Raw_data_format);
            this.Controls.Add(this.Sensor_2_Raw_data_format);
            this.Controls.Add(this.Sensor_1_Sample_rate);
            this.Controls.Add(this.Sensor_1_Scale_factor_X);
            this.Controls.Add(this.Sensor_1_Scale_factor_Y);
            this.Controls.Add(this.Sensor_1_Scale_factor_Z);
            this.Controls.Add(this.Sensor_1_SF_Tempco_X);
            this.Controls.Add(this.Sensor_1_SF_Tempco_Y);
            this.Controls.Add(this.Sensor_1_SF_Tempco_Z);
            this.Controls.Add(this.Sensor_1_Offset_X);
            this.Controls.Add(this.Sensor_1_Offset_Y);
            this.Controls.Add(this.Sensor_1_Offset_Z);
            this.Controls.Add(this.Sensor_1_Offset_Tempco_X);
            this.Controls.Add(this.Sensor_1_Offset_Tempco_Y);
            this.Controls.Add(this.Sensor_1_Offset_Tempco_Z);
            this.Controls.Add(this.Sensor_1_Misalign_Alpha);
            this.Controls.Add(this.Sensor_1_Misalign_Beta);
            this.Controls.Add(this.Sensor_1_Misalign_Gamma);
            this.Controls.Add(this.Sensor_2_Sample_rate);
            this.Controls.Add(this.Sensor_2_Scale_factor_X);
            this.Controls.Add(this.Sensor_2_Scale_factor_Y);
            this.Controls.Add(this.Sensor_2_Scale_factor_Z);
            this.Controls.Add(this.Sensor_2_SF_Tempco_X);
            this.Controls.Add(this.Sensor_2_SF_Tempco_Y);
            this.Controls.Add(this.Sensor_2_SF_Tempco_Z);
            this.Controls.Add(this.Sensor_2_Offset_X);
            this.Controls.Add(this.Sensor_2_Offset_Y);
            this.Controls.Add(this.Sensor_2_Offset_Z);
            this.Controls.Add(this.Sensor_2_Offset_Tempco_X);
            this.Controls.Add(this.Sensor_2_Offset_Tempco_Y);
            this.Controls.Add(this.Sensor_2_Offset_Tempco_Z);
            this.Controls.Add(this.Sensor_2_Misalign_Alpha);
            this.Controls.Add(this.Sensor_2_Misalign_Beta);
            this.Controls.Add(this.Sensor_2_Misalign_Gamma);
            this.Controls.Add(this.Temperature_offset);
            this.Controls.Add(this.Temperature_scale_factor);
            this.Controls.Add(this.label_Carrier_serial_number);
            this.Controls.Add(this.label_Sensor_1_name);
            this.Controls.Add(this.label_Sensor_2_name);
            this.Controls.Add(this.label_Sensor_1_active_sensors);
            this.Controls.Add(this.label_Sensor_1_installed_bitmap);
            this.Controls.Add(this.label_Sensor_1_enabled_bitmap);
            this.Controls.Add(this.label_Sensor_1_faulty_bitmap);
            this.Controls.Add(this.label_Sensor_2_active_sensors);
            this.Controls.Add(this.label_Sensor_2_installed_bitmap);
            this.Controls.Add(this.label_Sensor_2_enabled_bitmap);
            this.Controls.Add(this.label_Sensor_2_failty_bitmap);
            this.Controls.Add(this.label_Encoder_offset);
            this.Controls.Add(this.label_Sensor_1_Raw_data_format);
            this.Controls.Add(this.label_Sensor_2_Raw_data_format);
            this.Controls.Add(this.label_Sensor_1_Sample_rate);
            this.Controls.Add(this.label_Sensor_1_Scale_factor_X);
            this.Controls.Add(this.label_Sensor_1_Scale_factor_Y);
            this.Controls.Add(this.label_Sensor_1_Scale_factor_Z);
            this.Controls.Add(this.label_Sensor_1_SF_Tempco_X);
            this.Controls.Add(this.label_Sensor_1_SF_Tempco_Y);
            this.Controls.Add(this.label_Sensor_1_SF_Tempco_Z);
            this.Controls.Add(this.label_Sensor_1_Offset_X);
            this.Controls.Add(this.label_Sensor_1_Offset_Y);
            this.Controls.Add(this.label_Sensor_1_Offset_Z);
            this.Controls.Add(this.label_Sensor_1_Offset_Tempco_X);
            this.Controls.Add(this.label_Sensor_1_Offset_Tempco_Y);
            this.Controls.Add(this.label_Sensor_1_Offset_Tempco_Z);
            this.Controls.Add(this.label_Sensor_1_Misalign_Alpha);
            this.Controls.Add(this.label_Sensor_1_Misalign_Beta);
            this.Controls.Add(this.label_Sensor_1_Misalign_Gamma);
            this.Controls.Add(this.label_Sensor_2_Sample_rate);
            this.Controls.Add(this.label_Sensor_2_Scale_factor_X);
            this.Controls.Add(this.label_Sensor_2_Scale_factor_Y);
            this.Controls.Add(this.label_Sensor_2_Scale_factor_Z);
            this.Controls.Add(this.label_Sensor_2_SF_Tempco_X);
            this.Controls.Add(this.label_Sensor_2_SF_Tempco_Y);
            this.Controls.Add(this.label_Sensor_2_SF_Tempco_Z);
            this.Controls.Add(this.label_Sensor_2_Offset_X);
            this.Controls.Add(this.label_Sensor_2_Offset_Y);
            this.Controls.Add(this.label_Sensor_2_Offset_Z);
            this.Controls.Add(this.label_Sensor_2_Offset_Tempco_X);
            this.Controls.Add(this.label_Sensor_2_Offset_Tempco_Y);
            this.Controls.Add(this.label_Sensor_2_Offset_Tempco_Z);
            this.Controls.Add(this.label_Sensor_2_Misalign_Alpha);
            this.Controls.Add(this.label_Sensor_2_Misalign_Beta);
            this.Controls.Add(this.label_Sensor_2_Misalign_Gamma);
            this.Controls.Add(this.label_Temperature_offset);
            this.Controls.Add(this.label_Temperature_scale_factor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Interfacer";
            this.Text = "Testbench Interfacer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_serialConnect;
        private System.Windows.Forms.TextBox Baudrate;
        private System.Windows.Forms.TextBox sendMessage;
        //private System.Windows.Forms.TextBox Carrier_Serial_number;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.RichTextBox ComStatus;
        private System.ComponentModel.BackgroundWorker ReceiveWorker;
        private System.Windows.Forms.ListBox comList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Baudrate;
        private System.Windows.Forms.Button bt_send;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.RichTextBox Console;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox CarrierList;
        private System.Windows.Forms.Button bt_Reload_Carrier_List;
        private System.Windows.Forms.Button bt_Set_Carrier;
        private System.ComponentModel.BackgroundWorker SendWorker;

        private System.Windows.Forms.TextBox Carrier_serial_number;
        private System.Windows.Forms.Label label_Carrier_serial_number;
        private System.Windows.Forms.TextBox Sensor_1_name;
        private System.Windows.Forms.Label label_Sensor_1_name;
        private System.Windows.Forms.TextBox Sensor_2_name;
        private System.Windows.Forms.Label label_Sensor_2_name;
        private System.Windows.Forms.TextBox Sensor_1_active_sensors;
        private System.Windows.Forms.Label label_Sensor_1_active_sensors;
        private System.Windows.Forms.TextBox Sensor_1_installed_bitmap;
        private System.Windows.Forms.Label label_Sensor_1_installed_bitmap;
        private System.Windows.Forms.TextBox Sensor_1_enabled_bitmap;
        private System.Windows.Forms.Label label_Sensor_1_enabled_bitmap;
        private System.Windows.Forms.TextBox Sensor_1_faulty_bitmap;
        private System.Windows.Forms.Label label_Sensor_1_faulty_bitmap;
        private System.Windows.Forms.TextBox Sensor_2_active_sensors;
        private System.Windows.Forms.Label label_Sensor_2_active_sensors;
        private System.Windows.Forms.TextBox Sensor_2_installed_bitmap;
        private System.Windows.Forms.Label label_Sensor_2_installed_bitmap;
        private System.Windows.Forms.TextBox Sensor_2_enabled_bitmap;
        private System.Windows.Forms.Label label_Sensor_2_enabled_bitmap;
        private System.Windows.Forms.TextBox Sensor_2_failty_bitmap;
        private System.Windows.Forms.Label label_Sensor_2_failty_bitmap;
        private System.Windows.Forms.TextBox Encoder_offset;
        private System.Windows.Forms.Label label_Encoder_offset;
        private System.Windows.Forms.TextBox Sensor_1_Raw_data_format;
        private System.Windows.Forms.Label label_Sensor_1_Raw_data_format;
        private System.Windows.Forms.TextBox Sensor_2_Raw_data_format;
        private System.Windows.Forms.Label label_Sensor_2_Raw_data_format;
        private System.Windows.Forms.TextBox Sensor_1_Sample_rate;
        private System.Windows.Forms.Label label_Sensor_1_Sample_rate;
        private System.Windows.Forms.TextBox Sensor_1_Scale_factor_X;
        private System.Windows.Forms.Label label_Sensor_1_Scale_factor_X;
        private System.Windows.Forms.TextBox Sensor_1_Scale_factor_Y;
        private System.Windows.Forms.Label label_Sensor_1_Scale_factor_Y;
        private System.Windows.Forms.TextBox Sensor_1_Scale_factor_Z;
        private System.Windows.Forms.Label label_Sensor_1_Scale_factor_Z;
        private System.Windows.Forms.TextBox Sensor_1_SF_Tempco_X;
        private System.Windows.Forms.Label label_Sensor_1_SF_Tempco_X;
        private System.Windows.Forms.TextBox Sensor_1_SF_Tempco_Y;
        private System.Windows.Forms.Label label_Sensor_1_SF_Tempco_Y;
        private System.Windows.Forms.TextBox Sensor_1_SF_Tempco_Z;
        private System.Windows.Forms.Label label_Sensor_1_SF_Tempco_Z;
        private System.Windows.Forms.TextBox Sensor_1_Offset_X;
        private System.Windows.Forms.Label label_Sensor_1_Offset_X;
        private System.Windows.Forms.TextBox Sensor_1_Offset_Y;
        private System.Windows.Forms.Label label_Sensor_1_Offset_Y;
        private System.Windows.Forms.TextBox Sensor_1_Offset_Z;
        private System.Windows.Forms.Label label_Sensor_1_Offset_Z;
        private System.Windows.Forms.TextBox Sensor_1_Offset_Tempco_X;
        private System.Windows.Forms.Label label_Sensor_1_Offset_Tempco_X;
        private System.Windows.Forms.TextBox Sensor_1_Offset_Tempco_Y;
        private System.Windows.Forms.Label label_Sensor_1_Offset_Tempco_Y;
        private System.Windows.Forms.TextBox Sensor_1_Offset_Tempco_Z;
        private System.Windows.Forms.Label label_Sensor_1_Offset_Tempco_Z;
        private System.Windows.Forms.TextBox Sensor_1_Misalign_Alpha;
        private System.Windows.Forms.Label label_Sensor_1_Misalign_Alpha;
        private System.Windows.Forms.TextBox Sensor_1_Misalign_Beta;
        private System.Windows.Forms.Label label_Sensor_1_Misalign_Beta;
        private System.Windows.Forms.TextBox Sensor_1_Misalign_Gamma;
        private System.Windows.Forms.Label label_Sensor_1_Misalign_Gamma;
        private System.Windows.Forms.TextBox Sensor_2_Sample_rate;
        private System.Windows.Forms.Label label_Sensor_2_Sample_rate;
        private System.Windows.Forms.TextBox Sensor_2_Scale_factor_X;
        private System.Windows.Forms.Label label_Sensor_2_Scale_factor_X;
        private System.Windows.Forms.TextBox Sensor_2_Scale_factor_Y;
        private System.Windows.Forms.Label label_Sensor_2_Scale_factor_Y;
        private System.Windows.Forms.TextBox Sensor_2_Scale_factor_Z;
        private System.Windows.Forms.Label label_Sensor_2_Scale_factor_Z;
        private System.Windows.Forms.TextBox Sensor_2_SF_Tempco_X;
        private System.Windows.Forms.Label label_Sensor_2_SF_Tempco_X;
        private System.Windows.Forms.TextBox Sensor_2_SF_Tempco_Y;
        private System.Windows.Forms.Label label_Sensor_2_SF_Tempco_Y;
        private System.Windows.Forms.TextBox Sensor_2_SF_Tempco_Z;
        private System.Windows.Forms.Label label_Sensor_2_SF_Tempco_Z;
        private System.Windows.Forms.TextBox Sensor_2_Offset_X;
        private System.Windows.Forms.Label label_Sensor_2_Offset_X;
        private System.Windows.Forms.TextBox Sensor_2_Offset_Y;
        private System.Windows.Forms.Label label_Sensor_2_Offset_Y;
        private System.Windows.Forms.TextBox Sensor_2_Offset_Z;
        private System.Windows.Forms.Label label_Sensor_2_Offset_Z;
        private System.Windows.Forms.TextBox Sensor_2_Offset_Tempco_X;
        private System.Windows.Forms.Label label_Sensor_2_Offset_Tempco_X;
        private System.Windows.Forms.TextBox Sensor_2_Offset_Tempco_Y;
        private System.Windows.Forms.Label label_Sensor_2_Offset_Tempco_Y;
        private System.Windows.Forms.TextBox Sensor_2_Offset_Tempco_Z;
        private System.Windows.Forms.Label label_Sensor_2_Offset_Tempco_Z;
        private System.Windows.Forms.TextBox Sensor_2_Misalign_Alpha;
        private System.Windows.Forms.Label label_Sensor_2_Misalign_Alpha;
        private System.Windows.Forms.TextBox Sensor_2_Misalign_Beta;
        private System.Windows.Forms.Label label_Sensor_2_Misalign_Beta;
        private System.Windows.Forms.TextBox Sensor_2_Misalign_Gamma;
        private System.Windows.Forms.Label label_Sensor_2_Misalign_Gamma;
        private System.Windows.Forms.TextBox Temperature_offset;
        private System.Windows.Forms.Label label_Temperature_offset;
        private System.Windows.Forms.TextBox Temperature_scale_factor;
        private System.Windows.Forms.Label label_Temperature_scale_factor;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox Sent;
        private System.Windows.Forms.ProgressBar LoggProgress;
        private System.Windows.Forms.Button bt_Start_Logging;
        private System.ComponentModel.BackgroundWorker LoggWorker;
        private System.Windows.Forms.Button bt_Cancel_Logging;
        private System.Windows.Forms.Button bt_Motor1_Setup;
        private System.Windows.Forms.Label lb_Motor_Controller1;
        private System.Windows.Forms.TextBox Motor1_Velocity;
        private System.Windows.Forms.TextBox Motor1_Acceleration;
        private System.Windows.Forms.Button bt_Motor1_Save_Setting;
        private System.Windows.Forms.TextBox Logging_Period;
        private System.Windows.Forms.TextBox Toggle_Delay;
        private System.Windows.Forms.Label lb_Logging_Period;
        private System.Windows.Forms.Label lb_Toggle_Delay;
        private System.Windows.Forms.Label lb_Motor1_Velocity;
        private System.Windows.Forms.Label lb_Motor1_Acceleration;
        private System.Windows.Forms.TextBox Motor1_Status;
        private System.Windows.Forms.CheckBox cb_Logg_Enabled;
        private System.Windows.Forms.CheckBox cb_Motor1_Enabled;
        private System.Windows.Forms.CheckBox cb_Motor2_Enabled;
        private System.Windows.Forms.TextBox Motor2_Status;
        private System.Windows.Forms.Label lb_Motor2_Acceleration;
        private System.Windows.Forms.Label lb_Motor2_Velocity;
        private System.Windows.Forms.Button bt_Motor2_Save_Setting;
        private System.Windows.Forms.TextBox Motor2_Acceleration;
        private System.Windows.Forms.TextBox Motor2_Velocity;
        private System.Windows.Forms.Label lb_Motor_Controller2;
        private System.Windows.Forms.Button bt_Motor2_Setup;
        private System.Windows.Forms.CheckBox cb_Motor3_Enabled;
        private System.Windows.Forms.TextBox Motor3_Status;
        private System.Windows.Forms.Label lb_Motor3_Acceleration;
        private System.Windows.Forms.Label lb_Motor3_Velocity;
        private System.Windows.Forms.Button bt_Motor3_Save_Setting;
        private System.Windows.Forms.TextBox Motor3_Acceleration;
        private System.Windows.Forms.TextBox Motor3_Velocity;
        private System.Windows.Forms.Label lb_Motor_Controller3;
        private System.Windows.Forms.Button bt_Motor3_Setup;
    }
}

