namespace ProjetoLanchonete
{
    public abstract class Produto
    {
        private decimal precoBaseProduto;

        public string nomeProduto { get; set; }

        public decimal precoBase
        { 
            get { return precoBaseProduto; }

            set 
            {
                if (value >= 0)
                    precoBaseProduto = value;
                else
                    precoBaseProduto = 0;
            }   
        }

        public Produto(string nome, decimal precoBase)
        {
            nomeProduto = nome;
            this.precoBase = precoBase;
        }

        public abstract decimal CalcularPrecoFinal();

        public virtual void ExibirResumoProduto()
        {
            Console.WriteLine($"Produto: {nomeProduto}");
            Console.WriteLine($"Preço final: R$ {CalcularPrecoFinal():f2}");
        }
    }
}