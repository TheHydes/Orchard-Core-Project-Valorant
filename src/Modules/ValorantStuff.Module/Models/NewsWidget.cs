using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement;
using OrchardCore.Media.Fields;

namespace ValorantStuff.Models;

public class NewsWidget : ContentPart
{
    public MediaField Image { get; set; } = new();
    public TextField Title { get; set; } = new();
    public HtmlField Text { get; set; } = new();
}
