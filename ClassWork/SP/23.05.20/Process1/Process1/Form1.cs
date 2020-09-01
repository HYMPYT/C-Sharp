using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Process1
{
    public partial class Form1 : Form
    {
        Process process1;
        public Form1()
        {
            InitializeComponent();
            process1 = new Process();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            process1.StartInfo = new ProcessStartInfo("notepad.exe");
            process1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            process1.CloseMainWindow();
            process1.Close();
        }
    }
}
