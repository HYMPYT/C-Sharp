using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodsCatalog
{
    public partial class DelCategory : Form
    {
        DataManager dm = new DataManager();
        public string CategoryName { get; set; }
        public string Confirm { get; set; }
        public DelCategory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoryName = comboBox1.SelectedItem.ToString();
            MessageBox.Show(CategoryName);
            Confirm = "Yes";
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void DelCategory_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (var c in dm.Categories)
            {
                comboBox1.Items.Add(c.Name);
            }
            comboBox1.SelectedIndex = 0;
        }
    }
}
