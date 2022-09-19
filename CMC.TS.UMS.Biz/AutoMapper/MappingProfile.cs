using System;
using System.Collections.Generic;
using System.Text;
using CMC.TS.UMS.Data;
using AutoMapper;

namespace CMC.TS.UMS.Biz.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Data.Model.USERS, Model.User.Edit>().ReverseMap();
            CreateMap<Data.Model.USERS, Model.User.View>().ReverseMap();
            CreateMap<Data.Model.USERS, Model.User.New>().ReverseMap();
            CreateMap<Data.Model.USERS, Model.User.List>().ReverseMap();

        }
    }
}
