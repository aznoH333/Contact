namespace Contact.Contact;

public class ContactData
{
    public int ID { get; private set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }

    public ContactData(int id, string firstName, string lastName, string phoneNumber, string email)
    {
        // Temporary placeholder
        ID = id;
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public ContactData()
    {
        
    }

    public string GetFullName()
    {
        return FirstName + " " + LastName;
    }

    public string GetShortName()
    {
        return FirstName[0] + ". " + LastName;
    }

    public static ContactData CreateEmpty()
    {
        return new ContactData(0, "", "", "", "");
    }
}