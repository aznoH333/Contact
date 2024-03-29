namespace Contact.Models;

public class ContactModel
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string PhoneNumber { get; private set; }
    public string Email { get; private set; }

    public ContactModel(int id, string name, string phoneNumber, string email)
    {
        // Temporary placeholder
        Id = id;
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
    }
}