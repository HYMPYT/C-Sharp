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
    public partial class DelCategory : Form
    {
        public string Confirm { get; set; }
        public string CategoryName { get; set; }
        public DelCategory()
        {
            InitializeComponent();
        }

        private void DelOkBtn_Click(object sender, EventArgs e)
        {
            Confirm = "Yes";
            this.DialogResult = DialogResult.OK;
        }

        private void DelCancelBtn_Click(object sender, EventArgs e)
        {
            Confirm = "No";
            this.DialogResult = DialogResult.Cancel;
        }

        private void DelCategory_Load(object sender, EventArgs e)
        {
            textBox1.Text = CategoryName;
        }
    }
}
