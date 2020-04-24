using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    //----------------------------------------------------------------------------

    /// <summary>
    /// Outro Interface
    /// </summary>
    interface IRandomNumberGen
    {
        int GetNextNumber();
    }

    //----------------------------------------------------------------------------

    /// <summary>
    /// Interface para calculadora
    /// </summary>
    public interface ICalculadora
    {
        int Soma(int x, int y);
        int Abs(int x);
    }
}
