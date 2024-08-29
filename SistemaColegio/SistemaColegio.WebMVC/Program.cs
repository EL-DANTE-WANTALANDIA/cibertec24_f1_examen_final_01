using Microsoft.EntityFrameworkCore;
using SistemaColegio.Dominio.Repositories;
using SistemaColegio.Infraestructura.Datos;
using SistemaColegio.Infraestructura.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ColegioDbContext>(
    options => options.UseSqlServer("Data Source=NEFTALY6;Initial Catalog=dbColegio; Integrated Security=true;TrustServerCertificate=true;")
    );

builder.Services.AddTransient<IAlumnoRepository, AlumnoRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
