using System;

namespace C_Sharp_Primeiro_Passos_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estruturas de Controle:");
            var idade = 18;
            //Estrutura de controle
            if(idade > 18){
                Console.WriteLine("Pode entrar!");
            } else {
                Console.WriteLine("Você ainda não pode entrar!");
            }

            //Variáveis booleanas
            bool saida = true;  //Inicialiando a variável
            saida = 5 > 3;
            Console.WriteLine($"Resultado da comparação:{saida}");

            //Exemplo estrutura while
            int contador = 0;
            double valor = 1000;
            double rendimento = 0.0036;
            while(contador < 12)
            {
                valor *= (1 + rendimento);
                Console.WriteLine($"Valor depois de {contador} meses: {valor}");
                contador += 1;
            }
            //Mesmo comportamento com a estrutura for básico
            contador = 0;
            valor = 1000;
            rendimento = 0.0036;
            for(contador = 0; contador < 12; contador++)
            {
                valor *= (1 + rendimento);
                Console.WriteLine($"Valor depois de {contador} meses: {valor}");
            }

            //Instrução break
            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna < 10; coluna++)
                {
                    Console.Write("*");
                    if (coluna >= linha)
                        break; //Interrompe a execução do for interno
                }
                Console.WriteLine();
            }
        }
    }
}
