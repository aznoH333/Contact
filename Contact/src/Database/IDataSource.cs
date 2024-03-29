using Contact.Contact;
using Contact.Models;

namespace Contact.database;

public interface IDataSource
{ 
    void Connect(string connectionString);
    void CloseConnection();
    
    List<ContactData> GetContacts();
    ContactData GetContact(int contactId);
}