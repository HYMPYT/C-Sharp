using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Organizer.Models;

namespace Organizer
{
    public partial class AddTaskForm : Form
    {
        string connectionString;
        SqlConnection connection;
        List<Category> categories;
        public string TaskName { get; set; }
        public string TaskAbout { get; set; }
        public string TaskTerm { get; set; }
        public int CategoryID { get; set; }
        public AddTaskForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            connection = new SqlConnection(connectionString);
            categories = new List<Category>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaskName = textBox1.Text;
            if (TaskName == "")
            {
                MessageBox.Show("Вы не ввели заголовок задачи");
            }
            else
            {
                TaskAbout = textBox2.Text;
                TaskTerm = textBox3.Text;
                Category c = (Category)comboBox1.SelectedItem;
                CategoryID = c.Id;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AddTaskForm_Load(object sender, EventArgs e)
        {
            string query = "select * from Categories";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            categories.Clear();
            while (reader.Read())
            {
                Category c = new Category()
                {
                    Id = (int)reader["Id"],
                    Name = (string)reader["Name"]
                };
                categories.Add(c);
            }
            connection.Close();

            comboBox1.Items.Clear();
            foreach (var c in categories)
            {
                comboBox1.Items.Add(c);
            }
            comboBox1.DisplayMember = "Name";
            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
        }
    }
}
