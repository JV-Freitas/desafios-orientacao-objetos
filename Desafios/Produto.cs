using System.Reflection.Metadata.Ecma335;

class Produto
{
    public string Nome { get; set; }
    public string Marca { get; set; }
    private int preco;
    public int Preco
    {
        get { return preco; }
        set
        {
            if (value >= 0)
            {
                preco = value;
            }
            else
            {
                Console.WriteLine($"O preço deve ser positivo.");
            }

        }
    }
    private int estoque;
    public int Estoque
    {
        get { return estoque; }
        set
        {
            if (value >= 0)
            {
                estoque = value;
            }
            else
            {
                Console.WriteLine($"O estoque deve ser positivo.");
            }

        }
    }

    public string DetalhesDoProduto  => $"\nNome: {Nome}\nMarca: {Marca}\nPreço: R${Preco}\nEstoque: {Estoque}";
}