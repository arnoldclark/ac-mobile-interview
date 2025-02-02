using AcGarageAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace AcGarageAPI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddCors();

        builder.Services.AddDbContext<GarageDbContext>(opts =>
            opts.UseSqlServer(builder.Configuration.GetConnectionString(nameof(GarageDbContext))));

        builder.Services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(typeof(Program).Assembly);
        });

        var app = builder.Build();

        app.UseCors(b => b.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}