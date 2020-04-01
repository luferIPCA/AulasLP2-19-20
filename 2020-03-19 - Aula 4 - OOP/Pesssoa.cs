// -------------------------------------------------
// <copyright file="Pesssoa.cs" company="IPCA">
// </copyright>
// <summary>
//	LP2 - 2019-2020
// <desc>OOP, Construtores, Propriedades</desc>
// </summary>
//-------------------------------------------------

using System;

namespace OOP
{
    /// <summary>
    /// Classe que descreve uma Pessoa...
    /// </summary>
    class Pessoa
    {
        #region ESTADO
        int idade;
        string nome;
        DateTime dataNasc;
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
        }

        #endregion
        /*
         * Demonstra como implementar em JAVA
         * Métodos diferentes para cada ação
        */
        #region A_la_JAVA

        /// <summary>
        /// Define a idade da pessoa...
        /// </summary>
        /// <param name="i"></param>
        public void SetIdade(int i)
        {
            if (i > 0)
                idade = i;
        }
        /// <summary>
        /// Define a idade da pessoa por defeito
        /// </summary>
        public void SetIdade()
        {
                idade = 20;
        }

        /// <summary>
        /// Devolve a idade da pessoa...
        /// </summary>
        public int GetIdade()
        {
            return idade;
        }

        /// <summary>
        /// Devolve a idade da pessoa...controlada!
        /// </summary>
        /// <param name="perfil">Perfil do utilizador</param>
        /// <returns></returns>
        public int GetIdade(int perfil)
        {
            if (perfil > 100)
                return idade;
            else
                return -1;
        }

        #endregion

        /*
         * Demonstra como implementar em C#
         * Apenas um método suporta as duas ações
         * */
        #region PROPRIEDADES
        //Métodos usados para manipular atributos do Estado

        /// <summary>
        /// Manipula o atributo "idade"
        /// int idade;
        /// </summary>
        public int Idade
        {
            get { return idade; }
            set { if (value>0) idade = value; }
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


        //DateTime dataNasc;
        public DateTime DataNasc
        {
            get { return dataNasc; }
            set {
                DateTime aux;
                if (DateTime.TryParse(value.ToString(), out aux)==true){ 
                dataNasc = value;
                }
            }
        }
        #endregion

        #endregion

        #region OVERRIDES
        public override string ToString()
        {
            return "Idade: " + idade + " Nome:" + nome;
        }
        #endregion

        /// <summary>
        /// Destrutor
        /// </summary>
        ~Pessoa()
        {

        }

    }
}
