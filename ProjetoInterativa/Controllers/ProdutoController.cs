using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetoInterativa.Context;
using ProjetoInterativa.Models;
using System.Linq;

namespace ProjetoInterativa.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly AppDbContext _context;

        public ProdutoController(AppDbContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            var produtos = _context.Produtos.OrderBy(p=>p.Nome);

            return View(produtos);
        }


        public ActionResult Create()
        {
           
          //ViewBag.FabricanteNome = new SelectList( "FabricantesName", "FabricanteName");

            return View();
        }

        // POST: ProdutoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Produto produto)
        {
            try
            {
                _context.Add(produto);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(produto);
            }
        }

        // GET: ProdutoController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var produto = _context.Produtos.Find(id);
            if (produto == null) { return NotFound(); }


            return View(produto);
        }

        // POST: ProdutoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Produto produto)
        {
           

            if (id != produto.ProdutoId)
            {
                return NotFound();
            }
            try
            {  
                _context.Update(produto);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProdutoController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var produto = _context.Produtos.Find(id);
            if (produto == null) { return NotFound(); }


            return View(produto);
        }

        // POST: ProdutoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Produto produto = _context.Produtos.Find(id);

            if (id != produto.ProdutoId)
            {
                return NotFound();
            }
            try
            {
                _context.Remove(produto);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Pesquisar(Produto produto)
        //{
            
        //}
    }
}
