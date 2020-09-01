using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public string PeopleName { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string NameOfCompany { get; set; }
        public string Post { get; set; }
        public string Sex { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                Sex = "Мужской";
            }
            else if(checkBox2.Checked)
            {
                Sex = "Женский";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PeopleName = textBox1.Text;
            Surname = textBox2.Text;
            NameOfCompany = textBox4.Text;
            Post = textBox5.Text;
            try
            {
                Age = int.Parse(textBox3.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            textBox6.Text = $"Имя: {PeopleName}\r\nФамилия: {Surname}\r\nПол: {Sex}\r\nВозраст: {Age}\r\nДолжность: {Post}\r\nНазвание компании: {NameOfCompany}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                checkBox1.Checked = false;
            else if (checkBox2.Checked)
                checkBox2.Checked = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
