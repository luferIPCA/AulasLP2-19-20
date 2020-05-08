/*
 * lufer
 * I/O
 * TryParse
 * Math class
 * DateTime Class
 * String.Format
 * <refs>
 * https://docs.microsoft.com/en-us/dotnet/standard/base-types/composite-formatting
 * https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
 * https://docs.microsoft.com/pt-br/dotnet/standard/base-types/formatting-types
 * https://www.csharp-examples.net/string-format-double/
 * </refs>
 * */
using System;


namespace _2020_02_29___Aula_1
{
    /// <summary>
    /// C# Essencial: Logica de Programação
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            #region DUVIDA_ALUNO_ARRAYS
            int tot = 0;
            Pessoa[] pes = new Pessoa[10];

            //pes[0].idade = 12;
            //pes[0].nome = "ola";
            Pessoa p1 = new Pessoa("ola", 12);

            pes[tot++] = p1;

            pes[tot++] = p1;

            p1.idade = 40;

            tot = AddArray(p1, pes, tot);

            tot = AddArrayII(p1, pes, tot);

            p1.idade = 25;

            Console.ReadKey();

            #endregion

            #region TiposDeDados
            int x =3;
            double y=3.7;
            float z=3.7F;
            string s = "Benfica";
            bool aux = true;
            #endregion

            #region EstruturasControlo

            #region IF
            if (aux) x = 1; else x = 2;
            //equivalente a
            x= (aux) ? 1 : 2;
            #endregion

            #region Switch
            switch (s)
            {
                case "Benfica": Console.WriteLine("Clube: {0}",s); break;
                case "Porto": Console.WriteLine("Clube: {0}", s); break;
                default: aux = false;break;
            }
            #endregion

            #region EstruturasControloRepetitivas

            #region For
            //Mostrar pares múltiplos de 3 entre 0 e 20
            int k = 0;
            for(; k<20;k++)
            {
                if (k % 2 == 0 && k % 3 == 0) Console.WriteLine("FOR: {0} ",k.ToString());
            }
            #endregion

            #region DoWhile
            k = 0;
            do
            {
                if (k % 2 == 0 && k % 3 == 0) Console.WriteLine("DO: {0} ", k.ToString());
                k++;
            }
            while (k < 20);
            #endregion

            #region WhileDo
            k = 0;
            while (k < 20)
            {
                if (k % 2 == 0 && k % 3 == 0) Console.WriteLine("WHILE: {0} ", k.ToString());
                k++;
            }
            #endregion

            #region BreakContinue
            //Exercicio: Mostrar todos os pares de 0 a 50. Ignorar os múltiplos de 3; 
            //Terminar se encontrar uma valor impar e multiplo de 3;
            k = 0;
            for (; k < 20; k++)
            {
                if (k % 2 != 0 && k % 3 == 0) break;
                if (k % 3 == 0) continue;   //ignora multiplo de 3
                if (k % 2 == 0)             //mostra par
                    Console.WriteLine("Par: {0} ", k.ToString());
            }
            //Tentar com ciclo Do..While e While

            #endregion

            #endregion

            #endregion

            #region InputOutput

            #region Input
            //Usar Console.Readline()
            //Converter de string para tipo destino
            //usar Parse, TryParse ou Convert
            //TryParse: valida a entrada de dados
            //Parse e Convert: não validam a entrada de dados

            //Parse: não garante data válida
            Console.Write("\nData1:");
            DateTime d1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Data inserida 1: {0}", d1.ToShortDateString());

            //Convert: não garante data válida
            //Ver https://docs.microsoft.com/en-us/dotnet/api/system.convert?view=netframework-4.8
            Console.Write("\nData2:");
            d1 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Data inserida 2: {0}", d1.ToShortDateString());

           //TryParse: garante data válida
            DateTime data;
            Console.Write("\nData3:");
            aux = DateTime.TryParse(Console.ReadLine(), out data);
            if (aux)
            {
                Console.WriteLine("Data válida: {0}", data.ToShortDateString());
                Console.WriteLine("Ano Bissexto? {0}", DateTime.IsLeapYear(data.Year));
            }
            #endregion
                 
