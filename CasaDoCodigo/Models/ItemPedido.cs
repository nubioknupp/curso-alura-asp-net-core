namespace CasaDoCodigo.Models
{
    public class ItemPedido
    {
        public int Id { get; private set; }
        public Produto Produto { get; private set; }
        public int Quantidade { get; private set; }

        public decimal Subtotal => Quantidade * Produto.Preco;

        public ItemPedido(int id, Produto produto, int quantidade)
        {
            Id = id;
            Produto = produto;
            Quantidade = quantidade;
        }
        
        
    }
}