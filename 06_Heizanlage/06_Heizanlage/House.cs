﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _06_Heizanlage
{
    public partial class House : Form
    {
        public static int tem;
        private static int max;
        private static int min;

        public House(int mini, int maxi)
        {
            max = maxi;
            min = mini;
            InitializeComponent();
        }

        public static bool CheckTemp(bool a)
        {
            if (!a)
            {
                if (tem < min)
                {
                    return true;
                }
            }
            else
            {
                if (tem>max)
                {
                    return false;
                }
            }
            return a;
        }

        public static void Draw()
        {
            //Form1 f = new Form1();
            //f.Draw();
        }
    }
}