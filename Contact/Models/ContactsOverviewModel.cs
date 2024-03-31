using Contact.Contact;
using Contact.database;

namespace Contact.Models;

public class ContactsOverviewModel
{
    public List<ContactData> contacts;
    public string? Filter { get; set; }

    public ContactsOverviewModel(string? filter)
    {
        Filter = filter;
        IDataSource database = DatabaseUtility.GetDatabaseConnection();
        contacts = string.IsNullOrEmpty(filter) ? database.GetContacts() : database.GetContacts(filter);
        database.CloseConnection();
    }
}