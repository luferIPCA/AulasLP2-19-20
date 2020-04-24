/*
*	<copyright file="Biblioteca.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>4/24/2020 8:10:39 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula8
{

    enum TipoPublicacao
    {
        LIVRO,
        REVISTA,
        JORNAL
    }

    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 4/24/2020 8:10:39 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Biblioteca
    {
        string nome;
        Publicacao[] publi;
        int totPublic = 0;

        //AddPublic

        public bool AddPublic(Publicacao p)
        {
            ///
            publi[totPublic++] = p;
            return true;
        }

    }

    public class Publicacao
    {
        TipoPublicacao tipo;
        string titulo;
    }
}
