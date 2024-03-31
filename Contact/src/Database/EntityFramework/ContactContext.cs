using Contact.Contact;
using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;


namespace Contact.Database.EntityFramework;

public class ContactContext : DbContext
{

    public Microsoft.EntityFrameworkCore.DbSet<ContactData> Contacts { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseSqlite("Data Source=contact.db");
    }
    
}