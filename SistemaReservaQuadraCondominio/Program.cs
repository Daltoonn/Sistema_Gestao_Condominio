using Microsoft.EntityFrameworkCore;
using SistemaReservaQuadraCondominio.Data;

var builder = WebApplication.CreateBuilder(args);

// Configuração do banco de dados
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Adicionando MVC e Razor Views
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configuração de redirecionamento padrão para o controlador Home e ação Index
app.UseHttpsRedirection();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");  // Define Home como controlador padrão

app.Run();
