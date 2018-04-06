using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace _09_Arduino
{
    public partial class lbl_Refresh : Form
    {
        string rgb = "setrgb#";
        string analogRead = "getvalue#";
        string analogpin;
        Graphics g;
        Pen p;
        bool graphic;
        float drawx=1;
        float drawx2 = 1;
        float drawy2 = 1;
        bool gfirst = true;

        public lbl_Refresh()
        {
            InitializeComponent();
        }

        private void Arduino_Load(object sender, EventArgs e)
        {
            string[] a = SerialPort.GetPortNames();
            cmb_COM.Items.AddRange(a);
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (btn_Connect.Text == "Connect")
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
            string s = sP1.ReadExisting();
            if (s != "")
            {
                ltb_Ausgabe.Items.Add(s);
            }

            if (graphic)
            {
                GraphicValue();
            }
        }

        private void btn_Send2_Click(object sender, EventArgs e)
        {
            sP1.WriteLine(rgb + "R" + tb_Red.Value.ToString());
            sP1.WriteLine(rgb + "G" + tb_Green.Value.ToString());
            sP1.WriteLine(rgb + "B" + tb_Blue.Value.ToString());
        }

        private void GraphicValue()
        {
            string s;
            int try1=0;
            sP1.WriteLine(analogRead + analogpin);
            do
            {
                Thread.Sleep(1);
                 s = sP1.ReadExisting();
                try1++;
            } while (s == ""|| try1 < 10);

            if (try1 != 10)
            {
                try
                {
                    s = s.Substring(4);
                    int gvalue = Convert.ToInt32(s);
                    Draw(gvalue);
                }
                catch
                {

                }
            }
            else
            {
                MessageBox.Show("Keine Daten wurden eingelesen");
            }
        }

        private void btn_CreateG_Click(object sender, EventArgs e)
        {
            try
            {
                analogpin = cmb_analogpin.Text;
                MessageBox.Show("Analogpin '"+ analogpin +"' wurde ausgewählt");
            }
            catch
            {
                analogpin = "A0";
                MessageBox.Show("Eingabe fehlerhaft! Analogpin A0 wurde ausgewählt");
            }
            g = pb_G.CreateGraphics();
            p = new Pen(Color.Black, 2);
            graphic = true;
        }

        private void Draw(int gvalue)
        {
            if (drawx > pb_G.Width)
            {
                g.Clear(Color.White);
                drawx=1;
                drawx2 = 1;
            }

            

            float gvaluen = ((gvalue / 4)*-1)+(pb_G.Height-10);

            if (gfirst)
            {
                drawy2 = gvaluen;
                gfirst = false;
            }

            g.DrawLine(p, drawx2, drawy2, drawx, gvaluen);
            drawx2 = drawx;
            drawy2 = gvaluen;
            drawx += 0.3f;
        }

        private void tb_ValueTimer_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = tb_ValueTimer.Value;
        }
    }
}
