using models;
using System;
using System.Collections.Generic;

namespace ConsoleApp4Generics
{
    class Program
    {

        /// <summary>
        /// clases generics
        /// methods generics
        /// existe el where T : class, new(), {some object}
        /// where T : struct //tipo valor 
        /// where T : class // tipo referencia
        /// Where T : new() //constructor sin parametros
        /// Where T : IExample //Interfaz concreta
        /// Where T : Example //una clase concreta
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ExampleGeneric<string> eg = new ExampleGeneric<string>();
            eg.Value = "un string";

            Console.WriteLine($"string: {eg.ToString()}");

            ExampleGeneric<int> egInt = new ExampleGeneric<int>
            {
                Value = 1
            };

            Console.WriteLine($"int: {egInt}");

            Person person = new Person
            {
                Age = 20,
                Name = "oscar",
                LastName = "cortez"
            };

            ExampleGeneric<Person> egPerson = new ExampleGeneric<Person>
            {
                Value = person
            };

            Console.WriteLine($"Person: {person.ToString()}");

            ExampleGeneric<int> ex1 = new ExampleGeneric<int>
            {
                Value = 12
            };

            ExampleGeneric<int> ex2 = new ExampleGeneric<int>
            {
                Value = 4
            };


            List<ExampleGeneric<int>> algo = new List<ExampleGeneric<int>>();

            Console.WriteLine( $"int: {person.Concatenar<int>(2,2)}" );

            Console.WriteLine($"double: {person.Concatenar<double>(2, 2)}");

            Console.WriteLine($"string: {person.Concatenar<string>("2", "fsaf2")}");

            Console.WriteLine("fasdfasdf");

            Console.WriteLine($"{Add<int>(1,1)}");

            Console.WriteLine($"{Add<double>(1.12d, 1.23d)}");

            Console.WriteLine($"{Add<float>(1.12f, 1.23f)}");

            Console.WriteLine($"{Add<decimal>(1.12m, 1.23m)}");

            Console.WriteLine($"{Add<string>("fgsdf", "1212")}");

        }

        public static T Add<T>(T number1, T number2)
        {
            dynamic a = number1;
            dynamic b = number2;
            return a + b;
        }
    }
}
