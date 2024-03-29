namespace Contact.Contact;

public class ContactData
{
    public int Id { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string PhoneNumber { get; private set; }
    public string Email { get; private set; }

    public ContactData(int id, string firstName, string lastName, string phoneNumber, string email)
    {
        // Temporary placeholder
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Email = email;
    }
}