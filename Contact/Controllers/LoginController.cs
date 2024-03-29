using Contact.Models;
using Microsoft.AspNetCore.Mvc;

namespace Contact.Controllers;

public class LoginController : Controller
{
    public IActionResult Index()
    {
        return View(new UserModel());
    }

    public IActionResult Register()
    {
        return View(new UserModel());
    }

    [HttpPost]
    public IActionResult TryLogin(string userName, string password)
    {
        Console.WriteLine("tried login with " + userName + " and " + password);
        // temporary logic
        if (userName == "argus" && password == "premium")
        {
            return RedirectToAction("Index", "Home");
        }
        else
        {
            return new JsonResult(new Dictionary<string, string>
            {
                //{""}
            });
        }
    }

    [HttpPost]
    public IActionResult Test(int number)
    {
        Console.WriteLine(number);
        return Ok();
    }
}