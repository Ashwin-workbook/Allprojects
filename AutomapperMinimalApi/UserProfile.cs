using AutoMapper;
namespace AutomapperMinimalApi
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>();
        }
    }
}
