//
// lufer
// Descreve uma Garagem de Carros
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula_5___Static
{
    public class CarrosII
    {
        #region Member Variables

        const int MAXLUGARESPARQUE = 100;
        static Carro[] garagem;
        static int totCarrosEstacionados;

        #endregion

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        static CarrosII()
        {
            garagem = new Carro[MAXLUGARESPARQUE];
            totCarrosEstacionados = 0;
        }

        //static CarrosII(int numeroLugaresGaragem)
        //{
        //    if (numeroLugaresGaragem > MAXLUGARESPARQUE)
        //        numeroLugaresGaragem = MAXLUGARESPARQUE;
        //    garagem = new Carro[numeroLugaresGaragem];      //CUIDADO com o Maximo
        //    totCarrosEstacionados = 0;
        //}

        #endregion

        #region Properties
        #endregion

        #region Functions

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool EstacionaCarro(Carro c)
        {
            //Verificar se o Pareque não está cheiro!
            //Verificar se o carro ainda não está estacionado
            garagem[totCarrosEstacionados] = c;
            totCarrosEstacionados++;
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mat"></param>
        /// <returns></returns>
        public static int CarroEstacionado(string mat)
        {
            //Percorrer a garagem à procura dessa matricula
            //Percorrer até analisar todos os carros estacionados (totCarrosEstacionados)
            //Percorrer até o encontrar
            return -1;
        }
        #endregion

        #region Enums
        #endregion
    }
}
