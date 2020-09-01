using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicRedactor
{
    public partial class ChangeSizeForm : Form
    {
        public string Chose { get; set; }
        public int NewHeight { get; set; }
        public int NewWidth { get; set; }
        public int HeightProc { get; set; }
        public int WidthProc { get; set; }
        public ChangeSizeForm(int height, int width)
        {
            InitializeComponent();
            NewHeight = height;
            NewWidth = width;
            textBox1.Text = "100";
            textBox2.Text = "100";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Chose = "Проценты";
                try
                {
                    WidthProc = int.Parse(textBox1.Text);
                    HeightProc = int.Parse(textBox2.Text);
                }
                catch
                {
                    MessageBox.Show("Вы ввели неверный формат", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Chose = "Пиксели";
                try
                {
                    NewWidth = int.Parse(textBox1.Text);
                    NewHeight = int.Parse(textBox2.Text);
                }
                catch
                {
                    MessageBox.Show("Вы ввели неверный формат", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Text = "100";
                textBox2.Text = "100";
            }
            else
            {
                textBox1.Text = NewWidth.ToString();
                textBox2.Text = NewHeight.ToString();
            }
        }
    }
}
