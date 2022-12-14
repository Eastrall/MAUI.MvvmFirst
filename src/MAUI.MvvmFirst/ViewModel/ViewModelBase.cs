using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUI.MvvmFirst.Abstractions;
using MAUI.MvvmFirst.DependencyInjection;
using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace MAUI.MvvmFirst.ViewModel;

public partial class ViewModelBase : ObservableObject, INotifyPropertyChanged, INotifyPropertyChanging
{
    protected INavigationService Navigation { get; init; } = DependencyContainer.GetService<INavigationService>() ??
        throw new InvalidProgramException("Failed to get NavigationService from DependencyContainer.");

    [RelayCommand]
    protected virtual Task OnAppearingAsync() => Task.CompletedTask;

    [RelayCommand]
    protected virtual Task OnDisapearingAsync() => Task.CompletedTask;

    protected ViewModelBase()
    {
    }
}
