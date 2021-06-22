using System;
namespace C_Sharp_Heranca_Interface
{
    public class Cliente
    {
        //Atributos da classe
        public string Nome { get; set; }

        private string _cpf;
        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                _cpf = value;
            }
        }
        public string Profissao { get; set; }

        public Cliente(string nome, string cPF, string profissao)
        {
            Nome = nome;
            CPF = cPF;
            Profissao = profissao;
        }

        public override string ToString()
        {
            return $"Cliente: Nome - {Nome}, CPF - {CPF}, Professicao: {Profissao}";
        }
    }
}
