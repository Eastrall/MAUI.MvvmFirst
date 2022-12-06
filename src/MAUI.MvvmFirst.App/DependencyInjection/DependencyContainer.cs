using System;

namespace MAUI.MvvmFirst.App.DependencyInjection;

public static class DependencyContainer
{
    private static IServiceProvider _serviceProvider;

    public static void SetServiceProvider(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public static TService GetService<TService>() => (TService)GetService(typeof(TService));

    public static object GetService(Type serviceType) => _serviceProvider.GetService(serviceType);
}
