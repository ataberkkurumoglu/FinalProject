using System;
using System.Collections.Generic;
using System.Text;

namespace CoreReCap.UtilitiesReCap.ResultsReCap
{
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
