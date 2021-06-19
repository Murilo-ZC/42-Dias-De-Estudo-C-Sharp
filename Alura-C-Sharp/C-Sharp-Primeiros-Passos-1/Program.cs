using System;

namespace C_Sharp_Primeiros_Passos_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 2");
            //Declara uma variável
            int idade;
            //Atribui um valor a variável
            idade = 32;
            //Interpolando a String
            Console.WriteLine($"Valor da variável: {idade}");
            //Declara um double
            double valor = 7.0;
            Console.WriteLine($"Divisão por inteiro:{idade/3}");
            //Força o cast do tipo
            Console.WriteLine($"Divisão por real:{(double)idade/3}");
            Console.WriteLine($"Divisão por double:{valor/3}");

            //Trabalhando com caracteres
            char letra = 'a';
            //Exibindo e trabalhando com ele
            Console.WriteLine($"Valor atribuído a variável: {letra}");
            //Manipulando os valores numéricos
            Console.WriteLine($"Valor: {(char)((int)letra + 1)}");

            //Manipulando Strings
            string texto = "Ola Mundo";
            Console.WriteLine(texto);
        }
    }
}
