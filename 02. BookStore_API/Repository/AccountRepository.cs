using _02._BookStore_API.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace _02._BookStore_API.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<ApplicationUser> userManager;

        public AccountRepository(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<IdentityResult> SignUpAsync(SignUpModel signUpModel)
        {
            var user = new ApplicationUser()
            {
                FirstName = signUpModel.FirstName,
                LastName = signUpModel.LastName,
                Email = signUpModel.Email,
                UserName = signUpModel.Email,
            };

            return await userManager.CreateAsync(user, signUpModel.Password);
        }
    }
}
