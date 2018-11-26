using System.Data;
using System.Collections.Generic;
using Distribution.Model.Enums;

namespace Distribution.Model.Interfaces
{
  /// <summary>
  /// Manage database usage.
  /// </summary>
  public interface IDatabase
  {
    /// <summary>
    /// Retrieve database connection
    /// </summary>
    IConnectionManager Connection { get; }

    /// <summary>
    /// Get database name.
    /// </summary>
    string DatabaseName { get; }

    /// <summary>
    /// Execute single SQL non query command. 
    /// Throws exception if connection closed.
    /// 
    /// </summary>
    /// <param name="sql">SQL command to execute</param>
    /// <returns>Number rows affected by the operation</returns>
    ExecuteResult Execute( string sql );

    /// <summary>
    /// Execute series of SQL non-query command.
    /// Commands will executed sequentially wrapped in a transaction
    /// </summary>
    /// <param name="sqls">Series of SQL commands to execute</param>
    /// <returns>Number rows affected by operation </returns>
    ExecuteResult Execute( string[] sqls );

    /// <summary>
    /// Execute single SQL query command and get last inserted id
    /// </summary>
    /// <param name="sql">SQL command to execute, typically SQL insert</param>
    /// <returns>The id of last inserted row, null otherwise</returns>
    object ExecuteGetId( string sql );

    /// <summary>
    /// Execute a SQL query
    /// </summary>
    /// <param name="sql">SQL query to execute</param>
    /// <returns>Dataset represents</returns>
    DataSet Query( string sql );

    /// <summary>
    /// Gets whether the connection execute initial database script;
    /// </summary>
    //bool IsExecuteScript { get; }
  }
}
