using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;

namespace MAUI.MvvmFirst.App.ViewModels;

public partial class HomeViewModel : ViewModelBase
{
    [RelayCommand]
    private async Task DisplayUserProfileAsync()
    {
        await Navigation.PushAsync<UserProfileViewModel>();
    }
}