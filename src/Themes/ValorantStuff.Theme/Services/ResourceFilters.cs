using Lombiq.HelpfulLibraries.OrchardCore.ResourceManagement;
using static ValorantStuff.Theme.Constants.ResourceNames;
using static ValorantStuff.Theme.Constants.FeatureIds;

namespace ValorantStuff.Theme.Services;

[ResourceFilterThemeRequirement(Area)]
public class ResourceFilters : IResourceFilterProvider
{
    public void AddResourceFilter(ResourceFilterBuilder builder)
    {
        builder.Always().RegisterStylesheet(Site);
        builder.WhenPath("/agents").RegisterFootScript(ExpandableWidget);
        builder.WhenPath("/agents").RegisterStylesheet(Agents);
        builder.WhenPath("/news").RegisterStylesheet(News);
        builder.WhenPath("/").RegisterStylesheet(Home);

        builder.WhenPath("/phoenixA").RegisterStylesheet(Agent);
        builder.WhenPath("/reynaA").RegisterStylesheet(Agent);
        builder.WhenPath("/sageA").RegisterStylesheet(Agent);
        builder.WhenPath("/omenA").RegisterStylesheet(Agent);
    }
}
