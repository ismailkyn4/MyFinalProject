using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T> //Sen bir Result'sın Resultın içindekiler aynen sendede geçerli. Resultın içinde olan constructorları burada implemente etmek lazım.
    {

        public DataResult(T data,bool success,string message):base(success,message)
        {
            Data = data;
        }
        public DataResult(T data,bool success):base(success)
        {
            Data = data;
        }
        public T Data { get; }

    }
}
