using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            double lenth = Math.Sqrt(Math.Pow(e.X - label1.Location.X, 2) + Math.Pow(e.Y - label1.Location.Y, 2));

            if (lenth < 40)
            {

                double sinus = (label1.Location.Y - e.Y) / lenth;
                double cosinus = (label1.Location.X - e.X) / lenth;
                if (sinus >= 0.5)
                    label1.Location = new Point(label1.Location.X, label1.Location.Y + 2);
                if (sinus <= -0.5)
                    label1.Location = new Point(label1.Location.X, label1.Location.Y - 2);
                if (cosinus >= 0.5)
                    label1.Location = new Point(label1.Location.X + 2, label1.Location.Y);
                if (cosinus <= -0.5)
                    label1.Location = new Point(label1.Location.X - 2, label1.Location.Y);

            }
        }
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            double lenth = Math.Sqrt(Math.Pow(e.X, 2) + Math.Pow(e.Y, 2));

            if (lenth < 20)
            {

                double sinus = -(e.Y) / lenth;
                double cosinus = -(e.X) / lenth;
                if (sinus >= 0.5)
                    label1.Location = new Point(label1.Location.X, label1.Location.Y + 2);
                if (sinus <= -0.5)
                    label1.Location = new Point(label1.Location.X, label1.Location.Y - 2);
                if (cosinus >= 0.5)
                    label1.Location = new Point(label1.Location.X + 2, label1.Location.Y);
                if (cosinus <= -0.5)
                    label1.Location = new Point(label1.Location.X - 2, label1.Location.Y);

            }
        }
    }
}
