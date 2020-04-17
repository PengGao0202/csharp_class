using System;
using System.Collections.Generic;
using System.Linq;

namespace quiz1gao
{
    class Program
    {
        //1- Which Statement is correct?
        //    a.Properties of anonymous types will be read-only properties so you cannot change their
        //    values.
        //    b.A dynamic type escapes type checking at run time.
        //    c.Struct can declare a default constructor like a class
        //    d. Partial classes can have different class names.
        // Answer: a
        static void Main(string[] args)
        {
            //2 - Create a class Name is as Employee(id, name, salary)
            Employee employee = new Employee();
            //    a.Use a generic collection to put 5 employees in that. (Use optional data)
            IList<Employee> employeeList = new List<Employee>() {
                new Employee(){id=1, name="peng1", salary=10000},
                new Employee(){id=2, name="peng2", salary=20000},
                new Employee(){id=3, name="peng3", salary=30000},
                new Employee(){id=4, name="peng4", salary=40000},
                new Employee(){id=5, name="peng5", salary=50000},
            };
            //    b.Iterate through the collection 
            //    and Write the name of the employee in the console.
            //foreach(element in employeeList)
            //    Console.WriteLine(employee.name);
            //    c.Use delegate to find the lowest and highest salary among the employee

            Console.WriteLine("-------------------------------------------");
            //3- Use Tuple to create an object which has 3 fields (name, age, address) and print the fields in the
            //   console.
            //   a.User Interpolation => $””
            //   b.Use Format({ 0})

            Tuple<string, int, string> person = new Tuple<string, int, string>("Bill Gates", 50, "99 vista, Seattle, WA");
            Console.WriteLine($"Name is { person.Item1}");
            Console.WriteLine($"Age is { person.Item2}");
            Console.WriteLine($"Address is { person.Item3}");

            Console.WriteLine("-------------------------------------------");
            //4 - Use Dictionary to keep the values of Information of 5 employees in question 2.
            //    a.Use employeeId as the key and the office address as the value.
            IDictionary<int, string> dict = new Dictionary<int, string>()
                    {
                        {1, "Address1" },
                        {2, "Address2" },
                        {3, "Address3" },
                        {4, "Address4" },
                        {5, "Address5" },
                    };
            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
            Console.WriteLine("-------------------------------------------");
            //5- Create a Generic Class the only accepts class reference
            MyGenericClass<int> intGenericClass = new MyGenericClass<int>(555);
            int val = intGenericClass.genericMethod(999);
            Console.WriteLine("-------------------------------------------");

            //6- Use Extension method for integer to check if the number is dividable by 3
            int i = 15;
            bool result1 = i.IsDividableBy(3);
            Console.WriteLine($"If {i} is dividable by 3? {result1}");
            Console.WriteLine("-------------------------------------------");

            //7- Write a method that has one string parameter. 
            //   By Using predicate check if that string has vowel
            //   sounds and print all the vowel sounds in the output.
            Predicate<string> hasVowel = hasVowelSound;
            String str = "peng gao";
            bool result2 = hasVowelSound(str);
            Console.WriteLine($"If '{str}' contains vowel sound? {result2}");

            Console.WriteLine("-------------------------------------------");
            //8- (Bonus) Use Event/Func/Action/delegate with 2 classes (student, RegisterStudentOperation). If
            //     the student graduates, notifies the RegisterStudentOperation and Prints a message in the
            //     console.

        }

        static bool hasVowelSound(string str)
        {
            return str.Contains('a') ||
                   str.Contains('e') ||
                   str.Contains('i') ||
                   str.Contains('o') ||
                   str.Contains('u');
        }

    }
}
