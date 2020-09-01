using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year, month, day;
            try
            {
                year = int.Parse(textBox1.Text);
                month = int.Parse(textBox2.Text);
                day = int.Parse(textBox3.Text);
                DateTime dtnow = DateTime.Now;
                DateTime dt = new DateTime(year, month, day);
                if (dtnow < dt)
                {
                    if (radioButton1.Checked)
                    {
                        if (year % 4 == 0)
                            textBox4.Text = Math.Round((dt - dtnow).TotalDays / 366, 2).ToString();
                        else
                            textBox4.Text = Math.Round((dt - dtnow).TotalDays / 365, 2).ToString();
                    }
                    else if (radioButton2.Checked)
                    {
                        textBox4.Text = Math.Round((dt - dtnow).TotalDays / 30, 1).ToString();
                    }
                    else if (radioButton3.Checked)
                    {
                        textBox4.Text = (dt - dtnow).Days.ToString();
                    }
                    else if (radioButton4.Checked)
                    {
                        textBox4.Text = ((dt - dtnow).Days * 1440).ToString();
                    }
                    else
                    {
                        textBox4.Text = ((dt - dtnow).Days * 86400).ToString();
                    }
                }
                else
                    MessageBox.Show("Дата которую вы ввели меньше сегодняшней даты");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
