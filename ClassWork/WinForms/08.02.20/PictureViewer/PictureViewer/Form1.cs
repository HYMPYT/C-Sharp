using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        private List<string> names;
        private List<string> pathes;
        public Form1()
        {
            InitializeComponent();
            names = new List<string>();
            pathes = new List<string>();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPEG(*.jpeg)|*.jpeg|JPG(*.jpg)|*.jpg|PNG(*.png)|*.png|BMP(*.bmp)|*.bmp|GIF(*.gif)|*.gif|All files(*.*)|*.*||";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                names.AddRange(ofd.SafeFileNames);
                pathes.AddRange(ofd.FileNames);
                listBox1.Items.Clear();
                foreach (string name in names)
                {
                    listBox1.Items.Add(name);
                }
                listBox1.SelectedIndex = 0;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int k = listBox1.SelectedIndex;
            if(k > -1)
            {
                pictureBox1.Image = Image.FromFile(pathes[k]);
            }
        }

        private void forwardBtn_Click(object sender, EventArgs e)
        {
            int k = listBox1.SelectedIndex;
            if(k == -1)
            {
                MessageBox.Show("Предупреждение", "Не выбран файл изображения!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int n = names.Count;
                if(k == n - 1)
                {
                    k = 0;
                }
                else
                {
                    k++;
                }
                listBox1.SelectedIndex = k;
            }
        }

        private void backwardBtn_Click(object sender, EventArgs e)
        {
            int k = listBox1.SelectedIndex;
            if (k == -1)
            {
                MessageBox.Show("Предупреждение", "Не выбран файл изображения!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int n = names.Count;
                if (k == 0)
                {
                    k = n - 1;
                }
                else
                {
                    k--;
                }
                listBox1.SelectedIndex = k;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int k = listBox1.SelectedIndex;
            if (k == -1)
            {
                MessageBox.Show("Предупреждение", "Не выбран файл изображения!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int n = names.Count;
                if (k == n - 1)
                {
                    k = 0;
                }
                else
                {
                    k++;
                }
                listBox1.SelectedIndex = k;
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = int.Parse(numericUpDown1.Value.ToString()) * 1000;
            startBtn.Enabled = false;
            stopBtn.Enabled = true;
            resetBtn.Enabled = false;
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            startBtn.Enabled = true;
            stopBtn.Enabled = false;
            resetBtn.Enabled = true;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 2;
            listBox1.SelectedIndex = 0;
        }
    }
}
