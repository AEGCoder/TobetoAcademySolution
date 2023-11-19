using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
       

        public SuccessDataResult(T data, string message) : base(data, true, message) // base : Result'ın 3 parametreli constructor'ını çalıştırır.
        {
        }

        public SuccessDataResult(T data) : base(data, true) // base : Result'ın 2 parametreli constructor'ını çalıştırır.
        {
        }

        public SuccessDataResult(string message) : base(default, true, message) // base : Result'ın 3 parametreli constructor'ını çalıştırır.
        {
        }

        public SuccessDataResult() : base(default, true) // base : Result'ın 2 parametreli constructor'ını çalıştırır.
        {
        }
       
    }
}
