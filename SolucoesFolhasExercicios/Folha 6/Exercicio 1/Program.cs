/*
 * Resolução parcial da Folha de Exercícios VI
 * lufer
 * */
using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {

            BankAccount b = new BankAccount("t", 12345);
            Console.WriteLine("Saldo: " + b.Balance);

            b.MakeDeposit(1234, DateTime.Now.AddDays(2), "Poupança");
            b.MakeWithdrawal(10, DateTime.Now, "Despesa");

            Console.WriteLine("Saldo: " + b.Balance);

            Console.ReadKey();
        }
    }
}
