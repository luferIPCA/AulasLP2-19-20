/*
lufer
*/

using System;
using System.Diagnostics;

namespace HerancaLib
{
    public class ProfSaude : Person
    {
        public int cod;
        public string nome;

        //public int idade;
        //public string espec;
        //public double salario;
        Sexo sexo;

        public ProfSaude(int z, string k) : base (k,12,"ola")
        {
            cod = z;
            nome = k;
            vencimento = 200;
            Debug.WriteLine("Dentro de PROFSAUDE II");
        }

        public ProfSaude()
        {
            Debug.WriteLine("Dentro de PROFSAUDE I");
            cod = 0;
            nome = "";
        }

        public virtual double GetVencimento()
        {
            return vencimento;
        }

        public override string ToString()
        {

            return base.ToString()+ "Ola";
        }

        public bool X()
        {
            return true;
        }
    }
}
