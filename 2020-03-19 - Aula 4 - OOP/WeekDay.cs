// -------------------------------------------------
// <copyright file="Day.cs" company="IPCA">
// </copyright>
// <summary>
//	LP2 - 2019-2020
// </summary>
// <desc> Exercício </desc>
//-------------------------------------------------
using System;

namespace OOP
{
    /// <summary>
    /// Classe que descreve um dia
    /// </summary>
    class WeekDay
    {
        int day;
        int month;
        int year;

        #region METODOS

        #region CONST
        /// <summary>
        /// Construtor
        /// </summary>
        public WeekDay()
        {
            day = DateTime.Now.Day;
            month = DateTime.Now.Month;
            year = DateTime.Now.Year;
        }
        /// <summary>
        /// Construtor
        /// </summary>
        public WeekDay(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        #endregion

        #region PROPERTIES

        public int Day
        {
            get { return day; }
            set { if (value > 0 && value < 31) day = value; }
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Devolve a data atual
        /// Metodo static
        /// </summary>
        /// <returns></returns>
        public static DateTime Today()
        {
            return DateTime.Today;
        }

        /// <summary>
        /// Método de instância
        /// Devolve a data corrente
        /// </summary>
        /// <returns></returns>
        public DateTime Current()
        {
            return new DateTime(year, month, day);
        }

        /// <summary>
        /// Devolve o número de dias de um determinado mês
        /// Método static
        /// </summary>
        /// <param name="month">Ano</param>
        /// <param name="year">Mês</param>
        /// <returns></returns>
        public static int DaysInMonth(int month, int year)
        {
            return DateTime.DaysInMonth(year, month);
        }

        /// <summary>
        /// Comparar duas datas
        /// </summary>
        /// <param name="d1">Dia 1</param>
        /// <param name="d2">Dia 2</param>
        /// <returns></returns>
        public static int Compare(DateTime d1, DateTime d2)
        {
            return (DateTime.Compare(d1, d2));
        }

        /// <summary>
        /// Formato a usar no output
        /// </summary>
        public static string datePatt = @"M/d/yyyy hh:mm:ss tt";

        /// <summary>
        /// Source: https://docs.microsoft.com/en-us/dotnet/api/system.datetime.kind?view=netframework-4.7.2
        /// Display the value and Kind property of a DateTime structure, the 
        /// DateTime structure converted to local time, and the DateTime structure converted to universal time. 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="inputDt"></param>
        public static void Display(string title, DateTime inputDt)
        {
            DateTime dispDt = inputDt;
            string dtString;

            // Display the original DateTime.

            dtString = dispDt.ToString(datePatt);
            Console.WriteLine("{0} {1}, Kind = {2}",
                              title, dtString, dispDt.Kind);

            // Convert inputDt to local time and display the result. 
            // If inputDt.Kind is DateTimeKind.Utc, the conversion is performed.
            // If inputDt.Kind is DateTimeKind.Local, the conversion is not performed.
            // If inputDt.Kind is DateTimeKind.Unspecified, the conversion is 
            // performed as if inputDt was universal time.

            dispDt = inputDt.ToLocalTime();
            dtString = dispDt.ToString(datePatt);
            Console.WriteLine("  ToLocalTime:     {0}, Kind = {1}",
                              dtString, dispDt.Kind);

            // Convert inputDt to universal time and display the result. 
            // If inputDt.Kind is DateTimeKind.Utc, the conversion is not performed.
            // If inputDt.Kind is DateTimeKind.Local, the conversion is performed.
            // If inputDt.Kind is DateTimeKind.Unspecified, the conversion is 
            // performed as if inputDt was local time.

            dispDt = inputDt.ToUniversalTime();
            dtString = dispDt.ToString(datePatt);
            Console.WriteLine("  ToUniversalTime: {0}, Kind = {1}",
                              dtString, dispDt.Kind);
            Console.WriteLine();
        }

        /// <summary>
        /// Display the value and Kind property for DateTime.Now and DateTime.UtcNow.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="inputDt"></param>
        public static void DisplayNow(string title, DateTime inputDt)
        {
            string dtString = inputDt.ToString(datePatt);
            Console.WriteLine("{0} {1}, Kind = {2}",
                              title, dtString, inputDt.Kind);
        }
        #endregion

        #region OVERRIDES
        public override string ToString()
        {
            return new DateTime(year, month, day).ToLongDateString();
        }
        #endregion

        /// <summary>
        /// Destrutor
        /// </summary>
        ~WeekDay()
        {

        }
        #endregion
    }
}
