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

namespace WindowsFormsApp1
{
    public partial class FormSearchWindow : Form
    {
        public FormSearchWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.ShowNewFolderButton = false;

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    List<string> files = Directory.GetFiles(fbd.SelectedPath, textBox1.Text).Select(f => Path.GetFileName(f)).ToList();
                    listBox1.Items.AddRange(files.ToArray());
                }
            }
            
        }
    }
}
