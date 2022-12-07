using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MAUI.MvvmFirst.App.ViewModels;

public partial class LoginViewModel : ViewModelBase
{
    [RelayCommand]
    public async Task OnLoginAsync(object param)
    {
        await Navigation.ChangeShellStateAsync("WelcomeTutorial");
    }

    protected override Task OnAppearingAsync()
    {
        Debug.WriteLine("[LoginViewModel]: On Appearing");

        return base.OnAppearingAsync();
    }

    protected override Task OnDisapearingAsync()
    {
        Debug.WriteLine("[LoginViewModel]: On Disapearing");

        return base.OnDisapearingAsync();
    }
}
