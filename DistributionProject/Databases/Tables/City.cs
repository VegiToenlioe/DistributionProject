using Distribution.Model.Interfaces;
using Distribution.Model.Interfaces.GlobalImplementations;

namespace Distribution.Model.Databases.Tables
{
  public class City : ITable
  {
    public City()
    {
      Id = new Column<int>( "Id", 0, true, false );
      Name = new Column<string>( "Name", null, false, false );
    }

    public City( string jsonText )
    {

    }

    public IColumn<int> Id { get; private set; }
    public IColumn<string> Name { get; set; }

    #region ITable

    public string TableName { get { return "City"; } }

    #endregion
  }
}
