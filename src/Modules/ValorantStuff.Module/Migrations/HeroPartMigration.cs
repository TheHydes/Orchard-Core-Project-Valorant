using ValorantStuff.Models;
using OrchardCore.ContentManagement.Metadata;
using OrchardCore.ContentManagement.Metadata.Settings;
using OrchardCore.Data.Migration;
using OrchardCore.Title.Models;
using static ValorantStuff.Constants.MigrationSettings;
using static Lombiq.HelpfulExtensions.Extensions.ContentTypes.ContentTypes;

namespace ValorantStuff.Migrations;

public class HeroPartMigration : DataMigration
{
    private readonly IContentDefinitionManager _contentDefinitionManager;

    public HeroPartMigration(IContentDefinitionManager contentDefinitionManager) =>
        _contentDefinitionManager = contentDefinitionManager;

    public int Create()
    {
        _contentDefinitionManager.AlterPartDefinition<HeroPart>(part => part
            .WithField(part => part.Title, field => field
                .WithDisplayName("Title")
                .WithPosition("0"))
            .WithField(part => part.ColorList, field => field
                .WithDisplayName("Background Color List")
                .WithPosition("1")
                .WithEditor("PredefinedList")
                .WithSettings(PredefinedColorListSettings))
            .WithField(part => part.Body, field => field
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
