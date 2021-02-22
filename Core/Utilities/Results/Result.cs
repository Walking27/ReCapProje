using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool Success, string Message):this(Success)
        {
            
        }

        public Result(bool Success)
        {
            
        }

        public bool Success { get; }

        public string Message { get; }
    }
}

