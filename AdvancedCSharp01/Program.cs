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

            #region Question 04: What is a generic method? Write Swap<T> method
            /// A method that is declared with type parameters, allowing it to work with different data types without duplicating code for each specific type.
            Console.WriteLine("\n____________ Question04 :______________\n");
            int x = 5, y = 10;
            Console.WriteLine($"Before Swap: x = {x}, y = {y}");

            Helper.Swap(ref x, ref y);

            Console.WriteLine($"After Swap: x = {x}, y = {y}");
            #endregion

            #region Question 05: Write a generic method FindMax<T> that finds maximum value
            Console.WriteLine("\n____________ Question05 :______________\n");
            List<int> prices = new List<int> { 99, 150, 45 };
            int maxPrice = Helper.FindMaxInList(prices);

            Console.WriteLine($"Max Price: {maxPrice}");

            #endregion

            #region Question 06: What is a generic interface? Write IRepository<T>
            Console.WriteLine("\n____________ Question06 :______________\n");
            // A generic interface is a contract that defines methods and properties using a type parameter (<T>).
            // It enforces a structural blueprint on implementing classes while deferring the specification of the actual data type until execution or implementation.

            #endregion

            Console.ReadLine();
        }
    }
}