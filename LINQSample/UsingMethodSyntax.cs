using System;
using System.Linq;

namespace LINQSample
{
    /// <summary>
    /// LINQ Method Syntax
    /// </summary>
    static class UsingMethodSyntax
    {
        public static void ObjectTestUsingLinq()
        {
            Student[] studentArray = {
                new Student() { Id = 1, Name = "John", Age = 18 },
                new Student() { Id = 2, Name = "Steve",  Age = 21 },
                new Student() { Id = 3, Name = "Bill",  Age = 52 },
                new Student() { Id = 4, Name = "Ram" , Age = 42 },
                new Student() { Id = 5, Name = "Ron" , Age = 31 },
                new Student() { Id = 6, Name = "Chris",  Age = 37 },
                new Student() { Id = 7, Name = "Rob",Age = 18  },
                new Student() { Id = 8, Name = "Rohan",Age = 25  },
                new Student() { Id = 9, Name = "Ronald",Age = 2  },
                new Student() { Id = 10, Name = "Rajesh",Age = 25  },
                new Student() { Id = 11, Name = "Rashmi",Age = 6  },
                new Student() { Id = 12, Name = "Ranjitha",Age = 22  },
            };

            var result = studentArray.Where(res => res.Age >= 18).OrderBy(x => x.Age);

            Console.WriteLine("\n Age Ascending - Method Syntax \n-----------------------------------");
            foreach (var str in result)
            {
                Console.WriteLine($"{str.Age} - {str.Name}");
            }


            Console.WriteLine("Age Descending - Method Syntax \n-----------------------------------");
            //Func<Student[], Student[]> func = (x) => 
            //{
            //    List<Student> result1 = new List<Student>();
            //    foreach (var std in x) {
            //        result1.Add(std);
            //    }
            //    return result1.ToArray();
            //};
            foreach (var str in studentArray.Where(x => x.Age < 18).OrderByDescending(x => x.Age))
            {
                Console.WriteLine($"{str.Age} - {str.Name}");
            }
        }
    }
}
