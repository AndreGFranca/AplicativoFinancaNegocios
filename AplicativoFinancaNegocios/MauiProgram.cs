using Microsoft.Extensions.Logging;
using AplicativoFinancaNegocios.DataBase;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using AplicativoFinancaNegocios.Config;

namespace AplicativoFinancaNegocios;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        //Cria o banco de dados ou atualiza caso tenha mudanças nele
        //var db = new ApplicationDBContext();
        //db.Database.Migrate();
        const string DatabaseName = "financasNegocios.db";
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });
        builder.Services.AddMauiBlazorWebView();
        //Config AutoMapper
        builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


            builder.Services.AddMudServices();
        builder.Services.AddDbContext<ApplicationDBContext>(Options =>
        {
            String databasePath;
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library", DatabaseName);
                    break;
                case Device.Android:
                    databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), DatabaseName);
                    break;
                default:
                    //databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Database", DatabaseName);
                    databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.ToString(), DatabaseName);
                    if (!File.Exists(databasePath))
                        File.Create(databasePath).Dispose();
                    break;
            }
            Options.UseSqlite($"Filename={databasePath}");


        });

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif

        //builder.Services.AddSingleton<WeatherForecastService>();

        #region Applicações Criadas
            builder.Services.AddAplicationRegistration();
        #endregion

        #region Serviços Criados
            builder.Services.AddAplicationServicesRegistration();
        #endregion

        #region Repositorios Criados
            builder.Services.AddRepositoriesServicesRegistration();
        #endregion
        var app = builder.Build();
        try
        {
            var dbContext = app.Services.GetService<ApplicationDBContext>();
            dbContext.Database.Migrate();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }


        return app;
    }
}
