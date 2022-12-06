using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;

namespace MAUI.MvvmFirst.App.ViewModels;

public partial class LoginViewModel : ViewModelBase
{
    [RelayCommand]
    public async Task OnLoginAsync(object param)
    {
        await Navigation.ChangeShellStateAsync("WelcomeTutorial");
    }
}
