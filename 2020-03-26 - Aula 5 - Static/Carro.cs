//
// lufer
// Descreve um Carro
//

using System;

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

        #region Overrides

        public override string ToString()
        {
            return "Matricula: " + matricula;
        }


        /// <summary>
        /// Compare dois Carros
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Carro aux = (Carro)obj;
            return (String.Compare(aux.matricula,this.matricula)==0);
        }



        #endregion

        #region Operadores
        public static bool operator ==(Carro c1, Carro c2)
        {
            return (c1.Equals(c2));
        }

        public static bool operator !=(Carro c1, Carro c2)
        {
            //return (!c1.Equals(c2));
            return (!(c1==c2));
        }

        #endregion
    }
}
