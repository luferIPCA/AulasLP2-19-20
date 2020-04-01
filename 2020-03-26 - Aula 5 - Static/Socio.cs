//
// lufer
// Gestão de Sòcios de um Clube
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula_5___Static
{
    public class Socio
    {
        #region Member Variables

        string nome;
        int numSocio;

        static int totalSocios;     //valor "global"

        #endregion

        #region Constructors

        /// <summary>
        /// Executado "pelo programa"
        /// </summary>
        static Socio()
        {
            totalSocios = 0;
        }

        /// <summary>
        /// Executado quando fizer "new"
        /// </summary>
        public Socio()
        {
            totalSocios++;
            nome = "";
            numSocio = totalSocios;
        }

        /// <summary>
        /// Executado quando fizer "new"
        /// </summary>
        /// <param name="n"></param>
        public Socio(string n)
        {
            totalSocios++;
            nome = n;
            numSocio = totalSocios;
        }
        #endregion

        #region Properties

        public int NumSocio
        {
            get { return numSocio; }
            set { numSocio = value; }     //Para evitar que seja alterado do exterior!!!
        }
        #endregion

        #region Functions

        #region Operadores

        public static bool operator ==(Socio s1, Socio s2)
        {
            //return ((s1.numSocio == s2.numSocio) && String.Compare(s1.nome,s2.nome)==0);
            return (s1.Equals(s2));
        }

        public static bool operator !=(Socio s1, Socio s2)
        {
            return (!(s1 == s2));
        }

        public static bool operator >(Socio s1, Socio s2)
        {
            return true;

        }

        public static bool operator <(Socio s1, Socio s2)
        {
            return true;
        }

        /// <summary>
        /// Override de Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Socio aux = (Socio)obj;
            return ((this.numSocio == aux.numSocio) && String.Compare(this.nome, aux.nome) == 0);
            //return (this.nome == ((Socio)obj).nome);
        }


        #endregion
        #endregion

        #region Enums
        #endregion
    }
}
