/*
 * lufer
 * lufer@ipca.pt
 * Interfaces
 *      - Métodos são public por omissão. Privates não são permitidos!
 *      - Não podem conter atributos nem implementações. Só assinaturas
 *      - Só: Métodos, Indexadores, Propriedades, Eventos
 *      - Pode herdar de outros interfaces
 * */
using System;
using System.Text;

namespace Lib
{
    /// <summary>
    /// Interface para Pessoa
    /// </summary>
    public interface IPessoa
    {
        string Nome
        {
            get;
            set;
        }

        string UserID
        {
            get;
            set;
        }

        string GetPass();
        string GetUserId();
    }

}
