using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DeanOffice.DataModels;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DeanOffice.ViewModels
{
    class FacultiesViewModel : INotifyPropertyChanged
    {
        string connectionString;
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable table;

        public ObservableCollection<Faculty> Faculties { get; set; }

        public FacultiesViewModel()
        {
            Faculties = new ObservableCollection<Faculty>();
            connectionString = ConfigurationManager
                .ConnectionStrings["DefaultConnection"]
                .ConnectionString;
            connection = new SqlConnection(connectionString);

            string baseQuery = "select * from Faculties";
            adapter = new SqlDataAdapter(baseQuery, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            table = new DataTable();
        }

        public void LoadData()
        {
            table.Clear();
            adapter.Fill(table);
            Faculties.Clear();
            foreach (DataRow row in table.Rows)
            {
                Faculty f = new Faculty()
                {
                    Id = (int) row["Id"],
                    Name = (string) row["Name"]
                };
                Faculties.Add(f);
            }
        }

        public void AddFaculty(Faculty faculty)
        {
            DataRow row = table.NewRow();
            row["Id"] = faculty.Id;
            row["Name"] = faculty.Name;
            table.Rows.Add(row);
            adapter.Update(table);
        }

        public void DelFaculty(int fid)
        {
            DataRow[] rows = table.Select($"Id = {fid}");
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
