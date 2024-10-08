using Store.Data.Entities.IdentityEntities;

namespace Store.Service.TokenService;

public interface ITokenService
{
    string GenerateToken(AppUser user);
}