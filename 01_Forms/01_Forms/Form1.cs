using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _01_Forms
{
    public partial class Form1 : Form
    {
        private static Random rnd = new Random((int)DateTime.Now.Ticks);
        public Form1()
        {
            InitializeComponent();  //Initialisiert die GUI

            button1.Text = "OK";    //Button Namen umbenennen
        }

        private void button1_Click(object sender, EventArgs e)  //Doppel klick auf object
        {
            if (button1.Text == "Hallo")
            {
                button1.Text = "3BEL";
            }
            else
            {
                button1.Text = "Hallo";
            }
            if (rnd.Next(100) % 2 == 0)
            {
                richTextBox1.Text = "LÄÄÄÄRRRY";
            }
            else
            {
                richTextBox1.Text = "Johann du Lauch";
            }
            timer1.Start();

        }

        private void button1_MouseHover(object sender, EventArgs e) // Unter Eigenschaften unter blitz
        {
            button1.BackColor = Color.Blue;                         // Beim Drüberhover vom Button farbe ändern
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
