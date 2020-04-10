//
// lufer
//
using Fornecedor;
using Atletas;
using System;

namespace Folha7
{
    public class Clube
    {
        #region Member Variables
        public string nome;
        public DateTime fundado;
        //h1
        //Atleta[] atletas;
        //int totAtletas = 0;

        Atletas atl;

        Barcos barcos;
        //Atletas;
        #endregion

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Clube()
        {
            barcos = new Barcos();

        }

        #endregion

        #region Properties

        public string Nome
        {
            get;
            set;
        }
        #endregion

        #region Functions

        public bool RegistaBarcoClube(Barco c)
        {
            //Validações
            if (barcos.ExisteBarco(c.codBarco)==false)
                barcos.RegistaBarco(c);
            return true;
        }


        public bool RegistaAtletaClube(Atleta a)
        {
            if (atl.ExisteAtleta(a.Nome) == true) return false;
            atl.InsereAtleta(a);
            return true;
        }

        //#region GEREATLETAS

        ////public bool InsereAtleta(Atleta a)
        ////{
        ////    //Validações
        ////    atletas[totAtletas++] = a;
        ////    return true;
        ////}

        //#endregion

        #endregion

        #region Enums
        #endregion
    }

    public class Atletas
    {
        Atleta[] atletas;
        int totAtletas = 0;


        public bool InsereAtleta(Atleta a)
        {
            //Validações
            atletas[totAtletas++] = a;
            return true;
        }

        public bool ExisteAtleta (string n)
        {
            foreach(Atleta a in atletas)
            {
                if (a.Nome==n) return true;
            }
            return false;
        }

    }
}
