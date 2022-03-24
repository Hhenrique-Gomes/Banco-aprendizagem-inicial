using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Banco
{
    class ContaBancaria
    {

        public int NumeroBNC { get; private set; }
        public string Titular  { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria (int numeroBNC, string titular)
        {
            NumeroBNC = numeroBNC;
            Titular = titular;
            
        }

        public ContaBancaria (int numeroBNC, string titular, double depositoinicial) : this(numeroBNC, titular)
        {
            Deposito0(depositoinicial);
        }

        public void Deposito0(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque (double quantia)
        {
            Saldo -= quantia + 5;
        }

        public override string ToString()
        {          
            Console.WriteLine("Numero da conta: {0}, Titular: {1}, saldo: {2}", NumeroBNC,Titular,Saldo.ToString("F2", CultureInfo.InvariantCulture));
            string linha = "";
            linha = Console.ReadLine();        
            return linha;
        }

    }
}
