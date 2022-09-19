//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace hihi
//{
//    public class MsSqlDbContext
//    {
//        public class MsSqlDbContext : DomainDbContext
//        {
//            public MsSqlDbContext(IConfiguration configuration) : base(configuration)
//            {
//            }

//            protected override void OnConfiguring(DbContextOptionsBuilder options)
//            {
//                options.UseSqlServer(Configuration.GetConnectionString("MsSqlConnection"));
//            }
//        }
//    }
//}
