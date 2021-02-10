using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccesDataResult<T>:DataResult<T>
    {
        //farklı farklı versiyonlar
        public SuccesDataResult(T data,string message):base(data,true,message) //ister data ve mesaj ver.true ifadesi işlem sonucuna karşılık gelir. 
        {

        }
        public SuccesDataResult(T data):base(data,true) //istersen sadece data ver 
        {

        }
        public SuccesDataResult(string message):base(default,true,message) //istersen sadece mesaj ver.default dataya karşılık gelir 
        {

        }
        public SuccesDataResult():base(default,true) //istersen hiç birşey verme 
        {

        }
    }
}
