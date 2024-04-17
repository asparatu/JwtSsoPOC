using JwtSsoPoC.WebApi.Interfaces;

namespace JwtSsoPoC.WebApi.Extensions;

public static class WebApplicationExtensions
{
    #region RegisterEndpointDefinitions
    internal static void RegisterEndpointDefinitions(this WebApplication app)
    {
        var endpointDefinitions = typeof(Program).Assembly
            .GetTypes()
            .Where(t => t.IsAssignableTo(typeof(IEndpointsDefinition)) && !t.IsAbstract && !t.IsInterface)
            .Select(Activator.CreateInstance)
            .Cast<IEndpointsDefinition>();

            foreach(var endpointDefinition in endpointDefinitions)
            {
                endpointDefinition.RegisterEndpoints(app); 
            }
    }
    #endregion
}