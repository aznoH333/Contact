using Contact.Contact;
using Contact.database;

namespace Contact.Models;

public class ContactsOverviewModel
{
    public List<ContactData> contacts;

    public ContactsOverviewModel()
    {
        IDataSource database = DatabaseUtility.GetDatabaseConnection();
        contacts = database.GetContacts();
        database.CloseConnection();
    }
}