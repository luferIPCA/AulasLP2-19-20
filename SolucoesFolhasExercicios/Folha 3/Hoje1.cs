//
// lufer
//
/*
 *  Declare, defina e inicialize um array de valores numéricos correspondentes a idades de pessoas.
    Armazene um conjunto de idades inseridas pelo teclado (valores positivos, maiores que 0 e inferiores a 100). 
    Mostre todas as idades inseridas
    Calcule a maior idade e a média das idades inseridas

 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Folha_3
{
    public class Hoje1
    {
        #region Member Variables

        int[] idades = new int[] { 23, 18, 19, 24, 33 };

        //Algoritmo:
        // 1º Passo : calcular a maior idade
        // 2º Passo : calcular a média

        #endregion

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Hoje1()
        {
        }

        #endregion

        #region Properties
        #endregion

        #region Functions

        /// <summary>
        /// Calcula a maior idade
        /// </summary>
        /// <param name="idades"></param>
        /// <returns></returns>
        public static int CalculaMaiorIdade(int[] idades)
        {
            int maior = idades[0];
            //for(int i=1;i<idades.Length; i++)
            //{
            //    if (maior < idades[i]) maior = idades[i];
            //}

            foreach(int i in idades)
            {
                if (maior < i) maior = idades[i];
            }

            return maior;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idades"></param>
        /// <returns></returns>
        public static float CalculaMediaIdades(int[] idades)
        {
            //O que acontece se o array tiver a dimensão 0?
            //NOTA: Testar se idades.Length>0

            int soma = 0;
            foreach(int i in idades)
            {
                soma += i;
            }

            //int a=2.0;
            //int b=3;
            //int c=a/b     //0.6666666667
            //c==0.666666667

            return ((float) soma / idades.Length);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idades"></param>
        /// <returns></returns>
        public static int CalculaMaiorEMedia(int[] idades, out float media)
        {
            media = CalculaMediaIdades(idades);
            return CalculaMaiorIdade(idades); 
        }

        #endregion

        #region Enums
        #endregion
    }
}
