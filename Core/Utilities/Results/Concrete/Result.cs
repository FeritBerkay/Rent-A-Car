using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Concrete
{
    public class Result:IResult
    {
        //This succes demek sen calısnca succesi de calıstır demek.
        public Result(bool succes, string message):this(succes)
        {
            Message = message;
        }

         public Result(bool succes)
        {
            Success =succes;
        }

        public bool Success { get; }
        public string Message { get; }
    }
}
