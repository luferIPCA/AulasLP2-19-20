/*
*	<copyright file="Interfaces.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>4/23/2020 7:18:09 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 4/23/2020 7:18:09 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Pessoa  : IPessoa
    {
        protected int idade;

        public Pessoa()
        {
            idade = 12;
        }

        public Pessoa(int i)
        {
            //Testar
            idade = i;
        }

        public int Idade
        {
            get { return idade; }
            set { if (value > 0) idade = value; }
        }

        public virtual bool EMaiorIdade()
        {
            return idade > 18;
        }

        public string GetNome()
        {
            return "";
        }
    }



    public class PessoaII : IPessoa
    {
        int idade;
        public int Idade
        {
            get { return -1; }
            set {  idade = value; }
        }

        public string GetNome()
        {
            return "";
        }

    }

    
    public class Aluno : Pessoa, IAluno
    {
        int numAluno;

        public Aluno(int na, int id): base(id)
        {
            //idade = id;
            //Idade = id;
            numAluno = na;
        }

        public override bool EMaiorIdade()
        {
            return (Idade > 23);
        }


        public int X
        {
            get { return 1; }
            set { numAluno = value; }
        }
    }


    public abstract class Professor : Pessoa
    {
        int anoInicio;
        public abstract bool Doutorado();

        public int AnoInicio() 
        {
            return anoInicio;
        }
    }

    public class ProfessorAdjunto : Professor
    {
        DateTime inicio;
        string area;

        public ProfessorAdjunto() { }

        public override bool Doutorado()
        {
            return true;
        }
    }


    
}
