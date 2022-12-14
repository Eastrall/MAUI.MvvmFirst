using CommunityToolkit.Maui;
using MAUI.MvvmFirst.App.Pages;
using MAUI.MvvmFirst.App.ViewModels;
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
            .UseMvvmFirst(options =>
            {
                options.ConfigureNavigation(builder =>
                {
                    builder.Register<LoginViewModel, LoginPage>();
                    builder.Register<WelcomeViewModel, WelcomePage>();
                    builder.Register<HomeViewModel, HomePage>();
                    builder.Register<UserProfileViewModel, UserProfilePage>();
                });
                options.ConfigureViewModels(builder =>
                {
                    builder.Configure<LoginViewModel>(isCached: true);
                    builder.Configure<WelcomeViewModel>(isCached: true);
                });
            })
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        MauiApp app = builder.Build();

        app.UseDependencyContainer();

        return app;
    }
}
