using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IClube
    {
        string Nome
        {
            get;
            set;
        }

        int Ano
        {
            get;
        }

        bool FundadoEm(int ano);
    }


    public class Clube : IClube
    {
        string nome;
        int ano;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public bool FundadoEm(int ano)
        {
            return this.ano == ano;
        }
    }


    public abstract class ClubeBase
    {
        protected int numSocios;
        string presidente;

        public bool EPresidente(string p)
        {
            return (string.Compare(presidente, p) == 0);    //true | false
        }

        public abstract bool EClubeGrande();

        public abstract string GetNome(IPessoa p);

    }


    public class ClubeTotal : ClubeBase, IClube
    {
        string nome;
        int ano;

        //IClube

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public bool FundadoEm(int ano)
        {
            return this.ano == ano;
        }

        //ClubeBase
        public override bool EClubeGrande()
        {
            return numSocios > 6000000;
        }

        public override string GetNome(IPessoa p)
        {
            return p.GetNome();
        }
    }


    public interface IPessoa
    {
        string GetNome();
    }

    

   
}
