using System;

public interface IDatabase
{  
    void Connect();
    void InsertData(String data);
    void Disconnect();
}
class SQLDatabase : IDatabase
{
    public void Connect()
    {
        Console.WriteLine("Connected to SQL Database");
    }
    public void InsertData(String data)
    {
        Console.WriteLine("Data inserted");
    }

    public void Disconnect()
    {
        Console.WriteLine("Disconnected from SQL Database");
    }

}

class NoSQLDatabase : IDatabase
{
    public void Connect()
    {
        Console.WriteLine("Connected to NoSQL Database");
    }

    public void InsertData(String data)
    {
        Console.WriteLine("Data Inserted");
    }

    public void Disconnect()
    {
    Console.WriteLine("Disconnected from NoSQL Database");   
    }
}

public class DatabaseManager
{
    private IDatabase _database;
    
    public DatabaseManager(IDatabase database)
    {
        _database = database;
    }

    public void AddData()
    {
        _database.Connect();
        _database.InsertData("sample_data1");
        _database.Disconnect();
    }


}

class MainEntry
{
    public static void Main(String[] args)
    {
        DatabaseManager databaseManager = new DatabaseManager(new SQLDatabase());
        dbm.AddData();

        databaseManager = new DatabaseManager(new NoSQLDatabase());
        dbm.AddData();
        
    }
}