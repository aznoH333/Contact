namespace Contact.Models;

public class ContactsOverviewModel
{
    public List<ContactModel> contacts;

    public ContactsOverviewModel()
    {
        // temporary placeholder
        contacts = new List<ContactModel>
        {
            new ContactModel(0, "Josef", "+420 123 456 789", "josef@gmail.com"),
            new ContactModel(1, "Lorem", "+420 123 456 789", "josef@gmail.com"),
            new ContactModel(2, "Ipsum", "+420 123 456 789", "josef@gmail.com"),
            new ContactModel(3, "Ogre", "+420 123 456 789", "josef@gmail.com"),

        };


    }
}