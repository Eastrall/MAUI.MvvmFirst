namespace MAUI.MvvmFirst.App.ViewModels;

public partial class AppShellViewModel : ViewModelBase
{
    public LoginViewModel LoginViewModel { get; } = new();

    public WelcomeViewModel WelcomeViewModel { get; } = new();

    public HomeViewModel HomeViewModel { get; } = new();

    public UserProfileViewModel UserProfileViewModel { get; } = new();
}