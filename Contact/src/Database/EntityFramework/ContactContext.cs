using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Contact.Contact;
using Microsoft.EntityFrameworkCore;
using DbContext = System.Data.Entity.DbContext;


public class ContactContext : DbContext
{
    public ContactContext() : base("Data Source=contact.db")
    {
        
    }
    
    public Microsoft.EntityFrameworkCore.DbSet<ContactData> Contacts { get; set; }
    
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        
    }
}