            Console.Write("Tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            #region OutputFormatado

            #region CultureInfo
            double cost = 213.4;
            //"C" ou "c" - Currency (moeda)
            // Ver https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings?redirectedfrom=MSDN
            Console.WriteLine(cost.ToString("C",
                              new System.Globalization.CultureInfo("en-US")));

            #endregion

            #region FloatValues
            // Format a negative integer or floating-point number in various ways.
            Console.WriteLine("Standard Numeric Format Specifiers: FLOATS");
            Console.WriteLine(
                "(C) Currency: . . . . . . . . {0:C}\n" +
                "(D) Decimal:. . . . . . . . . {0:D}\n" +
                "(E) Scientific: . . . . . . . {1:E}\n" +
                "(F) Fixed point:. . . . . . . {1:F}\n" +
                "(G) General:. . . . . . . . . {0:G}\n" +
                "    (default):. . . . . . . . {0} (default = 'G')\n" +
                "(N) Number: . . . . . . . . . {0:N}\n" +
                "(P) Percent:. . . . . . . . . {1:P}\n" +
                "(R) Round-trip: . . . . . . . {1:R}\n" +
                "(X) Hexadecimal:. . . . . . . {0:X}\n",
                -123, -123.45f);

            Console.Write("Tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region DateTime
            // Format the current date in various ways.
            Console.WriteLine("Standard DateTime Format Specifiers: DATE");
            Console.WriteLine(
                "(d) Short date: . . . . . . . {0:d}\n" +
                "(D) Long date:. . . . . . . . {0:D}\n" +
                "(t) Short time: . . . . . . . {0:t}\n" +
                "(T) Long time:. . . . . . . . {0:T}\n" +
                "(f) Full date/short time: . . {0:f}\n" +
                "(F) Full date/long time:. . . {0:F}\n" +
                "(g) General date/short time:. {0:g}\n" +
                "(G) General date/long time: . {0:G}\n" +
                "    (default):. . . . . . . . {0} (default = 'G')\n" +
                "(M) Month:. . . . . . . . . . {0:M}\n" +
                "(R) RFC1123:. . . . . . . . . {0:R}\n" +
                "(s) Sortable: . . . . . . . . {0:s}\n" +
                "(u) Universal sortable: . . . {0:u} (invariant)\n" +
                "(U) Universal full date/time: {0:U}\n" +
                "(Y) Year: . . . . . . . . . . {0:Y}\n",
                DateTime.Today);

            string FormatString1 = String.Format("{0:dddd MMMM}", DateTime.Now);
            Console.WriteLine("Hoje:{0}", FormatString1);
            string FormatString2 = DateTime.Now.ToString("dddd MMMM yy");
            Console.WriteLine("Hoje:{0}", FormatString2);

            Console.Write("Tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region StringFormat
            float f = 7623.456F;
            //# - opcional; 0 - obrigatorio
            Console.WriteLine(String.Format("{0:000.00}", f));
            Console.WriteLine(String.Format("{0:00,0.00}", f) );
            Console.WriteLine(String.Format("{0:0.##0}", f));
            Console.WriteLine(String.Format("{0,-10:0.0}", f));
            Console.WriteLine(String.Format("{0,10:0.0}", f));
            //ver mais exemplos em
            //https://www.csharp-examples.net/string-format-double/
            #endregion

            #endregion

            #endregion

        }

        public static int AddArray(Pessoa p, Pessoa[] ps, int tot)
        {
            ps[tot] = p;
            return tot+1;
        }

        public static int AddArrayII(Pessoa p, Pessoa[] ps, int tot)
        {
            Pessoa aux = new Pessoa(p.nome, p.idade);
            //aux = p;
            ps[tot] = aux;
            return tot + 1;
        }
    }

    public class Pessoa
    {
        public int idade;
        public string nome;

        public Pessoa(string n, int u)
        {
            idade = u;
            nome = n;
        }
    }
}
