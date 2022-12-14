using System;

namespace MAUI.MvvmFirst.DependencyInjection;

public static class DependencyContainer
{
    private static IServiceProvider _serviceProvider;

    /// <summary>
    /// Sets the service provider to the dependency container.
    /// </summary>
    /// <param name="serviceProvider">Service provider.</param>
    public static void SetServiceProvider(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    /// <summary>
    /// Gets the service matching the given service type.
    /// </summary>
    /// <typeparam name="TService">Service type.</typeparam>
    /// <returns>Service instance if found.</returns>
    public static TService GetService<TService>() => (TService)GetService(typeof(TService));

    /// <summary>
    /// Gets the service matching the given service type.
    /// </summary>
    /// <param name="serviceType">Service type.</param>
    /// <returns>Service instance if found.</returns>
    public static object GetService(Type serviceType) => _serviceProvider.GetService(serviceType);
}
