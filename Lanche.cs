namespace ProjetoLanchonete
{
    public class Lanche : Produto 
    {
        private decimal TaxaEmbalagem = 2.00m;

        public Lanche(string nomeProduto, decimal precoBase) 
            : base(nomeProduto, precoBase)
        {
        }

        public override decimal CalcularPrecoFinal()
        { 
            return precoBase + TaxaEmbalagem;
        }

        public override void ExibirResumoProduto()
        {
            Console.WriteLine("Tipo: Lanche");
            base.ExibirResumoProduto();
            Console.WriteLine();
        }
    }
}