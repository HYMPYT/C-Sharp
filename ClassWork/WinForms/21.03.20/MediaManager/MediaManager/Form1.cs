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

namespace MediaManager
{
    public partial class Form1 : Form
    {
        FileInfo[] files;
        public Form1()
        {
            InitializeComponent();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = ofd.FileName;
            }
        }

        private void openDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo di = new DirectoryInfo(fbd.SelectedPath);
                files = di.GetFiles().Where(f => f.Extension == ".mp3" || f.Extension == ".mp4").ToArray();
                fileList.Items.Clear();
                foreach (FileInfo f in files)
                {
                    fileList.Items.Add(f.Name);
                }
            }
        }

        private void fileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = files[fileList.SelectedIndex].FullName;
        }
    }
}
