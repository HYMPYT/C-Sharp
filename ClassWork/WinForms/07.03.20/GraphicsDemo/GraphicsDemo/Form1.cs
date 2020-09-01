using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsDemo
{
    public partial class Form1 : Form
    {
        int mode;
        public Form1()
        {
            InitializeComponent();
            mode = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mode = 1;
            pictureBox1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mode = 2;
            pictureBox1.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mode = 3;
            pictureBox1.Invalidate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mode = 4;
            pictureBox1.Invalidate();
        }

        private void DrawShapes1(Graphics g)
        {
            g.DrawLine(new Pen(Color.Red, 6), 50, 50, 300, 50);
            g.DrawLine(new Pen(Color.Red, 6), 300, 50, 300, 300);
            g.DrawLine(new Pen(Color.Red, 6), 300, 300, 50, 300);
            g.DrawLine(new Pen(Color.Red, 6), 50, 300, 50, 100);
            g.DrawLine(new Pen(Color.Red, 6), 50, 100, 250, 100);
            g.DrawLine(new Pen(Color.Red, 6), 250, 100, 250, 250);
            g.DrawLine(new Pen(Color.Red, 6), 250, 250, 100, 250);
            g.DrawLine(new Pen(Color.Red, 6), 100, 250, 100, 150);
            g.DrawLine(new Pen(Color.Red, 6), 100, 150, 200, 150);
            g.DrawLine(new Pen(Color.Red, 6), 200, 150, 200, 200);
            g.DrawLine(new Pen(Color.Red, 6), 200, 200, 150, 200);

            g.DrawLine(new Pen(Color.Green, 3), 350, 50, 350, 300);
            g.DrawLine(new Pen(Color.Green, 5), 400, 50, 400, 300);
            g.DrawLine(new Pen(Color.Green, 7), 450, 50, 450, 300);
            g.DrawLine(new Pen(Color.Green, 9), 500, 50, 500, 300);

            Pen p1 = new Pen(Color.Red, 6);
            p1.DashStyle = DashStyle.DashDot;

            g.DrawLine(p1, 200, 400, 200, 600);
            g.DrawLine(p1, 100, 500, 300, 500);

            p1.Color = Color.Orange;
            p1.DashStyle = DashStyle.Dot;

            g.DrawLine(p1, 400, 400, 600, 600);
            g.DrawLine(p1, 400, 600, 600, 400);

            p1.Color = Color.Blue;
            p1.DashStyle = DashStyle.DashDotDot;

            g.DrawLine(p1, 700, 600, 825, 400);
            g.DrawLine(p1, 825, 400, 950, 600);
            g.DrawLine(p1, 950, 600, 700, 600);
        }

        private void DrawShapes2(Graphics g)
        {
            g.FillRectangle(Brushes.Blue, 50, 50, 700, 300);
            g.FillRectangle(Brushes.Yellow, 50, 350, 700, 300);
            Font f = new Font("Verdana", 25, FontStyle.Bold | FontStyle.Italic);
            g.DrawString("Ukraine", f, Brushes.Red, 200, 275);
        }

        private void DrawShapes3(Graphics g)
        {
            g.FillEllipse(Brushes.Red, 50, 50, 400, 400);
            g.DrawEllipse(new Pen(Color.Green, 5), 50, 50, 400, 400);
        }

        private void DrawShapes4(Graphics g)
        {
            g.FillPie(Brushes.Crimson, 50, 50, 400, 400, 180, 90);
            g.FillPie(Brushes.Green, 250, 250, 400, 400, 0, 90);
            g.FillPie(Brushes.Red, 250, 50, 400, 400, 270, 90);
            g.FillPie(Brushes.Blue, 50, 250, 400, 400, 90, 90);
        }

        private void DrawShapes5(Graphics g)
        {
            HatchBrush hb1 = new HatchBrush(HatchStyle.DashedDownwardDiagonal, Color.Navy, Color.OliveDrab);
            HatchBrush hb2 = new HatchBrush(HatchStyle.Percent30, Color.Navy, Color.OliveDrab);
            HatchBrush hb3 = new HatchBrush(HatchStyle.Wave, Color.Navy, Color.OliveDrab);

            LinearGradientBrush lgb = new LinearGradientBrush(new Rectangle(50, 50, 200, 300), Color.LightGreen, Color.Orange, 45);

            g.FillRectangle(lgb, 50, 50, 200, 300);
            g.FillRectangle(hb2, 300, 50, 200, 300);
            g.FillRectangle(hb3, 550, 50, 200, 300);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            switch(mode)
            {
                case 1:
                    DrawShapes1(e.Graphics);
                    break;
                case 2:
                    DrawShapes2(e.Graphics);
                    break;
                case 3:
                    DrawShapes3(e.Graphics);
                    break;
                case 4:
                    DrawShapes4(e.Graphics);
                    break;
                case 5:
                    DrawShapes5(e.Graphics);
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mode = 5;
            pictureBox1.Invalidate();
        }
    }
}
