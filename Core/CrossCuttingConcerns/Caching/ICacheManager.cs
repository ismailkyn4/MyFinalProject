using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Caching
{
    public  interface ICacheManager
    {
        T get<T>(string key);
        object Get(string key);
        void Add(string key, object value,int duration);
        bool IsAdd(string key); //Cache de var mı konrtol etmek için 
        void Remove(string key);
        void RemoveByPattern(string pattern);

    }
}
