/*
 * lufer
 * Resolução da Folha de Exercícios nº7
 * */
using System;
using Fornecedor;

namespace Aula8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Barcos

            Barco b1 = new Barco();
            b1.codBarco = 1;
            b1.nome = "Skiff";
            b1.data = DateTime.Today;

            Barcos barcos = new Barcos();
            barcos.fornecedor = "Nelo";
            barcos.RegistaBarco(b1);


            #endregion


            #region ClasseAB

            ClasseA ca = new ClasseA();
            ClasseB cb = new ClasseB();

            //cb.total = 2;


            #endregion

            Console.ReadKey();
        }
    }
}
