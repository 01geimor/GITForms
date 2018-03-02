namespace _07_Widerstand
{
    partial class Form1
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
            this.r1 = new System.Windows.Forms.ComboBox();
            this.r4 = new System.Windows.Forms.ComboBox();
            this.r3 = new System.Windows.Forms.ComboBox();
            this.r2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtb_Ausgabe = new System.Windows.Forms.TextBox();
            this.btn_rechner = new System.Windows.Forms.Button();
            this.txtB_Toleranz = new System.Windows.Forms.TextBox();
            this.lbl_Toleranz = new System.Windows.Forms.Label();
            this.lbl_Wert = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            this.SuspendLayout();
            // 
            // r1
            // 
            this.r1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r1.FormattingEnabled = true;
            this.r1.Items.AddRange(new object[] {
            "Schwarz",
            "Braun",
            "Rot",
            "Orange",
            "Gelb",
            "Grün",
            "Blau",
            "Violett",
            "Grau",
            "Weiss"});
            this.r1.Location = new System.Drawing.Point(35, 42);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(96, 24);
            this.r1.TabIndex = 0;
            this.r1.SelectedIndexChanged += new System.EventHandler(this.r1_SelectedIndexChanged);
            // 
            // r4
            // 
            this.r4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r4.FormattingEnabled = true;
            this.r4.Items.AddRange(new object[] {
            "Braun",
            "Rot",
            "Grün",
            "Blau",
            "Violett",
            "Gold",
            "Silber"});
            this.r4.Location = new System.Drawing.Point(341, 42);
            this.r4.Name = "r4";
            this.r4.Size = new System.Drawing.Size(96, 24);
            this.r4.TabIndex = 1;
            this.r4.SelectedIndexChanged += new System.EventHandler(this.r4_SelectedIndexChanged);
            // 
            // r3
            // 
            this.r3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r3.FormattingEnabled = true;
            this.r3.Items.AddRange(new object[] {
            "Schwarz",
            "Braun",
            "Rot",
            "Orange",
            "Gelb",
            "Grün",
            "Blau",
            "Violett",
            "Gold",
            "Silber"});
            this.r3.Location = new System.Drawing.Point(239, 42);
            this.r3.Name = "r3";
            this.r3.Size = new System.Drawing.Size(96, 24);
            this.r3.TabIndex = 2;
            this.r3.SelectedIndexChanged += new System.EventHandler(this.r3_SelectedIndexChanged);
            // 
            // r2
            // 
            this.r2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r2.FormattingEnabled = true;
            this.r2.Items.AddRange(new object[] {
            "Schwarz",
            "Braun",
            "Rot",
            "Orange",
            "Gelb",
            "Grün",
            "Blau",
            "Violett",
            "Grau",
            "Weiss"});
            this.r2.Location = new System.Drawing.Point(137, 42);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(96, 24);
            this.r2.TabIndex = 3;
            this.r2.SelectedIndexChanged += new System.EventHandler(this.r2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(35, 42);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(82, 63);
            this.pb1.TabIndex = 5;
            this.pb1.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.Location = new System.Drawing.Point(341, 42);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(82, 63);
            this.pb4.TabIndex = 6;
            this.pb4.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(239, 42);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(82, 63);
            this.pb3.TabIndex = 7;
            this.pb3.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(137, 42);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(82, 63);
            this.pb2.TabIndex = 8;
            this.pb2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // txtb_Ausgabe
            // 
            this.txtb_Ausgabe.Location = new System.Drawing.Point(413, 209);
            this.txtb_Ausgabe.Name = "txtb_Ausgabe";
            this.txtb_Ausgabe.Size = new System.Drawing.Size(100, 20);
            this.txtb_Ausgabe.TabIndex = 12;
            // 
            // btn_rechner
            // 
            this.btn_rechner.Location = new System.Drawing.Point(438, 261);
            this.btn_rechner.Name = "btn_rechner";
            this.btn_rechner.Size = new System.Drawing.Size(75, 23);
            this.btn_rechner.TabIndex = 13;
            this.btn_rechner.Text = "Berechnen";
            this.btn_rechner.UseVisualStyleBackColor = true;
            this.btn_rechner.Click += new System.EventHandler(this.btn_rechner_Click);
            // 
            // txtB_Toleranz
            // 
            this.txtB_Toleranz.Location = new System.Drawing.Point(413, 235);
            this.txtB_Toleranz.Name = "txtB_Toleranz";
            this.txtB_Toleranz.Size = new System.Drawing.Size(100, 20);
            this.txtB_Toleranz.TabIndex = 14;
            // 
            // lbl_Toleranz
            // 
            this.lbl_Toleranz.AutoSize = true;
            this.lbl_Toleranz.Location = new System.Drawing.Point(359, 242);
            this.lbl_Toleranz.Name = "lbl_Toleranz";
            this.lbl_Toleranz.Size = new System.Drawing.Size(48, 13);
            this.lbl_Toleranz.TabIndex = 15;
            this.lbl_Toleranz.Text = "Toleranz";
            // 
            // lbl_Wert
            // 
            this.lbl_Wert.AutoSize = true;
            this.lbl_Wert.Location = new System.Drawing.Point(377, 216);
            this.lbl_Wert.Name = "lbl_Wert";
            this.lbl_Wert.Size = new System.Drawing.Size(30, 13);
            this.lbl_Wert.TabIndex = 16;
            this.lbl_Wert.Text = "Wert";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 388);
            this.Controls.Add(this.lbl_Wert);
            this.Controls.Add(this.lbl_Toleranz);
            this.Controls.Add(this.txtB_Toleranz);
            this.Controls.Add(this.btn_rechner);
            this.Controls.Add(this.txtb_Ausgabe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.r2);
            this.Controls.Add(this.r3);
            this.Controls.Add(this.r4);
            this.Controls.Add(this.r1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox r1;
        private System.Windows.Forms.ComboBox r4;
        private System.Windows.Forms.ComboBox r3;
        private System.Windows.Forms.ComboBox r2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtb_Ausgabe;
        private System.Windows.Forms.Button btn_rechner;
        private System.Windows.Forms.TextBox txtB_Toleranz;
        private System.Windows.Forms.Label lbl_Toleranz;
        private System.Windows.Forms.Label lbl_Wert;
    }
}

