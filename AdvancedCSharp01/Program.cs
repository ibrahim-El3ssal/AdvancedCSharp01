using System;
using System.Collections.Generic;

namespace AdvancedCSharp01
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Q01
            Console.WriteLine("\n____________ Question01 :______________\n");

            // Generics allow you to write classes, interfaces and methods with type parameters, The actual type is specified when the code is used, not when it is written.
            // we use generics because 1- it allows for type safety, 2- it allows for code reusability . 
            #endregion

            #region Q02
            Console.WriteLine("\n____________ Question02 :______________\n");
            Container <int> intContainer = new Container<int>();
            intContainer.Add(42);
            int value = intContainer.Get();
            Console.WriteLine($"Value: {value}");
            #endregion

            #region Q03
            Console.WriteLine("\n____________ Question03 :______________\n");

            Pair<int, string> student = new Pair<int, string>(1, "Elassal");
            Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
            #endregion

            #region Q04
            /// A method that is declared with type parameters, allowing it to work with different data types without duplicating code for each specific type.
            Console.WriteLine("\n____________ Question04 :______________\n");
            int x = 5, y = 10;
            Console.WriteLine($"Before Swap: x = {x}, y = {y}");

            Helper.Swap(ref x, ref y);

            Console.WriteLine($"After Swap: x = {x}, y = {y}");
            #endregion

            #region Q05
            Console.WriteLine("\n____________ Question05 :______________\n");
            List<int> prices = new List<int> { 99, 150, 45 };
            int maxPrice = Helper.FindMaxInList(prices);

            Console.WriteLine($"Max Price: {maxPrice}");

            #endregion

            #region Q06
            Console.WriteLine("\n____________ Question06 :______________\n");
            // A generic interface is a contract that defines methods and properties using a type parameter (<T>).
            // It enforces a structural blueprint on implementing classes while deferring the specification of the actual data type until execution or implementation.
            #endregion

            #region Q07
            Console.WriteLine("\n____________ Question07 :______________\n");
            /// The struct constraint(where T : struct) specifies that the type argument must be a non-nullable value type.
            /// This restricts T to types like primitive numeric types, booleans, or custom structs, preventing reference types (classes) from being used.
            
            Holder<int> holder = new Holder<int>(2);
            Console.WriteLine($"Value: {holder.GetValue()}");

            #endregion

            #region Q08
            /// The class constraint (where T : class) specifies that the type argument must be a reference type.
            /// This restricts T to classes, interfaces, or arrays, preventing value types (such as int, bool, or custom structs) from being used.
            Console.WriteLine("\n____________ Question08 :______________\n");

            Holder2<string> Refholder = new Holder2<string>("Ibrahim");
            Console.WriteLine($"Value: {Refholder.GetValue()}");

            #endregion

            #region Q09
            Console.WriteLine("\n____________ Question09 :______________\n");

            Holder3 <Product> product = new Holder3<Product>();
            Product newProduct = product.CreateNewItem();
            Console.WriteLine($"Created Product: {newProduct.Name}");

            #endregion

            #region Q10
            Console.WriteLine("\n____________ Question10 :______________\n");
            /// An interface constraint (where T : IInterfaceName) specifies that the type argument must implement a specific interface. 
            /// This allows you to safely call methods or access properties defined in that interface on instances of T.

            Printer<Invoice> invoicePrinter = new Printer<Invoice>();
            invoicePrinter.PrintItem(new Invoice());

            #endregion

            #region Q11
            Console.WriteLine("\n____________ Question11 :______________\n");
            AnimalShelter<Dog> dogAnimal = new AnimalShelter<Dog>();
            dogAnimal.ProcessAnimal(new Dog() { Name = "Buddy" });

            #endregion
           
            #region Q12
            Console.WriteLine("\n____________ Question12 :______________\n");
            /// Multiple constraints allow you to apply more than one restriction on a single generic type parameter T (such as combining a base class constraint,
            /// one or more interface constraints, and a constructor constraint). They are separated by commas (,)
             
            AdvancedManager<Order> manager = new AdvancedManager<Order>();
            manager.ProcessAndCreate();

            #endregion

            #region Q13
            Console.WriteLine("\n____________ Question13 :______________\n");
            ///  the default keyword is used to assign or return the default value of a generic type parameter T.
            ///  For reference types (classes), the default value is null.
            ///  For value types (structs, numeric types), the default value is 0 or equivalent zeroed state.
            ///  This is necessary because you cannot directly use null or 0 for an unknown generic type T.  
            ///  

            #endregion

            #region Q14
            Console.WriteLine("\n____________ Question14 :______________\n");
            
            SafeList<string> safeList = new SafeList<string>();
            safeList.Add("html");
            safeList.Add("css");

            Console.WriteLine($"Index 0: {safeList.GetAt(0)}"); 
            Console.WriteLine($"Index 1: {safeList.GetAt(1)}");

            #endregion

            #region Q15
            Console.WriteLine("\n____________ Question15 :______________\n");
            /// Covariance enables you to use a more derived type than originally specified. In C# generics,
            /// it allows an interface or delegate to return a more generic/base type than expected (i.e., assigning an IEnumerable<Dog> to an IEnumerable<Animal>).

            /// The out keyword means "Output Only". It tells the compiler that type T will only be returned by methods,
            /// never taken as an input parameter. This guarantees safety when doing Covariance, allowing you to treat a derived type (like Dog) as a base type (like Animal).
            /// 

            #endregion

            #region Q16
            Console.WriteLine("\n____________ Question16:______________\n");
            /// Contravariance is the reverse of covariance. It allows you to use a more generic/base type where a more derived type is expected
            /// (i.e., assigning an IProcessor<Animal> to an IProcessor<Dog>).
            ///The in keyword is used in generic interfaces to mark a type parameter as contravariant

            #endregion

            #region Q17
            Console.WriteLine("\n____________ Question17 :______________\n");
            ///Covariance (out): Allows you to use a more derived type (child) where a base type (parent) is expected (e.g., assigning IEnumerable<Dog> to IEnumerable<Animal>).
            ///It restricts the generic parameter T to output positions (return types only).

            /// Contravariance(in): The exact opposite.It allows you to use a base type(parent) where a more derived type(child) is expected(e.g., assigning IProcessor< Animal> to IProcessor<Dog>).
            /// It restricts the generic parameter T to input positions(method parameters only

            #endregion

            #region Q18
            Console.WriteLine("\n____________ Question18 :______________\n");
            /// static members are not shared across different types.
            /// A separate static field or property is created for each unique type argument (T) supplied to the generic class.
            /// static members belong to the generic class itself, so they must be accessed via the class name, not through an instance.

            #endregion

            #region Q19
            Console.WriteLine("\n____________ Question19 :______________\n");
            ///When a class inherits from a generic base class, you have two main options:
            /// Keep it Generic: The derived class remains generic, passing its own type parameter T up to the base class.  Example: class FullRepository<T> : Repository<T>
            /// Close the Type: The derived class stops being generic and locks the base class's type parameter to a specific, concrete type (like string or int) .  Example: class StringRepository : Repository<string> 
            ///
            ///
            #endregion

            #region Q20
            Console.WriteLine("\n____________ Question20 :______________\n");

            Cache<string, string> userSessionCache = new Cache<string, string>();

            userSessionCache.Add("Session_01", "Ibrahim_Admin", TimeSpan.FromSeconds(2));

            Console.WriteLine($"Contains 'Session_01': {userSessionCache.Contains("Session_01")}");
            Console.WriteLine($"Get 'Session_01': {userSessionCache.Get("Session_01")}");           

            Console.WriteLine("\nWaiting for 3 seconds for cache to expire...");
            System.Threading.Thread.Sleep(3000);

            string expiredResult = userSessionCache.Get("Session_01");
            Console.WriteLine($"Contains after expiry: {userSessionCache.Contains("Session_01")}"); 
            Console.WriteLine($"Get after expiry: [{(expiredResult == null ? "Null (Expired)" : expiredResult)}]");
            #endregion
          
            Console.ReadLine();
        }
    }
}