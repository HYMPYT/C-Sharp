using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string _hour;
        private string _minute;
        private string _second;
        public Form1()
        {
            InitializeComponent();
        }
        private void DisplayTime()
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            if (_hour == DateTime.Now.Hour.ToString() && _minute == DateTime.Now.Minute.ToString() && _second == DateTime.Now.Second.ToString())
            {
                Sound();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayTime();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayTime();
        }

        private void setAlarm_Click(object sender, EventArgs e)
        {
            _hour = hourNumericUpDown.Value.ToString();
            _minute = minuteNumericUpDown.Value.ToString();
            _second = secondNumericUpDown.Value.ToString();
            MessageBox.Show("Будильник создано");
        }

        private void resetAlarm_Click(object sender, EventArgs e)
        {
            _hour = "";
            _minute = "";
            _second = "";
            hourNumericUpDown.Value = 0;
            minuteNumericUpDown.Value = 0;
            secondNumericUpDown.Value = 0;
            MessageBox.Show("Будильник сброшено");
        }
        private void Sound()
        {
            Process p = new Process();
            p.StartInfo.FileName = @"..\..\Music\music.mp3";
            p.Start();
        }
    }
}
