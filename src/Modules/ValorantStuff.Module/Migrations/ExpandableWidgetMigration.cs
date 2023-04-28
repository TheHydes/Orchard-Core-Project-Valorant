using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement.Metadata;
using OrchardCore.ContentManagement.Metadata.Settings;
using OrchardCore.Data.Migration;
using OrchardCore.Media.Fields;
using static ValorantStuff.Constants.ContentTypes;
using static ValorantStuff.Constants.MigrationSettings;

namespace ValorantStuff.Migrations;

public class ExpandableWidgetMigration : DataMigration
{
    private readonly IContentDefinitionManager _contentDefinitionManager;

    public ExpandableWidgetMigration(IContentDefinitionManager contentDefinitionManager) =>
        _contentDefinitionManager = contentDefinitionManager;

    public int Create()
    {
        _contentDefinitionManager.AlterPartDefinition(ExpandableWidget, part => part
            .WithField("Title", field => field
                .OfType(nameof(TextField))
                .WithDisplayName("Title")
                .WithPosition("0"))
            .WithField("Color", field => field
                .OfType(nameof(TextField))
                .WithDisplayName("Color of accordion")
                .WithPosition("1")
                .WithEditor("PredefinedList")
                .WithSettings(PredefinedColorListSettings))
            .WithField("Text", field => field
                .OfType(nameof(HtmlField))
                .WithDisplayName("Text")
                .WithPosition("2")
                .WithEditor("Trumbowyg"))
            .WithField("AgentImage", field => field
                .OfType(nameof(MediaField))
                .WithDisplayName("Agent Image")
                .WithPosition("3"))
        );

        _contentDefinitionManager.AlterTypeDefinition(ExpandableWidget, type => type
            .DisplayedAs("Expandable Widget")
            .Securable()
            .Stereotype("Widget")
            .WithPart(ExpandableWidget, part => part
                .WithPosition("0"))
        );

        return 1;
    }
}
