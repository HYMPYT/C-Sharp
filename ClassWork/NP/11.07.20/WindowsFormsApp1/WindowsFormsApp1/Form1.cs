using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public MailAddress UserName { get; set; }
        public string Password { get; set; }
        MailMessage message;

        string server = "smtp.gmail.com";
        public Form1()
        {
            InitializeComponent();
            message = new MailMessage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var to = toBox.Text.Split(',');
            message.From = UserName;
            for (int i = 0; i < to.Length; i++)
            {
                message.To.Add(to[i]);
                
            }
            message.Subject = themeBox.Text;
            message.Body = bodyBox.Text;
            SmtpClient client = new SmtpClient(server);
            client.Credentials = new NetworkCredential(UserName.ToString(), Password);
            client.EnableSsl = true;
            client.Port = 25;
            client.SendAsync(message, "That's all");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Authentication au = new Authentication();
            if (au.ShowDialog() == DialogResult.OK)
            {
                UserName = au.UserNameAU;
                Password = au.PasswordAU;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                message.Attachments.Add(new Attachment(ofd.FileName));
            }
            listBox1.Items.Clear();
            foreach (var item in message.Attachments)
            {
                listBox1.Items.Add(item.Name);
            }
        }
    }
}
