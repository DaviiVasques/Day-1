using System;
using Produtos;

namespace Principal
{
    class Program 
    {
            static void Main(string[] args)
            {
                Console.Write("Digite o nome do produto que deseja adicionar: ");
                string nomeProduto = Console.ReadLine() ?? "Nome não adicionado";
                Console.Write("Digite o preço do produto que deseja adicionar: ");
                float precoProduto = float.Parse(Console.ReadLine() ?? "Preço não adicionado");
                Console.Write("Digite a quantidade do produto que deseja adicionar: ");
                int quantidade = int.Parse(Console.ReadLine() ?? "Quantidade não adicionada");

                Produto Televisão = new Produto(nomeProduto, precoProduto, quantidade);

                Console.WriteLine(Televisão);

                Televisão.nome = "Smart televisão";
                
                Console.WriteLine(Televisão);

            }
    }
}
