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
    /// Classe Derivada
    /// Define uma Carro como sendo Veiculo
    /// </summary>
    public class Carro : Veiculo
    {
        #region ESTADO
        double cilindrada;
        string marca;

        #endregion

        #region PROPERTIES

        public double Cilindrada
        {
            get { return cilindrada; }
            set { cilindrada = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        #endregion

        #region CONSTRUTORES

        public Carro() : this(4)
        {
            this.cilindrada = 1200;
            Debug.WriteLine("Dentro do construtor Filho");
        }

        public Carro(string marca)//construtor pai que receb uma string
        {
            this.marca = marca;
            NumRodas = 4;
        }

        public Carro(int p) : base("Fiat")
        {
            NumRodas = p;
        }

        public Carro(string s, int p) : base(s)
        {
            NumRodas = p;
        }

        #endregion

        #region METODOS

        /// <summary>
        /// Redefine Print() da classe Pai
        /// Hidding
        /// </summary>
        public  new void Print()        //hidding
        //public void Print()
        {
            //base.Print(); //Pode usar o método da classe base!
            Debug.WriteLine("Print do Carro");   
        }


        public override void Print2()
        {
            //base.Print2();
            //Debug.WriteLine(base.SayHello("Viva")); //SayHello é "protected"
            Debug.WriteLine("Print do Carro 2");
        }

        #region Operadores
        public override bool Equals(object obj)
        {
            return this.Marca==((Carro)obj).Marca;
        }

        public static bool operator ==(Carro c1, Carro c2)
        {
            return c1.Equals(c2);
        }

        public static bool operator !=(Carro c1, Carro c2)
        {
            return !c1.Equals(c2);
        }
        #endregion

        #endregion

        #region DEST
        /// <summary>
        /// Destruidor de instância de classe
        /// </summary>
        ~Carro()
        {
            //Qualquer coisa!
        }
        #endregion
    }



    //public class Carrinho : Carro       //não permitido se Carro for "sealed"
    //{
    //}


    
}
