/*
 * lufer
 * lufer@ipca.pt
 * Interfaces
 * */

using System;
using System.Text;

namespace Lib
{

    /// <summary>
    /// Classe que descreve uma Pessoa e respeita o interface IPessoa
    /// </summary>
    public class Pessoa :  IPessoa
    {
        string nome;
        string userID;
        string passwd;

        public string Nome
        {
            get{return nome;}
            set{nome = value;}
        }

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public string GetUserId()
        {
            return "";
            //throw new NotImplementedException();
        }

        public string GetPass()
        {
            return "";
        }
        
    }

    /// <summary>
    /// Classe OutraPessoa que também implementa IPessoa
    /// </summary>
   public  class OutraPessoa : IPessoa
    {
        string nome;
        string userID;
        string passwd;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public string GetUserId()
        {
            return "";
        }

        public string GetPass()
        {
            return "";
        }
    }



    #region Heranca_Interface    

    /// <summary>
    /// Interface
    /// </summary>
    interface IUser
    {
        bool Login(IPessoa p);
    }

    /// <summary>
    /// Class que implementa IUser
    /// </summary>
    public class User: IUser
    {
        int x;
        public bool Login(IPessoa p)
        {
            //Pessoa p1 = (Pessoa)p;
            //OutraPessoa op1 = (OutraPessoa)p;

            if (p.GetType() == typeof(Pessoa)) { 
            //conversão explicita de tipos
            Pessoa p1 = (Pessoa)p;                
            }
            
            //ou
            if (p is Pessoa)
            {
                x = 3;
            }

            //Conversão de tipos
            //Coisa c = p as Coisa;
            //Coisa c1 = p as Pessoa;
            //Pessoa pp = (Pessoa)p;
            
            return String.IsNullOrEmpty(p.Nome);        //p.Nome == null || p.Nome == String.Empty;
        }

        //O mesmo que

        //public bool Login(Pessoa p)
        //{
        //    return String.IsNullOrEmpty(p.Nome);
        //}

        //public bool Login(Coisa c)
        //{
        //    return String.IsNullOrEmpty(c.Nome);
        //}

    }


    

    #endregion
}
