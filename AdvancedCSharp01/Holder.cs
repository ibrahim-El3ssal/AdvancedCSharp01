using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharp01
{
    internal class Holder<T> where T : struct
    {
        private T _value;
        public Holder(T value)
        {
            _value = value;
        }

        public T GetValue() => _value;
    }
    internal class Holder2<T> where T : class
    {
        private T _value;
        public Holder2(T value)
        {
            _value = value;
        }
        public T GetValue() => _value;
    }
    public class Product
    {
        public string Name { get; set; } = "Product Name";
    }
    internal class Holder3<T> where T : new()
    {
        public T CreateNewItem()
        {
            return new T();
        }

    }

    public interface IPrintable
    {
        void Print();
    }
    public class Printer<T> where T : IPrintable
    {
        public void PrintItem(T item)
        {
            item.Print();
        }
    }
    public class Invoice : IPrintable
    {
        public void Print() => Console.WriteLine(" Invoice Document ");
    }

    public class BaseEntity
    {
        public int Id { get; set; }
    }
    public class AdvancedManager<T> where T : BaseEntity, IPrintable, new()
    {
        public T ProcessAndCreate()
        {
            T item = new T();

            item.Id = 505;

            item.Print();

            Console.WriteLine($"Generated Item ID: {item.Id}");
            return item;
        }
    }
    public class Order : BaseEntity, IPrintable
    {
        public void Print() => Console.WriteLine("Printing Order Details...");
    } 

}