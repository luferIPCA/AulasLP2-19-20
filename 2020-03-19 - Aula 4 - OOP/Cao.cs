//
// lufer
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    /// <summary>
    /// Descreve um cão...
    /// </summary>
    public class Cao
    {
        #region Atributos

        int idade;
        string nome;

        #endregion


        #region Comportamento

        public bool Ladra()
        {
            return true;
        }

            #endregion
    }


    public class Gato
    {
        #region Atributos

        int idade;
        string nome;

        #endregion


        #region Comportamento

        public bool Mia()
        {
            return true;
        }

        #endregion
    }
}
