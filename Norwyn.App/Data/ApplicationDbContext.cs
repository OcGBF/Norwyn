using Microsoft.EntityFrameworkCore;
using Norwyn.Shared.Models.Users;

namespace Norwyn.App.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<UserModel> Users { get; set; }
    }
}