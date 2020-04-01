//
// lufer
// Descreve um Carro
//

namespace Aula_5___Static
{
    public class Carro
    {
        #region Member Variables

        string matricula;

        #endregion

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Carro()
        {
            matricula = "";
        }

        public Carro(string m)
        {
            matricula = m;
        }

        #endregion

        #region Properties

        public string Matricula
        {
            //get => matricula;
            //set => matricula = value;
            get { return matricula; }
            set { matricula = value; }
        }

        #endregion

        #region Functions

        #endregion

        #region Enums
        #endregion
    }
}
