using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DaenOffice.DataModels;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DaenOffice.ViewModels
{
    public class FacultiesViewModel : INotifyPropertyChanged
    {
        string connectionString;
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable table;

        public ObservableCollection<Faculty> Faculties { get; set; }

        public FacultiesViewModel()
        {
            Faculties = new ObservableCollection<Faculty>();
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            connection = new SqlConnection(connectionString);

            string baseQuery = "select * from Faculties";
            adapter = new SqlDataAdapter(baseQuery, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            table = new DataTable();
        }

        public void LoadData()
        {
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                Faculty f = new Faculty()
                {
                    Id = (int)row["Id"],
                    Name = (string)row["Name"]
                };
                Faculties.Add(f);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
