using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using AvaloniaControls.ViewModels;

namespace AvaloniaControls.Samples.Chat;

public partial class ChatCardsViewModel : ViewModelBase
{
    [ObservableProperty] private ObservableCollection<ChatCard> _chatCards = new()
    {
        new ChatCard("John Doe", "Hey, how are you today? 😊"),
        new ChatCard("Sarah Wilson", "Just finished the project proposal. Ready for review! 📋"),
        new ChatCard("Mike Chen", "Thanks for the help yesterday 🙏"),
        new ChatCard("Emily Rodriguez", "Are we still on for the meeting at 3pm?"),
        new ChatCard("David Thompson", "Check out this cool article I found 🔗"),
        new ChatCard("Lisa Wang", "Happy birthday! Hope you have a great day 🎉"),
        new ChatCard("Alex Johnson", "The new design looks fantastic! Great work 👍"),
        new ChatCard("Rachel Green", "Can you send me the latest version of the files?"),
        new ChatCard("Tom Anderson", "Let's grab coffee sometime this week ☕"),
        new ChatCard("Jessica Kim", "Meeting notes attached. Let me know if you have questions"),
        new ChatCard("Chris Martinez", "Running 10 minutes late, starting without me 🏃‍♂️"),
        new ChatCard("Amanda Taylor", "Great presentation today! Really well done 🎯"),
        new ChatCard("Ryan Lee", "Weekend plans? Thinking about hiking 🥾"),
        new ChatCard("Sophia Brown", "The client loved the mockups. Moving to next phase! ✨"),
        new ChatCard("James Wilson", "Quick question about the API documentation"),
        new ChatCard("Natalie Davis", "Thanks for covering for me yesterday! You're the best 💪"),
        new ChatCard("Kevin Zhang", "New restaurant opened downtown. Want to try it? 🍕"),
        new ChatCard("Olivia Miller", "Code review completed. Everything looks good 👌"),
        new ChatCard("Daniel Garcia", "Flight delayed by 2 hours 😤 Will be late to office"),
        new ChatCard("Grace Liu", "Congrats on the promotion! Well deserved 🎊")
    };
    
    [ObservableProperty]
    private ChatCard? _selectedChatCard;
}