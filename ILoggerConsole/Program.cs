using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
//Memonic follow MEDA but insead of dependency injection, its Logging
using Microsoft.Extensions.Logging.Console;

//ILogger is builting feature in .Net for logging purpose
//Logging Levels : Trace, Debug, Warning, Error, Information, Critical, None
// Trace, Debug : Debug and development purpoase
//Information : like User logged in
//None : disable logging
//Warning : recoverable errors
//Error : Current operation failure
//Critcal : System failure
//Low to high order in logging level: Trace, Debug, Information, Warning, Error, Critcal, None

var services = new ServiceCollection();

services.AddLogging(logConfig =>
{
    logConfig.ClearProviders(); //Existing logging ways will be removed.
    logConfig.AddConsole();
    logConfig.SetMinimumLevel(LogLevel.Information);
});

var provider = services.BuildServiceProvider();
var serviceObj = provider.GetRequiredService<ILogger<Program>>();
serviceObj.LogInformation("Application Starting Now");




