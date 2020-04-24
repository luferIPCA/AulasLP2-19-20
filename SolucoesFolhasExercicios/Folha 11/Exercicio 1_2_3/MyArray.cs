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
    /// Descreve uma Pessoa
    /// </summary>
    class Pessoa{
        public string nome;

        public Pessoa()
        {
            nome = "";
        }
        public Pessoa(string s)
        {
            nome = s;
        }
    }


    /// <summary>
    /// Descreve um Array Genérico
    /// </summary>
    abstract class MyArray
    {
        public abstract bool Exist(Pessoa p);       //verifica se p existe na estrutura
        //public abstract bool Add(Pessoa p);         //insere nova pessoa no final do array
        //public abstract int Find(string nome);      //devolve a posição onde se encontra determinada pessoa       
    }


    /// <summary>
    /// Implementa um array Unidimensional
    /// </summary>
    class MyArrayUni : MyArray
    {
        const int MAX = 20;
        //private Pessoa[] valores = new Pessoa[MAX];
        public Pessoa[] valores = new Pessoa[MAX];


        public override bool Exist(Pessoa p)
        {
            for(int i=0; i < valores.Length; i++)
            {
                if (object.ReferenceEquals(valores[i], null)) continue;
                if (valores[i].nome==p.nome) return true;    //rever operadores

            }
            //...
            return false;
        }
        
        //...        
    }


    /// <summary>
    /// Implementa um array Bidimensional
    /// </summary>
    class MyArrayBid : MyArray
    {
        const int MAXX = 20;
        const int MAXY = 20;
        private Pessoa[,] valores = new Pessoa[MAXX,MAXY];

        public override bool Exist(Pessoa p)
        {
            //...
            return true;
        }
        
        //...
    }
}
