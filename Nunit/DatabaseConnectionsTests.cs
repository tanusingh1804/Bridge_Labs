using NUnit.Framework;

[TestFixture] 
public class DatabaseConnectionTests
{
    private DatabaseConnection dbConnection;

    [SetUp] 
    public void Setup()
    {
        dbConnection = new DatabaseConnection();
        dbConnection.Connect();
    }

    [TearDown] 
    public void Teardown()
    {
        dbConnection.Disconnect();
    }

    [Test]
    public void Connect_ShouldSetIsConnectedToTrue()
    {
        Assert.IsTrue(dbConnection.IsConnected);
    }

    [Test] 
    public void Disconnect_ShouldSetIsConnectedToFalse()
    {
        dbConnection.Disconnect();
        Assert.IsFalse(dbConnection.IsConnected);
    }
}

