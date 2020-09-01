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
    public partial class DelCategoryForm : Form
    {
        public string CategoryName { get; set; }
        public DelCategoryForm()
        {
            InitializeComponent();
        }
        public DelCategoryForm(string categoryName)
        {
            InitializeComponent();
            CategoryName = categoryName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void DelCategoryForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = CategoryName;
        }
    }
}
