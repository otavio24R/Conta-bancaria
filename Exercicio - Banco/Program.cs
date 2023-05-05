using System.Security.Cryptography.X509Certificates;

namespace Exercicio___Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta_Bancaria cb;

            Console.WriteLine("Entre com nº de conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome do titular: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Deseja fazer um depósito inicial?");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.WriteLine("Qual é o valor do depósito inicial?");
                double depositoInicial = double.Parse(Console.ReadLine());
                cb = new Conta_Bancaria(numero, titular, depositoInicial);


            }
            else { cb = new Conta_Bancaria(numero, titular); }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(cb);
            Console.WriteLine();
            
            Console.WriteLine("Valor a depositar: ");
            double quantia = double.Parse(Console.ReadLine());
            cb.Deposito(quantia);
            Console.WriteLine("Dados atualizados da conta: ");
            Console.WriteLine(cb);

            Console.WriteLine();
            Console.WriteLine("Que valor pretende levantar?");
            cb.Levantamento(quantia);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados da conta: ");
            Console.WriteLine(cb);

















        }
    }
}