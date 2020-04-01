//
// lufer
// Resolução Folha 6 de Exercicios
//
using System;

namespace Aula_5___Static
{
    /// <summary>
    /// Gere uma conta bancária
    /// </summary>
    public class ContaBancaria
    {
        #region Member Variables

        long nib;
        string nome;
        float saldo;
        Operacao[] extrato;

        #endregion

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public ContaBancaria()
        {
        }

        #endregion

        #region Properties
        #endregion

        #region Functions

        // Deposito

        //Levantamento

        //Consulta

        #endregion

        #region Enums
        #endregion
    }

    public class Operacao
    {

        Oper tipoOper;
        float valor;
        DateTime data;

    }

    enum Oper
    {
        LEV=0,
        DEP=1,
        CONS=2
    }
}
