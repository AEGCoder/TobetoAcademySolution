using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult // IResult'ın implementasyonu
    {
        private bool v1;
        private string v2;
        private string courseAdded;

        public Result(bool success, string message) : this(success) // this(success) : Result'ın tek parametreli constructor'ını çalıştırır.
        {
          Message = message;
            Success = success;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public Result(string courseAdded)
        {
            this.courseAdded = courseAdded;
        }

        public bool Success { get; }

        public string Message { get; }
    }
    
    
}
