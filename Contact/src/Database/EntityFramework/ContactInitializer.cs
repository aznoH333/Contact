using Contact.Contact;

namespace Contact.database.EntityFramework;

public class ContactInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<ContactContext>
{
    protected override void Seed(ContactContext context)
    {
        // initialize some testing contacts
        var testingContacts = new List<ContactData>
        {
            new ContactData(0, "QWERT", "YUIOP", "+123 123 123", "QWER@gmail.com"),
            new ContactData(1, "ASDF", "GHJK", "+4564654566", "FDADASS@gmail.com"),
            new ContactData(2, "HDGFGHDFG", "DFGFDH", "+99999999", "asuiDUIFAG@DSADSADASV.com"),
        };
        foreach (var contact in testingContacts)
        {
            context.Contacts.Add(contact);
        }

        context.SaveChanges();
    }
}