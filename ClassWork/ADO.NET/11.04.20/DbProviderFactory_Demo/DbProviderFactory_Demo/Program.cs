using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;

namespace DbProviderFactory_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString1 = ConfigurationManager.ConnectionStrings["Server1"].ConnectionString;
            // string connectionString2 = .....
            DbConnection connection1 = new SqlConnection(connectionString1);
            // DbConnection connection2 = ....
            connection1.Open();
            DbProviderFactory factory1 = DbProviderFactories.GetFactory(connection1);
            // DbProviderFactory factory2 = DbProviderFactories.GetFactory(connection2);

            DbCommand cmd1 = factory1.CreateCommand();
            cmd1.CommandText = "select * from Empoyees";
            cmd1.Connection = connection1;
            DbDataReader reader1 = cmd1.ExecuteReader();

            while(reader1.Read())
            {
                Console.WriteLine($"Name: {reader1["Name"]}; Position: {reader1["Position"]}; Salary: {reader1["Salary"]};");
            }

            reader1.Close();
            connection1.Close();
        }
    }
}
