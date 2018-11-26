using System.Collections.Generic;
using System.Data;
using Distribution.Model.Enums;
using Distribution.Model.Interfaces;

namespace Distribution.Model.Databases
{
  /// <summary>
  /// Implementation of IDatabase.
  /// </summary>
  public abstract class Database : IDatabase
  {
    private string _databaseName;
    private IConnectionManager _connection;

    /// <summary>
    /// Database class constructor.
    /// </summary>
    public Database( string connectionString )
    {
      _connection = new ConnectionManager( connectionString );
    }

    #region IDatabase

    public IConnectionManager Connection { get { return _connection; } }
    public string DatabaseName { get { return _databaseName; } }

    public ExecuteResult Execute( string sql )
    {
      return ExecuteResult.Success;
    }

    public ExecuteResult Execute( string[] sqls )
    {
      return ExecuteResult.Success;
    }

    public object ExecuteGetId( string sql )
    {
      return null;
    }

    public DataSet Query( string sql )
    {
      return null;
    }

    #endregion
  }
}