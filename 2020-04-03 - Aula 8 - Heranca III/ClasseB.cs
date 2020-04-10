//
// lufer
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula8
{
    public class ClasseB : ClasseAB
    {
        #region Member Variables
        //int idade;
        //int ano;
        //string nome;
        //string morada;
        DateTime contacto;
        protected int total;        //campo visivel apenas na herança

        #endregion

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public ClasseB()
        {
        }

        #endregion

        #region Properties
        #endregion

        #region Functions
        #endregion

        #region Enums
        #endregion
    }


    public class ClassBB : ClasseB
    {
        int x;

        public ClassBB()
        {
            total++;
        }
    }
}
