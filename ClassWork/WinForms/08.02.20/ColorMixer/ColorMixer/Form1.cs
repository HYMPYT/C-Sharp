using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorMixer
{
    public partial class Form1 : Form
    {
        int R, G, B;
        public Form1()
        {
            InitializeComponent();
            R = G = B = 150;
            DisplayColor();
        }

        private void DisplayColor()
        {
            pictureBox1.BackColor = Color.FromArgb(R, G, B);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            R = trackBar1.Value;
            label1.Text = $"R: {R}";
            DisplayColor();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            G = trackBar2.Value;
            label2.Text = $"G: {G}";
            DisplayColor();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            B = trackBar3.Value;
            label3.Text = $"B: {B}";
            DisplayColor();
        }
    }
}
