using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace AvaloniaControls.Controls.Chat;

public class ChatCard : TemplatedControl
{
    public static readonly StyledProperty<object?> UserIconProperty = 
        AvaloniaProperty.Register<ChatCard, object?>(nameof(UserIcon));

    public static readonly StyledProperty<string?> UserNameProperty =
        AvaloniaProperty.Register<ChatCard, string?>(nameof(UserName));
    
    public static readonly StyledProperty<string?> MessageProperty = 
        AvaloniaProperty.Register<ChatCard, string?>(nameof(Message));

    public static readonly StyledProperty<string?> TimeProperty =
        AvaloniaProperty.Register<ChatCard, string?>(nameof(Time));
    
    public static readonly RoutedEvent<RoutedEventArgs> UserIconClickedEvent = 
        RoutedEvent.Register<ChatCard, RoutedEventArgs>(nameof(UserIconClicked), RoutingStrategies.Bubble);
    
    public event EventHandler<RoutedEventArgs>? UserIconClicked
    {
        add => AddHandler(UserIconClickedEvent, value);
        remove => RemoveHandler(UserIconClickedEvent, value);
    }

    protected virtual void OnUserIconClicked()
    {
        RoutedEventArgs args = new RoutedEventArgs(UserIconClickedEvent);
        RaiseEvent(args);
    }

    /// <summary>
    /// The icon of the user.
    /// </summary>
    public object? UserIcon
    {
        get => GetValue(UserIconProperty);
        set => SetValue(UserIconProperty, value);
    }

    /// <summary>
    /// The name of the user.
    /// </summary>
    public string? UserName
    {
        get => GetValue(UserNameProperty);
        set => SetValue(UserNameProperty, value);
    }

    /// <summary>
    /// The message content.
    /// </summary>
    public string? Message
    {
        get => GetValue(MessageProperty);
        set => SetValue(MessageProperty, value);
    }

    /// <summary>
    /// The time of the message.
    /// </summary>
    public string? Time
    {
        get => GetValue(TimeProperty);
        set => SetValue(TimeProperty, value);
    }

    protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
    {
        base.OnPropertyChanged(change);
        if (change.Property == UserIconProperty)
        {
            if (change.OldValue is Control userIconControlOld)
            {
                userIconControlOld.RemoveHandler(PointerPressedEvent, OnPointerPressed);
            }

            if (change.NewValue is Control userIconControlNew)
            {
                userIconControlNew.AddHandler(PointerPressedEvent, OnPointerPressed);
            }
        }
    }

    private void OnPointerPressed(object? sender, PointerPressedEventArgs e)
    {
        OnUserIconClicked();
        e.Handled = true;
    }
}