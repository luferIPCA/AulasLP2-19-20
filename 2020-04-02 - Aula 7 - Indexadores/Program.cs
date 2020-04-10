/*
 * Resumo:
 * 
 *  Classes e Objetos (new)
 *      - Estado = set(Atributos | Campos) (private)
 *      - Comportamento:
 *          - Construtor    (new)
 *          - Propriedades  (get; set)
 *          - Overrides     (Equals, ToString)
 *          - Operadores    (==, !=,....)   (public static bool operator == (Ob1, Ob2))
 *          - Indexadores
 *          - Outros Metodos
 * 
 * */

using System;   


namespace Revisoes
{
    class X
    {
        private int idade;
        public string nome;         //ATENçÂO ao public!!!
        public X()
        {
            idade = 2;
            nome = "ola";
        }

        public X(int x)
        {

        }


        public int Idade
        {
            get;
            set;
        }


        public override string ToString()
        {
            return "Idade: " + idade;
        }

        /// <summary>
        /// Comparar dois objetos
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            X aux = (X)obj;     //cast
            return (aux.idade == this.idade);
        }

        public static bool operator ==(X a, X b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(X a, X b)
        {
            //return !(a.Equals(b));
            return !(a==b);
        }

    }

    class VariosX
    {
        X[] varios;
        int tot;

        public VariosX()
        {
            varios = new X[20];
            tot = 0;
        }

        public bool InsertX(X a)
        {
            varios[tot] = a;
            tot++;
            return true;
        }

         /// <summary>
        /// Indexador por posição
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public X this[int i]
        {
            get { return varios[i]; }           //Validações
            set { varios[i] = value; tot++; }   //Validações
        }

        public X this[string n]
        {
            get { return WhereIs(n); }
            set { InsertX(value); }
        }


        private X WhereIs(string nome)
        {
            foreach(X a in varios)
            {
                if (a.nome == nome) return a;
            }
            return null;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            #region INDEXADORES_I

            X a = new X();

            X b = new X();

            if (a.Equals(b))
            {
                Console.WriteLine("Iguais");
            }
            Console.WriteLine("X= " + a.ToString());


            //-------------------------------------


            VariosX v = new VariosX();

            v[0] = a;                                       //indexador com set
            v[1] = b;

            v["ola"] = a;                                   //Indexador com set - via nome


            Console.WriteLine("X=" + v[0].ToString());      //indexador get
            Console.WriteLine("X=" + v["ola"].ToString());  //indexador get

            v.InsertX(a);
            v.InsertX(b);

            #endregion

            #region INDEXADORES_II

            Pessoas pes = new Pessoas();

            Pessoa p1 = new Pessoa("Joao", 12);

            int xxx = Pessoa.InserePessoa(p1);

            pes[9] = p1;                //Indexador

            Console.WriteLine("Pessoa: " + pes[9].ToString());     //Indexador por posição

            Console.WriteLine("Pessoa: " + Pessoas.GetPessoa(9));  //Metodo static

            pes[0] = new Pessoa(12, "ola");     //Indexador

            //pes["Joao"] = p1;
            Pessoa aux = pes["Joao"];
            if (aux!=null)
                Console.WriteLine("Pessoa: " + aux.ToString()); //Indexador por nome

            #endregion

            #region Pessoas
            //Pessoas pp = new Pessoas();         //Crítico!!!!
            if (Pessoas.InserePessoa(p1) == 1)
            {
                Console.WriteLine("Bem vindo...");
            }

            #region Operadores
            Pessoa p3 = new Pessoa(13, "ole");
            if (p3.Equals(p1))
            {
                Console.WriteLine("A mesma pessoa");
            }

            if (p3 == p1)
            {
                Console.WriteLine("A mesma pessoa");
            }
            #endregion

            #endregion

            Console.ReadKey();
        }
    }

    
}
