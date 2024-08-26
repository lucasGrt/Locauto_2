using Locacoes.Data;
using Locacoes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Locacoes.Controllers
{
    public class ClienteController : Controller
    {
        private readonly locacoesContext _context;

        public ClienteController(locacoesContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Clientes.OrderBy(cli => cli.Nome).ToListAsync());
        }

        public IActionResult Create()
        {

        return View(); 

        }

    [HttpPost]
    [ValidateAntiForgeryToken]

    //    public IActionResult Create(Cliente cliente)
    //    {
    //        cliente.id = Clientes.Select(x => x.id).Max() + 1;
    //        Clientes.Add(cliente);
    //        return RedirectToAction("Index");
    //    }

    //    public IActionResult Edit(int id) 
    //    {
    //        return View(Clientes.Where(cli => cli.id == id).First());
    //    }

    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public IActionResult Edit(Cliente cliente)
    //    {
    //        var clienteOld = Clientes.Where(cli => cli.id == cliente.id).First();
    //        Clientes.Remove(clienteOld);
    //        Clientes.Add(cliente);
    //        return RedirectToAction("Index");
    //    }
    //    public IActionResult Details(int id)
    //    {
    //        return View(Clientes.Where(cli => cli.id == id).First());
    //    }

    //    public IActionResult Delete(int id)
    //    {
    //        return View(Clientes.Where(cli => cli.id == id).First());
    //    }

    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public IActionResult Delete(Cliente cliente)
    //    {
    //        var clienteRemove = Clientes.Where(cli => cli.id == cliente.id).First();
    //        Clientes.Remove(clienteRemove);
    //        return RedirectToAction("Index");
    //    }

    }
}
