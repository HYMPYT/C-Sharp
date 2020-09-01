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
    class EmpManager : DbProvider
    {
        public List<Employee> Employees { get; set; }
        public EmpManager()
        {
            Employees = new List<Employee>();
        }

        public void LoadEmp(string depName)
        {
            string query = "getEmpList";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@DepName", SqlDbType.NVarChar, 50).Value = depName;
            SqlDataReader reader = cmd.ExecuteReader();
            Employees.Clear();
            while(reader.Read())
            {
                if (reader["Viber"] == DBNull.Value)
                {
                    Employee e = new Employee()
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"],
                        Birthday = (DateTime)reader["Birthday"],
                        Email = (string)reader["Email"],
                        Phone = (string)reader["Phone"],
                        Viber = "",
                        Position = (string)reader["Position"],
                        Salary = (decimal)reader["Salary"],
                        Skills = (string)reader["Skills"],
                        DepartmentId = (int)reader["DeparmentId"]
                    };
                    Employees.Add(e);
                }
                else if(reader["Skills"] == DBNull.Value)
                {
                    Employee e = new Employee()
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"],
                        Birthday = (DateTime)reader["Birthday"],
                        Email = (string)reader["Email"],
                        Phone = (string)reader["Phone"],
                        Viber = (string)reader["Viber"],
                        Position = (string)reader["Position"],
                        Salary = (decimal)reader["Salary"],
                        Skills = "",
                        DepartmentId = (int)reader["DeparmentId"]
                    };
                    Employees.Add(e);
                }
                else
                {
                    Employee e = new Employee()
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"],
                        Birthday = (DateTime)reader["Birthday"],
                        Email = (string)reader["Email"],
                        Phone = (string)reader["Phone"],
                        Viber = (string)reader["Viber"],
                        Position = (string)reader["Position"],
                        Salary = (decimal)reader["Salary"],
                        Skills = (string)reader["Skills"],
                        DepartmentId = (int)reader["DeparmentId"]
                    };
                    Employees.Add(e);
                }
            }
            connection.Close();
        }

        public void AddEmp()
        {

        }

        public void DelEmp()
        {

        }
    }
}
