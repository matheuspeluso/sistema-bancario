using System;
using System.Globalization;

namespace SistemaBancario
{
    class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public double Saldo { get; private set;}
        public string NomeTitular;
        public double Taxa = 5.00;

        public ContaBancaria()
        {

        }
        
        public ContaBancaria(int numero, string titular)
        {
            NumeroConta = numero;
            NomeTitular = titular;
        }

        public ContaBancaria(int numero, double valor, string titular) : this(numero, titular)
        {
            Deposito(valor);
        }

        // OPERAÇÕES
        public void Deposito(double valorDeposito)
        {
            Saldo += valorDeposito; // += É A MESMA COISA QUE : Saldo = Saldo + valorDeposito;
        }

        public void Saque(double valorSaque)
        {
            Saldo = Saldo - valorSaque - Taxa;  // mesma coisa que : Saldo -= (valorSaque + Taxa);
        }

        public override string ToString()
        {
            return "Conta "+ NumeroConta +", Titular: "+NomeTitular+", Saldo: R$ "+ Saldo.ToString("f2",CultureInfo.InvariantCulture);
        }


    }
}
