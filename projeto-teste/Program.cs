using System;

namespace projeto_teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string nome, cidade;
            DateTime datanasc;

            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Cidade: ");
            cidade = Console.ReadLine();
            Console.Write("Nascimento: ");
            datanasc = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nome: " + nome + ", Cidade: " + cidade + "Data de Nascimento: " + datanasc + ".");

        }
    }
}
