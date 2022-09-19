using AutoMapper;
using CMC.TS.UMS.Data.Access;
using CMC.TS.UMS.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using CMC.TS.Biz.Helper;

namespace CMC.TS.UMS.Biz.User
{
    public class Respository : IRespository
    {
        private readonly DomainDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<RepositoryWrapper> _logger;
        public Respository(DomainDbContext context, IMapper mapper,ILogger<RepositoryWrapper> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<PagedResult<CMC.TS.UMS.Biz.Model.User.List>> GetAsync(int page, int pageSize)
        {
            _logger.LogInformation("Logger inside library");
            return await _context.Users.GetPagedAsync<Data.Model.USERS,Biz.Model.User.List>(_mapper,page, pageSize);
            
        }
        public async Task<CMC.TS.UMS.Biz.Model.User.View> CreateAsync(CMC.TS.UMS.Biz.Model.User.New user)
        {
            CMC.TS.UMS.Data.Model.USERS item = _mapper.Map<CMC.TS.UMS.Biz.Model.User.New, CMC.TS.UMS.Data.Model.USERS>(user);
            await _context.Users.AddAsync(item);
            await _context.SaveChangesAsync();
            return _mapper.Map<CMC.TS.UMS.Data.Model.USERS, CMC.TS.UMS.Biz.Model.User.View>(item);
        }
        public async Task<Model.User.View> UpdateAsync(Model.User.Edit user)
        {
            Data.Model.USERS user1 = _mapper.Map<Model.User.Edit, Data.Model.USERS>(user);
            _context.Users.Update(user1);
            await _context.SaveChangesAsync();
            return _mapper.Map<Data.Model.USERS, Model.User.View>(user1);
        }
        public async Task DeleteAsync(uint id)
        {
            Data.Model.USERS item = new Data.Model.USERS() { ID = id };
            _context.Remove(item);
            await _context.SaveChangesAsync();
        }

        public Task<int> countCode(uint id)
        {
            return _context.Users.CountAsync(u => u.ID == id);
        }
    }
}
