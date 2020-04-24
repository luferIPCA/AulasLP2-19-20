/*
lufer

*/

using System;
using System.Diagnostics;

namespace HerancaLib
{
    public enum Sexo
    {
        MASC,
        FEM,
        HIB
    }

    public class Enfermeiro : ProfSaude
    {
        #region ATRIB
        public string especialidade;
        #endregion

        //public Enfermeiro(int c, string n, string p)
        //{
        //    base.cod = c;
        //    base.nome = n;
        //    pancada = p;
        //}


        public Enfermeiro(int c, string n, string p) : base(c,n)
        {
            especialidade = p;
            Debug.WriteLine("Dentro de ENFER");
        }

        public Enfermeiro(string p)
        {
            base.cod = 0;
            base.nome = "";

            especialidade = p;
        }

        public override double GetVencimento()
        {
            return 159;
        }

        public override string ToString()
        {
            return base.ToString() + "Pancada=" + especialidade;
        }

        public new bool X()
        {
            return false;
        }
    }
}


