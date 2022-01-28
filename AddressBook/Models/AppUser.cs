using Microsoft.AspNetCore.Identity;

namespace AddressBook.Models;

public class AppUser : IdentityUser
{
   public string FirstName { get; set; }
   public string LastName { get; set; }
   
   public string FullName { get; set; }
}