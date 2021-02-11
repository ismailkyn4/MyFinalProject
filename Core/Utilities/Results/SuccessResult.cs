using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        public SuccessResult(string message) : base(true, message) //base işlemiyle SuccesResult'ın base olan Result'a işlem sonucu ve messageyi yolluyoruz.
        {

        }
        public SuccessResult() : base(true)
        {

        }
    }
}
