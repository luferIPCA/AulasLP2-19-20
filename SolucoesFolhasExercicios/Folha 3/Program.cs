using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Folha_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] idades = new int[] { 23, 24, 19, 18, 20, 21 }; //idades assumidas

            int maior = Hoje1.CalculaMaiorIdade(idades);
            float media = Hoje1.CalculaMediaIdades(idades);

            maior = Hoje1.CalculaMaiorEMedia(idades, out media);





        }
    }
}
