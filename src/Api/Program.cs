using ManufactureFreight.BusinessLogic.Extensions;
using ManufactureFreight.DataAccess.Extensions;
using ManufactureFreight.Models.Extensions;
using Microsoft.OpenApi.Models;
using Serilog;
using Serilog.Events;
using System.Diagnostics.CodeAnalysis;
using Utilities.Extensions;

[ExcludeFromCodeCoverage]
public static class Program
{
    public static void Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
            .WriteTo.Console()
            .CreateBootstrapLogger();

        try
        {
            WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);

            Log.Information("Hosting Environment: {Environment}", builder.Environment.EnvironmentName);

            builder.Services.AddVersionedApiExplorer(o =>
            {
                o.GroupNameFormat = "'v'VVV";
                o.SubstituteApiVersionInUrl = true;
            });

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();

            builder.Logging.AddSerilog();

            builder.Services.AddApiVersioning();

            builder.Services.AddBusinessLogicDependencies(builder.Configuration, builder.Environment);

            builder.Services.AddDataAccessDependencies(builder.Configuration, builder.Environment);

            builder.Services.AddModelValidators();

            builder.Services.AddUtilitiesDependencies();

            builder.Services.AddHealthChecks();

            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Manufacture API",
                    Description = "Manufacture Freight API"
                });
            });

            builder.Services.AddSwaggerGen();

            //services cors
            builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
            {
                builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
            }));

            WebApplication? app = builder.Build();

            app.UseHttpsRedirection();

            if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api v1"));

            app.MapHealthChecks(builder.Configuration["HealthCheckUrl"]).AllowAnonymous();

            app.MapControllers();
            app.UseCors("corsapp");

            builder.Configuration.AddXmlFile("web.config", optional: true, reloadOnChange: true);

            app.Run();
        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "Error in Startup");
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }
}