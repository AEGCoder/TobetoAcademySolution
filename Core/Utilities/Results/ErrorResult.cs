using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(false, message) // base : Result'ın tek parametreli constructor'ını çalıştırır.
        {
        }

        public ErrorResult() : base(false) // base : Result'ın tek parametreli constructor'ını çalıştırır.
        {
        }
    }
}
