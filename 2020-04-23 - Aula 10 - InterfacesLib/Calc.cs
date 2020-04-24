/*
*  -------------------------------------------------
* <copyright file="Calc.cs" company="IPCA"/>
* <summary>
*	LP2
* </summary>
* <date></date>
* <author>lufer</author>
* <email>lufer@ipca.pt</email>
* <desc>
*   Herança de Classes
*   Interfaces
*   Classes Abstractas
*   Biblioteca (library) de classes
* </desc>
* -------------------------------------------------
**/
using System;

namespace Lib
{
    /// <summary>
    /// Class abstracta pois tem métodos abstractos
    /// Não permite instanciar objectos
    /// </summary>
    public abstract class Calc
    {
        /// <summary>
        /// Calcula a Soma de dois valores inteiros
        /// </summary>
        /// <param name="x">Valor 1</param>
        /// <param name="y">valor 2</param>
        /// <returns></returns>
        public int Soma(int x, int y)
        {
            return (x + y);
        }

        /// <summary>
        /// método abstracto obriga a classe a ser abstracta
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public abstract int Sub(int x, int y);
    }
}
