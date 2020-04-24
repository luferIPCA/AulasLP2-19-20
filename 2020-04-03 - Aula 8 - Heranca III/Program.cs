/*
 * lufer
 * Resolução da Folha de Exercícios nº7
 * */
using System;
using Fornecedor;

namespace Aula8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Barcos

            Barco b1 = new Barco();
            b1.codBarco = 1;
            b1.nome = "Skiff";
            b1.data = DateTime.Today;

            Barcos barcos = new Barcos();
            barcos.fornecedor = "Nelo";
            barcos.RegistaBarco(b1);


            #endregion

            #region ClasseAB

            ClasseA ca = new ClasseA();
            ClasseB cb = new ClasseB();

            //cb.total = 2;


            #endregion

            #region QUATRO

            Medico m = new Medico("ola", 40, Especialidade.CIRURGIAO, 1029);

            Infetado inf = new Infetado("ole", 12);

            Infecao i1 = new Infecao();
            i1.nome = "COVIR-19";

            inf.AddInfecao(i1);

            inf[2] = i1;        //Usa Indexador

            #endregion


            #region CINCO

            User u1 = new User("ola", 24);

            Filme f = new Filme("Titulo", 12, Users.GetAutor("ola"));

            #endregion


            #region SEIS

            Biblioteca bib = new Biblioteca();

            Publicacao pb = new Publicacao();
            bib.AddPublic(pb);


            #endregion

            Console.ReadKey();
        }
    }
}
