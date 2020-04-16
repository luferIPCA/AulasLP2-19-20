/*
 * lufer
 * lufer@ipca.pt
 * Classes Abstractas
 * */


namespace Classes_Abstractas
{
    /// <summary>
    /// Classe abstrata para uma Calculadora
    /// </summary>
    abstract class Calculadora  
    {        

        /// <summary>
        /// propriedade abstrata
        /// </summary>
        public abstract int X
        {
            get;
            set;
        }

        //metodo abstrato
        public abstract int Soma(int a, int b);

        /// <summary>
        /// Implementa a Subtração de dois números
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Sub(int x, int y)
        {
            return (x - y);
        }


    }




    /// <summary>
    /// Classe concreta: implementa a classe abstracta
    /// </summary>
    class BoaCalculadora : Calculadora
    {
        int x, y;

        /// <summary>
        /// Propriedade herdada
        /// </summary>
        public override int X
        {
            get { return x; }
            set { x = value; }
        }

        /// <summary>
        /// Nova propriedade
        /// </summary>
        public int Y
        {
            get { return y; }
            set { if (value > 0) y = value; }
        }

        public override int Soma(int x, int y)
        {
            return x + y;
        }

    }


    interface ICalc
    {
        int Soma(int x, int y);
        int Mul(int x, int y);
    }

    interface ICalcPlus : ICalc
    {
        int Fact(int x);
    }


    //class X : ICalcPlus
    //{

    //}
    
}


