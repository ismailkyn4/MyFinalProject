using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //getter readonly'dir ve constructorda set edilebilir.*****İstisnayi bir durumdur *****
        public Result(bool success, string message):this(success) //Burda tek parametre yazarak Bu classın(result) tek paramatre olanını çalıştır dedik. Alt kısımdaki succes çalıştı.
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }  //Okumak için get kullanılır. Yazmak için ise set

        public string Message { get; }
    }
}
