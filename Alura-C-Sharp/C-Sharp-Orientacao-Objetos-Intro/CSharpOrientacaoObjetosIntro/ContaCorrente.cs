//Coloca a classe dentro do namespace (realizae seu registro nele)
namespace CSharpOrientacaoObjetosIntro
{

    /**
     * Classe que representa uma Conta Corrente
     */
    public class ContaCorrente
    {
        /**
         * Atributos da classe
         */
        public Cliente cliente;

        public int agencia;
        public int numero;
        public double saldo = 100.0; //Inicializa o atributo com um valor padrão

        /**
         * Realiza alteração no Saldo
         */
        public bool Sacar(double valor)
        {
            //Verifica se o saldo é insuficiente para realizar o saque
            if (this.saldo < valor)
                return false;
            //Caso o saldo seja suficiente
            this.saldo -= valor;
            return true;
        }


        /**
         * Comportamento para depositar valores
         */
        public void Depositar(double valor)
        {
            this.saldo += valor;
        }


        /**
         * Transferir dinheiro entre contas
         */



    }

}