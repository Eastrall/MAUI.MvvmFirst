using MAUI.MvvmFirst.DependencyInjection;
using Microsoft.Maui.Hosting;

namespace MAUI.MvvmFirst;

public static class MauiAppExtensions
{
    public static MauiApp UseDependencyContainer(this MauiApp app)
    {
        DependencyContainer.SetServiceProvider(app.Services);

        return app;
    }
}