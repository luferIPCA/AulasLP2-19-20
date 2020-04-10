//
// lufer
// Folha 3: 
// Exercício 
//	3.1 - Declare, defina e inicialize um array de valores numéricos correspondentes a idades de pessoas.
//	3.2 - Armazene um conjunto de idades inseridas pelo teclado(valores positivos, maiores que 0 e inferiores a 100). 
//	3.3 - Mostre todas as idades inseridas
//  3.4 - Calcule a maior idade e a média das idades inseridas
// Algoritmo:
//  - Guardar todas as idades num array
//  - Calcular a maior idade
//  - Calcular a média das idades
//  H1:
//      - Calcular ao mesmo tempo o maior e a média
//  H2:
//      - Usar as funções CalculaMaior e CalculaMedia
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Folha_3
{
    public struct Varios
    {
        public int maiorIdade;
        public float mediaIdades;
    }

    public class Exercicio_3
    {
        #region Member Variables

        int[] idades = new int[] { 23, 24, 19, 18, 20, 21 }; //idades assumidas

        #endregion

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Exercicio_3()
        {
        }

        #endregion

        #region Properties
        #endregion

        #region Functions

        /// <summary>
        /// Calcula a idade mais velha...
        /// </summary>
        /// <param name="idades">conjunto de idades</param>
        /// <returns></returns>
        public static int CalculaMaisVelho(int[] idades)
        {
            int maiorIdade = idades[0];
            for(int i=1; i < idades.Length; i++)
            {
                if (idades[i] > maiorIdade) maiorIdade = idades[i];
            }
            return maiorIdade;
        }

        /// <summary>
        /// Calcula a Mèdia das idades
        /// </summary>
        /// <param name="idades"></param>
        /// <returns></returns>
        public static float CalculaMedidaIdades(int[] idades)
        {
            int soma = 0;
            for(int i=0; i<idades.Length; i++)
            {
                soma += idades[i];
            }
            // int a=2.0
            // int b=3
            // int c=a/b // 0,6666666666666667
            // c==0!!!

            //(float) x : Exemplo (float)50 -> 50.0
            float average = (float)soma / idades.Length;
            return average;

        }

        /// <summary>
        /// H1: Calcula a maior idade e a média de idades
        /// </summary>
        /// <param name="idades"></param>
        /// <returns></returns>
        public static Varios CalculaMaiorEMedia(int[] idades)
        {
            //Invariante: array tem de conter valores!!!
            //if (idades.Length>0)

            Varios resultados;
            int maiorIdade = idades[0];
            int somaIdades = idades[0];
            
            for (int i = 1; i < idades.Length; i++)
            {
                //Calcular a maior idade
                if (idades[i] > maiorIdade) maiorIdade = idades[i];
                //Calcular a soma das idades
                somaIdades += idades[i];
            }
            float mediaIdades = (float)somaIdades/idades.Length;

            //instanciar a struct
            resultados.maiorIdade = maiorIdade;
            resultados.mediaIdades = mediaIdades;

            //devolver a struct
            return resultados;

        }

        /// <summary>
        /// H2: Calcula a maior idade e a média de idades, usando
        /// as  funções que definimos antes
        /// </summary>
        /// <param name="idades"></param>
        /// <returns></returns>
        public static Varios CalculaMaiorEMediaII(int[] idades)
        {
            //Invariante: array tem de conter valores!!!
            //if (idades.Length>0)

            Varios resultados;
            //int maiorIdade;
            //float mediaIdades;

            //maiorIdade = CalculaMaisVelho(idades);
            //mediaIdades = CalculaMedidaIdades(idades);
            //instanciar a struct
            //resultados.maiorIdade = maiorIdade; 
            //resultados.mediaIdades = mediaIdades;

            resultados.maiorIdade = CalculaMaisVelho(idades);
            resultados.mediaIdades = CalculaMedidaIdades(idades);

            //devolver a struct
            return resultados;

        }



        #endregion

        #region Enums
        #endregion
    }
}
