using System.Globalization;

namespace Produtos;

class Produto
{
    public string nome;
    public float preco;
    public int quantidade;

    CultureInfo Real = new CultureInfo("pt-BR");


    public Produto(string nome, float preco, int quantidade)
    {
        this.nome = nome;
        this.preco = preco;
        this.quantidade = quantidade;
    }
    

   public double ValorEstoque()
   {
     return quantidade * preco;
   }

    public void AdicionarProduto(int quantidadeAdicionada)
    {
        quantidadeAdicionada += quantidade;
    }

    public void RemoverProduto(int quatidadeRemovida)
    {
        quatidadeRemovida -= quantidade;
    }
    public override string ToString()
    {
        return "O produto "
        + nome + ", tem "
        + quantidade + " em estoque, e o seu preço é: "
        + preco.ToString("C2", Real)
        + " e o seu Valor total do estoque: " + ValorEstoque().ToString("C2", Real);
    }
}
