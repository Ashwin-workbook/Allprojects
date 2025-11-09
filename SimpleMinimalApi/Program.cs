//Minimal Api are used light weight api with minimum code, config and dependency to handle http request and response

//Memonic Create-> Build -> Run
var builder = WebApplication.CreateBuilder();
var app = builder.Build();

//Minimal api code here
//Map is used to map url with some code. 

app.MapGet("/", ()=>"Hello world");

app.MapGet("/{name}", (string name) => $"Hello {name}");

app.Run();