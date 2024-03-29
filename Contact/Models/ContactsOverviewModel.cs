using Contact.Contact;
using Contact.database;

namespace Contact.Models;

public class ContactsOverviewModel
{
    public List<ContactData> contacts;

    public ContactsOverviewModel()
    {
        IDataSource database = new MockDatabase();
        database.Connect("123");
        contacts = database.GetContacts();
        database.CloseConnection();
    }
}