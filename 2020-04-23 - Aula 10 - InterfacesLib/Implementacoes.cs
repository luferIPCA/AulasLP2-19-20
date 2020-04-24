
/*
 * lufer
 * lufer@ipca.pt
 * Interfaces
 *      - Métodos são public por omissão. Privates não são permitidos!
 *      - Não podem conter atributos nem implementações. Só assinaturas
 *      - Só: Métodos, Indexadores, Propriedades, Eventos
 *      - Pode herdar de outros interfaces
 * */

using System;
using System.Text;

namespace Lib
{
    /// <summary>
    /// Classe que implementa o interface IRandomNumberGen
    /// </summary>
    class Implementacoes : IRandomNumberGen
    {
        public int GetNextNumber()
        {
            return 1;
        }

    }

    //----------------------------------------------------------------------------

    /// <summary>
    /// Implementa vários interfaces
    /// </summary>
    public class OutraII : IRandomNumberGen, ICalculadora
    {
        /// <summary>
        /// Gerar números aleatórios entre 0 e um máximo
        /// </summary>
        /// <returns></returns>
        public int GetNextNumber()
        {
            Random random = new Random();
            return random.Next(100);
        }
        /// <summary>
        /// Gerar números aleatórios entre dois valores
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public int GetNextNumber(int min, int max)
        {
            return (new Random().Next(min, max));
        }

        /// <summary>
        /// Método de ICalculadora
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Soma(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Calcula o valor absoluto
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int Abs(int x)
        {
            return ((x < 0) ? (-1 * x) : x);
        }
    }



    public class OutraIII : IRandomNumberGen, ICalculadora
    {
        /// <summary>
        /// Gerar números aleatórios entre 0 e um máximo
        /// </summary>
        /// <returns></returns>
        public int GetNextNumber()
        {
            Random random = new Random();
            return random.Next(100);
        }

        /// <summary>
        /// Gerar números aleatórios entre dois valores
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public int GetNextNumber(int min, int max)
        {
            return (new Random().Next(min, max));
        }

        /// <summary>
        /// Método de ICalculadora
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Soma(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Calcula o valor absoluto
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int Abs(int x)
        {
            return ((x < 0) ? (-1 * x) : x);
        }
    }

    public class ZZZ
    {
        public int F(ICalculadora x, int a, int b)
        {                       
            return x.Soma(a, b);
        }
    }
}
