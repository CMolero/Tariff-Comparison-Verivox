using Tariff_Comparison_Verivox.Models;
using Tariff_Comparison_Verivox.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton(new List<Product>
    {
        new Product { Name = "Product A", Type = 1, BaseCost = 5, AdditionalKwhCost = 0.22 },
        new Product { Name = "Product B", Type = 2, IncludedKwh = 4000, BaseCost = 800, AdditionalKwhCost = 0.30 },
        // Add more products here if needed, implemented this way only for simplicity purposes
    });
builder.Services.AddScoped<TariffComparisonService>();

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

app.UseAuthorization();

app.MapControllers();

app.Run();
