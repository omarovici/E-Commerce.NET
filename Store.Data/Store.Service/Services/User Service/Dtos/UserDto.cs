namespace Store.Service.Services.User_Service.Dtos;

public class UserDto
{
    public Guid Id { get; set; }
    public string DisplayName { get; set; }
    public string Email { get; set; }
    public string Token { get; set; }
}