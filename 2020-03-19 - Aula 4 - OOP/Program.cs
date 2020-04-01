/*
 * lufer
 * */
using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region OBJETOS E PROPRIEDADES
            //criar objetos da classe Pessoa
            Pessoa p = new Pessoa();        //usa construtor por defeito
            Pessoa q = new Pessoa(25, "ok");//usa construtor com valores

            p.SetIdade();                   //define idade a_la_Java
            Console.WriteLine(p.GetIdade());//mostra idade a_la_java

            p.Idade = 12;                   //define idade com Property Idade
            p.Nome = "ola";                 //define nome com Property Nome
            Console.WriteLine("Idade = " + p.Idade + " Nome = " + p.Nome);

            #endregion

            #region DateTime
            DateTime date1 = new DateTime(2019, 3, 19, 13, 0, 0);
            DateTime date2 = new DateTime(2019, 3, 19, 12, 0, 0);
            //int result = DateTime.Compare(date1, date2);
            int result = WeekDay.Compare(date1, date2);
            string relationship;

            if (result < 0)
                relationship = "mais cedo do que";
            else if (result == 0)
                relationship = "igual a";
            else
                relationship = "mais tarde que ";

            Console.WriteLine("{0} {1} {2}", date1, relationship, date2);

            Console.WriteLine("-----------------------------------");
            // Get the date and time for the current moment, adjusted 
            // to the local time zone.

            DateTime saveNow = DateTime.Now; //Equivale a "DateTime.Today" é Property

            // Get the date and time for the current moment expressed 
            // as coordinated universal time (UTC).

            DateTime saveUtcNow = DateTime.UtcNow;
            DateTime myDt;

            // Display the value and Kind property of the current moment 
            // expressed as UTC and local time.

            WeekDay.DisplayNow("HojeUtc: ..........", saveUtcNow);
            WeekDay.DisplayNow("Hoje: .............", saveNow);
            Console.WriteLine();

            // Change the Kind property of the current moment to 
            // DateTimeKind.Utc and display the result.

            myDt = DateTime.SpecifyKind(saveNow, DateTimeKind.Utc);
            WeekDay.Display("Utc: .............", myDt);

            // Change the Kind property of the current moment to 
            // DateTimeKind.Local and display the result.

            myDt = DateTime.SpecifyKind(saveNow, DateTimeKind.Local);
            WeekDay.Display("Local: ...........", myDt);

            // Change the Kind property of the current moment to 
            // DateTimeKind.Unspecified and display the result.

            myDt = DateTime.SpecifyKind(saveNow, DateTimeKind.Unspecified);
            WeekDay.Display("Unspecified: .....", myDt);

            Console.WriteLine("-----------------------------------");

            Console.ReadKey();
            #endregion

            #region BANK


            //criar nova Conta
            //"var account" é quivalente a "int account"
            var account = new OOP.BankAccount("T", 1000);
            Console.OutputEncoding = System.Text.Encoding.UTF8; //simbolo €
            Console.WriteLine("Conta {0} criada para {1} com saldo inicial de {2}€.", account.Number, account.Owner, account.Balance);
            //C# >=6.0
            //Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance."); 
            #endregion


            Console.ReadKey();
        }
    }
}
