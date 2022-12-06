using CommunityToolkit.Maui;
using MAUI.MvvmFirst.App.DependencyInjection;
using MAUI.MvvmFirst.App.Pages;
using MAUI.MvvmFirst.App.Services;
using MAUI.MvvmFirst.App.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;

namespace MAUI.MvvmFirst.App;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddSingleton<NavigationService>(_ =>
        {
            var service =  new NavigationService();

            service.Register<LoginViewModel, LoginPage>();
            service.Register<WelcomeViewModel, WelcomePage>();
            service.Register<HomeViewModel, HomePage>();
            service.Register<UserProfileViewModel, UserProfilePage>();

            return service;
        });

        MauiApp app = builder.Build();

        DependencyContainer.SetServiceProvider(app.Services);

        return app;
    }
}
