using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUI.MvvmFirst.App.DependencyInjection;
using MAUI.MvvmFirst.App.Services;
using System.ComponentModel;
using System.Threading.Tasks;

namespace MAUI.MvvmFirst.App.ViewModels;

public partial class ViewModelBase : ObservableObject, INotifyPropertyChanged, INotifyPropertyChanging
{
    protected NavigationService Navigation { get; init; } = DependencyContainer.GetService<NavigationService>();

    [RelayCommand]
    protected virtual Task OnAppearingAsync() => Task.CompletedTask;

    [RelayCommand]
    protected virtual Task OnDisapearingAsync() => Task.CompletedTask;

    protected ViewModelBase()
    {
    }
}
