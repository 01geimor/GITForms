namespace _09_Arduino
{
    partial class lbl_G
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
            this.pb_G = new System.Windows.Forms.PictureBox();
            this.btn_CreateG = new System.Windows.Forms.Button();
            this.cmb_analogpin = new System.Windows.Forms.ComboBox();
            this.gpb_Arduino.SuspendLayout();
            this.gpb_SetRGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Red)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tp_SetRGB.SuspendLayout();
            this.tp_Graphics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_G)).BeginInit();
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
            this.tp_SetRGB.Size = new System.Drawing.Size(593, 239);
            this.tp_SetRGB.TabIndex = 0;
            this.tp_SetRGB.Text = "Set RGB";
            this.tp_SetRGB.UseVisualStyleBackColor = true;
            // 
            // tp_Graphics
            // 
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
            // pb_G
            // 
            this.pb_G.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_G.Location = new System.Drawing.Point(3, 6);
            this.pb_G.Name = "pb_G";
            this.pb_G.Size = new System.Drawing.Size(512, 270);
            this.pb_G.TabIndex = 0;
            this.pb_G.TabStop = false;
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
            // cmb_analogpin
            // 
            this.cmb_analogpin.FormattingEnabled = true;
            this.cmb_analogpin.Items.AddRange(new object[] {
            "A0"});
            this.cmb_analogpin.Location = new System.Drawing.Point(516, 37);
            this.cmb_analogpin.Name = "cmb_analogpin";
            this.cmb_analogpin.Size = new System.Drawing.Size(71, 21);
            this.cmb_analogpin.TabIndex = 2;
            // 
            // lbl_G
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
            this.Name = "lbl_G";
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
            ((System.ComponentModel.ISupportInitialize)(this.pb_G)).EndInit();
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
    }
}

