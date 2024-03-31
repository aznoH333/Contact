using Contact.Contact;

namespace Contact.Models;

public enum ContactDetailType
{
    EDIT_CONTACT,
    ADD_CONTACT,
}


public class ContactModel
{
    public ContactData Contact { private set; get; }
    
    public ContactDetailType Type { private set; get; }

    public ContactModel(ContactData contactData, ContactDetailType type)
    {
        Contact = contactData;
        Type = type;
    }
    
}