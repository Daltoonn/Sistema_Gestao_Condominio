using Microsoft.EntityFrameworkCore;
using SistemaReservaQuadraCondominio.Data;

var builder = WebApplication.CreateBuilder(args);

// Configura��o do banco de dados
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Adicionando MVC e Razor Views
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configura��o de redirecionamento padr�o para o controlador Home e a��o Index
app.UseHttpsRedirection();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");  // Define Home como controlador padr�o

app.Run();
