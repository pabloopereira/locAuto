using Locauto.Models;
using Microsoft.AspNetCore.Mvc;

namespace Locauto.Controllers
{
    public class FabricanteController : Controller
    {
        public static List<Fabricante> Fabricantes =
            new List<Fabricante>()
            {
                new Fabricante()
                {
                    Id = 1,
                    Nome = "Travis",
                    Pais = "Dinamarca",
                },
                new Fabricante(){
                    Id = 2,
                    Nome = "Pedro",
                    Pais = "Brasil",
                },

            };
        public IActionResult Index()
        {
            return View(Fabricantes);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Fabricante fabricante)
        {
            fabricante.Id = Fabricante.Select(x => x.Id).Max() + 1;
            Fabricante.Add(fabricante);
            return RedirectToAction("Index");
        }
    }
}

  

