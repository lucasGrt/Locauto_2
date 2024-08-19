using Locacoes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Locacoes.Controllers
{
    public class ClienteController : Controller
    {
        public static List<Cliente> Clientes = new List<Cliente>()
        {
            new Cliente()
            {
                id = 1,
                Nome = "Rebeca",
                Email = "rebeca@gool.com",
                Telefone = "(24)123456789",
                Cidade = "Volta Redonda"
            },
            new Cliente()
            {
                id = 2,
                Nome = "Medina",
                Email = "medina@gool.com",
                Telefone = "(24)987654321",
                Cidade = "Santos"
            }
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
            cliente.id = Clientes.Select(x => x.id).Max() + 1;
            Clientes.Add(cliente);
            return RedirectToAction("Index");
        }

}
}
