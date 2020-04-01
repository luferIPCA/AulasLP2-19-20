// -------------------------------------------------
// <copyright file="Pessoas.cs" company="IPCA">
// </copyright>
// <summary>
//	LP2 - 2019-2020
// </summary>
//-------------------------------------------------

namespace Aula_5___Static
{
    enum RES
    {
        OK = 30,
        ESTASCA = -100,
        NAOCABES = 100
    }


    /// <summary>
    /// Descreve a classe Pessoas.
    /// Possui dados referentes a várias pessoas!
    /// </summary>
    class Pessoas
    {
        #region ATRIBUTOS
        const int MAX = 10;
        static Pessoa[] pess;// = new Pessoa[MAX];
        static int numPess = 0;
        #endregion

        #region METODOS

        #region CONST
        /// <summary>
        /// Construtor de classe
        /// </summary>
        static Pessoas()
        {
            pess = new Pessoa[MAX];
        }
        #endregion

        /// <summary>
        /// Verifica se determinada pessoa existe
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static bool ExistePessoa(string nome)
        {
            for (int i = 0; i < numPess; i++)
            {
                if (pess[i].Nome.CompareTo(nome) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Regista uma nova pessoa
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static int InserePessoa(Pessoa p)
        {
            //Testar se está cheio
            if (numPess >= MAX) return 0;
            //testar se já existe; 
            if (GetPessoa(p.Idade) != null) return 0;
            //ou
            //if (totPessoas >= MAX || GetPessoa(p.Idade) != null) return 0;

            pess[numPess++] = p;
            return 1;
        }

        /// <summary>
        /// Tenta registar nova pessoa e devolve o resultado da operação
        /// </summary>
        /// <param name="p">Nova pessoa</param>
        /// <returns>Estado da Operação</returns>
        public static RES InserePessoaRes(Pessoa p)
        {
            //Testar se está cheio
            if (numPess >= MAX) return RES.NAOCABES;
            //testar se já existe; 
            if (ExistePessoa(p.Nome)) return RES.ESTASCA;

            pess[numPess++] = p;
            return RES.OK;
        }

        /// <summary>
        /// Procura a ficha de determinada pessoa ...
        /// </summary>
        /// <param name="id">Nome da pessoa</param>
        /// <returns>Ficha da Pessoa</returns>
        public static Pessoa GetPessoa(int id)
        {
            for (int i = 0; i < numPess; i++)
            {
                if (pess[i].Idade == id) return pess[i];
            }
            return null;
        }

        /// <summary>
        /// Verifica se uma pessoa existe. Se existir devolve a Ficha da Pessoa
        /// </summary>
        /// <param name="nome">Nome da Pessoa</param>
        /// <returns></returns>
        public static Pessoa WhereIs(string nome)
        {
            for (int i = 0; i < numPess; i++)
            {
                if (pess[i].Nome.CompareTo(nome) == 0)
                {
                    return pess[i];
                }
            }
            return null;
        }
       
        #endregion

    }
}
