// -------------------------------------------------
// <copyright file="Pessoa.cs" company="IPCA">
// </copyright>
// <summary>
//	LP2 - 2019-2020
// </summary>
// <desc> Métodos static versus instância </desc>
//-------------------------------------------------
using System;


namespace Atletas
{
    /// <summary>
    /// Classe Pessoa possui também os dados (static)
    /// </summary>
    public class Pessoa
    {
        #region ESTADO

        int idade;
        string nome;
        string morada;
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
       
        #region PROPRIEDADES
        //Métodos usados para manipular atributos do Estado

        /// <summary>
        /// Manipula o atributo "idade"
        /// int idade;
        /// </summary>
        //public int Idade
        //{
        //    get { return idade; }
        //    set { if (value > 0) idade = value; }
        //}


        public int Idade
        {
            get => idade;
            set => idade = value;
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

        
        #region OVERRIDES

        public override bool Equals(Object obj)
        {
            return (this.nome == ((Pessoa)obj).nome);
        }

        public override string ToString()
        {
            return string.Format("Nome= {0} - Idade= {1}", Nome, Idade);
        }
        #endregion

        #region DESTR

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
