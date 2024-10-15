using SingletonVsScopedVsTransientServicesInAspNetCore.Models;
namespace SingletonVsScopedVsTransientServicesInAspNetCore;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddMvc();

        //         builder.Services.AddSingleton<IStudentRepository, StudentRepository>();
        // builder.Services.AddSingleton<SomeOtherService>();

        // builder.Services.AddScoped<IStudentRepository, StudentRepository>();
        // builder.Services.AddScoped<SomeOtherService>();

        builder.Services.AddTransient<IStudentRepository, StudentRepository>();
        builder.Services.AddTransient<SomeOtherService>();

        var app = builder.Build();

        app.UseRouting();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}"
        );

        // app.MapGet("/", () => "Hello World!");

        app.Run();
    }
}
