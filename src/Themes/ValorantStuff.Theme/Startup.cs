using Lombiq.BaseTheme.Services;
using Lombiq.HelpfulLibraries.OrchardCore.ResourceManagement;
using ValorantStuff.Theme.Constants;
using ValorantStuff.Theme.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using OrchardCore.Modules;
using OrchardCore.ResourceManagement;
using System;
using System.Threading.Tasks;

namespace ValorantStuff.Theme;

public class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<ICssClassHolder, CssClassHolder>();
        services.AddTransient<IConfigureOptions<ResourceManagementOptions>, ResourceManagementOptionsConfiguration>();
        services.AddScoped<IResourceFilterProvider, ResourceFilters>();
    }

    public override void Configure(IApplicationBuilder app, IEndpointRouteBuilder routes, IServiceProvider serviceProvider)
    {
        app.UseResourceFilters();

        app.Map("/favicon.ico", appBuilder => appBuilder.Run(context =>
        {
            context.Response.Redirect($"/{FeatureIds.ValorantStuff}/icons/favicon.ico", permanent: true);
            return Task.CompletedTask;
        }));
    }
}
