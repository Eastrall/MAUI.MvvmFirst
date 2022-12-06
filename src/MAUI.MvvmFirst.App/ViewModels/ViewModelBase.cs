using CommunityToolkit.Mvvm.ComponentModel;
using MAUI.MvvmFirst.App.DependencyInjection;
using MAUI.MvvmFirst.App.Services;

namespace MAUI.MvvmFirst.App.ViewModels;

public class ViewModelBase : ObservableObject, IViewModel
{
    protected NavigationService Navigation { get; init; } = DependencyContainer.GetService<NavigationService>();

    protected ViewModelBase()
    {
    }
}
