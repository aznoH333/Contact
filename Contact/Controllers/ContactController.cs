using System.Text.RegularExpressions;
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

    public IActionResult EditContact(int contactId)
    {
        IDataSource database = DatabaseUtility.GetDatabaseConnection();
        ContactData data = database.GetContact(contactId);
        database.CloseConnection();

        return View("ContactEdit", new ContactModel(data, ContactDetailType.EDIT_CONTACT));
    }

    public IActionResult AddNewContact()
    {
        ContactData data = ContactData.CreateEmpty();

        return View("ContactEdit", new ContactModel(data, ContactDetailType.ADD_CONTACT));
    }
    

    // this should be RFC 5322 compliant
    private const string EmailValidationRegex =
        "(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|\"(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-z0-9-]*[a-z0-9]:(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])";
    // private const string EmailValidationRegex = ".+@.+\\..{2,4}";

    private const string PhoneNumberValidationRegex =
        "\\+(9[976]\\d|8[987530]\\d|6[987]\\d|5[90]\\d|42\\d|3[875]\\d|\n2[98654321]\\d|9[8543210]|8[6421]|6[6543210]|5[87654321]|\n4[987654310]|3[9643210]|2[70]|7|1)\\d{1,14}$";

    [HttpPost]
    public JsonResult IsContactValid(string email, string phoneNumber)
    {
        Dictionary<string, string> output = new Dictionary<string, string>();

        output["email"] = Regex.IsMatch(email, EmailValidationRegex) ? "" : "Please enter a valid email adress";

        output["phone"] = Regex.IsMatch(phoneNumber, PhoneNumberValidationRegex) ? "" : "Please enter a valid phone number";

        return new JsonResult(output);
    }
    
}