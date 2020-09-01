using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DeanOffice.DataModels;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DeanOffice.ViewModels
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
            connectionString = ConfigurationManager
                .ConnectionStrings["DefaultConnection"]
                .ConnectionString;
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
                    Id = (int) row["Id"],
                    Name = (string) row["Name"],
                    Address = (string) row["Address"],
                    Phone = (string) row["Phone"],
                    Contacts = (string) row["Contacts"],
                    Grades = (string) row["Grades"],
                    Info = (string) row["Info"],
                    GroupId = (int) row["GroupId"]
                };
                Students.Add(s);
            }
        }

        public void AddStudent(Student student)
        {
            DataRow row = table.NewRow();
            row["Id"] = student.Id;
            row["Name"] = student.Name;
            row["Address"] = student.Address;
            row["Phone"] = student.Phone;
            row["Contacts"] = student.Contacts;
            row["GroupId"] = student.GroupId;
            row["Grades"] = student.Grades;
            row["Info"] = student.Info;
            table.Rows.Add(row);
            adapter.Update(table);
        }

        public void DelStudent(int sid)
        {
            DataRow[] rows = table.Select($"Id = {sid}");
            rows[0].Delete();
            adapter.Update(table);
        }

        public void EditStudent(Student student)
        {
            DataRow[] rows = table.Select($"Id = {student.Id}");
            rows[0]["Id"] = student.Id;
            rows[0]["Name"] = student.Name;
            rows[0]["Address"] = student.Address;
            rows[0]["Phone"] = student.Phone;
            rows[0]["Contacts"] = student.Contacts;
            rows[0]["GroupId"] = student.GroupId;
            rows[0]["Grades"] = student.Grades;
            rows[0]["Info"] = student.Info;
            adapter.Update(table);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
