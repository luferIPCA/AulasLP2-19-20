using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula8
{

    public enum Especialidade
    {
        CIRURGIAO,
        CARDIO,
        PEDIAT
    }

    public class Pessoa
    {
        public string nome;
        int idade;


        public Pessoa(string n, int i)
        {
            nome = n;
            idade = i;
        }

    }

    public class Medico : Pessoa
    {
        Especialidade area;
        int codMedico;
        Infetado[] doentes;

        public Medico(string nome, int idade, Especialidade esp, int cod) : base(nome, idade)
        {
            area = esp;
            codMedico = cod;
        }

        public Especialidade Area
        {
            get { return area; }
            set { area = value; }
        }

    }

    public class Infetado : Pessoa
    {
        DateTime infecao;
        int codMedico;
        Infecao[] doencas;

        /*List<Infecao> doencasII;*/

        int totDoencas = 0;

        public int CodMedico
        {
            get;
            set;
        }

        public Infecao this[int i]
        {
            get {return doencas[i]; }
            set { doencas[i] = value; totDoencas++; /*doencasII.Add(value);*/ }
        }


        public Infetado(string n, int i) : base(n, i) { }


        public bool AddInfecao(Infecao i)
        {
            //ATENçÂO: Validações
            doencas[totDoencas++] = i;
            return true;
        }
    }


    public class Doente : Pessoa
    {
        int numDoente;  //SNS
        EpisodioClinico[] processoClinico;
        int codHospital;                        //hospital onde o doente foi atentido

        public Doente(string n, int i) : base(n, i) { }


        #region PCLINICO

        //Add
        //Cons

        #endregion
    }

    public class Hospital
    {
        int codHospital;
        string nome;
    }

    public class EpisodioClinico
    {
        int n;
    }

    public class Infecao
    {
        public string nome;
    }
}