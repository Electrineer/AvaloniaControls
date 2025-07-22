using Avalonia;
using Avalonia.Controls.Primitives;

namespace AvaloniaControls.Controls.Chat;

public class ChatCard : TemplatedControl
{
    public static readonly StyledProperty<object?> UserIconProperty = AvaloniaProperty.Register<ChatCard, object?>(nameof(UserIcon));

    public static readonly StyledProperty<string?> TitleProperty =
        AvaloniaProperty.Register<ChatCard, string?>(nameof(Title));
    
    public static readonly StyledProperty<string?> MessageProperty = AvaloniaProperty.Register<ChatCard, string?>(nameof(Message));

    public static readonly StyledProperty<string?> TimeProperty =
        AvaloniaProperty.Register<ChatCard, string?>(nameof(Time));
    
    /// <summary>
    /// The icon of the user.
    /// </summary>
    public object? UserIcon
    {
        get => GetValue(UserIconProperty);
        set => SetValue(UserIconProperty, value);
    }

    public string? Message
    {
        get => GetValue(MessageProperty);
        set => SetValue(MessageProperty, value);
    }

    public string? Title
    {
        get => GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public string? Time
    {
        get => GetValue(TimeProperty);
        set => SetValue(TimeProperty, value);
    }
    
}