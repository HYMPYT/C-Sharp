using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBrowser
{
    public partial class AddCategory : Form
    {
        public string CategoryName { get; set; }
        public AddCategory()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Вы не введи название категории");
            }
            else
            {
                CategoryName = textBox1.Text;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
