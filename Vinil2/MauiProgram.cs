﻿using Microsoft.Extensions.Logging;
using Plugin.Fingerprint.Abstractions;
using Vinil2.Servicios;

namespace Vinil2
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("fa-solid-900.ttf", "AwesomeSolid");
                });

            builder.Services.AddSingleton<IRickAndMortyService, RickAndMortyService>();
            builder.Services.AddTransient<MainPage>();

#if DEBUG
            builder.Logging.AddDebug();
            builder.Services.AddSingleton(typeof(IFingerprint), CrossFingerprint.Current);
#endif

            return builder.Build();
        }
    }
}
