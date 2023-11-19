using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {


        public ErrorDataResult(T data, string message) : base(data, false, message) // base : Result'ın 3 parametreli constructor'ını çalıştırır.
        {
        }

        public ErrorDataResult(T data) : base(data, false) // base : Result'ın 2 parametreli constructor'ını çalıştırır.
        {
        }

        public ErrorDataResult(string message) : base(default, false, message) // base : Result'ın 3 parametreli constructor'ını çalıştırır.
        {
        }

        public ErrorDataResult() : base(default, false) // base : Result'ın 2 parametreli constructor'ını çalıştırır.
        {
        }

    }
}
