using JwtSsoPoC.WebApi.Abstract;
using JwtSsoPoC.WebApi.Enums;

using Microsoft.AspNetCore.Identity;

namespace JwtSsoPoC.WebApi.Domain.Entities;

public class Member : IdentityUser
{
    public Person Person{ get; set; }
    public AccountStatus AccountStatus{ get; set; }
}