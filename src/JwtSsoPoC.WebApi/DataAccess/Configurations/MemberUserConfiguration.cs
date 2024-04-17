using JwtSsoPoC.WebApi.Common.Enums;
using JwtSsoPoC.WebApi.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JwtSsoPoC.WebApi.DataAccess.Configurations;

public class MemberUserConfiguration : IEntityTypeConfiguration<MemberUser>
{
    public void Configure(EntityTypeBuilder<MemberUser> builder)
    {
        builder.ToTable("Members");

        builder.Property(p => p.Person).IsRequired();
        builder.Property(p => p.AccountStatus).HasConversion(c => c.Value, c => AccountStatus.FromValue(c)).HasDefaultValue(AccountStatus.Unknown).IsRequired();
    }
}