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
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;

        List<Category> categories;
        List<MyTask> myTasks;

        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            connection = new SqlConnection(connectionString);
            categories = new List<Category>();
            myTasks = new List<MyTask>();
        }

        private void LoadCategories()
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

            CategoriesList.Items.Clear();
            foreach (var c in categories)
            {
                CategoriesList.Items.Add(c);
            }
            CategoriesList.DisplayMember = "Name";
            if (CategoriesList.Items.Count > 0)
                CategoriesList.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void CategoriesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category c = (Category)CategoriesList.SelectedItem;
            connection.Open();
            string query = "select * from MyTasks join Categories on MyTasks.CategoryId = Categories.Id where Categories.Name = @name";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = c.Name;
            SqlDataReader reader = cmd.ExecuteReader();
            myTasks.Clear();
            while(reader.Read())
            {
                MyTask t = new MyTask()
                {
                    Id = (int)reader["Id"],
                    Title = (string)reader["Title"],
                    About = (string)reader["About"],
                    Term = (string)reader["Term"],
                    CategoryId = (int)reader["CategoryId"]
                };
                myTasks.Add(t);
            }
            connection.Close();

            TaskList.Items.Clear();
            foreach (var t in myTasks)
            {
                TaskList.Items.Add(t);
            }
            TaskList.DisplayMember = "Title";
            if (TaskList.SelectedIndex > 0)
                TaskList.SelectedIndex = 0;
        }

        private void AddCategory_Click(object sender, EventArgs e)
        {
            AddCategoryForm acf = new AddCategoryForm();
            if (acf.ShowDialog() == DialogResult.OK)
            {
                string name = acf.CategoryName;
                string query = "insert into Categories (Name) values (@name)";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = name;
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Категория успешно добавлена");
                LoadCategories();
            }
        }

        private void DelCategory_Click(object sender, EventArgs e)
        {
            Category c = (Category)CategoriesList.SelectedItem;
            DelCategoryForm dcf = new DelCategoryForm(c.Name);
            if(dcf.ShowDialog() == DialogResult.OK)
            {
                string query = "delete from Categories where Name like @name";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = c.Name;
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Категория успешно удалена");
                LoadCategories();
            }
        }

        private void TaskList_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyTask t = (MyTask)TaskList.SelectedItem;
            connection.Open();
            string query = "select * from MyTasks where Title = @title";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add("@title", SqlDbType.NVarChar, 50).Value = t.Title;
            SqlDataReader reader = cmd.ExecuteReader();
            myTasks.Clear();
            while(reader.Read())
            {
                MyTask mt = new MyTask()
                {
                    Id = (int)reader["Id"],
                    Title = (string)reader["Title"],
                    About = (string)reader["About"],
                    Term = (string)reader["Term"],
                    CategoryId = (int)reader["CategoryId"]
                };
                myTasks.Add(mt);
            }
            connection.Close();

            TitleField.Text = myTasks[0].Title;
            AboutField.Text = myTasks[0].About;
            TermField.Text = myTasks[0].Term;
        }

        private void AddTask_Click(object sender, EventArgs e)
        {

        }

        private void DelTask_Click(object sender, EventArgs e)
        {

        }

        private void EditTask_Click(object sender, EventArgs e)
        {

        }

        private void ResetTask_Click(object sender, EventArgs e)
        {

        }
    }
}
