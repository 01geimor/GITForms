using System;
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
        private static int houses;

        public House(int h)
        {

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

        private void Generator()
        {
            groupBox1 = new System.Windows.Forms.GroupBox();
            trackBar1 = new System.Windows.Forms.TrackBar();
            progressBar1 = new System.Windows.Forms.ProgressBar();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            SuspendLayout();

            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(progressBar1);
            groupBox1.Controls.Add(trackBar1);
            groupBox1.Location = new System.Drawing.Point(13, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(385, 139);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            
            trackBar1.Location = new System.Drawing.Point(121, 88);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new System.Drawing.Size(165, 45);
            trackBar1.TabIndex = 0;
            
            
            progressBar1.Location = new System.Drawing.Point(121, 52);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(165, 23);
            progressBar1.TabIndex = 1;
            
            
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(80, 52);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 13);
            label1.TabIndex = 2;
            label1.Text = "label1";
            
            
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(292, 52);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(35, 13);
            label2.TabIndex = 3;
            label2.Text = "label2";
            
            
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(187, 36);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(35, 13);
            label3.TabIndex = 4;
            label3.Text = "label3";
        }

        private GroupBox groupBox1;
        private ProgressBar progressBar1;
        private TrackBar trackBar1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
