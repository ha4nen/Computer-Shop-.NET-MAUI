using lab12.DataTransactions;
using Microsoft.Extensions.Logging;

namespace lab12
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
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            string _dbPath =Path.Combine(FileSystem.AppDataDirectory, "User.db");
            builder.Services.AddSingleton(s=> ActivatorUtilities.CreateInstance<DBTrans>(s,_dbPath));
            return builder.Build();
        }
    }
}
