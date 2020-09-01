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
    public partial class AddSite : Form
    {
        public string SiteName { get; set; }
        public string SiteURL { get; set; }
        public string CategoryNameForSite { get; set; }
        public AddSite()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Вы не ввели имя сайта", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SiteName = textBox1.Text;
                CategoryNameForSite = textBox3.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AddSite_Load(object sender, EventArgs e)
        {
            textBox2.Text = SiteURL;
        }
    }
}
