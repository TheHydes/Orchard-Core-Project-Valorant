using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement;
using OrchardCore.Media.Fields;

namespace ValorantStuff.Models;

public class ExpandableWidget : ContentPart
{
    public TextField Title { get; set; } = new();
    public HtmlField Text { get; set; } = new();
    public TextField Color { get; set; } = new();
    public MediaField AgentImage { get; set; } = new();
}
