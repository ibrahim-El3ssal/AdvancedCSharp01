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

            #region Question 07: What is the 'struct' constraint? Write an example
            Console.WriteLine("\n____________ Question07 :______________\n");
            /// The struct constraint(where T : struct) specifies that the type argument must be a non-nullable value type.
            /// This restricts T to types like primitive numeric types, booleans, or custom structs, preventing reference types (classes) from being used.
            
            Holder<int> holder = new Holder<int>(2);
            Console.WriteLine($"Value: {holder.GetValue()}");

            #endregion

            #region Question 08: What is the 'class' constraint? Write an example
            /// The class constraint (where T : class) specifies that the type argument must be a reference type.
            /// This restricts T to classes, interfaces, or arrays, preventing value types (such as int, bool, or custom structs) from being used.
            Console.WriteLine("\n____________ Question08 :______________\n");

            Holder2<string> Refholder = new Holder2<string>("Ibrahim");
            Console.WriteLine($"Value: {Refholder.GetValue()}");

            #endregion

            #region Question 09: What is the 'new()' constraint? Write an example
            Console.WriteLine("\n____________ Question09 :______________\n");

            Holder3 <Product> product = new Holder3<Product>();
            Product newProduct = product.CreateNewItem();
            Console.WriteLine($"Created Product: {newProduct.Name}");

            #endregion

            #region Question 10: What is the interface constraint? Write an example
            Console.WriteLine("\n____________ Question10 :______________\n");
            /// An interface constraint (where T : IInterfaceName) specifies that the type argument must implement a specific interface. 
            /// This allows you to safely call methods or access properties defined in that interface on instances of T.

            Printer<Invoice> invoicePrinter = new Printer<Invoice>();
            invoicePrinter.PrintItem(new Invoice());

            #endregion

            #region Question 11: What is the base class constraint? Write an example
            Console.WriteLine("\n____________ Question11 :______________\n");
            AnimalShelter<Dog> dogAnimal = new AnimalShelter<Dog>();
            dogAnimal.ProcessAnimal(new Dog() { Name = "Buddy" });

            #endregion
           
            #region Question 12: How do you apply multiple constraints? Write an example
            Console.WriteLine("\n____________ Question12 :______________\n");
            /// Multiple constraints allow you to apply more than one restriction on a single generic type parameter T (such as combining a base class constraint,
            /// one or more interface constraints, and a constructor constraint). They are separated by commas (,)
             
            AdvancedManager<Order> manager = new AdvancedManager<Order>();
            manager.ProcessAndCreate();

            #endregion

            #region Question 13: What does the 'default' keyword do in generics?
            Console.WriteLine("\n____________ Question13 :______________\n");
            ///  the default keyword is used to assign or return the default value of a generic type parameter T.
            ///  For reference types (classes), the default value is null.
            ///  For value types (structs, numeric types), the default value is 0 or equivalent zeroed state.
            ///  This is necessary because you cannot directly use null or 0 for an unknown generic type T.  
            #endregion

            Console.ReadLine();
        }
    }
}