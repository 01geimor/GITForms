namespace _09_Arduino
{
    partial class lbl_Refresh
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sP1 = new System.IO.Ports.SerialPort(this.components);
            this.cmb_Baud = new System.Windows.Forms.ComboBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.gpb_Arduino = new System.Windows.Forms.GroupBox();
            this.ltb_Ausgabe = new System.Windows.Forms.ListBox();
            this.txt_Eingabe = new System.Windows.Forms.TextBox();
            this.cmb_COM = new System.Windows.Forms.ComboBox();
            this.lbl_Baud = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gpb_SetRGB = new System.Windows.Forms.GroupBox();
            this.btn_Send2 = new System.Windows.Forms.Button();
            this.lbl_B = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_R = new System.Windows.Forms.Label();
            this.tb_Blue = new System.Windows.Forms.TrackBar();
            this.tb_Green = new System.Windows.Forms.TrackBar();
            this.tb_Red = new System.Windows.Forms.TrackBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_SetRGB = new System.Windows.Forms.TabPage();
            this.tp_Graphics = new System.Windows.Forms.TabPage();
            this.tb_ValueTimer = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_analogpin = new System.Windows.Forms.ComboBox();
            this.btn_CreateG = new System.Windows.Forms.Button();
            this.pb_G = new System.Windows.Forms.PictureBox();
            this.tp_Diode = new System.Windows.Forms.TabPage();
            this.btn_DStart = new System.Windows.Forms.Button();
            this.pb_Ddraw = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_DR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_DVPin = new System.Windows.Forms.ComboBox();
            this.cmb_DMPin = new System.Windows.Forms.ComboBox();
            this.gpb_Arduino.SuspendLayout();
            this.gpb_SetRGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Red)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tp_SetRGB.SuspendLayout();
            this.tp_Graphics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ValueTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_G)).BeginInit();
            this.tp_Diode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ddraw)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Baud
            // 
            this.cmb_Baud.AutoCompleteCustomSource.AddRange(new string[] {
            "9600"});
            this.cmb_Baud.FormattingEnabled = true;
            this.cmb_Baud.Items.AddRange(new object[] {
            "9600",
            "57600"});
            this.cmb_Baud.Location = new System.Drawing.Point(69, 13);
            this.cmb_Baud.Name = "cmb_Baud";
            this.cmb_Baud.Size = new System.Drawing.Size(121, 21);
            this.cmb_Baud.TabIndex = 0;
            this.cmb_Baud.SelectedIndexChanged += new System.EventHandler(this.cmb_Baud_SelectedIndexChanged);
            // 
            // btn_Send
            // 
            this.btn_Send.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Send.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Send.Location = new System.Drawing.Point(520, 131);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 1;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // gpb_Arduino
            // 
            this.gpb_Arduino.Controls.Add(this.ltb_Ausgabe);
            this.gpb_Arduino.Controls.Add(this.txt_Eingabe);
            this.gpb_Arduino.Controls.Add(this.btn_Send);
            this.gpb_Arduino.Enabled = false;
            this.gpb_Arduino.Location = new System.Drawing.Point(36, 40);
            this.gpb_Arduino.Name = "gpb_Arduino";
            this.gpb_Arduino.Size = new System.Drawing.Size(601, 161);
            this.gpb_Arduino.TabIndex = 2;
            this.gpb_Arduino.TabStop = false;
            this.gpb_Arduino.Text = "Arduino";
            // 
            // ltb_Ausgabe
            // 
            this.ltb_Ausgabe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ltb_Ausgabe.Location = new System.Drawing.Point(6, 20);
            this.ltb_Ausgabe.Name = "ltb_Ausgabe";
            this.ltb_Ausgabe.Size = new System.Drawing.Size(589, 108);
            this.ltb_Ausgabe.TabIndex = 4;
            // 
            // txt_Eingabe
            // 
            this.txt_Eingabe.Location = new System.Drawing.Point(6, 133);
            this.txt_Eingabe.Name = "txt_Eingabe";
            this.txt_Eingabe.Size = new System.Drawing.Size(508, 20);
            this.txt_Eingabe.TabIndex = 3;
            // 
            // cmb_COM
            // 
            this.cmb_COM.FormattingEnabled = true;
            this.cmb_COM.Location = new System.Drawing.Point(244, 13);
            this.cmb_COM.Name = "cmb_COM";
            this.cmb_COM.Size = new System.Drawing.Size(121, 21);
            this.cmb_COM.TabIndex = 3;
            // 
            // lbl_Baud
            // 
            this.lbl_Baud.AutoSize = true;
            this.lbl_Baud.Location = new System.Drawing.Point(33, 16);
            this.lbl_Baud.Name = "lbl_Baud";
            this.lbl_Baud.Size = new System.Drawing.Size(32, 13);
            this.lbl_Baud.TabIndex = 4;
            this.lbl_Baud.Text = "Baud";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(371, 11);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 6;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gpb_SetRGB
            // 
            this.gpb_SetRGB.Controls.Add(this.btn_Send2);
            this.gpb_SetRGB.Controls.Add(this.lbl_B);
            this.gpb_SetRGB.Controls.Add(this.label3);
            this.gpb_SetRGB.Controls.Add(this.lbl_R);
            this.gpb_SetRGB.Controls.Add(this.tb_Blue);
            this.gpb_SetRGB.Controls.Add(this.tb_Green);
            this.gpb_SetRGB.Controls.Add(this.tb_Red);
            this.gpb_SetRGB.Enabled = false;
            this.gpb_SetRGB.Location = new System.Drawing.Point(42, 31);
            this.gpb_SetRGB.Name = "gpb_SetRGB";
            this.gpb_SetRGB.Size = new System.Drawing.Size(508, 170);
            this.gpb_SetRGB.TabIndex = 8;
            this.gpb_SetRGB.TabStop = false;
            this.gpb_SetRGB.Text = "Set RGB";
            // 
            // btn_Send2
            // 
            this.btn_Send2.Location = new System.Drawing.Point(427, 141);
            this.btn_Send2.Name = "btn_Send2";
            this.btn_Send2.Size = new System.Drawing.Size(75, 23);
            this.btn_Send2.TabIndex = 6;
            this.btn_Send2.Text = "Send";
            this.btn_Send2.UseVisualStyleBackColor = true;
            this.btn_Send2.Click += new System.EventHandler(this.btn_Send2_Click);
            // 
            // lbl_B
            // 
            this.lbl_B.AutoSize = true;
            this.lbl_B.Location = new System.Drawing.Point(336, 136);
            this.lbl_B.Name = "lbl_B";
            this.lbl_B.Size = new System.Drawing.Size(28, 13);
            this.lbl_B.TabIndex = 5;
            this.lbl_B.Text = "Blue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Green";
            // 
            // lbl_R
            // 
            this.lbl_R.AutoSize = true;
            this.lbl_R.Location = new System.Drawing.Point(336, 37);
            this.lbl_R.Name = "lbl_R";
            this.lbl_R.Size = new System.Drawing.Size(27, 13);
            this.lbl_R.TabIndex = 3;
            this.lbl_R.Text = "Red";
            // 
            // tb_Blue
            // 
            this.tb_Blue.Location = new System.Drawing.Point(7, 124);
            this.tb_Blue.Maximum = 255;
            this.tb_Blue.Name = "tb_Blue";
            this.tb_Blue.Size = new System.Drawing.Size(322, 45);
            this.tb_Blue.TabIndex = 2;
            // 
            // tb_Green
            // 
            this.tb_Green.Location = new System.Drawing.Point(7, 72);
            this.tb_Green.Maximum = 255;
            this.tb_Green.Name = "tb_Green";
            this.tb_Green.Size = new System.Drawing.Size(322, 45);
            this.tb_Green.TabIndex = 1;
            // 
            // tb_Red
            // 
            this.tb_Red.Location = new System.Drawing.Point(7, 20);
            this.tb_Red.Maximum = 255;
            this.tb_Red.Name = "tb_Red";
            this.tb_Red.Size = new System.Drawing.Size(322, 45);
            this.tb_Red.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_SetRGB);
            this.tabControl1.Controls.Add(this.tp_Graphics);
            this.tabControl1.Controls.Add(this.tp_Diode);
            this.tabControl1.Location = new System.Drawing.Point(36, 208);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(601, 311);
            this.tabControl1.TabIndex = 10;
            // 
            // tp_SetRGB
            // 
            this.tp_SetRGB.Controls.Add(this.gpb_SetRGB);
            this.tp_SetRGB.Location = new System.Drawing.Point(4, 22);
            this.tp_SetRGB.Name = "tp_SetRGB";
            this.tp_SetRGB.Padding = new System.Windows.Forms.Padding(3);
            this.tp_SetRGB.Size = new System.Drawing.Size(593, 285);
            this.tp_SetRGB.TabIndex = 0;
            this.tp_SetRGB.Text = "Set RGB";
            this.tp_SetRGB.UseVisualStyleBackColor = true;
            // 
            // tp_Graphics
            // 
            this.tp_Graphics.Controls.Add(this.tb_ValueTimer);
            this.tp_Graphics.Controls.Add(this.label4);
            this.tp_Graphics.Controls.Add(this.label2);
            this.tp_Graphics.Controls.Add(this.cmb_analogpin);
            this.tp_Graphics.Controls.Add(this.btn_CreateG);
            this.tp_Graphics.Controls.Add(this.pb_G);
            this.tp_Graphics.Location = new System.Drawing.Point(4, 22);
            this.tp_Graphics.Name = "tp_Graphics";
            this.tp_Graphics.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Graphics.Size = new System.Drawing.Size(593, 285);
            this.tp_Graphics.TabIndex = 1;
            this.tp_Graphics.Text = "Graphics";
            this.tp_Graphics.UseVisualStyleBackColor = true;
            // 
            // tb_ValueTimer
            // 
            this.tb_ValueTimer.Location = new System.Drawing.Point(531, 107);
            this.tb_ValueTimer.Maximum = 100;
            this.tb_ValueTimer.Minimum = 1;
            this.tb_ValueTimer.Name = "tb_ValueTimer";
            this.tb_ValueTimer.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tb_ValueTimer.Size = new System.Drawing.Size(45, 169);
            this.tb_ValueTimer.TabIndex = 5;
            this.tb_ValueTimer.Value = 100;
            this.tb_ValueTimer.Scroll += new System.EventHandler(this.tb_ValueTimer_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Refresh Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "AnalogPin";
            // 
            // cmb_analogpin
            // 
            this.cmb_analogpin.FormattingEnabled = true;
            this.cmb_analogpin.Items.AddRange(new object[] {
            "A0"});
            this.cmb_analogpin.Location = new System.Drawing.Point(516, 49);
            this.cmb_analogpin.Name = "cmb_analogpin";
            this.cmb_analogpin.Size = new System.Drawing.Size(71, 21);
            this.cmb_analogpin.TabIndex = 2;
            // 
            // btn_CreateG
            // 
            this.btn_CreateG.Location = new System.Drawing.Point(516, 7);
            this.btn_CreateG.Name = "btn_CreateG";
            this.btn_CreateG.Size = new System.Drawing.Size(71, 23);
            this.btn_CreateG.TabIndex = 1;
            this.btn_CreateG.Text = "Create";
            this.btn_CreateG.UseVisualStyleBackColor = true;
            this.btn_CreateG.Click += new System.EventHandler(this.btn_CreateG_Click);
            // 
            // pb_G
            // 
            this.pb_G.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_G.Location = new System.Drawing.Point(3, 6);
            this.pb_G.Name = "pb_G";
            this.pb_G.Size = new System.Drawing.Size(512, 270);
            this.pb_G.TabIndex = 0;
            this.pb_G.TabStop = false;
            // 
            // tp_Diode
            // 
            this.tp_Diode.Controls.Add(this.btn_DStart);
            this.tp_Diode.Controls.Add(this.pb_Ddraw);
            this.tp_Diode.Controls.Add(this.label7);
            this.tp_Diode.Controls.Add(this.label6);
            this.tp_Diode.Controls.Add(this.txt_DR);
            this.tp_Diode.Controls.Add(this.label5);
            this.tp_Diode.Controls.Add(this.cmb_DVPin);
            this.tp_Diode.Controls.Add(this.cmb_DMPin);
            this.tp_Diode.Location = new System.Drawing.Point(4, 22);
            this.tp_Diode.Name = "tp_Diode";
            this.tp_Diode.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Diode.Size = new System.Drawing.Size(593, 285);
            this.tp_Diode.TabIndex = 2;
            this.tp_Diode.Text = "Diode";
            this.tp_Diode.UseVisualStyleBackColor = true;
            // 
            // btn_DStart
            // 
            this.btn_DStart.Location = new System.Drawing.Point(516, 88);
            this.btn_DStart.Name = "btn_DStart";
            this.btn_DStart.Size = new System.Drawing.Size(71, 23);
            this.btn_DStart.TabIndex = 11;
            this.btn_DStart.Text = "Start";
            this.btn_DStart.UseVisualStyleBackColor = true;
            this.btn_DStart.Click += new System.EventHandler(this.btn_DStart_Click);
            // 
            // pb_Ddraw
            // 
            this.pb_Ddraw.Location = new System.Drawing.Point(4, 4);
            this.pb_Ddraw.Name = "pb_Ddraw";
            this.pb_Ddraw.Size = new System.Drawing.Size(450, 275);
            this.pb_Ddraw.TabIndex = 7;
            this.pb_Ddraw.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(460, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mess Pin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Vcc Pin";
            // 
            // txt_DR
            // 
            this.txt_DR.Location = new System.Drawing.Point(517, 11);
            this.txt_DR.Name = "txt_DR";
            this.txt_DR.Size = new System.Drawing.Size(70, 20);
            this.txt_DR.TabIndex = 4;
            this.txt_DR.Text = "1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "R";
            // 
            // cmb_DVPin
            // 
            this.cmb_DVPin.Enabled = false;
            this.cmb_DVPin.FormattingEnabled = true;
            this.cmb_DVPin.Items.AddRange(new object[] {
            "A0",
            "A1",
            "A2",
            "A3"});
            this.cmb_DVPin.Location = new System.Drawing.Point(516, 34);
            this.cmb_DVPin.Name = "cmb_DVPin";
            this.cmb_DVPin.Size = new System.Drawing.Size(71, 21);
            this.cmb_DVPin.TabIndex = 2;
            this.cmb_DVPin.Text = "D5";
            // 
            // cmb_DMPin
            // 
            this.cmb_DMPin.FormattingEnabled = true;
            this.cmb_DMPin.Items.AddRange(new object[] {
            "A0",
            "A1",
            "A2",
            "A3"});
            this.cmb_DMPin.Location = new System.Drawing.Point(516, 61);
            this.cmb_DMPin.Name = "cmb_DMPin";
            this.cmb_DMPin.Size = new System.Drawing.Size(71, 21);
            this.cmb_DMPin.TabIndex = 1;
            this.cmb_DMPin.Text = "A2";
            // 
            // lbl_Refresh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 531);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Baud);
            this.Controls.Add(this.cmb_COM);
            this.Controls.Add(this.gpb_Arduino);
            this.Controls.Add(this.cmb_Baud);
            this.Name = "lbl_Refresh";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Arduino_Load);
            this.gpb_Arduino.ResumeLayout(false);
            this.gpb_Arduino.PerformLayout();
            this.gpb_SetRGB.ResumeLayout(false);
            this.gpb_SetRGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Red)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tp_SetRGB.ResumeLayout(false);
            this.tp_Graphics.ResumeLayout(false);
            this.tp_Graphics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ValueTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_G)).EndInit();
            this.tp_Diode.ResumeLayout(false);
            this.tp_Diode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ddraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort sP1;
        private System.Windows.Forms.ComboBox cmb_Baud;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.GroupBox gpb_Arduino;
        private System.Windows.Forms.TextBox txt_Eingabe;
        private System.Windows.Forms.ComboBox cmb_COM;
        private System.Windows.Forms.Label lbl_Baud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.ListBox ltb_Ausgabe;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gpb_SetRGB;
        private System.Windows.Forms.Label lbl_B;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_R;
        private System.Windows.Forms.TrackBar tb_Blue;
        private System.Windows.Forms.TrackBar tb_Green;
        private System.Windows.Forms.TrackBar tb_Red;
        private System.Windows.Forms.Button btn_Send2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_SetRGB;
        private System.Windows.Forms.TabPage tp_Graphics;
        private System.Windows.Forms.ComboBox cmb_analogpin;
        private System.Windows.Forms.Button btn_CreateG;
        private System.Windows.Forms.PictureBox pb_G;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tb_ValueTimer;
        private System.Windows.Forms.TabPage tp_Diode;
        private System.Windows.Forms.Button btn_DStart;
        private System.Windows.Forms.PictureBox pb_Ddraw;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_DR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_DVPin;
        private System.Windows.Forms.ComboBox cmb_DMPin;
    }
}

