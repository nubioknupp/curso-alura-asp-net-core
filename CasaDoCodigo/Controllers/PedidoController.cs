using System.Collections.Generic;
using CasaDoCodigo.Models;
using CasaDoCodigo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CasaDoCodigo.Controllers
{
    public class PedidoController : Controller
    {
        private readonly List<Produto> _produtos = new List<Produto>
        {
            new Produto {Id = 1, Nome = "Sleep not found", Preco = 59.90m},
            new Produto {Id = 2, Nome = "May the code be with you", Preco = 59.90m},
            new Produto {Id = 3, Nome = "Rollback", Preco = 59.90m},
            new Produto {Id = 4, Nome = "REST", Preco = 69.90m},
            new Produto {Id = 5, Nome = "Design Patterns com Java", Preco = 69.90m},
            new Produto {Id = 6, Nome = "Vire o jogo com Spring Framework", Preco = 69.90m},
            new Produto {Id = 7, Nome = "Test-Driven Development", Preco = 69.90m},
            new Produto {Id = 8, Nome = "iOS: Programe para iPhone e iPad", Preco = 69.90m},
            new Produto {Id = 9, Nome = "Desenvolvimento de Jogos para Android", Preco = 69.90m}
        };

        public IActionResult Carrossel()
        {
            return View(_produtos);
        }

        public IActionResult Carrinho()
        {
            var itensCarrinho = new List<ItemPedido>
            {
                new ItemPedido(1, _produtos[0], 1),
                new ItemPedido(2, _produtos[1], 2),
                new ItemPedido(3, _produtos[2], 3)
            };

            var viewModel = new CarrinhoViewModel(itensCarrinho);
            
            return View(viewModel);
        }

        public IActionResult Resumo()
        {
            return View();
        }
    }
}