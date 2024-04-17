 namespace JwtSsoPoC.WebApi.Abstract;

public class Person
{
    public string GivenName { get; set; }
    public string MiddleName { get; set; }
    public string SurName { get; set; }

    public string GetFullName()
    {
        return MiddleName.Length > 0 ? $"{GivenName} {MiddleName} {SurName}" : $"{GivenName} {SurName}";
    }
}