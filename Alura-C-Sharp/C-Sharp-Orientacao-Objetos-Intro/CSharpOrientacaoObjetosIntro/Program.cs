using System;

namespace CSharpOrientacaoObjetosIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Utilizando a classe ContaCorrente - primeira versão
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.cliente = new Cliente();
            contaDaGabriela.cliente.nome = "Gabriela";
            Console.WriteLine($"Nome do Cliente: {contaDaGabriela.cliente.nome}");
        }
    }
}
