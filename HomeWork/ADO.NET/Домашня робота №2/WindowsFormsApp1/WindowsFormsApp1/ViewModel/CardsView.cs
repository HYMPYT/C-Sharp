using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.ViewModel
{
    class CardsView : DBProvider<Card>
    {
        public CardsView(string connectionName, bool fill = false) : base("Cards", connectionName, fill)
        {
            _adapter.UpdateCommand = GetUpdateCommand();
        }

        public void LoadData()
        {
            _dataSet.Tables[TableName].Clear();
            _adapter.Fill(_dataSet);
            ObjColl.Clear();
            foreach (DataRow row in MainTable.Rows)
            {
                Card c = new Card() { Id = (int)row["Id"], FName = (string)row["FName"], MoneyOnCard = (decimal)row["MoneyOnCard"] };
                ObjColl.Add(c);
            }
        }

        public bool MoneyTransaction(decimal money, int fromId, int toId)
        {
            DbCommand takeMoney = GetTakeMoneyCommand();
            takeMoney.Parameters.AddRange(GetMoneyOperationParameters(money, fromId, takeMoney));

            DbCommand sendMoney = GetSendMoneyCommand();
            sendMoney.Parameters.AddRange(GetMoneyOperationParameters(money, toId, sendMoney));

            return BeginTransaction(takeMoney, sendMoney);
        }

        private DbParameter[] GetMoneyOperationParameters(decimal money, int id, DbCommand cmd)
        {
            DbParameter pMoney = cmd.CreateParameter();
            pMoney.ParameterName = "@pCurrency";
            pMoney.DbType = DbType.Currency;
            pMoney.Value = money;
            pMoney.SourceVersion = DataRowVersion.Current;
            pMoney.SourceColumn = "MoneyOnCard";

            DbParameter pId = cmd.CreateParameter();
            pId.ParameterName = "@pId";
            pId.DbType = DbType.Int32;
            pId.Value = id;
            pId.SourceVersion = DataRowVersion.Original;
            pId.SourceColumn = "Id";

            return new DbParameter[] { pMoney, pId };
        }

        private DbCommand GetTakeMoneyCommand()
        {
            DbCommand takeMoney = _conn.CreateCommand();
            takeMoney.Connection = _conn;
            takeMoney.CommandText = "Update Cards set MoneyOnCard = MoneyOnCard - @pCurrency where Id = @pId";
            takeMoney.CommandType = CommandType.Text;
            return takeMoney;
        }
        private DbCommand GetSendMoneyCommand()
        {
            DbCommand sendMoney = _conn.CreateCommand();
            sendMoney.Connection = _conn;
            sendMoney.CommandText = "Update Cards set MoneyOnCard = MoneyOnCard + @pCurrency where Id = @pId";
            sendMoney.CommandType = CommandType.Text;
            return sendMoney;
        }

        /// <summary>
        /// Hardcoded Example of transaction with NonQuery commands , with blackjack and whores
        /// </summary>
        /// <param name="commands"></param>
        /// <returns>True if method ended corectly and throw app ex if not.</returns>
        private bool BeginTransaction(params DbCommand[] commands)
        {
            DbTransaction transaction = null;
            try
            {
                _conn.Open();
                transaction = _conn.BeginTransaction();
                DbCommand cmd = null;
                foreach (DbCommand command in commands)
                {
                    cmd = command;
                    cmd.CommandType = CommandType.Text;
                    cmd.Transaction = transaction;
                    cmd.ExecuteNonQuery();
                }
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
            finally { _conn.Close(); }

            return true;
        }

        /// <summary>
        /// Example of creation parameterized command to update money on card by card id
        /// </summary>
        /// <returns></returns>
        public virtual DbCommand GetUpdateCommand()
        {
            DbCommand cmd = _conn.CreateCommand();
            cmd.Connection = _conn;
            cmd.CommandText = "Update Cards set MoneyOnCard = MoneyOnCard - @pCurrency where Id = @pId";
            cmd.CommandType = CommandType.Text;

            DbParameter curency = cmd.CreateParameter();
            curency.ParameterName = "@pCurrency";
            curency.DbType = DbType.Currency;
            curency.SourceVersion = DataRowVersion.Current;
            curency.SourceColumn = "MoneyOnCard";
            cmd.Parameters.Add(curency);

            DbParameter id = cmd.CreateParameter();
            id.ParameterName = "@pId";
            id.DbType = DbType.Int32;
            id.SourceVersion = DataRowVersion.Original;
            id.SourceColumn = "Id";
            cmd.Parameters.Add(id);

            return cmd;
        }


        /// <summary>
        /// Connected async data set fill operation
        /// Look like AsyncReader works only with Sql
        /// </summary>
        /// <param name="tableName"></param>
        public void SqlAsyncCollbackFillDataSet(string tableName)
        {
            if (_selectedProvider != "System.Data.SqlClient")
                throw new ApplicationException($"Such a method workds only with SqlProvider. You using the {_selectedProvider}");

            const string AsyncEnabled = "Asynchronous Processing=true";
            if (!_connString.Contains(AsyncEnabled))
                _connString = $"{_connString}; {AsyncEnabled}";

            _conn = new SqlConnection(_connString);
            DbCommand cmd = _conn.CreateCommand();
            cmd.CommandText = $"select * from {tableName};";
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 30;
            try
            {
                _conn.Open();
                AsyncCallback callback = new AsyncCallback(GetDataCallback);
                ((SqlCommand)cmd).BeginExecuteReader(callback, cmd);
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Collback method for specialized async method
        /// </summary>
        /// <param name="result"></param>
        private void GetDataCallback(IAsyncResult result)
        {
            SqlDataReader reader = null;
            DataTable table = null;
            try
            {
                SqlCommand command = (SqlCommand)result.AsyncState;
                reader = command.EndExecuteReader(result);
                bool firstLine = true;
                do
                {
                    while (reader.Read())
                    {
                        if (firstLine)
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                                table.Columns.Add(reader.GetName(i));
                            firstLine = false;
                        }
                        DataRow row = table.NewRow();
                        for (int i = 0; i < reader.FieldCount; i++)
                            row[i] = reader[i];
                        table.Rows.Add(row);
                    }
                } while (reader.NextResult());
                _dataSet.Tables.Add(table);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                try
                {
                    if (!reader.IsClosed)
                    {
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Connected async data set fill operation
        /// Look like AsyncReader works only with Sql
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public bool SqlAsyncWaitHandleFillDataSet(string tableName)
        {
            if (_selectedProvider != "System.Data.SqlClient")
                throw new ApplicationException($"Such a method workds only with SqlProvider. You using the {_selectedProvider}");

            const string AsyncEnabled = "Asynchronous Processing=true";
            if (!_connString.Contains(AsyncEnabled))
                _connString = $"{_connString}; {AsyncEnabled}";

            _conn = _fact.CreateConnection();
            DbCommand cmd = _conn.CreateCommand();
            cmd.CommandText = $"select * from {tableName}";
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 30;
            try
            {
                _conn.Open();
                IAsyncResult iar = ((SqlCommand)cmd).BeginExecuteReader();
                WaitHandle handle = iar.AsyncWaitHandle;
                if (handle.WaitOne(10000))
                {
                    GetData((SqlCommand)cmd, iar);
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Method for specialized async method with WaitHandle
        /// </summary>
        /// <param name="command"></param>
        /// <param name="ia"></param>
        private void GetData(SqlCommand command, IAsyncResult ia)
        {
            SqlDataReader reader = null;
            try
            {
                reader = command.EndExecuteReader(ia);
                DataTable table = new DataTable();
                bool firstLine = true;
                do
                {
                    while (reader.Read())
                    {
                        if (firstLine)
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                                table.Columns.Add(reader.GetName(i));
                            firstLine = false;
                        }
                        DataRow row = table.NewRow();
                        for (int i = 0; i < reader.FieldCount; i++)
                            row[i] = reader[i];
                        table.Rows.Add(row);
                    }
                } while (reader.NextResult());
                _dataSet.Tables.Add(table);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                try
                {
                    if (!reader.IsClosed)
                        reader.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

    }
}