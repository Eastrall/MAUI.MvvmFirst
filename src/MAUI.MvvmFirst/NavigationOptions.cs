using MAUI.MvvmFirst.Abstractions;
using Microsoft.Maui.Controls;

namespace MAUI.MvvmFirst;

public sealed class NavigationOptions
{
    private readonly INavigationService _navigationService;

    internal NavigationOptions(INavigationService navigationService)
    {
        _navigationService = navigationService;
    }

    public void Register<TViewModel, TPage>()
        where TViewModel : class
        where TPage : Page
    {
        _navigationService.Register<TViewModel, TPage>();
    }
}
