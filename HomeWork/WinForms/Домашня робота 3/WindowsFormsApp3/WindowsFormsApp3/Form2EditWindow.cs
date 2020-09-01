using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2EditWindow : Form
    {
        public event EventHandler eventReturnText;
        public string TextBox
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public Form2EditWindow()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            eventReturnText(sender, new MyEventArgs(TextBox));
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
