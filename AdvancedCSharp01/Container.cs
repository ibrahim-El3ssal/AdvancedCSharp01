using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharp01
{
    internal class Container <T>
    {
        private T _item;
        public void Add(T item) => _item = item;
        public T Get() => _item;
    }
}
