namespace Contact.database;

public static class DatabaseUtility
{
    private static string ConnectionString = "";
    
    public static IDataSource GetDatabaseConnection()
    {
        //IDataSource output = new MockDatabase();
        IDataSource output = new ContactDB();

        output.Connect(ConnectionString);
        return output;
    }
    
}