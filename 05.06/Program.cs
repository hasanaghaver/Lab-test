using _05._06.Data;
using Microsoft.EntityFrameworkCore;

namespace _05._06
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<AppDbContext>(opt=>opt.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

            var app = builder.Build();

            app.MapControllerRoute(
                "default",
                "{controller=home}/{action=index}"
                );

            app.Run();
        }
    }
}
