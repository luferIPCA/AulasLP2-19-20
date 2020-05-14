/*
 * lufer
 * 
 * Camada de Dados | Data Layer
 * */
using Excepcoes;
using ObjetosNegocio;
using System.Collections.Generic;

namespace Dados
{
    public class Pessoas
    {
        private static List<Pessoa> todasPessoas;

        static Pessoas()
        {
            todasPessoas = new List<Pessoa>();
        }

        /// <summary>
        /// Insere nova pessoa
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool AddPessoa(Pessoa p)
        {
            try
            {
                if (todasPessoas.Contains(p)) return false;
                todasPessoas.Add(p);
            }
            catch (InsercaoException e)
            {
                throw e;
            }
            return true;
        }

        public static Pessoa GetPessoa(int p)
        {
            return null;
        }

        public static bool SaveAll()
        {
            return true;
        }

        public static bool LoadAll()
        {
            return true;
        }

    }
}
