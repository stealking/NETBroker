using AutoMapper;
using Core.Entities;
using Core.Models.Requests.Users;
using Core.Models.Response.Users;

namespace Core.Models.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserProfile, UserResponse>();
            CreateMap<UserResponse, UserProfile>();
            CreateMap<UserRegisterRequest, UserProfile>();
            CreateMap<UserUpdateRequest, UserProfile>();
        }
    }
}
