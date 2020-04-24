/*
 * Classes Abstractas
 * 
 * Resolução do Exercício da Folha 11
 * lufer
 * */

using System;
using System.Text;

namespace Classes_Abstractas
{

    /// <summary>
    /// Interfrace de Conta Bancária
    /// </summary>
    interface IConta
    {
        string Nome {get; set;}
        double Saldo { get; set; }

        double Levantamento(double x);

    }



    /// <summary>
    /// Descreve Conta bancária
    /// </summary>
    abstract class Conta : IConta
    {

        //Atributos
        //Propriedades
        //Construtores
        //Métodos

        string nome;
        double saldo;

        public string Nome
        {
            get{return nome;}
            set{nome=value;}
        }


        public double Saldo
        {
            get{return saldo;}
            set{saldo=value;}

        }

        
        public abstract double Levantamento(double x);
        //public double Saldo { get; set; }
        //public abstract string GeraExtratoDetalhado();

 
    }

    
    /// <summary>
    /// Concretiza (I) a classe abstracta Conta
    /// </summary>
    class ContaPoupanca : Conta
    {
        int cId;
        DateTime a;

        //Atributos
        //Propriedades
        //Construtores
        //Métodos

        public new double Saldo
        {
            get { return base.Saldo; }
            set { if (value>0) base.Saldo = value; }

        }

        public override double Levantamento(double x)
        {
            base.Saldo += 0.1 *base.Saldo;      //+10%
            return (base.Saldo - x );
        }
    }

    /// <summary>
    /// Concretiza (II) a classe abstracta Conta
    /// </summary>
    class ContaSalario : Conta
    {
        int cId;

        //Atributos
        //Propriedades
        //Construtores
        //Métodos

        public override double Levantamento(double x)
        {
            //throw new NotImplementedException();
            base.Saldo -= x;
            return (x);
        }
    }
}
