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
using System.Threading;
using System.Data.Common;

namespace AsyncDB
{
    public partial class Form1 : Form
    {
        DbConnection connection = null;
        DbProviderFactory factory = null;
        string connectionString = "";
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string providerName = "System.Data.SqlClient";
            factory = DbProviderFactories.GetFactory(providerName);
            connection = factory.CreateConnection();
            connectionString = ConfigurationManager.ConnectionStrings["connection1"].ConnectionString;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Вы не ввели текст запроса!");
                }
                else
                {
                    connection.ConnectionString = connectionString;
                    await connection.OpenAsync();
                    DbCommand cmd = connection.CreateCommand();

                    cmd.CommandText = "WAITFOR DELAY '00:00:05'; ";
                    cmd.CommandText += textBox1.Text;

                    int rowsCount = 0;
                    DataTable table = new DataTable();
                    label1.Text = "Запрос на выборку данных обрабатывается ...";

                    using (DbDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        int line = 0;
                        int colsCount = reader.FieldCount;
                        do
                        {
                            while (await reader.ReadAsync())
                            {
                                if (line == 0)
                                {
                                    for (int i = 0; i < colsCount; i++)
                                    {
                                        table.Columns.Add(reader.GetName(i));
                                    }
                                    line++;
                                }
                                DataRow row = table.NewRow();
                                for (int i = 0; i < colsCount; i++)
                                {
                                    row[i] = await reader.GetFieldValueAsync<object>(i);
                                }
                                table.Rows.Add(row);
                                rowsCount++;
                            }
                        } while (reader.NextResult());

                        label1.Text = $"Успешно считано {rowsCount} строк";
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = table;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 3)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}
