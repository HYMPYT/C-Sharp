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
    public partial class QuestionForm : Form
    {
        public string FileName { get; set; }
        public QuestionForm()
        {
            InitializeComponent();
            FileName = "Безымянный";
            textBox1.Text = $"Вы хотите сохранить изменения в файле {FileName}?";
        }

        public QuestionForm(string name)
        {
            FileName = name;
            textBox1.Text = $"Вы хотите сохранить изменения в файле {FileName}?";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
