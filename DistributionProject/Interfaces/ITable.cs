using System.Data;

namespace Distribution.Model.Interfaces
{
  /// <summary>
  /// Interface for tables.
  /// </summary>
  public interface ITable
  {
    /// <summary>
    /// Get table name.
    /// </summary>
    string TableName { get; }
  }
}
