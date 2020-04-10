/*
*  -------------------------------------------------
* <copyright file="X.cs" company="IPCA"/>
* <summary>
*	LP2 - 2019-2020
* </summary>
* <date>3/28/2020 1:14:24 PM</date>
* <author>lufer</author>
* <email>lufer@ipca.pt</email>
* <desc>
*   Enumerados
*   Herança de Classes
* </desc>
* -------------------------------------------------
**/
using System;


namespace Heranca
{
    /// <summary>
    /// Enumerado para Resultado de Operação
    /// </summary>
    enum RES
    {
        OK=30,
        ESTASCA=-100,
        NAOCABES=100
    }

    /// <summary>
    /// enumerado para Profissão
    /// </summary>
    enum Profissao
    {
        PROF=100,
        FUNC,
        ALUN
    }

    class Pessoa
    {

        #region ESTADO
        int idade;
        string nome;
        string morada;
        DateTime dataNasc;
        protected Profissao prof;

        #endregion

        #region METODOS

        #region CONSTRUTORES
        //Métodos usados na criação de novos objectos

        /// <summary>
        /// Construtor com valores por defeito/omissão
        /// </summary>
        public Pessoa()
        {
            idade = -1;
            nome = "";
            prof = Profissao.FUNC;
        }

        /// <summary>
        /// Construtor com dados vindos do exterior
        /// Polimorfismo!
        /// </summary>
        /// <param name="i">Idade da Pessoa</param>
        /// <param name="n">Nome da Pessoa</param>
        public Pessoa(int i, string n)
        {
            idade = i;
            nome = n;
            prof = Profissao.ALUN;
        }

        /// <summary>
        /// Construtor com dados vindos do exterior
        /// Polimorfismo!
        /// </summary>
        /// <param name="nome">Nome da Pessoa</param>
        /// <param name="idade">Idade da Pessoa</param>
        public Pessoa(string nome, int idade)
        {
            this.idade = idade;
            this.nome = nome;
            prof = Profissao.ALUN;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idade">Idade da Pessoa</param>
        /// <param name="nome">Nome da Pessoa</param>
        /// <param name="p">Profissão da Pessoa</param>
        public Pessoa(int idade, string nome, Profissao p)
        {
            this.idade = idade;
            this.nome = nome;
            this.prof = p;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idade">Idade da Pessoa</param>
        /// <param name="nome">Nome da Pessoa</param>
        /// <param name="p">Profissão da Pessoa</param>
        public Pessoa(int idade, string nome, string mor)
        {
            this.idade = idade;
            this.nome = nome;
            this.morada = mor;
        }

        #endregion

        #region PROPRIEDADES
        //Métodos usados para manipular atributos do Estado

        /// <summary>
        /// Manipula o atributo "idade"
        /// int idade;
        /// </summary>
        public int Idade
        {
            get { return idade; }
            set { if (value > 0) idade = value; }
        }


        /// <summary>
        /// Manipula o atributo "nome"
        /// string nome;
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        /// <summary>
        /// Data de Nascimento
        /// </summary>
        public DateTime DataNasc
        {
            get { return dataNasc; }
            set
            {
                DateTime aux;
                if (DateTime.TryParse(value.ToString(), out aux) == true)
                {
                    dataNasc = value;
                }
            }
        }
        #endregion

        #region OPER
        public static bool operator ==(Pessoa x, Pessoa y)
        {
            return (x.Equals(y));
        }

        public static bool operator !=(Pessoa x, Pessoa y)
        {
            return (!(x==y));
        }
        #endregion

        #region OVERRIDES

        public override bool Equals(Object obj)
        {
            Pessoa aux = (Pessoa)obj;
            return (this.nome == aux.nome && aux.prof==this.prof); //completar!!!
        }


        public override string ToString()
        {
            return string.Format("Nome= {0} - Idade= {1}", Nome, Idade);
        }

        #endregion

        #region OUTROS

        /// <summary>
        /// Devolve apenas o dia de nascimento
        /// </summary>
        /// <returns></returns>
        //public int GetNasc()
        //{
        //    return (dataNasc.Day);
        //}

        public virtual int GetNasc()
        {
            return (dataNasc.Day);
        }

        #endregion

        #region DEST

        /// <summary>
        /// Destrutor
        /// </summary>
        ~Pessoa()
        {

        }
        #endregion

        #endregion



    }
}
