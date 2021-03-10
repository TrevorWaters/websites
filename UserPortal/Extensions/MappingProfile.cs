using AutoMapper;
using UserPortal.ViewModels;
using UserPortal.Data;

namespace UserPortal.Extensions
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserViewModel, UserViewModel>();
            CreateMap<UserRolesViewModel, UserRolesViewModel>();
        }
    }
}