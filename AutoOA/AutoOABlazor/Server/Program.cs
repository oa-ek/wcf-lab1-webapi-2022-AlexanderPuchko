global using AutoOA.Core;
global using AutoOA.Repository.Repositories;
using AutoOA.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var connectionString = builder.Configuration.GetConnectionString("AutoOAConnection");
builder.Services.AddDbContext<AutoOADbContext>(options =>
	options.UseSqlServer(connectionString));

builder.Services.AddControllers().AddJsonOptions(x =>
				x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddScoped<VehicleRepository>();
builder.Services.AddTransient<VehicleBrandRepository>();
builder.Services.AddTransient<VehicleModelRepository>();
builder.Services.AddTransient<BodyTypeRepository>();
builder.Services.AddTransient<DriveTypeRepository>();
builder.Services.AddTransient<FuelTypeRepository>();
builder.Services.AddTransient<GearBoxRepository>();
builder.Services.AddTransient<RegionRepository>();
builder.Services.AddTransient<SalesDataRepository>();



builder.Services.AddAutoMapper(typeof(AppAutoMapper).Assembly);

builder.Services.AddSwaggerGen(options =>
{
	options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
	{

		Version = "v1",
		Title = "Adding an API to our Schedule project",
		Description = "Education project with KN3, Ostroh Academy",
		Contact = new Microsoft.OpenApi.Models.OpenApiContact
		{
			Email = "pavlo.koshubinskyi@oa.edu.ua",
			Name = "Pavlo Koshubinskyi"
		}

	});

	var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";//через іксемель коментарі документується код
	var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
	//options.IncludeXmlComments(xmlPath);
});

builder.Services.AddRouting(options => options.LowercaseUrls = true);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
