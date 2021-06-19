/**
 * Classe que representa uma Conta Corrente
 */
public class ContaCorrente
{
    /**
     * Atributos da classe
     */
    public string titular;
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


    public void Depositar(double valor)
    {
        this.saldo += valor;
    }


}