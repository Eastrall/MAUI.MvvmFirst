using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAUI.MvvmFirst.App.Services;

/// <summary>
/// Provides a mechanism to navigate across the application.
/// </summary>
public class NavigationService
{
    private readonly Dictionary<Type, Type> _viewModelPages = new();

    /// <summary>
    /// Gets the current navigation object.
    /// </summary>
    private INavigation Navigation => Shell.Current.Navigation;

    /// <summary>
    /// Registers the given ViewModel and Page pair.
    /// </summary>
    /// <typeparam name="TViewModel">View model type</typeparam>
    /// <typeparam name="TPage">Page type</typeparam>
    public void Register<TViewModel, TPage>()
        where TViewModel : class
        where TPage : Page
    {
        Type viewModelType = typeof(TViewModel);
        Type pageType = typeof(TPage);

        if (!_viewModelPages.ContainsKey(viewModelType))
        {
            _viewModelPages.Add(viewModelType, pageType);  
        }
    }

    /// <summary>
    /// Navigates to the page associated with the given ViewModel type.
    /// If a ViewModel instance is provided, it will automatically be bound to the page's BindingContext; 
    /// otherwise a new view model instance is createde.
    /// </summary>
    /// <typeparam name="TViewModel">ViewModel type.</typeparam>
    /// <param name="viewModel">ViewModel instance.</param>
    /// <returns></returns>
    public async Task PushAsync<TViewModel>(TViewModel viewModel = null)
        where TViewModel : class
    {
        Page page = BuildPage(viewModel);

        if (page is not null)
        {
            await Navigation.PushAsync(page);
        }
    }

    /// <summary>
    /// Pops the current page.
    /// </summary>
    /// <returns></returns>
    public async Task PopAsync()
    {
        Page page = await Navigation.PopAsync();

        if (page is not null)
        {
            page.BindingContext = null;
        }
    }

    /// <summary>
    /// Navigates to the page associated with the given ViewModel type and clear the page history.
    /// If a ViewModel instance is provided, it will automatically be bound to the page's BindingContext; 
    /// otherwise a new view model instance is createde.
    /// </summary>
    /// <typeparam name="TViewModel">ViewModel type.</typeparam>
    /// <param name="viewModel">ViewModel instance.</param>
    /// <returns></returns>
    public async Task GoToAsync<TViewModel>(TViewModel viewModel = null)
        where TViewModel : class
    {
        Page page = BuildPage(viewModel);

        if (page is not null)
        {
            Navigation.InsertPageBefore(page, Navigation.NavigationStack[0]);
            await Navigation.PopToRootAsync();
        }
    }

    /// <summary>
    /// Changes the application shell state.
    /// </summary>
    /// <param name="routes">Application shell route to navigate to.</param>
    /// <returns></returns>
    public async Task ChangeShellStateAsync(params string[] routes)
    {
        string route = $"//";

        if (routes.Any())
        {
            route += $"//{string.Join("//", routes)}";
        }

        await Shell.Current.GoToAsync(route);
    }

    private Page BuildPage<TViewModel>(TViewModel viewModel = null)
        where TViewModel : class
    {
        Page page = null;

        if (!_viewModelPages.TryGetValue(typeof(TViewModel), out Type pageType))
        {
            page = Activator.CreateInstance(pageType) as Page;
        }

        page.BindingContext = viewModel is not null ? viewModel : ViewModelLocator.Get<TViewModel>();

        return page;
    }
}
