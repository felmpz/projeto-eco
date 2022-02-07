using Microsoft.AspNetCore.Mvc;
using projeto_eco.Models;
using projeto_eco_new.DAO;

namespace projeto_eco_new.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;
        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost] //Declaração de Metodo

        public IActionResult Criar(ContatoModel contato)
        {
            _contatoRepositorio.Adicionar(contato);
            return RedirectToAction("Index");
           
        }
    }
}
