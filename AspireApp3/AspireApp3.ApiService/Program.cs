using AspireApp3.ApiService.Data;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire client integrations.
builder.AddServiceDefaults();

// Add API Documentation
builder.Services.AddSwaggerGen();

// Add controllers services
builder.Services.AddControllers();

// Add services to the container.
builder.Services.AddProblemDetails();

// is a method commonly used in .NET applications, especially in the context of Entity Framework Core (EF Core), to configure a PostgreSQL
// database as the underlying database provider for your application's DbContext.

builder.AddNpgsqlDbContext<DataDbContext>("UserDatabase");

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();


app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI();

app.MapDefaultEndpoints();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
