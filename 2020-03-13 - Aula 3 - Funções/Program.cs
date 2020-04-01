/*
 * lufer
 * LP2
 * */
using System;

namespace _2020_03_13___Aula_3___Funções
{
    class Program
    {
        static void Main(string[] args)
        {
            int prod;
            int max;

            Console.WriteLine(" O Maior entre 2 e 3 é :{0}", Metodos.Maximo(2,3).ToString());

            max = Metodos.MaximoProduto(2, 3, out prod);

            Console.WriteLine(" O Maior entre 2 e 3 é :{0} e Produto e: {1}", max.ToString(),prod.ToString());

            int dobro = 7;
            Metodos.Dobro(ref dobro);

            Console.WriteLine("O Dobro de 7 é {0}", dobro.ToString() );

            Console.WriteLine("Somatorio: {0}", Metodos.Somatorio(1, 2, 3, 4, 5));
            Console.WriteLine("Somatorio: {0}", Metodos.Somatorio(1,2));

            Console.ReadKey();
        }
    }
}
