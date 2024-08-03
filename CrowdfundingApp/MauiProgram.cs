using Microsoft.Extensions.Logging;

namespace CrowdfundingApp
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
                    fonts.AddFont("MontserratBold.ttf", "MontserratBold");
                    fonts.AddFont("MontserratExtraBold.ttf", "MontserratExtraBold");
                    fonts.AddFont("MontserratRegular.ttf", "MontserratRegular");
                    fonts.AddFont("MontserratSemiBold.ttf", "MontserratSemiBold");
                }).ConfigureMauiHandlers(handlers =>
                {
#if ANDROID
    handlers.AddHandler(typeof(Shell), typeof(Platforms.Android.CustomShell));
#endif
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
