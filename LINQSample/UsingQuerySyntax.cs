using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQSample
{
    /// <summary>
    /// LINQ Query Syntax
    /// </summary>
    static class UsingQuerySyntax
    {
        #region Properties
        private static int[] _arr = { 10, 45, 67, 39, 8, 61, 74, 92, 87, 27, 56, 12, 13, 40, 55, 2, 45, 78, 113, 36 };
        static string _string = "I Enjoyed Writting C# Codes Using LINQ";
        private static Student _student = new Student() { }; 
        #endregion

        public static void ObjectTestUsingLinq()
        {
            var persons = new List<Student>() {
                new Student { Id=1, Name="Sumit", Age=31},
                new Student { Id=2, Name="Sohaib", Age=32},
                new Student { Id=3, Name="Benoit", Age=20},
                new Student { Id=4, Name="Krish", Age=21},
                new Student { Id=22, Name="Sahid", Age=24},
                new Student { Id=105, Name="Jonaid", Age=46},
                new Student { Id=107, Name="Raju", Age=55},

                new Student { Id=109, Name="Aamir", Age=16},
                new Student { Id=110, Name="Sonu", Age=8},
                new Student { Id=111, Name="Just 18", Age=18}
            };

            var result = from person in persons
                         where person.Age >= 18
                         orderby person.Age descending
                         select person;

            Console.WriteLine("Age Descending - Query Syntax\n-----------------------------------");
            foreach (Student str in result) {
                Console.WriteLine($"{str.Age} - {str.Name}");
            }


            Console.WriteLine("Age Ascending - Query Syntax\n-----------------------------------");
            foreach (Student str in from person in persons
                                   where person.Age < 18
                                   orderby person.Age ascending
                                   select person) {
                Console.WriteLine($"{str.Age} - {str.Name}");
            }
        }

        public static void StringTestUsingLinq()
        {
            var result = from s in _string
                         where s != ' '
                         group s by s;
                         // orderby s descending
                         // select s;
            // Console.WriteLine("Foreach Result");
            foreach (var str in result) {
                Console.WriteLine($"{str.Key}{str.Count()}");
            }
        }

        public static void IntegerTestUsingLinq() {
            var result = from i in _arr where i > 40 orderby i descending select i;
            Console.WriteLine("Foreach Result");
            foreach (int data in result) {
                Console.Write(data + " ");
            }
        }
    }
}
