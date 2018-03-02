using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace _06_Heizanlage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static void CallToChildThread()
        {
            Application.Run(new House(1, 1));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ThreadStart childref = new ThreadStart(CallToChildThread);
            //Thread childThread = new Thread(childref);
            //childThread.Start();
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Thread childThread = new Thread(childref);
            childThread.Start();
        }


    }
}
