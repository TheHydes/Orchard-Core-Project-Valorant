using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement.Metadata;
using OrchardCore.ContentManagement.Metadata.Settings;
using OrchardCore.Data.Migration;
using OrchardCore.Media.Fields;
using static ValorantStuff.Constants.ContentTypes;

namespace ValorantStuff.Migrations;

public class NewsWidgetMigration : DataMigration
{
    private readonly IContentDefinitionManager _contentDefinitionManager;

    public NewsWidgetMigration(IContentDefinitionManager contentDefinitionManager) =>
        _contentDefinitionManager = contentDefinitionManager;

    public int Create()
    {
        _contentDefinitionManager.AlterPartDefinition(NewsWidget, part => part
            .WithField("Image", field => field
                .OfType(nameof(MediaField))
                .WithDisplayName("Image")
                .WithPosition("0"))
            .WithField("Title", field => field
                .OfType(nameof(TextField))
                .WithDisplayName("Title")
                .WithPosition("1"))
            .WithField("Text", field => field
                .OfType(nameof(HtmlField))
                .WithDisplayName("Text")
                .WithPosition("2")
                .WithEditor("Trumbowyg"))
        );

        _contentDefinitionManager.AlterTypeDefinition(NewsWidget, type => type
            .DisplayedAs("News Widget")
            .Securable()
            .Stereotype("Widget")
            .WithPart(NewsWidget, part => part
                .WithPosition("0"))
        );

        return 1;
    }
}
