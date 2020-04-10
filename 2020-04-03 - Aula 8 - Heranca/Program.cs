/*
 * Enumerados: GetNames | GetValues
 * 
 * Herança de Classes
 * 
 * Classe Base (classe Pai)
 * Classe Derivada  (classe Filho)
 * 
 * i)   Construtores não são herdados. Cada sub-classe tem de ter o seu construtor!
 * ii)  uso de "this" : utilizar método/atributo do objecto  corrente
 * iii) uso de "base":  utilizar método/atributo do Pai
 * iv)  uso de new: alerta compilador do interesse em esconder ("hidding") o método Pai
 * v)   uso de virtual: permite especialização de método (ou property) na classe derivada
 * vi)  sealed: classe que não pode ser derivada
 * 
 * Ref: C# Unleashed
 * Explorar exemplos de https://msdn.microsoft.com/en-us/library/ms173153.aspx
 * lufer
 * */

using System;
using HerancaLib;
using LibExterna;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ENUMERADOS

            Pessoa p1 = new Pessoa(12, "ola", Profissao.FUNC);

            #region Enumerados - ANALISAR

            Console.WriteLine("------ Enumerados Profissão ------");
            foreach (int p in Enum.GetValues(typeof(Profissao)))
            {
                Console.WriteLine(p + "= " + ((int)p).ToString());

            }

            foreach (string s in Enum.GetNames(typeof(Profissao)))
            {
                Console.WriteLine(s);
            }

            #endregion

            #endregion

            #region INDEXADORES

           

            LibExterna.Pessoas pes = new LibExterna.Pessoas();

            pes[0] = new LibExterna.Pessoa(12, "ola");

            #endregion


            #region HERANÇA I

            p1 = new Pessoa();
            
            Aluno a1 = new Aluno();     //1º new Pessoa - 2º new Aluno

            Aluno a2 = new Aluno(12, "ola", DateTime.Today, 12, "Morada");

            a2.GetNasc();       //devolve o Month

            p1.GetNasc();       //devolve Day

            Docente d1 = new Docente("ola", "Matematica");
            d1.GetNasc();       //Devolve Year

            
            Console.WriteLine("Data: " +a1.DataNasc);

            #endregion


            #region HERANÇA II

            BaseClass bc = new BaseClass("ola");
            
            Console.WriteLine("BC= " + bc.ToString());

            bc.Method1();
            bc.Method2();
            bc.Method3();

            DerivedClass dc =  new DerivedClass("ole",12);

            dc.Method1();
            dc.Method2();
            dc.Method3();
            dc.Method4();

            BaseClass dc1 = new DerivedClass();  //o que acontece?

            dc1.Method2();
            //DerivedClass xx = new BaseClass(); //o que acontece?

            #endregion

            Console.ReadKey();

        }
    }
}
