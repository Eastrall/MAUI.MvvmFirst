using MAUI.MvvmFirst.Abstractions;
using MAUI.MvvmFirst.Navigation;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MAUI.MvvmFirst;

public sealed class MvvmFirstBuilder
{
    private readonly IServiceCollection _services;

    internal MvvmFirstBuilder(IServiceCollection services)
    {
        _services = services;
    }

    public void ConfigureNavigation(Action<NavigationOptions> options)
    {
        _services.AddSingleton<INavigationService, NavigationService>(_ =>
        {
            NavigationService navigation = new();
            NavigationOptions navigationOptions = new(navigation);

            if (options is not null)
            {
                options(navigationOptions);
            }

            return navigation;
        });
    }

    public void ConfigureViewModels(Action<ViewModelOptions> options)
    {
        ViewModelOptions viewModelOptions = new();

        options(viewModelOptions);
    }
}
