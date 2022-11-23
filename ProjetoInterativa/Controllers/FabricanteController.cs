using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoInterativa.Context;
using ProjetoInterativa.Models;
using ProjetoInterativa.Repositories.Interfaces;

namespace ProjetoInterativa.Controllers
{
    public class FabricanteController : Controller
    {
        private readonly AppDbContext _context;

        public FabricanteController(AppDbContext context)
        {
            _context = context;
        }


        public ActionResult Index()
        {
            var fabricantes = _context.Fabricantes;

            return View(fabricantes);
        }

        public ActionResult Create()
        {
            return View();
        }

        // POST: FabricanteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Fabricante fabricante)
        {
            try
            {
                var verificaNome = _context.Fabricantes.Where(m => m.FabricanteName == fabricante.FabricanteName).Count();
                if (verificaNome > 1)
                {
                    ModelState.AddModelError("", "Fabricante já cadastrado");
                    return View(fabricante);
                }
                _context.Add(fabricante);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(fabricante);
            }
        }
   

   
    }
}
