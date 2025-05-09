using dotenv.net;
using LOGIN;
using LOGIN.Database;
using LOGIN.Entities;
using Microsoft.AspNetCore.Identity;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Configurar Serilog
Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .CreateLogger();

builder.Host.UseSerilog();
builder.WebHost.UseUrls("http://0.0.0.0:4000");

try
{
    Log.Information("Starting web application");
    
    var startup = new Startup(builder.Configuration);
    startup.ConfigureServices(builder.Services);

    var app = builder.Build();
    startup.Configure(app, app.Environment);

    Log.Information("Initializing database...");
    await InitializeDatabaseAsync(app);

    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1"));
    
    app.UseRouting();
    app.UseCors("CorsPolicy");
    app.UseAuthentication();
    app.UseAuthorization();

    app.MapControllers();
    app.MapGet("/health", () => Results.Ok("Healthy"));

    DotEnv.Load(options: new DotEnvOptions(probeForEnv: true));

    app.UseSerilogRequestLogging(options =>
    {
        options.MessageTemplate = "HTTP {RequestMethod} {RequestPath} responded {StatusCode} in {Elapsed:0.0000} ms";
    });

    Log.Information("Application started successfully");
    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Application terminated unexpectedly");
}
finally
{
    Log.CloseAndFlush();
}

async Task InitializeDatabaseAsync(IHost app)
{
    using var scope = app.Services.CreateScope();
    var services = scope.ServiceProvider;
    var logger = services.GetRequiredService<ILogger<Program>>();

    try
    {
        var context = services.GetRequiredService<ApplicationDbContext>();
        var userManager = services.GetRequiredService<UserManager<UserEntity>>();
        var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

        logger.LogInformation("Applying pending migrations...");
        await context.Database.MigrateAsync();

        logger.LogInformation("Seeding initial data...");
        await ApplicationDbSeeder.InitializeAsync(userManager, roleManager, context, logger);
    }
    catch (Exception ex)
    {
        logger.LogError(ex, "An error occurred while initializing the database");
        throw;
    }
}
