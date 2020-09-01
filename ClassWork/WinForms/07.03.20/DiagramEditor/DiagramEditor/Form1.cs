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

namespace DiagramEditor
{
    public partial class Form1 : Form
    {
        static int amount_voices = 0;

        int mode = 0;
        public List<string> Legends { get; set; } = new List<string>();
        public List<int> Voices { get; set; } = new List<int>();
        public List<HatchBrush> HatchBrushes { get; set; } = new List<HatchBrush>();
        public Form1()
        {
            InitializeComponent();
            FillHatchBrushes();
        }
        private void LoadLegends()
        {
            listView1.Items.Clear();
            for (int i = 0; i < Legends.Count; i++)
            {
                var item = listView1.Items.Add(Legends[i]);
                item.SubItems.Add(Voices[i].ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (amount_voices >= 10)
            {
                MessageBox.Show("Превышено количество добавлений");
            }
            else
            {

                Legends.Add(textBox3.Text);
                Voices.Add(int.Parse(textBox2.Text));
                amount_voices++;
                LoadLegends();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = listView1.SelectedIndices[0];
            Legends.RemoveAt(index);
            Voices.RemoveAt(index);
            amount_voices -= 1;
            LoadLegends();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Legends.RemoveRange(0, Legends.Count);
            Voices.RemoveRange(0, Voices.Count);
            amount_voices = 0;
            LoadLegends();
            pictureBox1.BackColor = Color.FromArgb(240, 240, 240);
            mode = 0;
            textBox1.Text = "Статистика:";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Voices.Count == 0 || Legends.Count == 0)
            {
                MessageBox.Show("У вас нету записей для построения диаграмм");
            }
            else
            {
                mode = 1;
                Statistic();
                pictureBox1.Invalidate();
            }
        }

        private void FillHatchBrushes()
        {
            HatchBrushes.Add(new HatchBrush(HatchStyle.BackwardDiagonal, Color.Red, Color.Green));
            HatchBrushes.Add(new HatchBrush(HatchStyle.Cross, Color.Goldenrod, Color.DimGray));
            HatchBrushes.Add(new HatchBrush(HatchStyle.DiagonalBrick, Color.Firebrick, Color.Green));
            HatchBrushes.Add(new HatchBrush(HatchStyle.Divot, Color.Orange, Color.Purple));
            HatchBrushes.Add(new HatchBrush(HatchStyle.LargeCheckerBoard, Color.Plum, Color.Peru));
            HatchBrushes.Add(new HatchBrush(HatchStyle.OutlinedDiamond, Color.PowderBlue, Color.Yellow));
            HatchBrushes.Add(new HatchBrush(HatchStyle.Shingle, Color.Red, Color.Green));
            HatchBrushes.Add(new HatchBrush(HatchStyle.Sphere, Color.Violet, Color.RoyalBlue));
            HatchBrushes.Add(new HatchBrush(HatchStyle.Wave, Color.Salmon, Color.OrangeRed));
            HatchBrushes.Add(new HatchBrush(HatchStyle.ZigZag, Color.PaleGreen, Color.MistyRose));
        }

        private void DrawLegends(Graphics g)
        {
            int y = 0;
            Font f = new Font("Arial", 10, FontStyle.Regular);
            for (int i = 0; i < Legends.Count; i++)
            {
                g.FillRectangle(HatchBrushes[i], 30, 350 + y, 20, 20);
                g.DrawString(Legends[i], f, Brushes.Black, 60, 350 + y);
                y += 30;
            }
        }

        private void DrawUpDiagram(Graphics g)
        {
            Font f = new Font("Arial", 10, FontStyle.Bold);
            g.DrawLine(new Pen(Color.Black, 5), 30, 250, 30, 75);
            g.DrawLine(new Pen(Color.Black, 5), 30, 75, 20, 85);
            g.DrawLine(new Pen(Color.Black, 5), 30, 75, 40, 85);
            g.DrawLine(new Pen(Color.Black, 5), 30, 250, 700, 250);
            g.DrawLine(new Pen(Color.Black, 5), 700, 250, 690, 240);
            g.DrawLine(new Pen(Color.Black, 5), 700, 250, 690, 260);
            g.DrawString("V", f, Brushes.Red, 15, 45);
            g.DrawString("L", f, Brushes.Red, 710, 230);
            int max_voice = Voices.Max(), x = 0, height;
            for (int i = 0; i < Voices.Count; i++)
            {
                height = (Voices[i] * 150) / max_voice;
                g.FillRectangle(HatchBrushes[i], 50 + x, 250 - height, 40, height);
                x += 60;
            }
        }

        private void DrawDownDiagram(Graphics g)
        {
            int all_voice = Voices.Sum();
            float sweepAngle, startAngle = 0;
            for (int i = 0; i < Voices.Count; i++)
            {
                if (i == Voices.Count - 1)
                    sweepAngle = 360 - startAngle;
                else
                    sweepAngle = (Voices[i] * 360) / all_voice;
                g.FillPie(HatchBrushes[i], 375, 350, 300, 300, startAngle, sweepAngle);
                startAngle += sweepAngle;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            switch (mode)
            {
                case 1:
                    DrawUpDiagram(e.Graphics);
                    DrawLegends(e.Graphics);
                    DrawDownDiagram(e.Graphics);
                    break;
            }
        }

        private void Statistic()
        {
            textBox1.Text = $"Статистика:\r\nMax: {Voices.Max()}\r\nMin: {Voices.Min()}\r\nAvg: {Voices.Average()}";
        }
    }
}
