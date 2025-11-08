using DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
//mem : MEDA->MEDI->M.E.DI->Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
//create bag or container for collection

//services.AddTransient<IGreetingService, GreetingService>();//per injection
//services.AddScoped<IGreetingService, GreetingService>();//per request
services.AddSingleton<IGreetingService, GreetingService>();//per applicaiton lifetime
//Register dependency

var serviceProvider = services.BuildServiceProvider();
//Build provider for service

var greetObj = serviceProvider.GetRequiredService<IGreetingService>();
//provider provide me a service

greetObj.Greet("Ashwin");

Console.ReadKey();

//Realworld example
//in e commerce portal, there will be option for multiple payment methods.
//It will be difficult if one payment method is hard coded.

//Purpose of Dependency injection is decoupling

//If there are 2 classes with same name then add namespace before to that.