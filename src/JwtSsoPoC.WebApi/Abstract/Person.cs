namespace JwtSsoPoC.WebApi.Abstract;

public abstract class Person
{
    public string GivenName { get; set; }
    public string MiddleName { get; set; }
    public string SurName { get; set; }
}