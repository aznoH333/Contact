using Contact.Contact;
using Contact.Database.EntityFramework;

namespace Contact.database;

public class ContactDB : IDataSource
{
    private ContactContext db = new ContactContext();
    
    public void Connect(string connectionString)
    {
        
    }

    public void CloseConnection()
    {
        
    }

    public List<ContactData> GetContacts()
    {
        return db.Contacts.ToList();
    }

    public ContactData GetContact(int contactId)
    {
        Console.WriteLine(contactId);

        return db.Contacts.First(c => c.ID == contactId);
    }

    public void UpdateContact(ContactData data)
    {
        ContactData contact = GetContact(data.ID);
        contact.FirstName = data.FirstName;
        contact.LastName = data.LastName;
        contact.Email = data.Email;
        contact.PhoneNumber = data.PhoneNumber;
        db.SaveChanges();
    }

    public void CreateContact(string firstName, string lastName, string email, string phoneNumber)
    {
        ContactData data = new ContactData()
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            PhoneNumber = phoneNumber,
        };
        db.Contacts.Add(data);
        db.SaveChanges();
    }

    public void DeleteContact(int contactId)
    {
        db.Contacts.Remove(GetContact(contactId));
        db.SaveChanges();
    }

    public void DeletaAllContacts()
    {
        db.RemoveRange(db.Contacts);
        db.SaveChanges();
    }
}