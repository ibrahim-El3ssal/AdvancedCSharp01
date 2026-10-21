using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharp01
{
    internal interface IRepository<T>
    {
        void Add(T entity);
        T GetById(int id);
        List<T> GetAll();
    }
}
