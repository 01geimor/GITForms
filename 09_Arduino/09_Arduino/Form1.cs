using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace _09_Arduino
{
    public partial class lstb_Ausgabe : Form
    {
        public lstb_Ausgabe()
        {
            InitializeComponent();
        }

        private void Arduino_Load(object sender, EventArgs e)
        {
            string[] a =SerialPort.GetPortNames();
            cmb_COM.Items.AddRange(a);

        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (btn_Connect.Text=="Connect")
            {
                try
                {
                    sP1 = new SerialPort(cmb_COM.Text, Convert.ToInt32(cmb_Baud.Text));
                    btn_Connect.Text = "Disconnect";
                    InOff(false);
                    sP1.Open();
                    timer1.Start();
                }
                catch
                {
                    MessageBox.Show("Fehlerhafte Eingabe");
                }
            }
            else
            {
                timer1.Stop();
                sP1.Close();
                InOff(true);
                btn_Connect.Text = "Connect";
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            string s;
            try
            {
                s = txt_Eingabe.Text;
                sP1.WriteLine(s);
                txt_Eingabe.Text = null;
                ltb_Ausgabe.Items.Add(s);
            }
            catch
            {
                MessageBox.Show("Eingabe Fehlerhaft");
            }
        }

        private void cmb_Baud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InOff(bool b)
        {
            cmb_Baud.Enabled = b;
            cmb_COM.Enabled = b;
            gpb_Arduino.Enabled = !b;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ltb_Ausgabe.Items.Add(sP1.ReadExisting());
        }
    }
}
