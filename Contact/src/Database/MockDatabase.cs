using Contact.Contact;
using Contact.Models;

namespace Contact.database;

public class MockDatabase : IDataSource
{
    public void Connect(string connectionString)
    {
        Console.WriteLine("Connecting to mock database");
    }

    public void CloseConnection()
    {
        Console.WriteLine("Closed connection to mock database");

    }

    public List<ContactData> GetContacts()
    {
        Console.WriteLine("getting mock contacts");
        return new List<ContactData>
        {
            new ContactData(0, "ABC", "DEF", "+420 123 456 789", "a@gmail.com"),
            new ContactData(1, "EDF", "diosa", "+420 123 456 789", "b@gmail.com"),
            new ContactData(2, "GHL", "dajidaoi", "+420 123 456 789", "c@gmail.com"),
            new ContactData(3, "ASO", "dasdas", "+420 123 456 789", "d@gmail.com"),
        };
    }

    public ContactData GetContact(int contactId)
    {
        Console.WriteLine("getting mock contact : " + contactId);
        return new ContactData(contactId, "A", "B", "+420 123 456 789", "a@b.c");
    }
}