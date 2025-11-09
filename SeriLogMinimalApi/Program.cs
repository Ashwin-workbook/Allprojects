//Install packages SeriLog.AspNetcore
//SeriLog.Sinks.Console
//SeriLog.Sinks.File

using Serilog;

var builder = WebApplication.CreateBuilder(args);

//Log.Logger = new LoggerConfiguration().MinimumLevel.Debug().WriteTo.Console().WriteTo.File("").Enrich.FromLogContext().CreateLogger();

builder.Host.UseSerilog();

var app = builder.Build();

app.MapGet("/", (ILogger<Program> logger) => {

    logger.LogInformation("Logging");
    return Results.Ok();
});

app.Run();
