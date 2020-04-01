// -------------------------------------------------
// <copyright file="Pessoa.cs" company="IPCA">
// </copyright>
// <summary>
//	LP2 - 2019-2020
// </summary>
// <desc>
//  1 - Dados "abertos" no Main
//  2 - Dados na classe Pessoa
//  3 - dados na classe Pessoas
//
// Overloading de Operadores
// </desc>
//-------------------------------------------------

using System;

namespace Aula_5___Static
{
    class Gestao
    {
        static void Main(string[] args)
        {
            #region DadosNoMain

            //H1: Estrutura de dados publica, no Main!!!
            const int MAX = 10;
            Pessoa[] pess = new Pessoa[MAX];
            int numPessoas = 0;

             Pessoa p = new Pessoa(12, "ola");
            pess[numPessoas++] = p;             //critico!!! Nenhum controlo!!!

            //for (int i = 0; i < numPessoas; i++)
            //{
            //    if (pess[i].Nome.CompareTo("ola") == 0)
            //    //if (String.Compare(x[i].Nome,nome)==0)
            //    {
            //        Console.WriteLine("Existe!!!");
            //        break;
            //    }
            //}

            if (Gestao.ExistePessoa(pess, numPessoas, "ola") == true)
            {
                Console.WriteLine("Existe!!!");
            }

            #endregion

            #region DadosNaClassPessoa

            Pessoa p2 = new Pessoa(13, "ole");
            if (Pessoa.InserePessoa(p2) == 1)
            {
                Console.WriteLine("Bem vindo...");
            }

            #endregion

            #region DadosEmClassePessoas
            //Pessoas pp = new Pessoas();         //Crítico!!!!
            if (Pessoas.InserePessoa(p2) == 1)
            {
                Console.WriteLine("Bem vindo...");
            }

            #region Operadores
            Pessoa p3 = new Pessoa(13, "ole");
            if (p3.Equals(p2))
            {
                Console.WriteLine("A mesma pessoa");
            }

            if (p3 == p2)
            {
                Console.WriteLine("A mesma pessoa");
            }
            #endregion
            #endregion

            #region Nullable_Arrays
            //Arrays em que nas po´sições sem valor se colocam null
            //Testar valor de HasValue

            int?[] valores = new int?[10];

            valores[0] = 12;
            valores[1] = -2;
            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i].HasValue)  //ou //if (valores[i]!=null)
                {
                    Console.WriteLine("Valor: " + valores[i]);
                    Console.WriteLine("HasValue: " + valores[i].HasValue);
                    Console.WriteLine("Value: " + valores[i].Value);
                }
            }

            #endregion


            #region VARIAS_GARAGENS

            Carro c1 = new Carro("asad");

            Carros garagemShopping = new Carros();      // garagem para 100 carros

            bool aux = garagemShopping.EstacionaCarro(c1);

            //--------

            Carros garagenLidl = new Carros(50);        // garagem para 50 carros

            aux = garagenLidl.EstacionaCarro(c1);

            int xx = garagenLidl.CarroEstacionado(c1.Matricula);

            #endregion

            #region APENAS_UMA_GARAGEM

            //CarrosII garagemMunicipal = new CarrosII(1000);     //unica garagem
            aux = CarrosII.EstacionaCarro(c1);

            #endregion


            #region SOCIOS

            Socio s = new Socio("Ola");
            Console.WriteLine("Socio Nº " + s.NumSocio);

            if (s.NumSocio == 1) { }

            //s.NumSocio = 34;              //Não é permitido
            Socio s1 = new Socio("Ola");
            Console.WriteLine("Socio Nº " + s1.NumSocio);


            s1.NumSocio = 12;
            s.NumSocio = 12;

            //if ((s1.NumSocio == s2.NumSocio) && String.Compare(s1.nome, s2.nome) == 0) {
            //    Console.WriteLine("Iguais");
            //}

            if (s1.Equals(s)){

            }

            if (s == s1)
            {
                Console.WriteLine("Iguais");
            }


            Console.ReadKey();
            #endregion

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="numPess"></param>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static bool ExistePessoa(Pessoa[] x, int numPess, string nome)
        {
            for(int i=0; i < numPess; i++)
            {
                if (x[i].Nome.CompareTo(nome) == 0)
                //if (String.Compare(x[i].Nome,nome)==0)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
