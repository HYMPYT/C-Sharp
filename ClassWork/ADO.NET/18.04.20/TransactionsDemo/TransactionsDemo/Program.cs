using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace TransactionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection1"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = connection.CreateCommand();
            SqlTransaction transaction = null;

            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();
                cmd.Transaction = transaction;

                int pid = 2;
                int amount = 10;
                cmd.CommandText = $"insert into Sales (SaleDate, ProductId, Amount) values ('2020-04-18 13:25', {pid}, {amount})";
                cmd.ExecuteNonQuery();
                Console.WriteLine("\n> Insert Command - OK");

                cmd.CommandText = $"update Goodss set Amount = Amount - {amount} where Id = {pid}";
                cmd.ExecuteNonQuery();
                Console.WriteLine("\n> Update Command - OK");

                transaction.Commit();
                Console.WriteLine("\n> Transaction Commit - OK");
            }
            catch (Exception err)
            {
                Console.WriteLine($"\n> {err.Message}");
                Console.WriteLine("\n> Транзакция отменена");
                transaction.Rollback();
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
    }
}
