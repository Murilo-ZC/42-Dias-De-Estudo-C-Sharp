using System;
//Para utilizar Regex - Expressões Regulares
using System.Text.RegularExpressions;
//Para utilizar List<>
using System.Collections.Generic;

namespace cap1_produtividade
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estudo Basico do processamento de Strings
            // funcionalidades1();
            // Fatiamento de Strings
            // funcionalidades2();
            // Trabalhando com data e hora
            // funcionalidades3();
            // Utilizando mascara para realizar exibição de valores
            // funcionalidades4();
            // Escolhe um nome aleatório da lista de nomes
            // funcionalidade5();
            // Validação utilizando expressão regular
            funcionalidade6();
        }

        private static void funcionalidade6(){
            //Utilizando expressões regulares para validar padrões
            //Valida CEPs nos formatos: 09051-110 ou 09051110
            var padroesValidos = @"^(\d{5}\-\d{3}|\d{8})$";
            List<string> ceps = new List<string>();
            ceps.Add("1589");
            ceps.Add("09051110");
            ceps.Add("09051 110");
            ceps.Add("09051-110");

            //Cria um objeto regex
            Regex regex = new Regex(padroesValidos);

            //Verifica cada um dos CEPs
            foreach (var cep in ceps)
            {
                var saida = regex.IsMatch(cep) ? "Válido" : "Inválido";
                Console.WriteLine($"Para {cep}: {saida}"); 
            }

        }

        private static void funcionalidade5(){
            //Selecionando uma string do conjunto
            var palavras = "Goku,Gohan,Vegeta,Piccolo,Kuririn,Yantcha".Split(',');
            Console.WriteLine(@$"Nome Sorteado:
            {palavras[new Random().Next(palavras.Length)]}");
        }

        private static void funcionalidades4(){
            //Trabalhando com mascaras de strings
            string mascara = "00000-000";
            long cep = 09051110;
            Console.WriteLine(cep.ToString(mascara));
        }
        private static void funcionalidades3(){
            //Trabalhando com data e hora
            var dataEhora = DateTime.Now;
            Console.WriteLine(String.Format("Data: {0:d} - Hora: {0:t}", dataEhora));
            //Fazendo contas com horários
            var amanha = dataEhora.AddDays(1);
            Console.WriteLine(String.Format("Amanhã: Data: {0:d} - Hora: {0:t}", amanha));
        }
        private static void funcionalidades2(){
            //Cria uma lista de strings
            string[] palavras;
            var meuTexto = "ola mundo, aqui, tem, varias, coisas";
            palavras = meuTexto.Split(','); //Importante Split recebe um char como parâmetro
            foreach (var palavra in palavras)
            {
                Console.WriteLine($"Saida Atual:{palavra}" );
                Console.WriteLine($"Saida Atual Sem Espaços Antes e Depois:{palavra.Trim()}" );
            }

            //Separando os itens em uma linha e realizando seu cast de tipo
            var linhaComValores = "15.5;48;-96;45";
            var dados = linhaComValores.Split(';');
            foreach(var dado in dados){
                //Converte o valor numérico
                //CUIDADO COM O IDIOMA DA PLATAFORMA QUE RODAR O CÓDIGO
                Console.WriteLine(String.Format("Dado Atual: {0} - Seu Valor Convertido {1:C4}", dado, Double.Parse(dado.Replace('.',','))));
            }
        }
        private static void funcionalidades1(){
            var autor = "Murilo Zanini de Carvalho";
            var mensagem = "Nome do livro!";
            //Interpolação de Strings
            Console.WriteLine($"Interpolação de Strings: {autor} que escreveu {mensagem}");
            //Strings literais - Verbatim String
            Console.WriteLine(@"Exemplo
            de String
            em que caracteres de escape com \ são ignorados! - Muito
            util para montar queries SQL");

            //Segura o console aberto
            Console.WriteLine("Digite qualquer tecla para continuar...");
            Console.ReadKey();
        } 
    }
}
