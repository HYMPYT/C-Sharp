using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;

namespace WindowsFormsApp1.ViewModel
{
    public class DBProvider<T>
    {
        protected string _selectedProvider = null;
        protected DbProviderFactory _fact = null;
        protected DbConnection _conn = null;
        protected string _connString = null;
        protected DbDataAdapter _adapter = null;
        protected DataSet _dataSet = null;
        public DataTable MainTable { get => _dataSet.Tables[TableName]; }
        public readonly string TableName;
        public List<T> ObjColl = null;

        /// <summary>
        /// By default uses SqlClient
        /// </summary>
        /// <param name="connectionName"></param>
        public DBProvider(string tableName, string connectionName, bool fill = false)
        {
            ObjColl = new List<T>();
            _dataSet = new DataSet();
            TableName = tableName;
            _connString = GetConnectionStringByConnectionName(connectionName);
            _selectedProvider = GetProviderByConnectionName(connectionName);
            _fact = DbProviderFactories.GetFactory(_selectedProvider);
            _conn = _fact.CreateConnection();
            _conn.ConnectionString = _connString;
            _adapter = _fact.CreateDataAdapter();
            _adapter.SelectCommand = GetSelectCommand(tableName);
            DbCommandBuilder builder = _fact.CreateCommandBuilder();// you can work only with dataset or table , _adapter.Update(); will automatically sinchronize changes with db(by using _adapter commands) (https://metanit.com/sharp/adonet/3.3.php)
            builder.DataAdapter = _adapter;
            SetMapping();
            if (fill)
                _adapter.Fill(_dataSet);
        }

        public virtual DbCommand GetSelectCommand(string tableName)
        {
            DbCommand cmd = _conn.CreateCommand();
            cmd.Connection = _conn;
            cmd.CommandText = $"select * from {TableName}";
            cmd.CommandType = CommandType.Text;
            return cmd;
        }
        /// <summary>
        /// Find Connection String by connection name in App.config
        /// </summary>
        /// <param name="connnectionName"></param>
        /// <returns><paramref name="ConnectionString"/></returns>
        public static string GetConnectionStringByConnectionName(string connnectionName)
        {
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
            if (settings != null)
                foreach (ConnectionStringSettings cs in settings)
                    if (cs.Name == connnectionName)
                        return cs.ConnectionString;
            throw new ApplicationException($"There no connection string for {connnectionName}.");
        }
        /// <summary>
        /// Find Provider Name by connection name in App.config
        /// </summary>
        /// <param name="connnectionName"></param>
        /// <returns><paramref name="ProviderName"/></returns>
        public static string GetProviderByConnectionName(string connnectionName)
        {
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
            if (settings != null)
                foreach (ConnectionStringSettings cs in settings)
                    if (cs.Name == connnectionName)
                        return cs.ProviderName;
            throw new ApplicationException($"There no provider for {connnectionName}.");
        }


        /// <summary>
        /// Example of mapping
        /// </summary>
        public virtual void SetMapping()
        {
            DataTableMapping dtm = _adapter.TableMappings.Add("Table", TableName); /// _adapter.TableMappings.Add("Table", "Cards");
            //dtm.ColumnMappings.Add("FName", "User Name"); // looks like DataViewManager's filters dont work with that
        }

        /// <summary>
        /// Hardcoded Example to filter Cards Table by card owner name
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="owner"></param>
        /// <returns></returns>
        public virtual DataView GetView(string fName = "")
        {
            if (_dataSet == null)
                throw new ApplicationException("DataSet points to null.");
            DataViewManager dvm = new DataViewManager(_dataSet);
            dvm.DataViewSettings[TableName].RowFilter = $"FName like '%' +'{fName}'+ '%'";
            //dvm.DataViewSettings[TableName].Sort = "MoneyOnCard asc";
            return dvm.CreateDataView(_dataSet.Tables[TableName]);
        }

    }
}