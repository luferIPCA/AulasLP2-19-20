/*
*  -------------------------------------------------
* <copyright file="Aluno.cs" company="IPCA"/>
* <summary>
*	LP2 - 2019-2020
* </summary>
* <date>3/28/2020 10:35:05 AM</date>
* <author>lufer</author>
* <email>lufer@ipca.pt</email>
* <desc> 
*   Herança de Classes
*   this
*   base
*   virtual/new
*   protected
* </desc>
* -------------------------------------------------
**/

using System;

namespace Heranca
{
    /// <summary>
    /// Aluno herda de Pessoa
    /// </summary>
    class Aluno : Pessoa
    {
        public int numAluno;            //atenção ao public
        public DateTime inicioCurso;    //atenção ao public

        #region CONST

        public Aluno() {
            Nome = "Ok";                //da classe Pessoa
            Idade = 12;                 //da classe Pessoa
        }
        ////public Aluno(int na, string nome, DateTime dn, int idade)
        //{
        //    numAluno = na;
        //    inicioCurso = new DateTime(2018, 06, 12);
        //    base.DataNasc = dn;     //base - classe Pai
        //    base.Idade = idade;
        //}

        public Aluno(int na, string nome, DateTime dn, int idade, string mora) : base (idade,nome,mora)
        {
            numAluno = na;
            inicioCurso = new DateTime(2018, 06, 12);
        }
        #endregion

        //public new int GetNasc()
        //{
        //    //base.prof = Profissao.ALUN; //acesso a Protected
        //    return base.DataNasc.Month; //Reescreve devolvendo o mês
        //}



        public override int GetNasc()
        {
            return DataNasc.Month;
        }

        //public new int GetNasc()
        //{
        //    return (base.DataNasc.Month);
        //}

    }
}
