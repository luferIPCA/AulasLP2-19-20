/*
 * lufer
 * */

namespace HerancaLib
{
    /// <summary>
    /// Descreve uma pessoa....
    /// </summary>
    public class Person
    {
        string name;
        protected int age;
        protected string address;
        protected double vencimento;

        public Person() {
            vencimento = 0;
        }

        public Person(string n, int i, string m)
        {
            name = n;
            age = i;
            address = m;
            vencimento = 100;
        }

        public override string ToString()
        {
            return string.Format("Nome={0} Idade={1} Morada={2}", name, age, address);
        }
    }
}
