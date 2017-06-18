using Microsoft.AspNetCore.Mvc;

namespace CasaDoCodigo.Controllers
{
    public class PedidoController : Controller
    {
        // GET
        public IActionResult Carrossel()
        {
            return View();
        }

        public IActionResult Carrinho()
        {
            return View();
         }

        public IActionResult Resumo()
        {
            return View();
        }

   
      }
}