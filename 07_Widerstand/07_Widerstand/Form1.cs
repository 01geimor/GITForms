using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _07_Widerstand
{
    public partial class Form1 : Form
    {
        int code;
        string toleranz;

        public Form1()
        {
            InitializeComponent();
            r1.Text = "Schwarz";
            r2.Text = "Schwarz";
            r3.Text = "Schwarz";
            r4.Text = "Gold";
        }

        private void r1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColorChange(pb1,r1);
            label1.Text = r1.SelectedItem.ToString();
        }

        private void r2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColorChange(pb2, r2);
            label2.Text = r2.SelectedItem.ToString();
        }

        private void r3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColorChange(pb3, r3);
            label3.Text = r3.SelectedItem.ToString();
        }

        private void r4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColorChange(pb4, r4);
            label4.Text = r4.SelectedItem.ToString();
        }
        
        private void ColorChange(PictureBox pb,ComboBox cb)
        {
            switch (cb.Text)
            {
                case "Schwarz":
                    {
                        pb.BackColor = Color.Black;
                    }
                    break;
                case "Braun":
                    {
                        pb.BackColor = Color.SaddleBrown;
                        FarbCode(cb, 1, 10, "1");
                    }
                    break;
                case "Rot":
                    {
                        pb.BackColor = Color.Red;
                        FarbCode(cb, 2, 100, "2");
                    }
                    break;
                case "Orange":
                    {
                        pb.BackColor = Color.Orange;
                        FarbCode(cb, 3, 1000);
                    }
                    break;
                case "Gelb":
                    {
                        pb.BackColor = Color.Yellow;
                        FarbCode(cb, 4, 10000);
                    }
                    break;
                case "Grün":
                    {
                        pb.BackColor = Color.Green;
                        FarbCode(cb, 5, 100000, "0.5");
                    }
                    break;
                case "Blau":
                    {
                        pb.BackColor = Color.Blue;
                        FarbCode(cb, 6, 1000000, "0.25");
                    }
                    break;
                case "Violett":
                    {
                        pb.BackColor = Color.BlueViolet;
                        FarbCode(cb, 7, 10000000, "0.1");
                    }
                    break;
                case "Grau":
                    {
                        pb.BackColor = Color.Gray;
                        FarbCode(cb, 8,0, "0.05");
                    }
                    break;
                case "Weiss":
                    {
                        pb.BackColor = Color.White;
                        FarbCode(cb, 9,0, null);
                    }
                    break;
                case "Gold":
                    {
                        pb.BackColor = Color.Gold;
                        FarbCodeT(cb,10,"5");
                    }
                    break;
                case "Silber":
                    {
                        pb.BackColor = Color.Silver;
                        FarbCodeT(cb,100,"10");
                    }
                    break;
            }
        }

        private void FarbCode(ComboBox cb, int wert1, int wert2,string tol)
        {
            if (r1 == cb)
            {
                code += (wert1*10);
            }
            else if (r2 == cb)
            {
                code += wert1;
            }
            else if (r3 == cb)
            {
                code *= wert2;
            }
            else
            {
                toleranz += tol+"%";
            }
        }

        private void FarbCode(ComboBox cb, int wert1, int wert2)
        {
            if (r1 == cb)
            {
                code += (wert1 * 10);
            }
            else if (r2 == cb)
            {
                code += wert1;
            }
            else if (r3 == cb)
            {
                code *= wert2;
            }
        }

        private void FarbCodeT(ComboBox cb,int wert2, string tol)
        {
            if (r3 == cb)
            {
                code /= wert2;
            }
            else
            {
                toleranz += tol+"%";
            }
        }

        private void btn_rechner_Click(object sender, EventArgs e)
        {
            txtb_Ausgabe.Text = code.ToString();
            txtB_Toleranz.Text = toleranz;
        }
    }
}
