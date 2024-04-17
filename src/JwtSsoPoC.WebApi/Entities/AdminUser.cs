using JwtSsoPoC.WebApi.Abstract;

using Microsoft.AspNetCore.Identity;

namespace JwtSsoPoC.WebApi.Entities;

public class AdminUser : IdentityUser
{
    public AdminUser() 
    {
        this.Person = new();
    }
    public Person Person { get; set; }
}