/*
*	<copyright file="Clubecs.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>5/14/2020 7:47:57 PM</date>
*	<description>Data Layer</description>
**/
using ClubeBO;
using System;
using System.Collections.Generic;

namespace DadosClubes
{
    public class Clubes
    {
        private static List<Clube> allClubes;

        static Clubes()
        {
            allClubes = new List<Clube>();
        }

        /// <summary>
        /// Novo clube
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool AddClube(Clube c)
        {
            if (allClubes.Contains(c)) return false;
            allClubes.Add(c);
            return true;
        }


        public static bool SaveAll(String f)
        {
            return true;
        }

        public static bool LoadAll(String f)
        {
            return true;
        }
    }
}
