//
// lufer
// Manipular Métodos ou Funções
//

namespace _2020_03_13___Aula_3___Funções
{
    public class Metodos
    {
        #region Member Variables
        #endregion

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Metodos()
        {
        }

        #endregion

        #region Properties
        #endregion

        #region Functions

        /// <summary>
        /// Calcula o maior entre dois valors inteiros
        /// </summary>
        /// <param name="x">Valor 1</param>
        /// <param name="y">Valor 2</param>
        /// <returns></returns>
        public static int Maximo(int x, int y)
        {
            //if (x > y) 
            //    return x;
            //else
            //    return y;
            return (x > y ? x : y);
        }

        /// <summary>
        /// Calcula o Maximo e o Produtos dos valores em parametros
        /// usando parametro de saída: out
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="prod"></param>
        /// <returns></returns>
        public static int MaximoProduto(int x, int y, out int prod)
        {
            //int maximo = x > y ? x : y;
            //int produto = x * y;

            //prod = produto;

            prod = x * y;
            return (x > y ? x : y);

        }

        /// <summary>
        /// Calcula o dobro de uma valor passado como "referência"
        /// </summary>
        /// <param name="x"></param>
        public static void Dobro(ref int x)
        {
            x = x * 2;
            //return x; //não permite pois é void!!!
        }

        /// <summary>
        /// Calcula o somatório de um número variavel de valores
        /// </summary>
        /// <param name="valores">Conjunto de valores</param>
        /// <returns></returns>
        public static int Somatorio (params int[] valores)
        {
            int soma = 0;

            foreach(int i in valores)
            {
                soma += i;
            }
            return soma;
        }

        #endregion

        #region Enums
        #endregion
    }
}
