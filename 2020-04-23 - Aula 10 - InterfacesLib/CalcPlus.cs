/*
*  -------------------------------------------------
* <copyright file="CalcPlus.cs" company="IPCA"/>
* <summary>
*	LP2
* </summary>
* <date></date>
* <author>lufer</author>
* <email>lufer@ipca.pt</email>
* <desc>
*   Biblioteca (library) de classes
* </desc>
* -------------------------------------------------
**/
using System;

namespace Lib
{
    /// <summary>
    /// Classe que implementa o Interface ICalc
    /// </summary>
    public class OutraCalc : ICalc
    {
        public int Soma(int x, int y)
        {
            return (x * 2 - y);
        }
        public int Prod(int x, int y)
        {
            return (x * y);
        }
        public int Sub(int x, int y)
        {
            return (x - y);
        }
    }

    /// <summary>
    /// Classe que :
    ///     - Completa a classe abstracta Calc 
    ///     - Implementa o Interface IStr
    /// </summary>
    public class CalcPlus : Calc, ICalc, IStr
    {
        public override int Sub(int x, int y)
        {
            return (x - y);
        }

        public int Prod(int x, int y)
        {
            return (x * y);
        }

        public void Show(string s)
        {
            Console.Write(s);
        }
    }

    

    /// <summary>
    /// Usar Interfaces como parâmetros de métodos
    /// </summary>
    public class Generica
    {
        /// <summary>
        /// Método F recebe como parâmetro qualquer objecto de classe que
        /// implementa o interface ICalc....pode ser OutraCalc ou CalcPlus
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public int F(ICalc c)
        {
            return (c.Soma(2, 3));
        }
    }
}
