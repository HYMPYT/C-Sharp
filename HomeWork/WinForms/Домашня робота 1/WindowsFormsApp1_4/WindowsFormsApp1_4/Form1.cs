using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_4
{
    public partial class Form1 : Form
    {
        private Label label;
        public Point FirstCord { get; set; }
        public Point SecondCord { get; set; }
        static int countStatic = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                Point loc = (Point)sender.GetType().GetProperty("Location").GetValue(sender);
                Size size = (Size)sender.GetType().GetProperty("Size").GetValue(sender);
                this.Text = $"Square = {size.Height * size.Width} Location = {loc.X}; {loc.Y}";
            }
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                int index = (int)sender.GetType().GetProperty("TabIndex").GetValue(sender);
                foreach (var item in this.Controls)
                {
                    if(item is Label)
                    {
                        if(((Label)item).TabIndex == index)
                        {
                            this.Controls.Remove((Label)item);
                        }
                    }
                }
                countStatic--;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                SecondCord = new Point(e.X, e.Y);
                if (Math.Abs(SecondCord.X - FirstCord.X) < 10 || Math.Abs(SecondCord.Y - FirstCord.Y) < 10)
                {
                    MessageBox.Show("Вы задали очень маленький размер статика");
                }
                else
                {
                    label = new Label();
                    if (SecondCord.X < FirstCord.X || SecondCord.Y < FirstCord.Y)
                    {
                        label.Location = SecondCord;
                        label.Size = new Size(FirstCord.X - SecondCord.X, FirstCord.Y - SecondCord.Y);
                        label.TabIndex = countStatic;
                        label.MouseClick += Form1_MouseClick;
                        label.MouseDoubleClick += Form1_MouseDoubleClick;
                        label.Text = $"{countStatic}";
                        countStatic++;
                    }
                    else
                    {
                        label.Location = FirstCord;
                        label.Size = new Size(SecondCord.X - FirstCord.X, SecondCord.Y - FirstCord.Y);
                        label.TabIndex = countStatic;
                        label.MouseClick += Form1_MouseClick;
                        label.MouseDoubleClick += Form1_MouseDoubleClick;
                        label.Text = $"{countStatic}";
                        countStatic++;
                    }
                    this.Controls.Add(label);
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                FirstCord = new Point(e.X, e.Y);
            }
        }
    }
}
