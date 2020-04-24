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
*   Utilização de Bibliotecas:
*       - Add Reference
*       - Using nomeLibrary
* </desc>
* -------------------------------------------------
**/

using System;
using Lib;          //biblioteca externa - Aula 10
using HerancaLib;   //biblioteca externa - Aula 8

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //classes da biblioteca externa
            //Biblioteca Lib

            //Calc c = new Calc();    //não se pode instanciar uma classe abstracta
            CalcPlus x = new CalcPlus();
            OutraCalc y = new OutraCalc();

            y.Soma(2, 3);
            x.Show("Uso de Bibliotecas:\n");
            
            Console.WriteLine("Soma: " + x.Soma(2, 3).ToString());

            //biblioteca HerancaLib

            Person p = new Person();
            Medico m = new Medico();
            Enfermeiro e = new Enfermeiro(12, "Manuel", "Geriatria");

            Console.WriteLine("Nome: " + e.nome);


            //-----

            User u = new User();
            Pessoa pes = new Pessoa();
            OutraPessoa c = new OutraPessoa();
            bool aux = u.Login(pes);
            aux = u.Login(c);

            //----

            ZZZ aux1 = new ZZZ();

            OutraII xx = new OutraII();
            OutraIII xxx = new OutraIII();


            aux1.F(xx, 23, 45);
            aux1.F(xxx, 23, 45);

            Console.ReadKey();
        }
    }
}
