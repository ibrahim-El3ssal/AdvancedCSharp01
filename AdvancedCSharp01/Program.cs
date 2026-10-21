using System;
using System.Collections.Generic;

namespace AdvancedCSharp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01: What is a generic class? Why use generics?
            Console.WriteLine("\n____________ Question01 :______________\n");

            // Generics allow you to write classes, interfaces and methods with type parameters, The actual type is specified when the code is used, not when it is written.
            // we use generics because 1- it allows for type safety, 2- it allows for code reusability . 
            #endregion

            #region Question 02: Generic class Container<T> with Add and Get methods
            Console.WriteLine("\n____________ Question02 :______________\n");
            Container <int> intContainer = new Container<int>();
            intContainer.Add(42);
            int value = intContainer.Get();
            Console.WriteLine($"Value: {value}");
            #endregion

            #region Question 03: What are multiple type parameters? Write Pair<TKey, TValue>
            Console.WriteLine("\n____________ Question03 :______________\n");

            Pair<int, string> student = new Pair<int, string>(1, "Elassal");
            Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
            #endregion

            Console.ReadLine();
        }
    }
}