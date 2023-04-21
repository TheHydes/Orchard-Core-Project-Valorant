using OrchardCore.ContentFields.Settings;

namespace ValorantStuff.Constants;

public static class MigrationSettings
{
    private const string Black = "Black";
    private const string Gray = "Gray";
    private const string White = "White";

    public static readonly TextFieldPredefinedListEditorSettings PredefinedColorListSettings = new()
    {
        Options = new[]
        {
            new ListValueOption { Name = Black, Value = Black },
            new ListValueOption { Name = Gray, Value = Gray },
            new ListValueOption { Name = White, Value = White },
        },
        Editor = EditorOption.Dropdown,
        DefaultValue = Black,
    };
}
