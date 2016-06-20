﻿namespace DNS_gyro_Testbench_Interfacer
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
            this.bt_serialConnect = new System.Windows.Forms.Button();
            this.Baudrate = new System.Windows.Forms.TextBox();
            this.sendMessage = new System.Windows.Forms.TextBox();
            this.Carrier = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.ComStatus = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Baudrate = new System.Windows.Forms.Label();
            this.bt_send = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Console = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // bt_serialConnect
            // 
            this.bt_serialConnect.Location = new System.Drawing.Point(126, 144);
            this.bt_serialConnect.Name = "bt_serialConnect";
            this.bt_serialConnect.Size = new System.Drawing.Size(75, 23);
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
            this.sendMessage.Location = new System.Drawing.Point(388, 354);
            this.sendMessage.Name = "sendMessage";
            this.sendMessage.Size = new System.Drawing.Size(401, 20);
            this.sendMessage.TabIndex = 2;
            // 
            // Carrier
            // 
            this.Carrier.Location = new System.Drawing.Point(74, 415);
            this.Carrier.Name = "Carrier";
            this.Carrier.Size = new System.Drawing.Size(1377, 20);
            this.Carrier.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(257, 158);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(257, 184);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(257, 210);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 6;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(257, 236);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 7;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(257, 262);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 8;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(257, 288);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 9;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(257, 314);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 10;
            // 
            // ComStatus
            // 
            this.ComStatus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ComStatus.Location = new System.Drawing.Point(93, 26);
            this.ComStatus.Name = "ComStatus";
            this.ComStatus.ReadOnly = true;
            this.ComStatus.Size = new System.Drawing.Size(108, 95);
            this.ComStatus.TabIndex = 11;
            this.ComStatus.Text = "";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.serial_Read_Worker);
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
            this.bt_send.Location = new System.Drawing.Point(812, 354);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(75, 23);
            this.bt_send.TabIndex = 14;
            this.bt_send.Text = "Send";
            this.bt_send.UseVisualStyleBackColor = true;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 753);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1463, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // Console
            // 
            this.Console.BackColor = System.Drawing.Color.FloralWhite;
            this.Console.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Console.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Console.Location = new System.Drawing.Point(388, 26);
            this.Console.MaxLength = 2000000;
            this.Console.Name = "Console";
            this.Console.ReadOnly = true;
            this.Console.Size = new System.Drawing.Size(499, 308);
            this.Console.TabIndex = 15;
            this.Console.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 775);
            this.Controls.Add(this.Console);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bt_send);
            this.Controls.Add(this.lb_Baudrate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comList);
            this.Controls.Add(this.ComStatus);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Carrier);
            this.Controls.Add(this.sendMessage);
            this.Controls.Add(this.Baudrate);
            this.Controls.Add(this.bt_serialConnect);
            this.Name = "Form1";
            this.Text = "DNS-gyro Testbench Interfacer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_serialConnect;
        private System.Windows.Forms.TextBox Baudrate;
        private System.Windows.Forms.TextBox sendMessage;
        private System.Windows.Forms.TextBox Carrier;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.RichTextBox ComStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox comList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Baudrate;
        private System.Windows.Forms.Button bt_send;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.RichTextBox Console;
    }
}
