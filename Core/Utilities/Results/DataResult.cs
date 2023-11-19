using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T> // Result'ın implementasyonu
    {
        public DataResult(T data, bool success, string message) : base(success, message) // base : Result'ın iki parametreli constructor'ını çalıştırır.
        {
            Data = data;
        }

        public DataResult(T data, bool success) : base(success) // base : Result'ın tek parametreli constructor'ını çalıştırır.
        {
            Data = data;
        }

        public T Data { get; }
    }

}
  
