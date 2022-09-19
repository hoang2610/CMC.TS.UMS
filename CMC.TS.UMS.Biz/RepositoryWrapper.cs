using AutoMapper;
using CMC.TS.Distributed.Cache.Core.Services.Interfaces;
using CMC.TS.UMS.Biz.AutoMapper;
using CMC.TS.UMS.Biz.User;
using CMC.TS.UMS.Data.Access;
using EasyNetQ;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace CMC.TS.UMS.Biz
{
    public class RepositoryWrapper:IRepositoryWrapper
    {
        private readonly DomainDbContext _context;
        private readonly ILogger<RepositoryWrapper> _logger;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        //private readonly IDistributedCacheService _cacheService;
        public RepositoryWrapper(DomainDbContext context, ILogger<RepositoryWrapper> logger, IConfiguration configuration/*, IDistributedCacheService cacheService*/)
        {
            _context = context;
            _mapper = Mapper();
            _configuration = configuration;
            //_cacheService = cacheService;
            _logger = logger;
        }
        private CMC.TS.UMS.Biz.User.IRespository _user;
        public CMC.TS.UMS.Biz.User.IRespository User => _user ?? (_user = new CMC.TS.UMS.Biz.User.Respository(_context, _mapper, _logger));

        public static IMapper Mapper()
        {
            MapperConfiguration mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            return mappingConfig.CreateMapper();
        }
    }
}
