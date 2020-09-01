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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Matrix m;
        int a, b;
        float t;
        float r1, r2, r3, r4, r5, r6, r7, r8;
        float v1, v2, v3, v4, v5, v6, v7, v8;
        float a1, a2, a3, a4, a5, a6, a7, a8;
        Point p;
        Bitmap i1, i2, i3, i4, i5, i6, i7, i8, i9;

        public Form1()
        {
            InitializeComponent();

            r1 = 38;
            r2 = 72;
            r3 = 100;
            r4 = 152;
            r5 = 520;
            r6 = 954;
            r7 = 1022;
            r8 = 1332;

            v1 = 47.36F;
            v2 = 35.02F;
            v3 = 29.785F;
            v4 = 24.077F;
            v5 = 16.06F;
            v6 = 13.69F;
            v7 = 10.81F;
            v8 = 9.43F;

            t = 1;

            m = new Matrix();

            a = (pictureBox1.Width / 2);
            b = (pictureBox1.Height / 2);
            p = new Point(a, b);

            i1 = new Bitmap(@"..\..\Images\Sun.png");
            i2 = new Bitmap(@"..\..\Images\Mercury.png");
            i3 = new Bitmap(@"..\..\Images\Venus.png");
            i4 = new Bitmap(@"..\..\Images\EARTH.png");
            i5 = new Bitmap(@"..\..\Images\Mars.png");
            i6 = new Bitmap(@"..\..\Images\Jupiter.png");
            i7 = new Bitmap(@"..\..\Images\Saturn.png");
            i8 = new Bitmap(@"..\..\Images\Uranus.png");
            i9 = new Bitmap(@"..\..\Images\Neptune.png");
        }

        private void CalcParams()
        {
            a1 = v1 / r1 * t;
            a2 = v2 / r2 * t;
            a3 = v3 / r3 * t;
            a4 = v4 / r4 * t;
            a5 = v5 / r5 * t;
            a6 = v6 / r6 * t;
            a7 = v7 / r7 * t;
            a8 = v8 / r8 * t;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            CalcParams();

            g.DrawImage(i1, p.X - 32, p.Y - 32);

            m.RotateAt(a1, p);
            g.Transform = m;
            g.DrawImage(i2, a, b - 100);
            m.Reset();

            m.RotateAt(a2, p);
            g.Transform = m;
            g.DrawImage(i3, a, b - 150);
            m.Reset();

            m.RotateAt(a3, p);
            g.Transform = m;
            g.DrawImage(i4, a, b - 200);
            m.Reset();

            m.RotateAt(a4, p);
            g.Transform = m;
            g.DrawImage(i5, a, b - 250);
            m.Reset();

            m.RotateAt(a5, p);
            g.Transform = m;
            g.DrawImage(i6, a, b - 300);
            m.Reset();

            m.RotateAt(a6, p);
            g.Transform = m;
            g.DrawImage(i7, a, b - 350);
            m.Reset();

            m.RotateAt(a7, p);
            g.Transform = m;
            g.DrawImage(i8, a, b - 400);
            m.Reset();

            m.RotateAt(a8, p);
            g.Transform = m;
            g.DrawImage(i9, a, b - 450);
            m.Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
            t++;
        }
    }
}
