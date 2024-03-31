using Contact.Contact;


namespace Contact.database;

public interface IDataSource
{ 
    
    void Connect(string connectionString);
    void CloseConnection();
    
    List<ContactData> GetContacts();

    List<ContactData> GetContacts(string filter);
    
    ContactData GetContact(int contactId);

    void UpdateContact(ContactData data);

    void CreateContact(string firstName, string lastName, string email, string phoneNumber);

    void DeleteContact(int contactId);

    void DeletaAllContacts();
}