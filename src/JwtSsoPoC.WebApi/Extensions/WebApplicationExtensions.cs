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

    #region UseSwaggerUI
    internal static void UseSwaggerUI(this WebApplication app)
    {
        // Configures the Http request Pipeline
        if(app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI( opts =>
            {
                var descriptions = app.DescribeApiVersions();

                //build a swagger endpoint for each discovered AP version
                foreach(var description in descriptions)
                {
                    var url = $"/swagger/{description.GroupName}/swagger.json";
                    var name = description.GroupName.ToUpper();
                    
                    opts.SwaggerEndpoint(url,name);
                }

                 opts.RoutePrefix = string.Empty;
            });
        }
    }
    #endregion
}