using System.ComponentModel.DataAnnotations;

namespace _02._BookStore_API.Models
{
    public class SignInModel
    {
        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}


