using System;
using System.Globalization;

namespace SistemaBancario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria _contaBancaria;
            Console.Write("Entre com o número da conta: ");
            int accNumber = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular da conta: ");
            string name = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Haverá deposito inicial (s/n) ? ");
            string resp = Console.ReadLine();
            double deposito_saque = 0;
            if (resp == "s")
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                deposito_saque = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                _contaBancaria = new ContaBancaria(accNumber, deposito_saque, name);

                
            }
            else
            {
                _contaBancaria=new ContaBancaria(accNumber, name);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(_contaBancaria);

            Console.Write("Você deseja fazer Depósito (s/n) ?  ");
            resp = Console.ReadLine();

            if (resp == "s")
            {
                Console.Write("Entre com o valor do depósito: ");
                deposito_saque = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                _contaBancaria.Deposito(deposito_saque);

                Console.WriteLine();
                Console.WriteLine("Dados Atualizados: ");
                Console.WriteLine(_contaBancaria);
            }

            Console.Write("Você deseja fazer Saque (s/n) ?");
            resp = Console.ReadLine();
            if (resp == "s")
            {
                Console.Write("Entre com o valor que deseja sacar: ");
                deposito_saque = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                _contaBancaria.Saque(deposito_saque);

                Console.WriteLine();
                Console.WriteLine("Dados Atualizados: ");
                Console.WriteLine(_contaBancaria);

            }
        }
    }
}