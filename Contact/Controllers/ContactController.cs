using System.Text.RegularExpressions;
using Contact.Contact;
using Contact.database;
using Contact.Models;
using Microsoft.AspNetCore.Mvc;

namespace Contact.Controllers;

public class ContactController : Controller
{
    public IActionResult Index(string? filter)
    {
        return View(new ContactsOverviewModel(filter));

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


    [HttpPost]
    public JsonResult IsContactValid(string email, string phoneNumber)
    {
        var output = new Dictionary<string, string>()
        {
            { "email", "" },
            { "phone", "" },
            { "general", "" },
        };
        
        bool hasEmail = !string.IsNullOrEmpty(email);
        bool hasPhone = !string.IsNullOrEmpty(phoneNumber);
        
        // has neither
        if (hasEmail == false && hasPhone == false)
        {
            output["general"] = "email or phone is required";

            return new JsonResult(output);
        }
        // email
        if (hasEmail)
        {
            output["email"] = ValidationUtility.IsEmailValid(email) ? "" : "Please enter a valid email adress";
        }
        // phone
        if (hasPhone)
        {
            output["phone"] = ValidationUtility.IsPhoneNumberValid(phoneNumber) ? "" : "Please enter a valid phone number";
        }

        
        
        
        

        return new JsonResult(output);
    }

    [HttpPost]
    public JsonResult UpdateContact(int id, string? firstName, string? lastName, string? email, string? phoneNumber)
    {
        
        try
        {
            var data = new ContactData(id, firstName ?? "", lastName ?? "", phoneNumber ?? "", email ?? "");
            
            IDataSource db = DatabaseUtility.GetDatabaseConnection();
            db.UpdateContact(data);
            db.CloseConnection();

            return new JsonResult("ok");
        }
        catch (Exception e)
        {
            return new JsonResult(e.Message);
        }
    }

    [HttpPost]
    public JsonResult CreateNewContact(string? firstName, string? lastName, string? email, string? phoneNumber)
    {
        try
        {
            IDataSource db = DatabaseUtility.GetDatabaseConnection();
            db.CreateContact(firstName ?? "", lastName ?? "", email ?? "", phoneNumber ?? "");
            db.CloseConnection();
            return new JsonResult("ok");
        }
        catch (Exception e)
        {
            return new JsonResult(e.Message);
        }
    }

    [HttpDelete]
    public JsonResult DeleteContact(int contactId)
    {
        try
        {
            IDataSource db = DatabaseUtility.GetDatabaseConnection();
            db.DeleteContact(contactId);
            db.CloseConnection();
            return new JsonResult("ok");
        }
        catch (Exception e)
        {
            return new JsonResult(e.Message);
        }
    }

    [HttpDelete]
    public JsonResult DeleteAllContacts()
    {
        try
        {
            IDataSource db = DatabaseUtility.GetDatabaseConnection();
            db.DeletaAllContacts();
            db.CloseConnection();
            return new JsonResult("ok");
        }
        catch (Exception e)
        {
            return new JsonResult(e.Message);
        }
    }
}