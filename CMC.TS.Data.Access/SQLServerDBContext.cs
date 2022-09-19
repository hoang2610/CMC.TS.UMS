using CMC.TS.UMS.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CMC.TS.UMS.Data.Access
{
    public class SQLServerDBContext : DomainDbContext
    {
        public SQLServerDBContext(IConfiguration configuration) : base(configuration)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration["ConnectionStrings:sqlserver"]);
        }
        
    }
}
