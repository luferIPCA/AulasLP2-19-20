/*
*	<copyright file="User.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>4/24/2020 7:43:13 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula8
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 4/24/2020 7:43:13 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class User: Pessoa
    {
        int userId;
        
        public User(string n, int i) : base(n, i) { }


        public int UserId
        {
            get;
        }


    }

    public class Users
    {
        static User[] atores;

        public static int GetAutor(string n)
        {
            foreach(User u in atores)
            {
                if (u.nome == n) return u.UserId;
            }
            return -1;
        }
    }

    class Filme
    {
        string titulo;
        int duracao;
        int userId;

        public Filme(string t, int d, int ui)
        {



        }
    }
}
