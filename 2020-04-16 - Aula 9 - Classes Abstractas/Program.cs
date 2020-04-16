/*
 * lufer
 * */
using System;

namespace Classes_Abstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            #region UM

            //Calculadora c = new Calculadora();      //não é permitido pois é abstrata

            BoaCalculadora aux = new BoaCalculadora();

            aux.X = 12;
            aux.Y = 13;
            Console.WriteLine("Soma: " + aux.Soma(12, 23).ToString());

            #endregion

            #region DOIS

            MyArrayBid aux1 = new MyArrayBid();
            MyArrayUni aux2 = new MyArrayUni();


            aux2.valores[0] = new Pessoa("ole");


            bool xx = aux1.Exist(new Pessoa());
            xx= aux2.Exist(new Pessoa("ole"));

            #endregion

            #region TRES

            ContaPoupanca c = new ContaPoupanca();

            c.Saldo = 1000;

            Console.WriteLine(c.Ok());

            c.Levantamento(20);

            Console.WriteLine("Saldo:" + c.Saldo.ToString());

            Console.ReadKey();

            #endregion
        }
    }
}
