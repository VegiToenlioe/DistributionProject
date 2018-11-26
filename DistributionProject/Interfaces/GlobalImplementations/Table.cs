namespace Distribution.Model.Interfaces.GlobalImplementations
{
  public abstract class Table : ITable
  {
    #region ITable

    public virtual string TableName { get; set; }

    #endregion
  }
}