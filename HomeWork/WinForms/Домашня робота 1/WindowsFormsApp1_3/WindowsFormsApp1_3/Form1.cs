using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_3
{
    public partial class Form1 : Form
    {
        public bool K { get; set; } = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (K)
                    this.Close();
                else
                {
                    if (e.X < 10 || e.Y < 10 || e.X > this.ClientSize.Width - 10 || e.Y > this.ClientSize.Height - 10)
                        MessageBox.Show("За границами прямоугольника");
                    else if (e.X >= 10 && e.X <= 15 || e.X >= this.ClientSize.Width - 15 && e.X <= this.ClientSize.Width - 10 || e.Y >= 10 && e.Y <= 15 || e.Y >= this.ClientSize.Height - 15 && e.Y <= this.ClientSize.Height - 10)
                        MessageBox.Show("На границе прямоугольника");
                    else if (e.X > 15 || e.Y > 15 || e.X < this.ClientSize.Width - 15 || e.Y < this.ClientSize.Height)
                        MessageBox.Show("В прямоугольнике");
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                this.Text = $"Ширина = {this.ClientSize.Width} Высота = {this.ClientSize.Height}";
            else
                this.Text = $"X = {e.X} Y = {e.Y}";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            K = e.Control;
        }
    }
}
