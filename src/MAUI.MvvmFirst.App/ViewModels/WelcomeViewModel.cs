using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MAUI.MvvmFirst.App.ViewModels;

public partial class WelcomeViewModel : ViewModelBase
{
    [ObservableProperty]
    private readonly IList<string> _welcomeTutorialSteps = new List<string>()
    {
        "Hello world!",
        "Welcome to this new app!",
        "Enjoy the app!"
    };

    [RelayCommand]
    private async Task GoToMainPageAsync()
    {
        await Navigation.ChangeShellStateAsync("Main", "Home");
    }
}
