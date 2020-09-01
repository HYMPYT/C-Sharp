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
    public class GroupsViewModel : INotifyPropertyChanged
    {
        string connectionString;
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable table;

        public ObservableCollection<Group> Groups { get; set; }

        public GroupsViewModel()
        {
            Groups = new ObservableCollection<Group>();
            connectionString = ConfigurationManager
                .ConnectionStrings["DefaultConnection"]
                .ConnectionString;
            connection = new SqlConnection(connectionString);

            string baseQuery = "select * from Groups";
            adapter = new SqlDataAdapter(baseQuery, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            table = new DataTable();
        }

        public void LoadData(int fid)
        {
            table.Clear();
            adapter.Fill(table);
            DataRow[] rows = table.Select($"FacultyId = {fid}");
            Groups.Clear();
            foreach (DataRow row in rows)
            {
                Group g = new Group()
                {
                    Id = (int) row["Id"],
                    Name = (string) row["Name"],
                    FacultyId = (int) row["FacultyId"]
                };
                Groups.Add(g);
            }
        }

        public void AddGroup(Group group)
        {
            DataRow row = table.NewRow();
            row["Id"] = group.Id;
            row["Name"] = group.Name;
            row["FacultyId"] = group.FacultyId;
            table.Rows.Add(row);
            adapter.Update(table);
        }

        public void DelGroup(int gid)
        {
            DataRow[] rows = table.Select($"Id = {gid}");
            rows[0].Delete();
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
