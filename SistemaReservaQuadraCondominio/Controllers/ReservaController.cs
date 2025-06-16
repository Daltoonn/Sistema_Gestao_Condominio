using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaReservaQuadraCondominio.Data;
using SistemaReservaQuadraCondominio.Models;

namespace SistemaReservaQuadraCondominio.Controllers
{
    public class ReservaController : Controller
    {
        private readonly AppDbContext _context;

        public ReservaController(AppDbContext context)
        {
            _context = context;
        }

        // Tela inicial / Cadastro de reserva
        public IActionResult Cadastro()
        {
            return View();
        }

        // Tela do Administrador (visualizar todas as reservas)
        public async Task<IActionResult> Administrador()
        {
            var reservas = await _context.Reservas.ToListAsync();
            return View("Administrador", reservas);
        }


        // Ação para registrar uma reserva
        [HttpPost]
        public async Task<IActionResult> Cadastro(Reserva reserva)
        {
            if (ModelState.IsValid)
            {
                _context.Reservas.Add(reserva);
                await _context.SaveChangesAsync();
                return RedirectToAction("Cadastro");
            }
            return View(reserva);
        }

        // Excluir uma reserva
        public async Task<IActionResult> Excluir(int id)
        {
            var reserva = await _context.Reservas.FindAsync(id);
            if (reserva != null)
            {
                _context.Reservas.Remove(reserva);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Administrador");
        }
    }
}
