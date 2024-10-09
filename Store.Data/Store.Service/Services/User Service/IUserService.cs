using Store.Service.Services.User_Service.Dtos;

namespace Store.Service.Services.User_Service;

public interface IUserService
{
    Task<UserDto> Login(LoginDto input);
    Task<UserDto> Register(RegisterDto input);
}