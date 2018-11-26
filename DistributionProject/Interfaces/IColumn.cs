namespace Distribution.Model.Interfaces
{
  public interface IColumn<T>
  {
    string Name { get; }
    T Value { get; set; }
    bool IsPrimaryKey { get; }
    bool IsNullable { get; }
  }
}
