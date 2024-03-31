using Contact.Contact;

namespace Contact.database;

public class ContactDB : IDataSource
{
    public void Connect(string connectionString)
    {
        throw new NotImplementedException();
    }

    public void CloseConnection()
    {
        throw new NotImplementedException();
    }

    public List<ContactData> GetContacts()
    {
        throw new NotImplementedException();
    }

    public ContactData GetContact(int contactId)
    {
        throw new NotImplementedException();
    }

    public void UpdateContact(ContactData data)
    {
        throw new NotImplementedException();
    }

    public void CreateContact(string firstName, string lastName, string email, string phoneNumber)
    {
        throw new NotImplementedException();
    }

    public void DeleteContact(int contactId)
    {
        throw new NotImplementedException();
    }

    public void DeletaAllContacts()
    {
        throw new NotImplementedException();
    }
}