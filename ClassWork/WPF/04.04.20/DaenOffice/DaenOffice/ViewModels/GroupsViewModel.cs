using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using DaenOffice.DataModels;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DaenOffice.ViewModels
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
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
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
                    Id = (int)row["Id"],
                    Name = (string)row["Name"],
                    FacultyId = (int)row["FacultyId"]
                };
                Groups.Add(g);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
