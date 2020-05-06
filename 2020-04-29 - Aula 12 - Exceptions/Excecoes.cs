/*
 * LP2
 * Excecoes
 * Lidar com novas exceções
 * 2019-2020
 * lufer
 * */
using System;

namespace Excecoes
{
    /// <summary>
    /// Exception própria
    /// </summary>
    public class  DataInvalidaException : ApplicationException
    {
        public DataInvalidaException() : base("Data Inválida") 
        {
        }

        public DataInvalidaException(string s) : base(s) { }

        public DataInvalidaException(string s, Exception e)
        {
            //throw new Exception(e.Message + " - " + s);
            throw new DataInvalidaException(e.Message + " - " + s);
        }

    }
}
