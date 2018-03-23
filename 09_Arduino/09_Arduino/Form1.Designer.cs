namespace _09_Arduino
{
    partial class lstb_Ausgabe
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
            this.txt_Eingabe = new System.Windows.Forms.TextBox();
            this.cmb_COM = new System.Windows.Forms.ComboBox();
            this.lbl_Baud = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.ltb_Ausgabe = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gpb_Arduino.SuspendLayout();
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
            this.btn_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Send.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Send.Location = new System.Drawing.Point(425, 204);
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
            this.gpb_Arduino.Size = new System.Drawing.Size(508, 233);
            this.gpb_Arduino.TabIndex = 2;
            this.gpb_Arduino.TabStop = false;
            this.gpb_Arduino.Text = "Arduino";
            // 
            // txt_Eingabe
            // 
            this.txt_Eingabe.Location = new System.Drawing.Point(7, 206);
            this.txt_Eingabe.Name = "txt_Eingabe";
            this.txt_Eingabe.Size = new System.Drawing.Size(403, 20);
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
            // ltb_Ausgabe
            // 
            this.ltb_Ausgabe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ltb_Ausgabe.FormattingEnabled = true;
            this.ltb_Ausgabe.Location = new System.Drawing.Point(7, 20);
            this.ltb_Ausgabe.Name = "ltb_Ausgabe";
            this.ltb_Ausgabe.Size = new System.Drawing.Size(493, 173);
            this.ltb_Ausgabe.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lstb_Ausgabe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 485);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Baud);
            this.Controls.Add(this.cmb_COM);
            this.Controls.Add(this.gpb_Arduino);
            this.Controls.Add(this.cmb_Baud);
            this.Name = "lstb_Ausgabe";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Arduino_Load);
            this.gpb_Arduino.ResumeLayout(false);
            this.gpb_Arduino.PerformLayout();
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
    }
}

