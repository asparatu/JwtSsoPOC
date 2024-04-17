using JwtSsoPoC.WebApi.Common.Abstract;
using JwtSsoPoC.WebApi.Common.Enums;

using Microsoft.AspNetCore.Identity;

namespace JwtSsoPoC.WebApi.Domain.Entities;

public class MemberUser : IdentityUser
{
    public Person Person{ get; set; }
    public AccountStatus AccountStatus{ get; set; }
}