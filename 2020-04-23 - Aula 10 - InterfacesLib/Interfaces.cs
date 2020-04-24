/*
*  -------------------------------------------------
* <copyright file="Calc.cs" company="IPCA"/>
* <summary>
*	LP2 
* </summary>
* <date></date>
* <author>lufer</author>
* <email>lufer@ipca.pt</email>
* <desc>
*   Herança de Classes
*   Interfaces
*   Classes Abstractas
* </desc>
* -------------------------------------------------
**/


namespace Lib
{
    /// <summary>
    /// Iterface: apenas apresenta assinaturas de métodos!
    /// </summary>
    public interface ICalc
    {
        int Soma(int x, int y);
        int Sub(int x, int y);
        int Prod(int x, int y);
    }

    /// <summary>
    /// Outro Interface
    /// </summary>
    public interface IStr
    {
        void Show(string s);
    }
}
