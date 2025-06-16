using Microsoft.AspNetCore.Mvc;

namespace SistemaReservaQuadraCondominio.Controllers
{
    public class HomeController : Controller
    {
        // Ação para a página inicial
        public IActionResult Index()
        {
            return View();  // Retorna a view 'Index'
        }
    }
}
