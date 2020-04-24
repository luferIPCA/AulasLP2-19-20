/*
*  -------------------------------------------------
* <copyright file="Program.cs" company="IPCA"/>
* <summary>
*	LP2 
* </summary>
* <date></date>
* <author>lufer</author>
* <email>lufer@ipca.pt</email>
* <desc></desc>
* -------------------------------------------------
**/

using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Empregado x = new Empregado("Manuel", 12);
            Gestor y = new Gestor("Jorge", 1200, true);

            y.ShowData();

            Supervisor s = new Supervisor(200, "Ana", 1200, false);
            s.ShowData();
            Console.ReadKey();

        }
    }
}
