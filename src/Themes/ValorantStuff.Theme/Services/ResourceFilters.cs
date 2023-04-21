using Lombiq.HelpfulLibraries.OrchardCore.ResourceManagement;
using static ValorantStuff.Theme.Constants.ResourceNames;
using static ValorantStuff.Theme.Constants.FeatureIds;

namespace ValorantStuff.Theme.Services;

[ResourceFilterThemeRequirement(Area)]
public class ResourceFilters : IResourceFilterProvider
{
    public void AddResourceFilter(ResourceFilterBuilder builder)
    {
        builder.WhenPath("/agents").RegisterFootScript(ExpandableWidget);
    }
}
