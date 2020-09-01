using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace AnimatedClock
{
    public partial class Form1 : Form
    {
        Pen p1, p2, p3, p4;
        Matrix m1, m2, m3, m4;
        float h, m, s, H, M, S;
        float a1, a2, a3, a4;
        int a, b;
        Point p;
        DateTime d;
        float sum1, sum2;

        public Form1()
        {
            InitializeComponent();

            p1 = new Pen(Color.Black, 8);
            p2 = new Pen(Color.Black, 6);
            p3 = new Pen(Color.Black, 4);
            p4 = new Pen(Color.Red, 2);

            m1 = new Matrix();
            m2 = new Matrix();
            m3 = new Matrix();
            m4 = new Matrix();

            a = pictureBox1.Width / 2;
            b = pictureBox1.Height / 2;
            p = new Point(a, b);

            H = M = S = 0;
        }

        private void CalcParams()
        {
            d = DateTime.Now;

            h = d.Hour;
            m = d.Minute;
            s = d.Second;

            a1 = (h + m / 60 + s / 3600) * 30;
            a2 = (m + s / 60) * 6;
            a3 = s * 6;
            a4 = (H + M / 60 + S / 3600) * 30;

            sum1 = h * 3600 + m * 60 + s;
            sum2 = H * 3600 + M * 60 + S;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            CalcParams();

            m1.RotateAt(a1, p);
            g.Transform = m1;
            g.DrawLine(p1, a, b + 6, a, b - 130);
            m1.Reset();

            m2.RotateAt(a2, p);
            g.Transform = m2;
            g.DrawLine(p2, a, b + 8, a, b - 170);
            m2.Reset();

            m3.RotateAt(a3, p);
            g.Transform = m3;
            g.DrawLine(p3, a, b + 10, a, b - 200);
            m3.Reset();

            if(a4 > 0)
            {
                m4.RotateAt(a4, p);
                g.Transform = m4;
                g.DrawLine(p4, a, b + 10, a, b - 200);
                m4.Reset();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
            if (sum1 == sum2)
            {
                MessageBox.Show("ДЗИНЬ!!!!!!!!!!!");
            }
        }

        private void setAlarmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetAlarmForm saf = new SetAlarmForm();
            if(saf.ShowDialog() == DialogResult.OK)
            {
                H = saf.H;
                M = saf.M;
                S = saf.S;
            }
        }

        private void resetAlarmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            H = M = S = 0;
        }
        
    }
}
