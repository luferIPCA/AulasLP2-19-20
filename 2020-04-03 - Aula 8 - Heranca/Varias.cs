/*
 * Herança de Classes
 * 
 * Classe Base (classe Pai)
 * Classe Derivada  (classe Filho)
 * 
 * using "new", "virtual", "override"
 * 
 *  
 * Explorar exemplos de https://msdn.microsoft.com/en-us/library/ms173153.aspx
 * lufer
 * */

using System;

namespace Heranca
{

    class BaseClass
    {
        public string a;

        #region CONST
        public BaseClass()
        {
            Console.WriteLine("BaseClass criada");
        }

        public BaseClass(string a)
        {
            Console.WriteLine("BaseClass criada - " + a);
            this.a = a;
        }

        #endregion

        #region METHODS
        public void Method1()
        {
            Console.WriteLine("Base - Metodo 1");
        }

        /// <summary>
        /// Testar new e override
        /// </summary>
        public void Method2()
        {
            Console.WriteLine("Base - Method 2");
        }

        /// <summary>
        /// Para reescrever
        /// </summary>
        public virtual void Method3()
        {
            Console.WriteLine("Base - Method 3");
        }

        public override string ToString()
        {
            return a;
        }

        #endregion
    }

    #region Herança
    class DerivedClass : BaseClass
    {
        public int b;   //atenção ao public!!!

        #region CONST
        public DerivedClass()
        {
            base.a = "ola";
            b = 0;
        }

        public DerivedClass(string s, int b) : base(s)
        {
            this.b = b;
            Console.WriteLine("DerivedClass criada");
        }

        // ou
        //public DerivedClass(string s, int b)
        //{
        //    this.b = b;
        //    base.a = s;
        //}

        #endregion

        /// <summary>
        /// Evitar warning com "new"...esconde o método base
        /// </summary>
        public new void Method2()
        {
            Console.WriteLine("Derivado - Metodo 2");
        }

        /// <summary>
        /// Reescreve com "new" ou "override"
        /// </summary>
        public override void Method3()
        {
            //base.Method3();
            Console.WriteLine("New - Method3");
        }

        /// <summary>
        /// Método só da classe Filho
        /// </summary>
        public void Method4()
        {
            Console.WriteLine("New - Method4");
        }

        public override string ToString()
        {
            return b.ToString();
        }

    }
    #endregion

    class C : DerivedClass
    {

        public C()
        {
        }
    }

}
