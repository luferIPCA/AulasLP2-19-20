/*
*  -------------------------------------------------
* <copyright file="Docente.cs" company="IPCA"/>
* <summary>
*	LP2 - 2019-2020
* </summary>
* <date>03/27/2019 5:14:28 PM</date>
* <author>lufer</author>
* <email>lufer@ipca.pt</email>
* <desc></desc>
* -------------------------------------------------
**/

namespace Heranca
{
    /// <summary>
    /// Docente herda de Pessoa
    /// </summary>
    class Docente : Pessoa
    {
        public string areaCient;

        public Docente()
        {
            areaCient = "INF";

        }
        
        public Docente(string n, string areaC): base(1,n)
        {
            //base.Nome = n;
            areaCient = areaC;
        }

        public override int GetNasc()
        {
            return base.DataNasc.Year;
        }
    }
}
