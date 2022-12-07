using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MAUI.MvvmFirst.App.ViewModels;

public partial class WelcomeViewModel : ViewModelBase
{
    [ObservableProperty]
    private IList<string> _welcomeTutorialSteps = new List<string>()
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

    protected override Task OnAppearingAsync()
    {
        Debug.WriteLine("[WelcomeViewModel]: On Appearing");

        return base.OnAppearingAsync();
    }

    protected override Task OnDisapearingAsync()
    {
        Debug.WriteLine("[WelcomeViewModel]: On Disapearing");

        return base.OnDisapearingAsync();
    }
}
