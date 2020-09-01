using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public List<string> TextFile { get; set; } = new List<string>();
        static int countRowOfText = 0;
        public int TextSize { get; set; } = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(progressBar1.Value == progressBar1.Maximum)
            {
                MessageBox.Show("Конец");
                this.Close();
            }
            int count = 0;
            while (countRowOfText < TextSize)
            {
                if(count == 3)
                {
                    break;
                }
                richTextBox1.AppendText(TextFile[countRowOfText]);
                countRowOfText++;
                count++;
            }
            progressBar1.Value += count;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader stream = new StreamReader(@"..\..\Files\TextFile1.txt");
            string line = "";
            while ((line = stream.ReadLine()) != null)
            {
                TextFile.Add(line);
                TextSize++;
            }
            progressBar1.Maximum = TextSize;
        }
    }
}
