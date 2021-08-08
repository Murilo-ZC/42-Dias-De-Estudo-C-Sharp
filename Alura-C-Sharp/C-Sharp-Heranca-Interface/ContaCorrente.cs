//Coloca a classe dentro do namespace (realizae seu registro nele)
namespace C_Sharp_Heranca_Interface
{

    /**
     * Classe que representa uma Conta Corrente
     */
    public class ContaCorrente
    {
        /**
         * Atributos da classe
         */
        public Cliente Cliente { set; get; }

        public int Agencia { get; set; }
        public int Numero { get; set; }
        private double _saldo = 100.0; //Inicializa o atributo com um valor padrão

        /**
         * Realiza alteração no Saldo
         */
        public bool Sacar(double valor)
        {
            //Verifica se o saldo é insuficiente para realizar o saque
            if (this.Saldo < valor)
                return false;
            //Caso o saldo seja suficiente
            this.Saldo -= valor;
            return true;
        }


        /**
         * Comportamento para depositar valores
         */
        public void Depositar(double valor)
        {
            this._saldo += valor;
        }


        /**
         * Transferir dinheiro entre contas
         */
        public bool TransferirDinheiro(double valor, ContaCorrente conta)
        {

            if (!this.Sacar(valor))
            {
                //Se o saldo não for suficiente, retorna falso
                return false;
            }

            //Esse fluxo é executado quando existe saldo o suficiente
            conta.Depositar(valor);
            return true;
        }

        /**
         * Construção de uma própriedade para a manipular algum atributo da classe
         */
        public double Saldo
        {
            get
            {
                return _saldo;
            }

            set
            {
                if (value < 0)
                    return;
                _saldo = value;
            }
        }

        static private int TotalDeContas {get; set;}
        static public int GetTotalDeContas { get { return TotalDeContas; } private set { } }

        public ContaCorrente(Cliente cliente, int agencia)
        {
            Cliente = cliente;
            Agencia = agencia;
            ContaCorrente.TotalDeContas += 1;
            Numero = ContaCorrente.GetTotalDeContas;
            Saldo = 100;
        }

        public override string ToString()
        {
            return $"Agencia: {Agencia}, Numero: {Numero}, Saldo: {Saldo}, Cliente: {Cliente}";
        }
    }

}