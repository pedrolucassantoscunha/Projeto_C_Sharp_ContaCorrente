// See https://aka.ms/new-console-template for more information
using System;

namespace ProjetoC
{
    class program
    {
        static void Main(string[] args)
        {
            // Objetos
            ContaCorrente conta_toddy = new ContaCorrente ("Toddy", 12345, 789, 1000);
            ContaCorrente conta_pedro = new ContaCorrente ("Pedro", 653633, 234,600);
            ContaCorrente conta_lucas = new ContaCorrente ("Lucas", 7502, 756, 100);


            Console.WriteLine("A conta é do (a) " + conta_toddy.Titular + ", a agência é " + conta_toddy.Agencia
            + " e o número é " + conta_toddy.Numero+ " Saldo: " + conta_toddy.Saldo);
            
            Console.WriteLine("A conta é do (a) " + conta_pedro.Titular + ", a agência é " + conta_pedro.Agencia
            + " e o número é " + conta_pedro.Numero+ " Saldo: " + conta_pedro.Saldo);
            
            Console.WriteLine("A conta é do (a) " + conta_lucas.Titular + ", a agência é " + conta_lucas.Agencia
            + " e o número é " + conta_lucas.Numero + " Saldo: " + conta_lucas.Saldo);

            bool sacar_conta = conta_toddy.Sacar(100);
            bool sacar_conta1 = conta_pedro.Sacar(100);
            bool sacar_conta2 = conta_lucas.Sacar(100);

            Console.WriteLine("A conta é do (a) " + conta_toddy.Titular + ", a agência é " + conta_toddy.Agencia
            + " e o número é " + conta_toddy.Numero+ " Saldo: " + conta_toddy.Saldo);
            
            Console.WriteLine("A conta é do (a) " + conta_pedro.Titular + ", a agência é " + conta_pedro.Agencia
            + " e o número é " + conta_pedro.Numero+ " Saldo: " + conta_pedro.Saldo);
            
            Console.WriteLine("A conta é do (a) " + conta_lucas.Titular + ", a agência é " + conta_lucas.Agencia
            + " e o número é " + conta_lucas.Numero + " Saldo: " + conta_lucas.Saldo);
        }
    }
}
