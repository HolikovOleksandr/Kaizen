using Kaizen.Core;
using Microsoft.EntityFrameworkCore;

namespace Kaizen.MainWeb;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();

        var connectionString = builder.Configuration.GetConnectionString("Default");
        builder.Services.AddDbContext<KaizenDbContext>(opt => opt.UseSqlServer(connectionString));

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        Database.Migrate(app);

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}