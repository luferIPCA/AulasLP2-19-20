/*
*	<copyright file="IOC.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>4/23/2020 11:48:12 AM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2020_04_24___Aula_11___IOC
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 4/23/2020 11:48:12 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Company
    {
        #region Attributes
        string name;
        Person cto;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Company(string n)
        {
            cto = new Person(n);     //ARRISCADO: Controlo passa para Person
        }


        /// <summary>
        /// Aplicar Inversion of Control with Injection Dependency
        /// </summary>
        /// <param name="p"></param>
        public Company (Person p)
        {
            //if (p is null)
            //    throw new Exception();
            this.cto = p;
        }

        #endregion

        #region Properties
        #endregion

        #region Functions
        #endregion

        #region Overrides
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Company()
        {
        }
        #endregion

        #endregion
    }

    public class Person
    {
        string name;

        public Person (string o)
        {
            name = o;
        }
    }
}
