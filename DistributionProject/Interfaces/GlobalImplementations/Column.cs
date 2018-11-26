namespace Distribution.Model.Interfaces.GlobalImplementations
{
  public class Column<T> : IColumn<T>
  {
    public Column( string name, T value, bool isPrimaryKey, bool isNullable )
    {
      Name = name;
      Value = value;
      IsPrimaryKey = isPrimaryKey;
      IsNullable = isNullable;
    }

    public string Name { get; private set; }
    public T Value { get; set; }
    public bool IsPrimaryKey { get; private set; }
    public bool IsNullable { get; private set; }
  }
}