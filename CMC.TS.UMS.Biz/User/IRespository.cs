using CMC.TS.Biz.Helper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CMC.TS.UMS.Biz.User
{
    public interface IRespository
    {
        Task<PagedResult<CMC.TS.UMS.Biz.Model.User.List>> GetAsync(int page, int pageSize);
        Task<CMC.TS.UMS.Biz.Model.User.View> CreateAsync(CMC.TS.UMS.Biz.Model.User.New user);
        Task<Model.User.View> UpdateAsync(Model.User.Edit user);
        Task DeleteAsync(uint id);
        Task<int> countCode(uint id);
    }
}
