using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SalesWebMvc.Data;
using SalesWebMvc.Services;
using System.Globalization;
using Microsoft.AspNetCore.Localization;

var builder = WebApplication.CreateBuilder(args);

// Configuração do banco de dados
builder.Services.AddDbContext<SalesWebMvcContext>((serviceProvider, optionsBuilder) =>
{
    var configuration = serviceProvider.GetService<IConfiguration>();
    var connectionString = configuration.GetConnectionString("SalesWebMvcContext");
    optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0)), mySqlOptions =>
    {
        mySqlOptions.MigrationsAssembly("SalesWebMvc");
    });
});

// Registro do serviço de seeding
builder.Services.AddScoped<SeedingService>();
builder.Services.AddScoped<SellerService>();
builder.Services.AddScoped<DepartmentService>();

builder.Services.AddControllersWithViews();

var app = builder.Build();
var dbContext = app.Services.CreateScope().ServiceProvider.GetRequiredService<SalesWebMvcContext>();

var enUS = new CultureInfo("en-US");
var localizationOptions = new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture(enUS),
    SupportedCultures = new List<CultureInfo> { enUS },
    SupportedUICultures = new List<CultureInfo> { enUS },
};

// Se estiver em ambiente de desenvolvimento, popula o banco de dados
if (app.Environment.IsDevelopment())
{
    SeedingService seedingService = new SeedingService(dbContext);
    seedingService.Seed();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseExceptionHandler("/Home/Error");
app.UseHsts();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();