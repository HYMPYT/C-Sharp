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
    public partial class DelSite : Form
    {
        public string SiteName { get; set; }
        public string Confirm { get; set; }
        public DelSite()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Confirm = "Yes";
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Confirm = "No";
            this.DialogResult = DialogResult.Cancel;
        }

        private void DelSite_Load(object sender, EventArgs e)
        {
            textBox1.Text = SiteName;
        }
    }
}
