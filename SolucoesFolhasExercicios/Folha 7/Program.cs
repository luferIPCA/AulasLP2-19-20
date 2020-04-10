/*
 * lufer
 * Resolução da Folha de Exercícios nº7
 * */
using System;
using Fornecedor;
using Atletas;

namespace Folha7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Barcos

            Barco b1 = new Barco();
            b1.codBarco = 1;
            b1.nome = "Skif";
            b1.data = DateTime.Today;


            Clube c = new Clube();
            c.nome = "Benfica";
            c.fundado = DateTime.Today;
            c.RegistaBarcoClube(b1);

            Barcos barcos = new Barcos();
            barcos.fornecedor = "Nelo";
            barcos.RegistaBarco(b1);


            #endregion

            Console.ReadKey();
        }
    }
}
