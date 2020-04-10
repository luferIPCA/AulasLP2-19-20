/*
 * Herança de Classes
 * 
 * Classe Base (classe Pai)
 * Classe Derivada  (classe Filho)
 * 
 * i)   Construtores não são herdados. Cada sub-classe tem de ter o seu construtor!
 * ii)  uso de "this" : utilizar método/atributo do objecto  corrente
 * iii) uso de "base":  utilizar método/atributo do Pai
 * iv)  uso de new: alerta compilador do interesse em esconder ("hidding") o método Pai
 * v)   uso de virtual: permite especialização de método (ou property) na classe derivada
 * vi)  sealed: classe que não pode ser derivada
 * 
 * Ref: C# Unleashed
 * 
 * lufer
 * */

using System.Diagnostics;

namespace HerancaLib
{

    /// <summary>
    /// Classe Base
    /// Define um Veiculo
    /// </summary>
    public class Veiculo
    {
        int numRodas;
        bool comMotor;

        #region PROPERTIES
        public int NumRodas
        {
            set { numRodas = value; }
            get { return numRodas; }
        }

        public bool ComMotor
        {
            set { comMotor = value; }
            get { return comMotor; }
        }

        #endregion

        #region CONST

        public Veiculo()
        {
            numRodas = 4;
            comMotor = true;

            Debug.WriteLine("Dentro do construtor Pai");
        }

        public Veiculo(string marca)
        {            
            numRodas = 4;
            comMotor = true;

            Debug.WriteLine("Dentro do construtor Pai: " + marca);
        }

        #endregion

        #region METHODS

        public void Print()
        {
            Debug.WriteLine("Sou um Veiculo");
        }

        public virtual void Print2(){
            Debug.WriteLine("Sou um Veiculo 2");
        }


        /// <summary>
        /// Protected Internal: só vista na hierarquia e dentro da bibliotecq
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        protected string SayHello(string s)
        {
            return "Hello " + s;
        }
        #endregion
    }
 
}
