{
    public abstract class Produto
{
    public string nome {get; set;};
    public decimal PrecoBase{get, set};
        
    

    public abstract void CalcularPrecoFinal();
    public void ExibirResumo()
    {x
        Console.WriteLine($"Produto: {nome}");
        Console.WriteLine($"Preço final: ");
        }
    }
}