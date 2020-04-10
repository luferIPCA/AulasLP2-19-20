//
// lufer
//

namespace Fornecedor
{
    public class Barcos
    {
        #region Member Variables
        const int MAX = 100;
        public string fornecedor;
        Barco[] bar;
        int tot;

        #endregion

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Barcos()
        {
            bar = new Barco[MAX];
        }

        #endregion

        #region Properties
        #endregion

        #region Functions
        public bool RegistaBarco(Barco b)
        {
            //Validações..
            bar[tot++] = b;
            return true;
        }

        public bool ExisteBarco(int cod)
        {
            //procurar..
            return true;
        }


        #endregion

        #region Enums
        #endregion
    }
}
