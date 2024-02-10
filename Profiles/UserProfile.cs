using AutoMapper;
using BookServiceWEBAPI.DTO;
using BookServiceWEBAPI.Entities;
namespace BookServiceWEBAPI.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
        }
    }
}
