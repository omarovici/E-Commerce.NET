using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Store.Data.Entities.IdentityEntities;

namespace Store.Data.Context;

public class StoreIdentityDbContext : IdentityDbContext<AppUser>
{
    public StoreIdentityDbContext(DbContextOptions<StoreIdentityDbContext> options) : base(options)
    {
    }
}