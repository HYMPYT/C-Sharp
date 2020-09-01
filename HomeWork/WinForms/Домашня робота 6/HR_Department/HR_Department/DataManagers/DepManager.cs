using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_Department.DataProviders;
using HR_Department.DataModels;
using System.Data.SqlClient;
using System.Data;

namespace HR_Department.DataManagers
{
    class DepManager : DbProvider
    {
        public List<Department> Departments { get; set; }
        
        public DepManager()
        {
            Departments = new List<Department>();
        }

        public void LoadDep()
        {
            string query = "getDepList";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            Departments.Clear();
            while(reader.Read())
            {
                Department dep = new Department()
                {
                    Id = (int)reader["Id"],
                    Name = (string)reader["Name"]
                };
                Departments.Add(dep);
            }
            connection.Close();
        }

        public void AddDep(Department dep)
        {

        }

        public void DelDep(string name)
        {

        }
    }
}
