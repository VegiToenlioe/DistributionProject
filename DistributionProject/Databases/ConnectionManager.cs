using System.Data;
using Distribution.Model.Interfaces;

namespace Distribution.Model.Databases
{
  public class ConnectionManager : IConnectionManager
  {
    private IDbConnection _connection;
    private string _connectionString;
    private string _physicalPath;

    public ConnectionManager( string connectionString )
    {
      _connectionString = connectionString;
    }

    #region IConnectionManager

    public IDbConnection Connection { get { return _connection; } }
    public string ConnectionString { get { return _connectionString; } }
    public string PhysicalPath { get { return _physicalPath; } }
    public bool IsOpen { get { return _connection.State == ConnectionState.Open; } }

    public bool Connect()
    {
      try
      {
        _connection.ConnectionString = _connectionString;
        _connection.Open();
        return true;
      }
      catch
      {
        return false;
      }
    }

    public void Disconnect()
    {
      if( _connection.State == ConnectionState.Open )
        _connection.Close();
    }

    #endregion

    #region IDisposable

    public void Dispose()
    {
      _connection.Dispose();
      _connection = null;
    }

    #endregion
  }
}