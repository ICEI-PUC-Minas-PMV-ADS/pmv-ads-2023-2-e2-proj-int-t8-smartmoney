using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using smartmoney.Models;

namespace smartmoney.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly AppDbContext _context;
        public CategoriasController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Categorias.ToListAsync();

            return View(dados);
        }
    }
}
