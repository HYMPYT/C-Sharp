using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegExpDemo
{
    public partial class LoginWindow : Form
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login = textBox1.Text;
            Password = textBox2.Text;
            if(Login == "" || Password == "")
            {
                MessageBox.Show("Вы не ввели исходные данные!");
            }
            else
            {
                // Валидация данных(проверка данных)
                string pattern = @"^[a-z][a-zA-Z0-9_\-]{4,11}$";
                Regex regex = new Regex(pattern);
                if (!(regex.IsMatch(Login)))
                {
                    MessageBox.Show("Логин - не валидный!");
                }
                else
                {
                    MessageBox.Show("Логин - валидный!");

                    // отправка данных
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
