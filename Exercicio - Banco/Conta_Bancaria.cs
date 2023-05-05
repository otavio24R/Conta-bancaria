using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio___Banco
{
    internal class Conta_Bancaria
    {
        //Definição de propriedades

        public int Numero { get; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }  //saldo //nao é disponivel para ser modificado o saldo (private set)




        // Construtores

        public Conta_Bancaria(int numero, string titular)   // este construtor permite instanciar contas bancarias apenas com o numero de conta e seu o seu titular.
        {
            Numero = numero;
            Titular = titular;
        }

        public Conta_Bancaria(int numero, string titular, double saldo) : this(numero, titular)   // permite instanciar uma conta a partir do seu nº de conta, tittular e seu saldo inicial.
        {
            Saldo = saldo;
        }




        // secção de métodos

        public void Deposito(double quantia)      // Este é o metodo que permite depositar o dinheiro na conta
        {

            Saldo += quantia;
        }


        public void Levantamento(double quantia) // Este metodo permite fazer o levantamento de dinheiro
        {

            Saldo -= quantia + 5;   // podemos acrescentar a taxa de 5
        }

        public override string ToString()
        {
            return "Conta bancaria numero "
            + Numero
            +", Titular da conta: "
            + Titular
            + ", Saldo da conta: "
            + Saldo.ToString("F2")
            + " euros.";
        }




    }
}
