using Distribution.Model.Interfaces;
using Distribution.Model.Interfaces.GlobalImplementations;

namespace Distribution.Model.Databases.Tables
{
  public class User : ITable
  {
    public User()
    {
      Id = new Column<int>( "Id", 0, true, false );
      Username = new Column<string>( "Username", null, false, false );
      Password = new Column<string>( "Password", null, false, true );
    }

    public User( string jsonText )
    {

    }

    public IColumn<int> Id { get; private set; }
    public IColumn<string> Username { get; set; }
    public IColumn<string> Password { get; set; }

    #region ITable

    public string TableName { get { return "User"; } }

    #endregion
  }
}
