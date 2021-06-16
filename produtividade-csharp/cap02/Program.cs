using System;

//Capítulo sobre operadores
namespace cap02
{
    //Criando uma classe
    public class Pessoa
    {
        //Define os atributos de pessoa
        public string Nome { get; set; }
        public Endereco endereco { get; set; }

        public override string ToString()
        {
            return @$"Pessoa('nome':{this.Nome}, 'endereco':{this.endereco})";
        }
    }

    public class Endereco
    {
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string Cep { get; set; }

        public override string ToString()
        {
            return $@"Endereco('Logradouro':{this.Logradouro}, 'Bairro':{this.Bairro},'Cidade':{this.Cidade}, 'Estado':{this.Estado}, 'Pais':{this.Pais}, 'Cep':{this.Cep})";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Murilo Zanini";
            pessoa.endereco = new Endereco();
            pessoa.endereco.Cep = "09051-110";
            Console.WriteLine($"Pessoa: {pessoa}");

            //É possível inicializar os objetos mesmo com o construtor padrão
            Pessoa pessoa2 = new Pessoa()
            {
                Nome = "Deku",
                endereco = new Endereco()
                {
                    Logradouro = "jajajaj",
                    Bairro = "kaklakslaksla",
                    Cep = "45678-987",
                    Cidade = "Japão",
                    Estado = "Japão",
                    Pais = "Japão" 
                }
            };

            Console.WriteLine($"Pessoa 2: {pessoa2}");
            //Operador para verificar se algo é nulo
            var pessoa3 = new Pessoa();
            pessoa3.Nome = null;
            var nome = pessoa3.Nome ?? "Sem nome";
            Console.WriteLine($"Nome da Pessoa: {nome}");

            //Realizando conversões com a classe Convert
            //Pode lançar uma exceção de tipo de conversão.
            var numero = Convert.ToDouble(Console.ReadLine().Trim());
            Console.WriteLine($"Valor informado: {numero}");
        }
    }
}
