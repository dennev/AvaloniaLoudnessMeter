namespace AvaloniaLoudnessMeter.DataModels;

/// <summary>
///     Information about a channel configuration
/// </summary>
public class ChannelConfigurationItem(string group, string text, string shortText)
{
    public string Group { get; set; } = group;
    public string Text { get; set; } = text;
    public string ShortText { get; set; } = shortText;
}