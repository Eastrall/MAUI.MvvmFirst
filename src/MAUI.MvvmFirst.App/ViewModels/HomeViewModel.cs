using CommunityToolkit.Mvvm.Input;
using MAUI.MvvmFirst.ViewModel;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MAUI.MvvmFirst.App.ViewModels;

public partial class HomeViewModel : ViewModelBase
{
    [RelayCommand]
    private async Task DisplayUserProfileAsync()
    {
        await Navigation.PushAsync<UserProfileViewModel>();
    }

    protected override Task OnAppearingAsync()
    {
        Debug.WriteLine("[HomeViewModel]: On Appearing");

        return base.OnAppearingAsync();
    }

    protected override Task OnDisapearingAsync()
    {
        Debug.WriteLine("[HomeViewModel]: On Disapearing");

        return base.OnDisapearingAsync();
    }
}