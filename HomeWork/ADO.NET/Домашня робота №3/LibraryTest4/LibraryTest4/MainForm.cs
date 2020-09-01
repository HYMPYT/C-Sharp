using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryTest4
{
    public partial class MainForm : Form
    {

        DbConnection _conn = null;
        DbProviderFactory _fact = null;
        string _connStr = "";

        public List<Book> Books { get; set; } = new List<Book>();
        public List<Author> Authors { get; set; } = new List<Author>();

        public MainForm()
        {
            InitializeComponent();
            if (mtfQuery.Text.Length < 3)
                mfBtnRunQuery.Enabled = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string provName = "System.Data.SqlClient";
            _fact = DbProviderFactories.GetFactory(provName);
            _conn = _fact.CreateConnection();
            _connStr = ConfigurationManager.ConnectionStrings["LocalLibrary"].ConnectionString;
            _conn.ConnectionString = _connStr;
        }

        private async void materialFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(mtfQuery.Text.Trim(' ')))
                {
                    await _conn.OpenAsync();

                    await FilBooksAsync();

                    if (mtfQuery.Text.Trim(' ').ToLower() == "select * from books")
                        await FillAuthorsAsync();

                }
                else throw new ApplicationException("Error");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                    _conn.Close();
            }
        }
        private async Task FilBooksAsync()
        {
            DbCommand cmd = _conn.CreateCommand();
            cmd.CommandText = "waitfor delay '00:00:02';";
            cmd.CommandText += mtfQuery.Text;
            Books.Clear();

            int rows = 0;
            DataTable table = new DataTable();
            mlStatus.Text = "Query is proccesing.";

            using (DbDataReader reader = await cmd.ExecuteReaderAsync())
            {
                bool fLine = true;
                int collCount = reader.FieldCount;

                do
                {
                    while (await reader.ReadAsync())
                    {
                        if (fLine)
                        {
                            for (int i = 0; i < collCount; i++)
                                table.Columns.Add(reader.GetName(i));
                            fLine = false;
                        }

                        DataRow row = table.NewRow();
                        await Task.Run(async () =>
                        {
                            for (int i = 0; i < collCount; i++)
                                row[i] = await reader.GetFieldValueAsync<object>(i);
                        });
                        Books.Add(new Book()
                        {
                            Id = (int)reader["Id"],
                            Author_Id = (int)reader["Author_Id"],
                            Title = reader["Title"] as string,
                            Price = (int)reader["Price"],
                            Pages = (int)reader["Pages"]
                        });
                        table.Rows.Add(row);
                        rows++;
                    }

                } while (reader.NextResult());
                mlStatus.Text = $"Succesfully readed {rows} rows from Books";
                dgvTableView.DataSource = table;
            }

        }
        private async Task FillAuthorsAsync()
        {
            Authors.Clear();
            DbCommand cmd = _conn.CreateCommand();
            cmd.CommandText = "waitfor delay '00:00:02';";
            cmd.CommandText += "select * from Authors";
            DataTable table = new DataTable();
            using (DbDataReader reader = await cmd.ExecuteReaderAsync())
            {
                bool fLine = true;
                int collCount = reader.FieldCount;
                int rows = 0;
                do
                {
                    while (await reader.ReadAsync())
                    {
                        if (fLine)
                        {
                            for (int i = 0; i < collCount; i++)
                                table.Columns.Add(reader.GetName(i));
                            fLine = false;
                        }

                        DataRow row = table.NewRow();
                        for (int i = 0; i < collCount; i++)
                            row[i] = await reader.GetFieldValueAsync<object>(i);

                        Authors.Add(new Author() { Id = (int)reader["Id"], Name = reader["Name"] as string, Surname = reader["Surname"] as string });
                        cbAuthors.Items.Add(Authors[Authors.Count - 1]);
                        rows++;
                    }
                } while (reader.NextResult());
                mlStatus.Text += $"\nSuccesfully readed {rows} rows from Authors";
            }
        }

        private void materialSingleLineTextField1_TextChanged(object sender, EventArgs e)
        {
            if (mtfQuery.Text.Length > 3)
                mfBtnRunQuery.Enabled = true;
            else
                mfBtnRunQuery.Enabled = false;
        }

        private async void cbAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAuthors.SelectedIndex != -1)
            {
                int count = 0;
                int authId = ((Author)cbAuthors.SelectedItem).Id;
                await Task.Run(() =>
                {
                    Parallel.ForEach<Book>(Books, (book) =>
                    {
                        if (book.Author_Id == authId)
                            count++;
                    });
                });

                mlBooksCount.Text = count.ToString();
            }
        }
    }
}