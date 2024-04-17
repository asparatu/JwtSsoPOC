using JwtSsoPoC.WebApi.DataAccess.Configurations;
using JwtSsoPoC.WebApi.Domain.Entities;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JwtSsoPoC.WebApi.DataAccess.Context;

public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext<AdminUser, IdentityRole, string>(options)
{
    public DbSet<MemberUser> Members { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfiguration(new AdminUserConfiguration());
        builder.Entity<IdentityRole>().ToTable("Roles");
        builder.Entity<IdentityUserClaim<string>>().ToTable("UserRoles");
        builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
        builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
        builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
        builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");

        builder.ApplyConfiguration(new MemberUserConfiguration());
    }
}