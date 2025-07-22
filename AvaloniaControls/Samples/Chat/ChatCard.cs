using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaControls.Samples.Chat;

public partial class ChatCard : ObservableObject
{
    [ObservableProperty] private string _userName;
    [ObservableProperty] private string _message;
    [ObservableProperty] private DateTime _dateTime;

    public ChatCard(string username, string message)
    {
        _userName = username;
        _message = message;
        _dateTime = DateTime.Now;
    }
}