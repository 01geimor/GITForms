using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _02_StopUhr
{
    public partial class Form1 : Form
    {
        int h;
        int m;
        int s;
        int ms;
        Random rnd = new Random((int)DateTime.Now.Ticks);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            ms = 0;
            s = 0;
            m = 0;
            h = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ms+1!=10)
            {
                ms ++;
            }
            else if (s+1!=60)
            {
                ms = 0;
                s ++;
            }
            else if (m+1!=60)
            {
                s = 0;
                m ++;
            }
            else
            {
                m = 0;
                h++;
            }


                label4.Text = h + ":" + m + ":" + s + "." + ms +rnd.Next(10)+ rnd.Next(10);
            
        }
    }
}
