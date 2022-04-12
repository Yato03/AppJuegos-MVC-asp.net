using AppJuegos.Models;
using AppJuegos.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AppJuegos.Controllers
{
    public class JuegoController : Controller
    {
        private readonly AppJuegoContext _context;

        public JuegoController(AppJuegoContext context)
        {
            _context = context;
        }

        public async Task <IActionResult> Index()
        {
            var juegos = _context.Juegos.Include(c => c.Categoria);
            return View(await juegos.ToListAsync());
        }
        public IActionResult Create()
        {
            ViewData["Categorias"] = new SelectList(_context.Categorias, "CategoriaId", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(JuegoViewModel model)
        {
            if (ModelState.IsValid)
            {
                var juego = new Juego()
                {
                    Name = model.Name,
                    CategoriaId = model.CategoriaId
                };
                _context.Add(juego);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewData["Categorias"] = new SelectList(_context.Categorias, "CategoriaId", "Name", model.CategoriaId);
            return View();
        }
    }
}
