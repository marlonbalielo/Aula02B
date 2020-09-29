using System;

namespace Aula02B
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();
                
            produto1.Codigo = 10;
            produto1.Nome = "Pimenta";
            produto1.Preco = 34.4;
            produto1.Quantidade = 10;
            produto1.Validade = DateTime.Now;

            Console.WriteLine("Codigo: " +produto1.Codigo);
            Console.WriteLine("Nome: " + produto1.Nome);
            Console.WriteLine("Preco: " + produto1.Preco);
            Console.WriteLine("Quantidade: " + produto1.Quantidade);
            Console.WriteLine("Validade: " + produto1.Validade);

            Pessoa pessoa1 = new Pessoa();

            pessoa1.Codigo = 10;
            pessoa1.Nome = "Alex";
            pessoa1.Idade = 34;
            pessoa1.Altura = 1.56;
            

            Console.WriteLine("\nCodigo: " + pessoa1.Codigo);
            Console.WriteLine("Nome: " + pessoa1.Nome);
            Console.WriteLine("Idade: " + pessoa1.Idade);
            Console.WriteLine("Altura: " + pessoa1.Altura);
           

        }
    }
}
