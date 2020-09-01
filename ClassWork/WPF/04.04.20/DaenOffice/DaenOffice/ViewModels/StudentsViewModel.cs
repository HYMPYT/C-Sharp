using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using DaenOffice.DataModels;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DaenOffice.ViewModels
{
    public class StudentsViewModel : INotifyPropertyChanged
    {
        string connectionString;
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable table;

        public ObservableCollection<Student> Students { get; set; }

        public StudentsViewModel()
        {
            Students = new ObservableCollection<Student>();
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            connection = new SqlConnection(connectionString);

            string baseQuery = "select * from Students";
            adapter = new SqlDataAdapter(baseQuery, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            table = new DataTable();
        }

        public void LoadData(int gid)
        {
            table.Clear();
            adapter.Fill(table);
            DataRow[] rows = table.Select($"GroupId = {gid}");
            Students.Clear();
            foreach (DataRow row in rows)
            {
                Student s = new Student()
                {
                    Id = (int)row["Id"],
                    Name = (string)row["Name"],
                    Address = (string)row["Address"],
                    Phone = (string)row["Phone"],
                    Contacts = (string)row["Contacts"],
                    Grades = (string)row["Grades"],
                    Info = (string)row["Info"],
                    GroupId = (int)row["GroupId"]
                };
                Students.Add(s);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
