using System;
using System.Collections.Generic;
using System.Text;

namespace CMC.TS.UMS.Biz
{
    public interface IRepositoryWrapper
    {
        User.IRespository User { get; }
        
    }
}
