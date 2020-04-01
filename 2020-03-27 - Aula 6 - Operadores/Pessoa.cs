//-----------------------------------------------------------------------
// <copyright file="Class1.cs" company="IPCA">
//     Copyright IPCA. All rights reserved.
// </copyright>
// <date>2020</date>
// <author>lufer</author>
// <email>lufer@ipca.pt</email>
// <version></version>
// <desc>Manipulação de Libraries: DLL externa com Operadores</desc>
//-----------------------------------------------------------------------



/// <summary>
/// Espaço com um conjunto de classes que suportam a entidade Pessoa
/// </summary>
namespace LibExterna
{
    /// <summary>
    /// Descreve uma pessoa...
    /// </summary>
    public class Pessoa
    {
        #region ATRI
        int idade;
        string nome;
        #endregion

        #region CONS

        public Pessoa() { idade = 0; nome = ""; }
        public Pessoa(int i, string n)
        {
            idade = i;
            nome = n;
        }
        #endregion

        #region PROPERTIES
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        #endregion

        #region METODOS

        #region OPERADORES
        /// <summary>
        /// Operador para comparar duas pessoas
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        {
            return ((this.nome == ((Pessoa)obj).nome) && (this.idade == ((Pessoa)obj).idade));
        }

        /// <summary>
        /// operador que compara duas pessoas
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Pessoa p1, Pessoa p2)
        {
            //if (object.ReferenceEquals(p1, null) || object.ReferenceEquals(p2, null))
            //{
            //    return false;
            //}
            //if (p1 == null || p2 == null) return false;
            return (p1.nome == p2.nome) && (p1.idade == p1.idade);
            //return p1.Equals(p2);
        }

        /// <summary>
        /// operador que compara duas pessoas
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Pessoa p1, Pessoa p2)
        {
            //if (object.ReferenceEquals(p1, null) || object.ReferenceEquals(p2, null))
            //{
            //    return false;
            //}
            //if (p1 == null || p2 == null) return false;
            return !(p1==p2);
        }

        /// <summary>
        /// ouput de dados internos (estado)
        /// </summary>
        /// <returns></returns>
        /// 
        #endregion

        #region OUTROS OPERADORES

        public static bool operator >(Pessoa x, Pessoa y)       //ou >=
        {
            return (x.idade > y.idade);
        }

        public static bool operator <(Pessoa x, Pessoa y)       //ou <=
        {
            return (x.idade < y.idade);
        }


        public static bool operator >=(Pessoa x, Pessoa y)
        {
            return x.Idade >= y.Idade;
        }


        public static bool operator <=(Pessoa x, Pessoa y)
        {
            return x.Idade <= y.Idade;
        }


        public static Pessoa operator ++(Pessoa m)
        {
            m.idade++;
            return m;
        }

        #endregion

        public override string ToString()
        {
            return string.Format("Nome= {0} - Idade= {1}", Nome, Idade);
        }

        #endregion

    }

    public class X
    {

        int a;

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return (this.a == ((X)obj).a);
        }
    }
}
