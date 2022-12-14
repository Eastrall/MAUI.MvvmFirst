using Microsoft.Maui.Hosting;
using System;

namespace MAUI.MvvmFirst;

public static class MauiAppBuilderExtensions
{
    public static MauiAppBuilder UseMvvmFirst(this MauiAppBuilder appBuilder, Action<MvvmFirstBuilder> options)
    {
        MvvmFirstBuilder builder = new(appBuilder.Services);

        if (options is not null)
        {
            options(builder);
        }
        else
        {
            builder.ConfigureNavigation(null);
        }

        return appBuilder;
    }
}
