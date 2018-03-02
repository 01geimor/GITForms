using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _04_remote
{
    public partial class Form1 : Form
    {
        int x = -7;
        int y = -113;
        int a;
        int v = 10;

        public Form1()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            move();
        }

        private void move()
        {
            switch (a)
            {
                case 2:
                    y -= v;
                    break;
                case 1:
                    y += v;
                    break;
                case 4:
                    x -= v;
                    break;
                case 3:
                    x += v;
                    break;
            }
            button1.Location = new Point(x, y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Text = " ";
        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'w':
                    a = 1;
                    break;
                case 's':
                    a = 2;
                    break;
                case 'a':
                    a = 3;
                    break;
                case 'd':
                    a = 4;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Name == "Stop")
            {
                timer1.Stop();
                button2.Name = "Start";
            }
            else
            {
                timer1.Start();
                button2.Name = "Stop";
            }
        }
    }
}