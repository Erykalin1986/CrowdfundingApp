using epj.ProgressBar.Maui;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Platform;

namespace CrowdfundingApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
#if ANDROID
            Microsoft.Maui.Handlers.PickerHandler.Mapper.AppendToMapping("NoUnderLine", (h, v) =>
            {
                h.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToPlatform());
            });
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUnderLine", (h, v) =>
            {
                h.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToPlatform());
            });
#endif
            MauiAppBuilder builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("MontserratBold.ttf", "MontserratBold");
                    fonts.AddFont("MontserratSemiBold.ttf", "MontserratSemiBold");
                    fonts.AddFont("MontserratExtraBold.ttf", "MontserratExtraBold");
                    fonts.AddFont("MontserratRegular.ttf", "MontserratRegular");
                }).ConfigureMauiHandlers(handlers =>
                {
#if ANDROID
                    handlers.AddHandler(typeof(Shell), typeof(Platforms.Android.CustomShell));
#endif
                }).UseProgressBar();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
