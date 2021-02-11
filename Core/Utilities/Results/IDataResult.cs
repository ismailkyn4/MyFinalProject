using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult //IDataResult mesaj işlem sonucu ve data içericek. kendimizi tekrar etmemek için IResult diyoruz
                                            //IResult zaten message ve success'i içermektedir.
    {
        T Data { get; }
    }
}
