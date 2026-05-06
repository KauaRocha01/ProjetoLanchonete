namespace ProjetoLanchonete
{
    public class Sobremesa : Produto
    {
        public Sobremesa(string nomeProduto, decimal precoBase) : base(nomeProduto, precoBase)
        {
        }

        public decimal AplicarDesconto()
        {
            return precoBase * 0.10m;
        }

        public override decimal CalcularPrecoFinal()
        {
            return precoBase - AplicarDesconto();
        }

        public override void ExibirResumoProduto()
        {
            Console.WriteLine("Tipo: Sobremesa");
            base.ExibirResumoProduto();
            Console.WriteLine($"Desconto: R$ {AplicarDesconto():f2}");
            Console.WriteLine();
        }
    }
}