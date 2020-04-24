/*
*  -------------------------------------------------
* <copyright file="Abstract.cs" company="IPCA"/>
* <summary>
*	LP2 
* </summary>
* <date></date>
* <author>lufer</author>
* <email>lufer@ipca.pt</email>
* <desc>
*   Classes Abstractas
* </desc>
* -------------------------------------------------
**/

namespace Lib
{
    /// <summary>
    /// classe abstracta; método GetArea por implementar!!! 
    /// </summary>
    public abstract class Areas
    {
        public Areas() { }
        public abstract double GetArea();
    }

    /// <summary>
    /// Classe que concretiza a classe abstracta Areas...para o caso de um Quadrado
    /// </summary>
    public class Quadrado : Areas
    {
        int lado;
        public Quadrado(int n)
        {
            lado = n;
        }
        public override double GetArea()
        {
            return lado * lado;
        }
    }

    /// <summary>
    /// Classe que concretiza a classe abstracta Areas...para o caso de um Triangulo
    /// </summary>
    public class Triangulo : Areas
    {
        int b;
        int h;

        public Triangulo(int b, int h)
        {
            this.b = b;
            this.h = h;
        }

        public override double GetArea()
        {
            return b * h / 2;
        }
    }
}
