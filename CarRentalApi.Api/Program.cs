using CarRentalApi.Api.Mapping;
using CarRentalApi.Data;
using CarRentalApi.Data.Repositories;
using CarRentalApi.Services.Implementations;
using CarRentalApi.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.SwaggerUI;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<VehicleRentalContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CarRentalDb")));

builder.Services.AddScoped<IVehicleService, VehicleService>();
builder.Services.AddScoped<IVehicleRepository, VehicleRepository>();

// Register AutoMapper
//builder.Services.AddAutoMapper(cfg =>
//{
//    cfg.AddProfile(new MappingProfile());
//});
builder.Services.AddAutoMapper(cfg => { },
    typeof(MappingProfile).Assembly);

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
//app.UseSwaggerUI(c => { });

// Seed data
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
