using System;

public interface IDatabase
{  
    void Connect();
    void InsertData(string data);
    void Disconnect();
}
class SQLDatabase : IDatabase
{    
    public void Connect()
    {
        Console.WriteLine("Connected to SQL Database");
    }
 
    public void InsertData(string data)
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

    public void InsertData(string data)
    {
        Console.WriteLine("Data inserted");
    }

    public void Disconnect()
    {
        Console.WriteLine("Disconnected from NoSQL Database");   
    }
}

public class DatabaseManager
{
    private readonly IDatabase _database;
    
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

class Program
{
    public static void Main(string[] args)
    {
        DatabaseManager databaseManager = new DatabaseManager(new SQLDatabase());

        databaseManager.AddData();

        databaseManager = new DatabaseManager(new NoSQLDatabase());

        databaseManager.AddData();        
    }
}