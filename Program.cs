using System;
using System.Globalization;

namespace Exercicio_Conta_Bancaria {
    class Program {
        static void Main(string[] args) {
                                             
            Console.Write("Entre com o número da conta: ");
            double conta = double.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
                        
            ContaBancaria p = new ContaBancaria(conta, titular);
            
            Console.Write("Haverá deposito (S/N) ");
            string hdeposito = Console.ReadLine();
            if (hdeposito == "S") {
                Console.Write("Entre o valor de deposito inicial: ");
                double qtee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p.Deposito(qtee);
                Console.WriteLine("Dados da conta autalizados:");
                Console.WriteLine(p);
            }
            else {
                Console.WriteLine();
                Console.WriteLine(p);
            }

            Console.WriteLine();
            Console.Write("Depositar: ");
            double qte = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.Deposito(qte);
            Console.WriteLine("Dados da conta autalizados:");
            Console.WriteLine(p);
            
            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            qte = double.Parse(Console.ReadLine());
            p.Saque(qte);
            Console.WriteLine("Dados da conta");
            Console.WriteLine(p);

            
            





        }
    }
}
