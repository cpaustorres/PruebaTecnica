using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pruebalocal.Data;
using Pruebalocal.Pages;
using System.Net.Http;
using System;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios a la capa de acceso a datos
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IVehicleRepository, VehicleRepository>();

// Add services to the container.
builder.Services.AddRazorPages();

// Leer la configuración de la URL base de la API
var apiBaseUrl = builder.Configuration["ApiBaseUrl"];

// Configura el cliente de HttpClient con la URL base de la API
builder.Services.AddHttpClient("InsecureClient", httpClient =>
{
    httpClient.BaseAddress = new Uri(apiBaseUrl);
    httpClient.DefaultRequestHeaders.Accept.Clear();
}).ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
{
    ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
});

// Configuración del contexto de base de datos
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LocalConnection")));

// Configura la API
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseEndpoints(endpoints =>
{

    endpoints.MapControllers();
});

app.UseAuthorization();

app.MapRazorPages();

app.Run();