//
// lufer
// Folha 2
// Exercício 3
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Folha2
{
      
    /// <summary>
    /// 3.	Implemente os seguintes métodos (explorar, se necessário, a classe DateTime):
    /// </summary>
    public class Resolucao
    {
        #region Member Variables
        #endregion

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Resolucao()
        {
        }

        #endregion

        #region Properties
        #endregion

        #region Functions
        /// <summary>
        /// a) Lê uma data apresentando a string do parâmetro
        /// </summary>
        /// <returns></returns>
        public static DateTime LeData()
        {
            String aux;
            DateTime d;
            bool b;

            aux = Console.ReadLine();   //ler a data...em string
            b = DateTime.TryParse(aux, out d);
            if (b==true) 
                return d;
            //se não inseriu uma data válida, devolve a data atual
            return DateTime.Today;
        }

        /// <summary>
        /// b.	LeDataValida: Lê uma data do teclado garantindo que essa data está entre o período de tempo pretendido
        /// Algoritmo:
        ///     1º - Ler uma data valida (posso usar o método LeData())
        ///     2º - Garantir que a data lida está entre d1 e d2
        /// </summary>
        /// <param name="d1">Data Inicio</param>
        /// <param name="d2">Data Fim</param>
        /// <returns></returns>
        public static DateTime LeDataValida(DateTime d1, DateTime d2) 
        {
            bool b;
            string aux;
            DateTime d;
            
            //Atenção: falta validar se d2>d1

            //1º Passo
            aux = Console.ReadLine();
            b = DateTime.TryParse(aux, out d);

            //d = LeData();

            //2º Passo
            if (b == true)
            {
                // d>=d1 && d <=d2
                // DateTime.Compare(d, d1) =0 se d==d1
                // DateTime.Compare(d, d1) >0 se d>d1
                // DateTime.Compare(d, d1) <0 se d< d1
                if (DateTime.Compare(d, d1) >= 0 && DateTime.Compare(d, d2) <= 0)
                    return d;
            }
            //se não inseriu uma data válida, devolve a data atual
            return 
                   DateTime.Today;
        }

        /// <summary>
        /// Verifica se uma data é válida.
        /// Devolve true e a data inserida caso seja uma data válida
        /// Devolve falso, caso contrário!
        /// </summary>
        /// <param name="s"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static DateTime VerifyDate(string s, out bool x)
        {
            DateTime aux;
            bool b;

            b = DateTime.TryParse(s, out aux);
            //if (b == true)
            //{
            //    x = b;
            //    return (aux);
            //}
            //else
            //{
            //    x = b;
            //    return (aux);
            //}
            x = b;
            return aux;

        }


        #endregion

        #region Enums
        #endregion


    }
}
