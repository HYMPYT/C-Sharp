using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimatedClock
{
    public partial class SetAlarmForm : Form
    {
        public float H { get; set; }
        public float M { get; set; }
        public float S { get; set; }
        public SetAlarmForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            H = (float)numericUpDown1.Value;
            M = (float)numericUpDown2.Value;
            S = (float)numericUpDown3.Value;
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
