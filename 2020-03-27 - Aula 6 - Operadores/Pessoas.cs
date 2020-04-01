//-----------------------------------------------------------------------
// <copyright file="Pessoas.cs" company="IPCA">
//     Copyright IPCA. All rights reserved.
// </copyright>
// <date>2020</date>
// <author>lufer</author>
// <email>lufer@ipca.pt</email>
// <version></version>
// <desc>Overloading de Operadores</desc>
//-----------------------------------------------------------------------

namespace LibExterna
{

    /// <summary>
    /// Classe que descreve um conjunto de pessoas....
    /// </summary>
    public class Pessoas
    {
        #region ATR

        const int MAX = 10;
        static Pessoa[] ps;
        static int totPessoas;

        #endregion

        #region MET
        
        #region CONST
        /// <summary>
        /// Construtor de classe
        /// </summary>
        static Pessoas()
        {
            ps = new Pessoa[MAX];
        }
        #endregion

        /// <summary>
        /// Registar uma nova pessoa
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static int InserePessoa(Pessoa p)
        {
            Pessoa p1 = new Pessoa(12, "ola");
            Pessoa p2 = new Pessoa(12, "ola");

            if (p1 != p2) { }
            if (p1.Equals(p2)) { }

            X aux1 = new X();
            X aux2 = new X();

            if (aux1 == aux2) { }

            if (aux1.Equals(aux2)) { }



            //Testar se está cheio
            if (totPessoas >= MAX) return 0;
            //testar se já existe; 
            if (GetPessoa(p.Idade) != null) return 0;
            //ou
            //if (totPessoas >= MAX || GetPessoa(p.Idade) != null) return 0;

            ps[totPessoas++] = p;
            return 1;
        }

        /// <summary>
        /// Procura se determinada pessoa existe
        /// </summary>
        /// <param name="id">Nome da pessoa</param>
        /// <returns>Ficha da Pessoa</returns>
        public static Pessoa GetPessoa(int id)
        {
            for(int i=0; i<totPessoas; i++)
            {
                if (ps[i].Idade == id) return ps[i];
            }
            return null;
        }

        #endregion

    }


}
