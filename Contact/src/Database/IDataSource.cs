using Contact.Contact;
using Contact.Models;

namespace Contact.database;

public interface IDataSource
{ 
    void Connect(string connectionString);
    void CloseConnection();
    
    List<ContactData> GetContacts();
    ContactData GetContact(int contactId);

    void UpdateContact(ContactData data);

    void CreateContact(string firstName, string lastName, string email, string phoneNumber);

    void DeleteContact(int contactId);

    void DeletaAllContacts();
}