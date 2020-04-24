/*
*  -------------------------------------------------
* <copyright file="Supervisor.cs" company="IPCA"/>
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
    class Supervisor : Gestor
    {
        double premio;

        public Supervisor()
        {
            premio = 0;
        }

        public Supervisor(int p, string n, double v, bool a)
            : base(n, v, a)
        {
            premio = p;
        }

        public override void ShowData()
        {
            base.ShowData();
            Console.WriteLine("Premio=" + premio);
        }
    }

}
