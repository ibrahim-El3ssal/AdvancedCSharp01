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

}