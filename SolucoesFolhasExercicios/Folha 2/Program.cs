/*
 * lufer
 * Soluções Folhas de Exercícios
 * */
using System;


namespace Folha2
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux;

            string data = "30-02-12";
            bool b;

            DateTime d1 = Resolucao.VerifyDate(data, out b);

            if (b == true)
            {
                Console.WriteLine("Data Valida inserida: " + d1.ToShortDateString());
            }
            else
            {
                Console.WriteLine("Data invalida : {0}", d1.ToShortDateString());
            }

            Console.ReadKey();


            Console.Write("Data: ");
            DateTime d = Resolucao.LeData();
            Console.WriteLine("Data inserida: " + d.ToShortDateString());


            Console.WriteLine("Inserir data entre " + DateTime.Today.ToShortDateString() + " e " + DateTime.Today.AddDays(10).ToShortDateString() + ":");
            d = Resolucao.LeDataValida(DateTime.Today, DateTime.Today.AddDays(10));
            Console.WriteLine("Data inserida: " + d.ToShortDateString());
            Console.ReadKey();
        }
    }
}
