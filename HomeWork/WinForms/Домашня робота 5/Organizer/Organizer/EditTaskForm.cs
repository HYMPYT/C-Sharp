using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizer
{
    public partial class EditTaskForm : Form
    {

        public string TaskName { get; set; }
        public string TaskAbout { get; set; }
        public string TaskTerm { get; set; }

        public EditTaskForm(string title, string about, string term)
        {
            InitializeComponent();
            textBox1.Text = TaskName = title;
            textBox2.Text = TaskAbout = about;
            textBox3.Text = TaskTerm = term;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaskName = textBox1.Text;
            TaskAbout = textBox2.Text;
            TaskTerm = textBox3.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
