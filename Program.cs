// See https://aka.ms/new-console-template for more information
using System;

namespace ProjetoC
{
    class program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta_toddy = new ContaCorrente ("Toddy", 12345, 789, 10);
            ContaCorrente conta_pedro = new ContaCorrente ("Pedro", 653633, 234,1);
            ContaCorrente conta_lucas = new ContaCorrente ("Lucas", 7502, 756, -100);


            Console.WriteLine("A conta é do (a) " + conta_toddy.Titular + ", a agência é " + conta_toddy.Agencia
            + " e o número é " + conta_toddy.Numero);
            
            Console.WriteLine("A conta é do (a) " + conta_pedro.Titular + ", a agência é " + conta_pedro.Agencia
            + " e o número é " + conta_pedro.Numero);
            
            Console.WriteLine("A conta é do (a) " + conta_lucas.Titular + ", a agência é " + conta_lucas.Agencia
            + " e o número é " + conta_lucas.Numero);
        }
    }
}
