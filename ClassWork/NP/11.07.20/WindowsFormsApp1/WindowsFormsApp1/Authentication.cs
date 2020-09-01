using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Authentication : Form
    {
        public MailAddress UserNameAU { get; set; }
        public string PasswordAU { get; set; }
        public Authentication()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserNameAU = new MailAddress(userBox.Text);
            PasswordAU = passwordBox.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
