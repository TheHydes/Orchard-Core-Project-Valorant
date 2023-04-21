using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ContentManagement;
using OrchardCore.Modules;
using ValorantStuff.Migrations;
using ValorantStuff.Models;

namespace ValorantStuff.Module
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddContentPart<HeroPart>()
                .WithMigration<HeroPartMigration>();

            services.AddContentPart<ExpandableWidget>()
                .WithMigration<ExpandableWidgetMigration>();

            services.AddContentPart<NewsWidget>()
                .WithMigration<NewsWidgetMigration>();
        }

        public override void Configure(IApplicationBuilder builder, IEndpointRouteBuilder routes, IServiceProvider serviceProvider)
        {
            //routes.MapAreaControllerRoute(
            //    name: "Home",
            //    areaName: "ValorantStuff.Module",
            //    pattern: "Home/Index",
            //    defaults: new { controller = "Home", action = "Index" }
            //);
        }
    }
}
