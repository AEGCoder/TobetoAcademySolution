using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result // Result'ın implementasyonu
    {
        public SuccessResult(string message) : base(true, message) // base : Result'ın tek parametreli constructor'ını çalıştırır.
        {
        }

        public SuccessResult() : base(true) // base : Result'ın tek parametreli constructor'ını çalıştırır.
        {
        }
    }
    
}
