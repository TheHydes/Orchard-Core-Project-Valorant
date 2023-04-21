using ValorantStuff.Models;
using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement.Metadata;
using OrchardCore.ContentManagement.Metadata.Settings;
using OrchardCore.Data.Migration;
using OrchardCore.Markdown.Fields;
using OrchardCore.Title.Models;
using static ValorantStuff.Constants.ContentTypes;
using static ValorantStuff.Constants.MigrationSettings;

namespace ValorantStuff.Migrations;

public class HeroPartMigration : DataMigration
{
    private readonly IContentDefinitionManager _contentDefinitionManager;

    public HeroPartMigration(IContentDefinitionManager contentDefinitionManager) =>
        _contentDefinitionManager = contentDefinitionManager;

    public int Create()
    {
        _contentDefinitionManager.AlterPartDefinition("HeroPart", part => part
            .WithField("Title", field => field
                .OfType(nameof(TextField))
                .WithDisplayName("Title")
                .WithPosition("0"))
            .WithField("ColorList", field => field
                .OfType(nameof(TextField))
                .WithDisplayName("Background Color List")
                .WithPosition("1")
                .WithEditor("PredefinedList")
                .WithSettings(PredefinedColorListSettings))
            .WithField("Body", field => field
                .OfType(nameof(MarkdownField))
                .WithDisplayName("Body")
                .WithPosition("2")
                .WithEditor("Wysiwyg"))
        );

        _contentDefinitionManager.AlterTypeDefinition(Page, type => type
            .RemovePart(nameof(TitlePart))
            .WithPart(nameof(HeroPart))
        );

        return 1;
    }
}
