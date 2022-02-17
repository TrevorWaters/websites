using AutoMapper;
using UserPortal.ViewModels;
using UserPortal.Models;
using System.Collections.Generic;

namespace UserPortal.Extensions
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