using AvaloniaControls.Samples.Chat;
using AvaloniaControls.ViewModels;

namespace AvaloniaControls.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public ChatCardsViewModel ChatCardsViewModel { get; } = new();
}