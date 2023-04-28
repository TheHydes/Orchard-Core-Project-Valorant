using ValorantStuff.Theme.Constants;
using Microsoft.Extensions.Options;
using OrchardCore.ResourceManagement;

namespace ValorantStuff.Theme;

public class ResourceManagementOptionsConfiguration : IConfigureOptions<ResourceManagementOptions>
{
    private const string WwwRoot = "~/" + FeatureIds.Area + "/";
    private const string Css = WwwRoot + "css/";
    private const string Js = WwwRoot + "js/";
    private const string Pages = Css + "pages/";

    private static readonly ResourceManifest _manifest = new();

    static ResourceManagementOptionsConfiguration()
    {
        _manifest.DefineResource("$" + nameof(FeatureIds.Area), FeatureIds.Area);

        _manifest
            .DefineStyle(ResourceNames.Site)
            .SetUrl(Css + "site.min.css", Css + "site.css");

        _manifest
            .DefineScript(ResourceNames.MainMenu)
            .SetUrl(Js + "main-menu.min.js", Js + "main-menu.js");

        _manifest
            .DefineStyle(ResourceNames.Agents)
            .SetUrl(Pages + "agents.min.css", Pages + "agents.css");

        _manifest
            .DefineStyle(ResourceNames.Agent)
            .SetUrl(Pages + "agentPage.min.css", Pages + "agentPage.css");

        _manifest
            .DefineStyle(ResourceNames.News)
            .SetUrl(Pages + "news.min.css", Pages + "news.css");

        _manifest
            .DefineStyle(ResourceNames.Home)
            .SetUrl(Pages + "mainPage.min.css", Pages + "mainPage.css");

        _manifest
            .DefineScript(ResourceNames.ExpandableWidget)
            .SetUrl(Js + "expandable-widget.min.js", Js + "expandable-widget.js");
    }

    public void Configure(ResourceManagementOptions options) => options.ResourceManifests.Add(_manifest);
}
