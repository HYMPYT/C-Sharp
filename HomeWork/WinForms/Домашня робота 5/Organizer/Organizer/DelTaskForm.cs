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
    public partial class DelTaskForm : Form
    {
        public string TaskTitle { get; set; }

        public DelTaskForm(string title)
        {
            InitializeComponent();
            TaskTitle = title;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void DelTaskForm_Load(object sender, EventArgs e)
        {
            label1.Text = $"Вы подтверждаете удаление задачи \"{TaskTitle}\"";
        }
    }
}
