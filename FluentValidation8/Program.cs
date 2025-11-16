using FluentValidation;
using FluentValidation8;
using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddValidatorsFromAssemblyContaining<UserDtoValidator>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapPost("/users", async (UserDto user, IValidator<UserDto> validator) => 
{
    var validationResult = await validator.ValidateAsync(user);
    if(!validationResult.IsValid)
    {
        return Results.BadRequest(validationResult.Errors);
    }
    return Results.Ok("User is valid");
});

app.Run();
