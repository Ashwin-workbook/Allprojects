using AutoMapper;
using AutomapperMinimalApi;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGet("/user", (IMapper mapper) =>
{
    var user = new User { Id = 1, Name = "Ashwin", Email = "ashwin@ex.com" };
    var userDto = mapper.Map<UserDto>(user);
    return userDto;
});

app.Run();
