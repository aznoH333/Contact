using Contact.Contact;
using Contact.database;
using Contact.Models;
using Microsoft.AspNetCore.Mvc;

namespace Contact.Controllers;

public class ContactController : Controller
{
    public IActionResult Index()
    {
        return View(new ContactsOverviewModel());
    }

    public IActionResult ContactEdit(int contactId)
    {
        IDataSource database = DatabaseUtility.GetDatabaseConnection();
        ContactData contact = database.GetContact(contactId);
        database.CloseConnection();

        return View(new ContactModel(contact, ContactDetailType.EDIT_CONTACT));
    }
}