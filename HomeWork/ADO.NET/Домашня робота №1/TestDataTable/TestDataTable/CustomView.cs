using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TestDataTable
{
    class CustomView
    {
        string _connectionString;
        string _showAll = @"select b.Id as 'BookId',b.Title,b.Price,b.Pages,a.FirstName as 'Author Name',a.LastName as 'Author Last Name',p.Name as 'Picture Path',p.Picture from Books b join Authors a on b.AuthorId=a.Id left join Pictures p on p.BookId=b.Id";
        SqlConnection _conn;
        SqlDataAdapter _dap;
        DataTable _table;

        public CustomView()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["Library"].ConnectionString;
            _conn = new SqlConnection(_connectionString);
            ExecuteQuery();
        }

        public DataTable ExecuteQuery(string cmd = null)
        {
            _table = new DataTable();
            if (cmd == null || string.IsNullOrEmpty(cmd.Trim(' ')))
                _dap = new SqlDataAdapter(_showAll, _conn);
            else
                _dap = new SqlDataAdapter(cmd, _conn);

            SqlCommandBuilder builder = new SqlCommandBuilder(_dap);

            _dap.Fill(_table);

            return _table;
        }

    }
}