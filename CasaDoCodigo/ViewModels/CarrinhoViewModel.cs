using System.Collections.Generic;
using CasaDoCodigo.Models;
using System.Linq;

namespace CasaDoCodigo.ViewModels
{
    public class CarrinhoViewModel
    {
        public List<ItemPedido> Itens { get; private set; }

        public decimal Total
        {
            get { return Itens.Sum(x => x.Subtotal);}
        }

        public CarrinhoViewModel(List<ItemPedido> itens)
        {
            Itens = itens;
        }
        
    }
}