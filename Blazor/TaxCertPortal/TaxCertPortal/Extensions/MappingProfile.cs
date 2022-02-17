using AutoMapper;
using System.Collections.Generic;
using TaxCertPortal.Models;
using TaxCertPortal.ViewModels;

namespace TaxCertPortal.Extensions
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserViewModel>();
            CreateMap<UserRole, UserRolesViewModel>();
            CreateMap<UserViewModel, User>();
            CreateMap<Role, RolesViewModel>();
        }
    }
}