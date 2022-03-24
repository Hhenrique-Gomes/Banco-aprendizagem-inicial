using System;
using System.Globalization;
namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta; 

            Console.Write("Entre o número da conta: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)?");
            char sn = Convert.ToChar(Console.ReadLine());

            if (sn == 's' || sn == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double dpstInicial = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero,titular,dpstInicial);
            }
            else
            {
                conta = new ContaBancaria(numero,titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Digite o valor a ser depositado: ");
            double quantia1 = Convert.ToDouble(Console.ReadLine());
            conta.Deposito0(quantia1);    
            Console.WriteLine("Dados da conta Atualizados");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Digite um valor a ser sacado: ");
            double quantia2 = Convert.ToDouble(Console.ReadLine());
            conta.Saque(quantia2);
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(conta);

        }
    }
}
