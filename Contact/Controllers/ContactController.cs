using Contact.Models;
using Microsoft.AspNetCore.Mvc;

namespace Contact.Controllers;

public class ContactController : Controller
{
    public IActionResult Index()
    {
        return View(new ContactsOverviewModel());
    }
}