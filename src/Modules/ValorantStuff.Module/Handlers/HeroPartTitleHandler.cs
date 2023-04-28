using ValorantStuff.Models;
using OrchardCore.ContentManagement.Handlers;

namespace ValorantStuff.Handlers;

public class HeroPartTitleHandler : ContentPartHandler<HeroPart>
{
    public override Task UpdatedAsync(UpdateContentContext context, HeroPart instance)
    {
        if (instance.Title?.Text is { } titleText && !string.IsNullOrEmpty(titleText))
        {
            context.ContentItem.DisplayText = titleText;
        }

        return Task.CompletedTask;
    }
}
