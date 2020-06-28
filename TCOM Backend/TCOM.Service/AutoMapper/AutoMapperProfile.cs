using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TCOM.Data.Entities;
using TCOM.Service.ViewModels;

namespace TCOM.Service.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<HomeCreateViewModel, Home>().ReverseMap();
            CreateMap<Home, HomeCreateViewModel>().ReverseMap();
            CreateMap<HomeViewModel, Home>().ReverseMap();
            CreateMap<Home, HomeViewModel>().ReverseMap();
        }
    }
}
