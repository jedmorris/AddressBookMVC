using AddressBook.Data;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL.Storage.Internal.Mapping;

namespace AddressBook.Services;

public class SearchService
{
//    private readonly ApplicationDbContext _context;
//
//    public SearchService(ApplicationDbContext context)
//    {
//    }
//
//    public IEnumerable<Contract> SearchContacts(string searchString, string userId)
//    {
//       var result = _context.Contacts.Include(c => c.Categories).Where(c => c.UserId == userId).AsQueryable();
//
//       if (searchString != null)
//       {
//          result = result.Where(c => c.Address1!.ToLower().Contains(searchString.ToLower()))
//       }
//    }
}