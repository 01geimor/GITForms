using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _05_TTT
{
    public partial class Form1 : Form
    {
        static string o = "One";
        static string t = "Two";
        static bool win;
        static string player = o;
        static int scoreo=0;
        static int scoret=0;

        static string rechner;
        static string[] a;
        static decimal [] zahlen;
        static char[] operatoren = new char[1000];
        static int f = 0;

        static char[] text;
        static string pfad;
        
        public Form1()
        {
            InitializeComponent();

            ScorePO.Text = "Score Player One : " + scoreo;
            ScorePT.Text = "Score Player Two : " + scoret;
            winner.Text = " ";
            //Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            //e.Graphics.DrawLine(pen, 20, 10, 300, 100);
            vertext.Enabled = false;
        }

        private void ClickP(PictureBox p)
        {
            p.Enabled = false;
            winner.Text = " ";
            if (player == o)
            {
                player = t;
                p.Image = Image.FromFile(@"H:\Eigene Dokumente\My Pictures\X2.png");
                p.Name = o;
                Check(o, ref scoreo);
            }
            else
            {
                player = o;
                p.Image = Image.FromFile(@"H:\Eigene Dokumente\My Pictures\O2.png");
                p.Name = t;
                Check(t, ref scoret);
            }

            label2.Text = "Now : Player " + player;
            ScorePO.Text = "Score Player One : " + scoreo;
            ScorePT.Text = "Score Player Two : " + scoret;
        }


        private void Check(string a, ref int b)
        {
            if (a == pictureBox1.Name & a == pictureBox6.Name & a == pictureBox7.Name)
            {
                b++;
                winner.Text = "Winner : Player " + a;
                win = true;
            }
            else if (a == pictureBox5.Name & a == pictureBox2.Name & a == pictureBox8.Name)
            {
                b++;
                winner.Text = "Winner : Player " + a;
                win = true;
            }
            else if (a == pictureBox4.Name & a == pictureBox3.Name & a == pictureBox9.Name)
            {
                b++;
                winner.Text = "Winner : Player " + a;
                win = true;
            }
            else if (a == pictureBox1.Name & a == pictureBox2.Name & a == pictureBox9.Name)
            {
                b++;
                winner.Text = "Winner : Player " + a;
                win = true;
            }
            else if (a == pictureBox7.Name & a == pictureBox2.Name & a == pictureBox4.Name)
            {
                b++;
                winner.Text = "Winner : Player " + a;
                win = true;
            }
            else if (a == pictureBox1.Name & a == pictureBox5.Name & a == pictureBox4.Name)
            {
                b++;
                winner.Text = "Winner : Player " + a;
                win = true;
            }
            else if (a == pictureBox6.Name & a == pictureBox2.Name & a == pictureBox3.Name)
            {
                b++;
                winner.Text = "Winner : Player " + a;
                win = true;
            }
            else if (a == pictureBox7.Name & a == pictureBox8.Name & a == pictureBox9.Name)
            {
                b++;
                winner.Text = "Winner : Player " + a;
                win = true;
            }

            if (win == true)
            {
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
                pictureBox9.Image = null;

                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
                pictureBox4.Enabled = true;
                pictureBox5.Enabled = true;
                pictureBox6.Enabled = true;
                pictureBox7.Enabled = true;
                pictureBox8.Enabled = true;
                pictureBox9.Enabled = true;

                win = false;

                pictureBox1.Name = " ";
                pictureBox2.Name = " ";
                pictureBox3.Name = " ";
                pictureBox4.Name = " ";
                pictureBox5.Name = " ";
                pictureBox6.Name = " ";
                pictureBox7.Name = " ";
                pictureBox8.Name = " ";
                pictureBox9.Name = " ";
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClickP(pictureBox1);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ClickP(pictureBox6);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ClickP(pictureBox7);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ClickP(pictureBox5);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ClickP(pictureBox2);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ClickP(pictureBox8);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ClickP(pictureBox4);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ClickP(pictureBox3);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ClickP(pictureBox9);
        }


        private void RechnerText(Button b)
        {
            rechner = rechner + b.Text;
            Ausgabe.Text = rechner;
        }

        private void Null_Click(object sender, EventArgs e)
        {
            RechnerText(Null);
        }

        private void Eins_Click(object sender, EventArgs e)
        {
            RechnerText(Eins);
        }

        private void Zwei_Click(object sender, EventArgs e)
        {
            RechnerText(Zwei);
        }

        private void Drei_Click(object sender, EventArgs e)
        {
            RechnerText(Drei);
        }

        private void Vier_Click(object sender, EventArgs e)
        {
            RechnerText(Vier);
        }

        private void Fuenf_Click(object sender, EventArgs e)
        {
            RechnerText(Fuenf);
        }

        private void Sechs_Click(object sender, EventArgs e)
        {
            RechnerText(Sechs);
        }

        private void Sieben_Click(object sender, EventArgs e)
        {
            RechnerText(Sieben);
        }

        private void Acht_Click(object sender, EventArgs e)
        {
            RechnerText(Acht);
        }

        private void Neun_Click(object sender, EventArgs e)
        {
            RechnerText(Neun);
        }

        private void Gleich_Click(object sender, EventArgs e)
        {
            Ausrechner();
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            RechnerText(Plus);
            operatoren[f] = '+';
            f++;
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            RechnerText(Minus);
            operatoren[f] = '-';
            f++;
        }

        private void Mal_Click(object sender, EventArgs e)
        {
            RechnerText(Mal);
            operatoren[f] = '*';
            f++;
        }

        private void Div_Click(object sender, EventArgs e)
        {
            RechnerText(Div);
            operatoren[f] = '/';
            f++;
        }

        private void Komma_Click(object sender, EventArgs e)
        {
            RechnerText(Komma);
        }

        private void Ausrechner()
        {
            a = rechner.Split('*', '-', '/', '+');

            zahlen = new decimal[a.Length];

            for (int i = 0; i < zahlen.Length; i++)
			{
			    zahlen[i] = Convert.ToDecimal(a[i]);
			}

            for (int i = 0; i < zahlen.Length-1; i++)
            {
                switch (operatoren[i])
                {
                    case '+':
                        zahlen[i + 1] += zahlen[i];
                        break;
                    case '-':
                        zahlen[i + 1] -= zahlen[i];
                        break;
                    case '*':
                        zahlen[i + 1] *= zahlen[i];
                        break;
                    case '/':
                        zahlen[i + 1] /= zahlen[i];
                        break;
                }
            }
            Ausgabe.Text = Convert.ToString(zahlen[zahlen.Length - 1]);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Ausgabe.Text = " ";
            rechner = null;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            int a, z = trackBar1.Value;
            text = unvertext.Text.ToCharArray();

            for (int i = 0; i < text.Length; i++)
            {
                a = Convert.ToInt32(text[i]);
                if (z > 26)
                {
                    z = z - 26;
                }
                if (a > 64 & a < 91)
                {
                    if (a + z > 90)
                    {
                        a = a + z - 26;
                    }
                    else
                    {
                        a = a + z;
                    }
                }

                if (a > 96 & a < 123)
                {
                    if (a + z > 122)
                    {
                        a = a + z - 26;
                    }
                    else
                    {
                        a = a + z;
                    }
                }
                text[i] = ((char)a);
            }
            string va = new string(text);
            vertext.Text = va;
            label6.Text = "Verschlüsselungsfaktor : " + trackBar1.Value.ToString();
        }

        private void save_Click(object sender, EventArgs e)
        {
            pfad = speicherpfad.Text;
            StreamWriter sw = new StreamWriter(@pfad);
            sw.Write(vertext.Text);
            sw.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ausgabe.Text = null;
            rechner = null;
        }
    }
}
