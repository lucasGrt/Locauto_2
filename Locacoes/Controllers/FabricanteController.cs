using Locacoes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Locacoes.Controllers
{
    public class FabricanteController : Controller
    {
        public static List<Fabricante> Fabricantes = new List<Fabricante>()
        {
            new Fabricante()
            {
                id = 1,
                Nome = "Assin",
                País = "Japao",

            },
            new Fabricante()
            {
                id = 2,
                Nome = "Volkswagen",
                País = "Alemanha",
            }
        };

        public IActionResult Create()
        {

            return View();

        }
        public IActionResult Index()
        {

            return View(Fabricantes);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Fabricante fabricante)
        {
            fabricante.id = Fabricantes.Select(x => x.id).Max() + 1;
            Fabricantes.Add(fabricante);
            return RedirectToAction("Index");

        }

    }
        
}
