/*
*  -------------------------------------------------
* <copyright file="Empregado.cs" company="IPCA"/>
* <summary>
*	LP2
* </summary>
* <date>4/8/2019 9:26:31 PM</date>
* <author>lufer</author>
* <email>lufer@ipca.pt</email>
* <desc></desc>
* -------------------------------------------------
**/

namespace Exercicio_3
{
    /// <summary>
    /// Exemplo demonstrativo de Herança de classes em C#
    /// </summary>
    /// <remarks>
    /// Classes: Empregado -> Gestor --> Supervisor
    /// </remarks>
    class Empregado
    {
        //Atributos
        public string nome;
        public double custoHora;

        //Construtores
        public Empregado() { }

        public Empregado(string n, double v)
        {
            nome = n;
            custoHora = v;
        }

        //Properties
        public string Nome
        {
            get { return (nome); }
            set { nome = value; }
        }

        public double CustHora
        {
            get { return custoHora; }
            set { custoHora = value; }
        }

        //Métodos
        public virtual double CalcSalario(int horas)
        {
            return (horas * custoHora);
        }
    }

}
