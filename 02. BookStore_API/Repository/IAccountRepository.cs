using _02._BookStore_API.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace _02._BookStore_API.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SignUpAsync(SignUpModel signUpModel);
    }
}
