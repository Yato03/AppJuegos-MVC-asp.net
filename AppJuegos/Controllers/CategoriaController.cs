using AppJuegos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AppJuegos.Controllers
{
    public class CategoriaController : Controller
    {

        private readonly AppJuegoContext _context;

        public CategoriaController(AppJuegoContext context)
        {
            _context = context;
        }

        public async Task <IActionResult> Index()
        {
            return View(await _context.Categorias.ToListAsync());
        }

    }
}
