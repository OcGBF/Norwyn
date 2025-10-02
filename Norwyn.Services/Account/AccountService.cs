using Norwyn.Shared.Models.Users;

using Norwyn.Infrastructure.Data;

namespace Norwyn.Services.Account
{
    public class AccountService : IAccountService
    {
        private readonly ApplicationDbContext _context;

        public AccountService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> RegisterUserAsync(UserModel user)
        {
            if (user == null) return false;

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}