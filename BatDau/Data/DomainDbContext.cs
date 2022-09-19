using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BatDau.Data
{
    public class User
    {
        public string id { get; set; }
    }
    public class DomainDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        protected DomainDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public DbSet<User> Users { get; set; }

    }
}
