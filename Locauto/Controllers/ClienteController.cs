using Locauto.Models;
using Microsoft.AspNetCore.Mvc;

namespace Locauto.Controllers
{
    public class ClienteController : Controller
    {
        public static List<Cliente> Clientes = 
            new List<Cliente>()
            {
                new Cliente()
                {
                    Id = 1, 
                    Nome = "Rebeca",
                    Email = "rebecaandrade@gmail.com",
                    Telefone = "(21)998347374",
                    Cidade = "Rio de Janeiro"
                },
                new Cliente(){
                    Id = 2,
                    Nome = "Medina",
                    Email = "Medina@gmail.com",
                    Telefone = "(21)99939735",
                    Cidade = "São Paulo",
                },

            };
        public IActionResult Index()
        {
            return View(Clientes);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Cliente cliente)
        {
            cliente.Id = Clientes.Select(x => x.Id).Max() +1;
            Clientes.Add(cliente);
            return RedirectToAction("Index");
        }
    }
}
