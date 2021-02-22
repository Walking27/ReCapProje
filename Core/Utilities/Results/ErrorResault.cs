using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResault:Result
    {
        public ErrorResault(string message) : base(false, message)
        {

        }
        public ErrorResault() : base(false)
        {

        }
    }
}
