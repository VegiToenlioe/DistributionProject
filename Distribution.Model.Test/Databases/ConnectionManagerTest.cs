using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Distribution.Model.Databases;

namespace Distribution.Model.Test
{
  [TestClass]
  public class ConnectionManagerTest
  {
    [TestMethod]
    public void ConnectionSuccessTest()
    {
      //Arrange
      bool expected = true;
      ConnectionManager cm = new ConnectionManager( "" );
      
      //Act
      bool actual = cm.Connect();

      //Assert
      Assert.AreEqual( expected, actual );
    }
  }
}
