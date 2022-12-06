using CommunityToolkit.Mvvm.ComponentModel;

namespace MAUI.MvvmFirst.App.ViewModels;

public partial class UserProfileViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _userName = "John Doe";
}
