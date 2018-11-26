using System;
using System.Data;

namespace Distribution.Model.Interfaces
{
  /// <summary>
  /// Manages connection to a relational database
  /// </summary>
  public interface IConnectionManager : IDisposable
  {
    /// <summary>
    /// Gets the database connection instance of current object instance
    /// </summary>
    IDbConnection Connection { get; }

    /// <summary>
    /// Gets database connection string of current database connection object
    /// </summary>
    string ConnectionString { get; }

    /// <summary>
    /// Gets the currently connected database physical path
    /// </summary>
    string PhysicalPath { get; }

    /// <summary>
    /// Checks if connection to database is opened
    /// </summary>
    bool IsOpen { get; }

    /// <summary>
    /// Connects to database using current object instance connection string
    /// </summary>
    /// <returns>True if success, false otherwise</returns>
    bool Connect();

    /// <summary>
    /// Disconnects from database specified if a connection opened
    /// </summary>
    void Disconnect();
  }
}
