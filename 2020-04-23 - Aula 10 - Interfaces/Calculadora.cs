/*
*	<copyright file="Hoje.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>4/23/2020 2:26:39 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hoje
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 4/23/2020 2:26:39 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public abstract class Calculadora
    {

        public Calculadora()
        {

        }

       public int Soma(int x, int y)
        {
            return x + y;
        }

        public abstract int Sub(int x, int y);
    }

    public class CalculadoraPronta : Calculadora
    {

        public override int Sub(int x, int y)
        {
            return x - y;
        }

        public int Mult(int x, int y)
        {
            return x * y;
        }

        //public abstract float Div(int x, int y);
    }
}
