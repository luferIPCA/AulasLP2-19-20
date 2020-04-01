//
// lufer
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    public class Veiculo
    {
        #region Member Variables
        #endregion

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Veiculo()
        {
        }

        /// <summary>
        /// Destructor
        /// </summary>
        ~Veiculo() { }

        #endregion

        #region Properties
        #endregion

        #region Functions
        public virtual void CheckList() { }
        public virtual void Adjust() { }
        public virtual void Cleanup() { }

        #endregion

        #region Enums
        #endregion
    }
}
