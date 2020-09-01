using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadTextBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog _opf = new OpenFileDialog())
            {
                _opf.Filter = "Text Files(*.txt)|*.txt||";

                if (_opf.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader _sr = File.OpenText(_opf.FileName))
                    {
                        textBox1.Text = _sr.ReadToEnd();
                    }
                    EditTextBtn.Enabled = true;
                }
            }
        }

        private void EditTextBtn_Click(object sender, EventArgs e)
        {
            Form2EditWindow _fEdit = new Form2EditWindow() { TextBox = textBox1.Text };
            _fEdit.eventReturnText += new EventHandler(EditText);
            _fEdit.Show(this);
        }

        public void EditText(object sender, EventArgs e)
        {
            this.textBox1.Text = ((MyEventArgs)e).Text;
        }
    }
}
