using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BatDau.Data
{
    public class MsSqlDbContext : DomainDbContext
    {
        public MsSqlDbContext(IConfiguration configuration) : base(configuration)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("MsSqlConnection"));
        }
    }
}
