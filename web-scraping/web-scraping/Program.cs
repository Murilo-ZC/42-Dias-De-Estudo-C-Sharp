using System;
using System.Net;
using System.Text.RegularExpressions;

namespace web_scraping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Web Scrapinling Básico:");
            var url = "https://boletando.com/";
            Console.WriteLine($"Disparando contra: {url}");
            //Documentação da classe WebClient: https://docs.microsoft.com/pt-br/dotnet/api/system.net.webclient?view=net-5.0
            WebClient webClient = new WebClient();
            //Pega o retorno como uma string
            var retornoUrl = webClient.DownloadString(url);
            //Dados obtidos
            //Console.WriteLine($"Dados obtidos: {retornoUrl}");
            //Utiliza o Regex para localizar os elementos da String: https://docs.microsoft.com/pt-br/dotnet/standard/base-types/regular-expression-example-scanning-for-hrefs
            //Para testar Regex: http://regexstorm.net/tester
            //Pegar elementos dentro de uma tag: https://qastack.com.br/programming/7167279/regex-select-all-text-between-tags
            var m = Regex.Match(retornoUrl, "<span class=\"rh_regular_price\">(.*?)</span>",
                        RegexOptions.IgnoreCase | RegexOptions.Compiled,
                        TimeSpan.FromSeconds(1));
            while (m.Success)
            {
                Console.WriteLine("Encontrado: " + m.Groups[1] + " em "
                   + m.Groups[1].Index);
                m = m.NextMatch();
            }

            Console.WriteLine("Terminando de buscar!");

        }
    }
}
