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
    class Builder
    {
        public Builder(int verschiebung)
        {
            this.verschiebung = verschiebung;
        }

        #region Labels
        private GroupBox groupBox1;
        private ProgressBar progressBar1;
        private TrackBar trackBar1;
        private Label label3;
        private Label label2;
        private Label label1;
        #endregion

        private int verschiebung;

        private void Generator(int i)
        {
            groupBox1 = new GroupBox();
            trackBar1 = new TrackBar();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();

            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(progressBar1);
            groupBox1.Controls.Add(trackBar1);

            groupBox1.Location = new Point(20,20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(385, 139);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";

            trackBar1.Location = new Point(121, 88);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(165, 45);
            trackBar1.TabIndex = 0;

            progressBar1.Location = new Point(121, 52);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(165, 23);
            progressBar1.TabIndex = 1;

            label1.Location = new Point(80, 52);
            label1.Name = "label1";
            label1.Size = new Size(35, 13);
            label1.TabIndex = 2;
            label1.Text = "label1";

            label2.Location = new Point(292, 52);
            label2.Name = "label2";
            label2.Size = new Size(35, 13);
            label2.TabIndex = 3;
            label2.Text = "label2";

            label3.Location = new Point(187, 36);
            label3.Name = "label3";
            label3.Size = new Size(35, 13);
            label3.TabIndex = 4;
            label3.Text = "label3";
        }

        #region Generator

        public GroupBox Box(int i)
        {
            GroupBox gb = new GroupBox();

            gb.Location = new Point(20, 20);
            gb.Name = "gb_House" + i;
            gb.Size = new Size(400, 150);
            gb.Text = "Wohnung " + (i+1);

            return gb;
        }

        public Label[] Text(ref GroupBox gb ,int i)
        {
            Label[] l = new Label[3];

            l[0] = new Label();
            l[0].Location = new Point(80, 50+i*verschiebung);
            l[0].Name = "lbl_min"+i;
            l[0].Size = new Size(35, 13);
            l[0].TabIndex = 2;
            l[0].Text = "Min";

            l[1] = new Label();
            l[1].Location = new Point(292, 50+i*verschiebung);
            l[1].Name = "lbl_max"+i;
            l[1].Size = new Size(35, 13);
            l[1].TabIndex = 3;
            l[1].Text = "Max";

            l[2] = new Label();
            l[2].Location = new Point(187, 35+i*verschiebung);
            l[2].Name = "lbl_Temp"+i;
            l[2].Size = new Size(35, 13);
            l[2].TabIndex = 4;
            l[2].Text = "Temp";

            gb.Controls.Add(l[0]);
            gb.Controls.Add(l[1]);
            gb.Controls.Add(l[2]);

            return l;
        }

        #endregion
    }
}
