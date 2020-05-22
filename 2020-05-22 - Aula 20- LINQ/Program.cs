using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        //declara delegate
        delegate bool IsYoungerThan(Student stud, int youngAge);


        static void Main(string[] args)
        {
            #region Lambda Functions

            //Func<input,outpu>
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5));


            string message1 = "O Benfica é o maior...";
            string message2 = "O Portinho é quase....";
            Action<string, string> concat;

            concat = WriteToConsole;

            concat(message1, message2);

            #endregion

            #region Lambda Functions

            //Lambda & Delegates
            Func<int, string, bool> isTooLong = (int x, string s) => s.Length > x;

            Console.WriteLine("'Olamundo' tem mais que 12 caracteres? " + isTooLong(12, "Olamundo"));


            Func<int, int, bool> testForEquality = (x, y) => x == y;

            Console.WriteLine("{0} = {1} ? {2}", 12, 12, testForEquality(12, 12));

            #endregion

            //A partir de C# 7
            //Lambda Expressions and Tuplos
            //Func<(int, int, int), (int, int, int)> doubleThem = ns => (2 * ns.Item1, 2 * ns.Item2, 2 * ns.Item3);
            //var numbers = (2, 3, 4);
            //var doubledNumbers = doubleThem(numbers);
            //Console.WriteLine($"The set {numbers} doubled: {doubledNumbers}");

            #region Lambda and Delegates

            #region Caso 1

            //Delegate
            //Lambda expression com uma só ação
            IsYoungerThan aux1 = (s, youngAge) => s.Age < youngAge;

            //Delegate
            //Lambda expression com várias ações
            IsYoungerThan aux2 = (s, youngAge) => {
                Console.WriteLine("Lambda expression com várias ações");
                return s.Age < youngAge;
            };

            Student stud = new Student() { Age = 25 };
            Console.WriteLine(aux2(stud, 26));

            #endregion

            #region Caso 2
            //Outro
            Func<Student, bool> isStudentTeenAger = s => s.Age > 12 && s.Age < 20;
            Student std = new Student() { Age = 21 };
            bool isTeen = isStudentTeenAger(std);   //devolve False

            //Action
            //Action<Student> PrintStudentDetail = s => Console.WriteLine("Name: {0}, Age: {1} ", s.Name, s.Age);
            //ou
            Action<Student> PrintStudentDetail = s => Console.WriteLine(s.ToString());
            Student std1 = new Student() { Name = "Bill", Age = 21 };
            PrintStudentDetail(std);//output: Name: Bill, Age: 21
            #endregion

            #endregion

            #region LINQ

            IList<Student> studentList = new List<Student>() {
                new Student() { Id = 1, Name = "Um", Age = 13} ,
                new Student() { Id = 2, Name = "Dois",  Age = 21 } ,
                new Student() { Id = 3, Name = "Tres",  Age = 18 } ,
                new Student() { Id = 4, Name = "Quatro" , Age = 20} ,
                new Student() { Id = 5, Name = "Cinco" , Age = 15 }
            };

            //usa delegate
            var teenAgerStudent = studentList.Where(isStudentTeenAger);
            Console.WriteLine("Lindinhos:");
            foreach (Student s in teenAgerStudent)
            {
                Console.WriteLine(s.Name);
            }

            //Compreensão
            var students =  from s in studentList
                            where s.Age > 20
                            select s;

            //Lambda
            var students1 = studentList.Where(s => s.Age > 20).ToList<Student>();

            //Usa Delegate
            var students2 = from s in studentList
                            where isStudentTeenAger(s)
                            select s.Name;

            //Extension Methods
            var filteredResult = studentList.Where((s, i) => {
                        if (i % 2 == 0) // if it is even element
                            return true;      
                        return false;
            });

            foreach (var s in filteredResult)
                Console.WriteLine(s.Name);

            //multiple where
            var filteredResult1 = from s in studentList
                                 where s.Age > 12
                                 where s.Age < 20
                                 select s;

            foreach (var s in filteredResult1)
                Console.WriteLine(s.Name);

            //Order by

            var orderByResult = from s in studentList
                                orderby s.Name descending                   
                                select s;
            //ou
            var studentsInAscOrder = studentList.OrderBy(s => s.Name);

            var orderByResult2 = from s in studentList
                                orderby s.Name, s.Age
                                select new { s.Name, s.Age };

            //All
            bool areAllStudentsTeenAger = studentList.All(s => s.Age > 12 && s.Age < 20);

            Console.WriteLine(areAllStudentsTeenAger);

            //Any - Checks for at least one match
            bool areAllStudentsTeenAger1 = studentList.Any(s => s.Age > 12 && s.Age < 20);


            //Contains

            IList<int> intList = new List<int>() { 1, 2, 3, 4, 5 };
            bool result = intList.Contains(10);  // returns false

            //Contains Student
            Student st = new Student() { Id = 3, Name = "Seis" };
            bool result1 = studentList.Contains(st, new StudentComparer());
            Console.WriteLine(result1);

            #endregion

            Console.ReadKey();
        }

        /// <summary>
        /// auxiliar
        /// </summary>
        /// <param name="string1"></param>
        /// <param name="string2"></param>
        private static void WriteToConsole(string string1, string string2)
        {
            Console.WriteLine("{0}\n{1}", string1, string2);
        }
       
    }

    /// <summary>
    /// Auxiliar
    /// </summary>
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1} ", Name, Age);
        }
    }

    /// <summary>
    /// Compara students
    /// </summary>
    class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x.Id == y.Id &&
                        x.Name.ToLower() == y.Name.ToLower())
                return true;

            return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.GetHashCode();
        }
    }
}
