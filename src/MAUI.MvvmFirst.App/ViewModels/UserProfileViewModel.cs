using CommunityToolkit.Mvvm.ComponentModel;
using MAUI.MvvmFirst.ViewModel;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MAUI.MvvmFirst.App.ViewModels;

public partial class UserProfileViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _userName = "John Doe";

    protected override Task OnAppearingAsync()
    {
        Debug.WriteLine("[UserProfileViewModel]: On Appearing");

        return base.OnAppearingAsync();
    }

    protected override Task OnDisapearingAsync()
    {
        Debug.WriteLine("[UserProfileViewModel]: On Disapearing");

        return base.OnDisapearingAsync();
    }
}
