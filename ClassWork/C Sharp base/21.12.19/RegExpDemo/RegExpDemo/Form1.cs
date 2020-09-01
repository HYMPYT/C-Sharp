using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegExpDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Меня нажали");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginWindow lw = new LoginWindow();
            if(lw.ShowDialog() == DialogResult.OK)
            {
                string security1 = "admin";
                string security2 = "adminadmin";
                if(lw.Login == security1 && lw.Password == security2)
                {
                    MessageBox.Show("Вы успешно авторизованы! Добро пожаловать!");
                }
                else
                {
                    MessageBox.Show("В доступе отказано!");
                    this.Close();
                }
            }
        }
    }
}
