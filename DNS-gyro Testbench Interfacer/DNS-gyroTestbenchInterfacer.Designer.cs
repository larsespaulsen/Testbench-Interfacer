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
            this.statusStrip1.Location = new System.Drawing.Point(0, 697);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1023, 22);
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
            // Interfacer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 719);
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
            this.Text = "DNS-gyro Testbench Interfacer";
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
    }
}

