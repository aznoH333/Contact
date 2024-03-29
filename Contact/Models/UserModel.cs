namespace Contact.Models;

public class UserModel
{
    public string UserName { get; set; }
    public string Password { get; set; }

    public UserModel()
    {
        UserName = "";
        Password = "";
    }
}