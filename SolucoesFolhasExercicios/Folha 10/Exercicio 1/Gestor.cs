/*
*  -------------------------------------------------
* <copyright file="Gestor.cs" company="IPCA"/>
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
    class Gestor : Empregado
    {
        private bool assalariado;

        //Construtor

        public Gestor() { }

        public Gestor(string n, double v, bool b) : base(n, v)
        {
            assalariado = b;
        }

        //Properties
        public bool Assalariado
        {
            get { return assalariado; }
            set { assalariado = value; }
        }
        //Métodos
        public override double CalcSalario(int horas)
        {
            if (assalariado) return custoHora;
            return (horas * custoHora);
        }

        public virtual void ShowData()
        {
            Console.WriteLine("Nome: " + base.Nome);
            Console.WriteLine("Assalariado: " + this.assalariado);
            Console.WriteLine("Valor:" + CalcSalario(3));

        }
    }

}
