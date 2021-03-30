using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Concrete
{
    public class DataResult<T>:Result, IDataResult<T>
    {
        public DataResult(T data, bool succes, string messages):base(succes,messages)
        {
            Data = data;
        }
        public DataResult(T data,bool succes):base(succes)
        {
            Data = data;
        }
        public T Data { get; }
    }
}
