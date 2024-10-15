namespace SetupMvcAspNetCoreApplication;

public class Program
{
    public static void Main(string[] args)
    {

        var builder = WebApplication.CreateBuilder(args);
        
        // Add MVC Services to the container
        builder.Services.AddMvc();

        var app = builder.Build();

        app.UseRouting();

        // app.MapDefaultControllerRoute();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}"
        );

        // app.MapGet("/", () => "Hello World!");

        app.Run();
    }
}
