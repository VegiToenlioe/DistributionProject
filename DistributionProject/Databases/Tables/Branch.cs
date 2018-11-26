using Distribution.Model.Interfaces;
using Distribution.Model.Interfaces.GlobalImplementations;

namespace Distribution.Model.Databases.Tables
{
  public class Branch : ITable
  {
    public Branch()
    {
      Id = new Column<int>( "Id", 0, true, false );
      Name = new Column<string>( "Name", null, false, false );
      CityId = new Column<int?>( "CityId", null, false, true );
    }

    public Branch( string jsonText )
    {

    }

    public IColumn<int> Id { get; private set; }
    public IColumn<string> Name { get; set; }
    public IColumn<int?> CityId { get; set; }

    #region ITable

    public string TableName { get { return "Branch"; } }

    #endregion
  }
}