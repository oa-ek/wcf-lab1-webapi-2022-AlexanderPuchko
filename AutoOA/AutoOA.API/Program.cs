using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AutoOA.Core;
using AutoOA.Repository.Repositories;
using System.Reflection;
using AutoMapper;
using AutoOA.Infrastructure;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("AutoOAConnection");
builder.Services.AddDbContext<AutoOADbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<BodyTypeRepository>();
builder.Services.AddScoped<DriveTypeRepository>();
builder.Services.AddScoped<FuelTypeRepository>();
builder.Services.AddScoped<GearBoxRepository>();
builder.Services.AddScoped<RegionRepository>();
builder.Services.AddScoped<SalesDataRepository>();
//builder.Services.AddScoped<UsersRepository>();
builder.Services.AddScoped<VehicleRepository>();
builder.Services.AddScoped<VehicleBrandRepository>();
builder.Services.AddScoped<VehicleModelRepository>();



builder.Services.AddAutoMapper(typeof(AppAutoMapper).Assembly);

builder.Services.AddControllersWithViews();

builder.Services.AddSwaggerGen(s =>
{
    s.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Version = "v1",
        Title = "AutoOAAPI",
        Description = "Api for AutoOA",
        Contact = new Microsoft.OpenApi.Models.OpenApiContact
        {
            Email = "oleksandr.puchko@oa.edu.ua",
            Name = "Puchko Olexander"
        }
    });

    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";//через іксемель коментарі документується код
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);//options.IncludeXmlComments(xmlPath);
});

builder.Services.AddRouting(options => options.LowercaseUrls = true);

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

app.Run();