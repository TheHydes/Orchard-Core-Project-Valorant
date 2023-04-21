using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement;
using OrchardCore.Markdown.Fields;

namespace ValorantStuff.Models;

public class HeroPart : ContentPart
{
    public TextField Title { get; set; } = new();
    public TextField ColorList { get; set; } = new();
    public MarkdownField Body { get; set; } = new();
}
