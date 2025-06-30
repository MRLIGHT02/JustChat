
using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;


namespace SocialApp
{
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
                    //fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    //fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("UbuntuMono-Regular.ttf", "UbuntuMonoRegular");
                    fonts.AddFont("UbuntuMono-Bold.ttf", "UbuntuMonoBold");
                });



#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
