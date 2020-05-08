/**
 * https://msdn.microsoft.com/en-us/library/system.collections.generic.aspx
 * List<T>
 * Dictionary<k,T>
 * HashSet<T>
 * LinkedList<T>
 * Queue<T>
 * Stack<T>
 * SortedList<TKey, TValue>
 * 
 * lufer
 * */

using System;
using System.Collections.Generic;
using System.Linq;


namespace Generics_II
{
    class Program
    {
        /// <summary>
        /// Auxiliar
        /// </summary>
        /// <param name="p"></param>
        private static void Mostra(Product p)
        {
            Console.WriteLine(p.name);
        }

        static void Main(string[] args)
        {
            
            #region List<T>
            List<Product> products = new List<Product>();
            
            // Criar Lista
            products.Add(new Product() { name = "Mesa" });
            products.Add(new Product() { name = "Cadeira" });

            products.Add(new Product() { name = "" });
            products.Add(new Product() { name = "Candeeiro" });

            Console.WriteLine("\nAntes:");
            foreach (Product p in products)
            {
                Console.WriteLine(p.name);
            }

           

            //Sort(IComparer<T>)
            products.Sort(new Product());           

            Console.WriteLine("\nDepois:");
            foreach (Product p in products)
            {
                Console.WriteLine(p.name);
            }
            #endregion

            #region Dictionary
            Dictionary<string, int> dictionary =
            new Dictionary<string, int>();

            dictionary.Add("O", 2);
            dictionary.Add("Benfica", 1);
            dictionary.Add("É", 0);
            dictionary.Add("o maior", -1);

            //Existe
            if (dictionary.ContainsKey("Benfica"))
            {
                int value = dictionary["Benfica"];
                Console.WriteLine(value);
            }

            //TryGetValues
            int val;
            if (dictionary.TryGetValue("Benfica", out val)) // Returns true.
            {
                Console.WriteLine(val); 
            }

            //Percorrer
            foreach (KeyValuePair<string, int> pair in dictionary)
            {
                Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
            }

            foreach (var pair in dictionary)
            {
                Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
            }

            //Armazenar Keys numa List

            List<string> list = new List<string>(dictionary.Keys);
            foreach (string k in list)
            {
                Console.WriteLine("{0}, {1}", k, dictionary[k]);
            }

            //Apagar

            dictionary.Remove("Porto");

            //Sort

            List<String> myKeys = new List<String>(dictionary.Keys);
            myKeys.Sort();

            //Sort com LINQ
            //foreach (KeyValuePair<string, Int16> author in dictionary.OrderBy(key => key.Key))
            //{
            //    Console.WriteLine("Key: {0}, Value: {1}", author.Key, author.Value);
            //}

            #endregion

            #region HashSet
            //HashSet is an unordered collection containing unique elements
            //https://blogs.msdn.microsoft.com/bclteam/2006/11/09/introducing-hashsett-kim-hamilton/

            string[] nomes =
            {
            "ola",
            "ole",
            "ola",
            "Benfica",
            "Porto",
            "Porto"
            };

            // Mostra array
            Console.WriteLine(string.Join(",", nomes));

            // HashSet elimina repetidos
            var hash = new HashSet<string>(nomes);

            // convert em array de strings
            string[] array2 = hash.ToArray();   //Linq            

            // mostra conjunto
            Console.WriteLine(string.Join(",", array2));
            #endregion            

            #region LinkedList
            //
            // Lista Duplamente ligada
            //
            LinkedList<string> linked = new LinkedList<string>();
            //
            // AddLast adiciona no fim.
            // AddFirst adiciona no inicio.
            //
            linked.AddLast("ola");
            linked.AddLast("ole");
            linked.AddLast("Porto");
            linked.AddFirst("Benfica");
            //
            // Percorre a Lista.
            //
            foreach (var s in linked)
            {
                Console.WriteLine(s);
            }
            #endregion

            #region SortedList<TKey, TValue>
            //SortedList ordenado pela Key


            #endregion

            #region LINQ



            //Exemplo de inicialização
            List<int> numbers = new List<int>() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int numCount1 =
                (from num in numbers
                 where num < 3 || num > 7
                 select num).Count();

            int numCount2 = numbers.Where(n => n < 3 || n > 7).Count();

            List<Product> parts;
            parts = products.FindAll(x => x.name.Contains("ola"));
            Product p1 = products.Find(x => x.name.Contains("ola"));
            bool aux = products.Exists(x => x.name.CompareTo("ola") == 0);

            //h1
            //Percorre Lista com método auxiliar:Mostra        
            products.ForEach(Mostra);
            //h2
            products.ForEach(delegate (Product p)
            {
                Console.WriteLine(p.name);
            });
            #endregion

            Console.ReadKey();
        }


        
    }

   
    /// <summary>
    /// 
    /// </summary>
    class Product : IComparer<Product>
    {
        public string name;      //sou preguiçoso!
        string url;
        int stock;

        public Product() { }
        public Product(string d, int s) { name = d; stock = s; }

        /// <summary>
        /// Comparador
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>

        public bool Equals(Product other)
        {
            if (other == null) return false;
            return (this.name.Equals(other.name));
        }

        // Deve fazer override == e != .

        public int Compare(Product p1, Product p2)
        {
            if (p1 == null) return 0;
            if (p2 == null) return 0;
            return (string.Compare(p1.name, p2.name));
        }
    }

    class CompareProduct : IComparer<Product>
    {
        /// <summary>
        /// Devolde 0, 1, -1
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public int Compare(Product p1, Product p2)
        {
            if (p1 == null) return 0;
            if (p2 == null) return 0;
            return (string.Compare(p1.name, p2.name));
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Product aux = obj as Product;
            if (aux == null) return false;
            else return Equals(aux);
        }

    }
}
