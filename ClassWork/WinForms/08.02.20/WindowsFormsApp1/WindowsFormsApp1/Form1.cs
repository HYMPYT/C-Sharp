using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int h, m, s, z;
        int controlTime, currentTime;
        public Form1()
        {
            InitializeComponent();
            h = m = s = z = 0;
        }

        private string GetTimeString()
        {
            if (z < 100)
                z++;
            else
            {
                z = 0;
                if (s < 60)
                    s++;
                else
                {
                    s = 0;
                    if (m < 60)
                        m++;
                    else
                    {
                        m = 0;
                        if (h < 24)
                            h++;
                        else
                        {
                            timer.Stop();
                            MessageBox.Show("Достигнут предел времени!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            string time = "";
            time += (h < 10) ? "0" + h.ToString() : h.ToString();
            time += ":";
            time += (m < 10) ? "0" + m.ToString() : m.ToString();
            time += ":";
            time += (s < 10) ? "0" + s.ToString() : s.ToString();
            time += ":";
            time += (z < 10) ? "0" + z.ToString() : z.ToString();
            return time;

        }

        private void DisplayProgress()
        {
            currentTime = (h * 3600 + m * 60 + s) * 100 + z;
            progress.Maximum = controlTime;
            progress.Value = currentTime;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            startBtn.Enabled = false;
            stopBtn.Enabled = true;
            resetBtn.Enabled = false;
            controlTime = ((int)hourField.Value * 3600 + (int)minuteField.Value * 60 + (int)secondField.Value) * 100;
            timer.Start();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            startBtn.Enabled = true;
            stopBtn.Enabled = false;
            resetBtn.Enabled = true;
            timer.Stop();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            startBtn.Enabled = true;
            stopBtn.Enabled = false;
            resetBtn.Enabled = false;
            progress.Value = 0;
            clock.Text = "00:00:00:00";
            h = m = s = z = 0;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (currentTime == controlTime)
            {
                stopBtn.Enabled = false;
                startBtn.Enabled = true;
                resetBtn.Enabled = true;
                timer.Stop();
                MessageBox.Show("Достигнут предел времени!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            clock.Text = GetTimeString();
            DisplayProgress();
           
        }
    }
}
