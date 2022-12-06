using MAUI.MvvmFirst.App.ViewModels;
using Microsoft.Maui.Controls;

namespace MAUI.MvvmFirst.App;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell
        {
            BindingContext = new AppShellViewModel()
        };
    }
}
