using System;

namespace CSharpOrientacaoObjetosIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Utilizando a classe ContaCorrente - primeira versão
            ContaCorrente contaDaGabriela = new ContaCorrente(
                new Cliente("Gabriela", "123456789", "Professor"),
                15897
                );
            ContaCorrente contaDoMurilo = new ContaCorrente(
                new Cliente("Murilo", "123456789", "Professor"),
                15897
                );
            Console.WriteLine($"Nome do Cliente: {contaDaGabriela}");
            Console.WriteLine($"Nome do Cliente: {contaDoMurilo}");
        }
    }
}
