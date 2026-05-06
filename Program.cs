namespace ProjetoLanchonete;

class Program
{
    static void Main(string[] args)
    {
        List<Produto> pedido = new List<Produto>();

        pedido.Add(new Lanche("X-Cheddar", 28.00m));
        pedido.Add(new Bebida("Coca-Zero", 8.00m));
        pedido.Add(new Sobremesa("Torta-Limão", 6.50m));

        Console.WriteLine($"===== Resumo Pedido =====");

        decimal total = 0;

        foreach (Produto produto in pedido)
        {
            produto.ExibirResumoProduto();
            total += produto.CalcularPrecoFinal();
        }

        Console.WriteLine($"Total do pedido: R$ {total:f2}");
    }
}