var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Dependency injection is injected automatically since its minimal api
app.MapGet("/",(ILogger<Program> logger) =>
{
    logger.LogInformation("Logging Information");
    return Results.Ok();
});

app.Run();
