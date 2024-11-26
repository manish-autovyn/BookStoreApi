using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace _02._BookStore_API.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
